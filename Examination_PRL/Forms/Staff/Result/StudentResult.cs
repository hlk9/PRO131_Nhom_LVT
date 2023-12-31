﻿using Examination_BUS.Services;
using Examination_PRL.Forms.Participant;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class StudentResult : Telerik.WinControls.UI.RadForm
    {

        ParticipantService _serStudent = new ParticipantService();

        ExamServices _serExam = new ExamServices();

        ExamResponseServices _serAll = new ExamResponseServices();

        string _idWhenCLick;

        public StudentResult()
        {
            InitializeComponent();
            radLblSumStudent.Text = _serStudent.getAllStudents().Count.ToString();
            radLblSumExam.Text = _serAll.GetAllExamResponse().Count.ToString();
            radLblPassedExam.Text = _serAll.GetAllExamResponse().Where(x => x.IsPassed == true).ToList().Count.ToString();
            radLblFailedExam.Text = _serAll.GetAllExamResponse().Where(x => x.IsPassed == false).ToList().Count.ToString();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;

            radGridViewStudent.ColumnCount = 10;

            radGridViewStudent.Columns[0].HeaderText = "STT";
            radGridViewStudent.Columns[1].HeaderText = "Mã Thí Sinh";
            radGridViewStudent.Columns[2].HeaderText = "Tên Thí Sinh";
            radGridViewStudent.Columns[3].HeaderText = "Giới Tính";
            radGridViewStudent.Columns[4].HeaderText = "Ngày Sinh";
            radGridViewStudent.Columns[5].HeaderText = "Số Điện Thoại";
            radGridViewStudent.Columns[6].HeaderText = "Email";
            radGridViewStudent.Columns[7].HeaderText = "Địa Chỉ";
            radGridViewStudent.Columns[8].HeaderText = "Mã Lớp";
            radGridViewStudent.Columns[9].HeaderText = "Trạng Thái";
            radGridViewStudent.Rows.Clear();

            foreach (var x in _serStudent.getAllStudents())
            {
                radGridViewStudent.Rows.Add(stt++, x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.ClassroomId, x.Status == 1 ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        public void loadDataExam(string id)
        {
            int stt = 1;
            radGridViewExam.ColumnCount = 8;

            radGridViewExam.Columns[0].HeaderText = "STT";
            radGridViewExam.Columns[1].HeaderText = "Bài Thi";
            radGridViewExam.Columns[2].HeaderText = "Điểm";
            radGridViewExam.Columns[3].HeaderText = "Môn Thi";
            radGridViewExam.Columns[4].HeaderText = "Ngày Hoàn Thành";
            radGridViewExam.Columns[5].HeaderText = "Đạt";
            radGridViewExam.Columns[6].HeaderText = "Ghi Chú";
            radGridViewExam.Columns[7].IsVisible = false;
            radGridViewExam.Columns[7].HeaderText = "ID Exam Response";

            radGridViewExam.Rows.Clear();

            foreach (var x in _serExam.GetAnswer_ResponsesViewModels(id))
            {
                radGridViewExam.Rows.Add(stt++, x.NameExam, x.Score, x.SubjectId, x.SubmitTime, x.IsPassed == null ? "Không Xác Định" : (x.IsPassed == true ? "Có" : "Không"), x.Note, x.Id);
            }
        }

        private void radGridViewStudent_CellClick_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenCLick = radGridViewStudent.CurrentRow.Cells[1].Value.ToString();

            radLblIdStudent.Text = _idWhenCLick;
            radLblSumExamStudent.Text = _serAll.GetAllExamResponse().Where(x => x.ParticipantId == _idWhenCLick).ToList().Count.ToString();
            radLblPassedExamStudent.Text = _serAll.GetExamResponseByParticipantId(_idWhenCLick).Where(x => x.IsPassed == true).ToList().Count.ToString();
            radLblFailedExamStudent.Text = _serAll.GetExamResponseByParticipantId(_idWhenCLick).Where(x => x.IsPassed == false).ToList().Count.ToString();
            loadDataExam(_idWhenCLick);
        }

        private void radGridViewExam_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem menuItem = new RadMenuItem("Xem Chi Tiết");
            menuItem.Click += MenuItem_Click;
            e.ContextMenu.Items.Add(menuItem);
        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            int idExamResponse = int.Parse(radGridViewExam.CurrentRow.Cells[7].Value.ToString());
            var form = new ReViewExam(idExamResponse);
            form.ShowDialog();
        }
    }
}
