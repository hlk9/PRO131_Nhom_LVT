﻿using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.Schedule
{
    public partial class AddScheduleTo : Telerik.WinControls.UI.RadForm
    {

        ClassroomServices classroomServices = new ClassroomServices();
        ParticipantService participantService = new ParticipantService();

        string _idClassrom;
        string _idSchedule;
        string _idParticipant;
        public AddScheduleTo()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            //load schedule

            gridViewClass.Rows.Clear();
            int stt1 = 1;
            gridViewClass.ColumnCount = 3;
            gridViewClass.Columns[0].HeaderText = "STT";
            gridViewClass.Columns[1].HeaderText = "ID";
            gridViewClass.Columns[2].HeaderText = "Tên Lớp";




            foreach (var item in classroomServices.GetClassrooms())
            {
                gridViewClass.Rows.Add(stt1++, item.Id, item.Name);
            }




        }

        private void gridViewSchedule_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try

            {
                _idClassrom = gridViewClass.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblCurrentClass.Text = gridViewClass.Rows[e.RowIndex].Cells[2].Value.ToString();

                gridViewParti.Rows.Clear();
                int stt = 1;
                gridViewParti.ColumnCount = 5;
                gridViewParti.Columns[0].HeaderText = "STT";
                gridViewParti.Columns[1].HeaderText = "ID";
                gridViewParti.Columns[2].HeaderText = "Họ và tên";
                gridViewParti.Columns[3].HeaderText = "Giới tính";
                gridViewParti.Columns[4].HeaderText = "Ngày sinh";
                foreach (var item in participantService.getAllStudents().Where(x => x.ClassroomId == _idClassrom))
                {
                    gridViewParti.Rows.Add(stt++, item.Id, item.FullName, item.Gender == true ? "Nam" : item.Gender == null ? "Khác" : "Nữ", item.DateOfBirth);
                }
                classmateCount.Text = gridViewParti.Rows.Count.ToString();

            }

            catch (Exception)
            {

                _idClassrom = "";
                gridViewParti.Rows.Clear();
                lblCurrentClass.Text = "";
                classmateCount.Text = "";
            }
        }

        private void gridViewParti_Click(object sender, EventArgs e)
        {
            try
            {
                _idParticipant = gridViewParti.CurrentRow.Cells[1].Value.ToString();
                lblCurrentParti.Text = _idParticipant;
            }
            catch
            {
                _idParticipant = "";
                lblCurrentParti.Text = "";
            }
        }
    }
}
