﻿using Examination_BUS.Services;
using Examination_PRL.Forms.Participant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff
{
    public partial class SubjectResult : Telerik.WinControls.UI.RadForm
    {

        SubjectServices _serSubject = new SubjectServices();

        string _idWhenClick;

        public SubjectResult()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            int stt = 1;

            radGridViewSubject.Rows.Clear();

            radGridViewSubject.ColumnCount = 4;

            radGridViewSubject.Columns[0].HeaderText = "STT";
            radGridViewSubject.Columns[1].HeaderText = "ID Môn";
            radGridViewSubject.Columns[2].HeaderText = "Tên Môn";
            radGridViewSubject.Columns[3].HeaderText = "Trạng Thái";

            foreach (var x in _serSubject.GetSubjects())
            {
                radGridViewSubject.Rows.Add(stt++, x.Id, x.Name, x.Status == 0 ? "Mở" : "Đóng");
            }
        }

        public void loadExamSubject(string id)
        {
            int stt = 1;

            radGridViewExamSubject.Rows.Clear();

            radGridViewExamSubject.ColumnCount = 7;

            radGridViewExamSubject.Columns[0].HeaderText = "STT";
            radGridViewExamSubject.Columns[1].HeaderText = "ID Bài Thi";
            radGridViewExamSubject.Columns[2].HeaderText = "Mã Thí Sinh";
            radGridViewExamSubject.Columns[3].HeaderText = "Mã Đề Thi";
            radGridViewExamSubject.Columns[4].HeaderText = "Điểm";
            radGridViewExamSubject.Columns[5].HeaderText = "Thời Gian Nộp";
            radGridViewExamSubject.Columns[6].HeaderText = "Đạt";

            radGridViewExamSubject.Columns[1].IsVisible = false;

            foreach (var x in _serSubject.GetSubject_ViewModel(id))
            {
                radGridViewExamSubject.Rows.Add(stt++, x.idExamResponses, x.participantId, x.ExamDetailCode, x.Score, x.SubmitTime, x.Ispassed == true ? "Có" : "Không");
            }
        }

        private void radGridViewSubject_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = radGridViewSubject.CurrentRow.Cells[1].Value.ToString();

            radLblSumExam.Text = _serSubject.GetSubject_ViewModel(_idWhenClick).Count.ToString();
            radLblSumExamPass.Text = _serSubject.GetSubject_ViewModel(_idWhenClick).Where(x => x.Ispassed == true).ToList().Count.ToString();
            radLblSumExamFailed.Text = _serSubject.GetSubject_ViewModel(_idWhenClick).Where(x => x.Ispassed == false).ToList().Count.ToString();
            double sumScore = 0;
            foreach (var x in _serSubject.GetSubject_ViewModel(_idWhenClick))
            {
                sumScore += x.Score;
            }

            double Avg = sumScore / _serSubject.GetSubject_ViewModel(_idWhenClick).Count;
       
            radLblSumScore.Text = Math.Round(Avg, 2).ToString();
            if (radLblSumScore.Text == "NaN")
            {
                radLblSumScore.Text = "0";
            }
            loadExamSubject(_idWhenClick);
        }

        private void radGridViewExamSubject_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem menuItem = new RadMenuItem("Xem Chi Tiết");
            menuItem.Click += MenuItem_Click;
            e.ContextMenu.Items.Add(menuItem);
        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            int idExamResponse = int.Parse(radGridViewExamSubject.CurrentRow.Cells[1].Value.ToString());
            var form = new ReViewExam(idExamResponse);
            form.ShowDialog();
        }
    }
}
