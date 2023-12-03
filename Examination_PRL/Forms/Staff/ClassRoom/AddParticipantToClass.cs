using Examination_BUS.Services;
using MediaFoundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff.ClassRoom
{
    public partial class AddParticipantToClass : Telerik.WinControls.UI.RadForm
    {
        ClassroomServices _serClass = new ClassroomServices();

        ParticipantService _serPar = new ParticipantService();

        string _classIdWhenClick;

        string _ParticipantIdWhenClick;

        string _ParticipantIdOfClassWhenClick;

        public AddParticipantToClass()
        {
            InitializeComponent();
            loadDBclass();
            loadDbPar();
            loadCmb();
        }

        public void loadCmb()
        {
            foreach (var x in _serClass.GetClassrooms())
            {
                radDdlClassId.Items.Add(x.Id);
            }
            radDdlClassId.SelectedIndex = 0;
        }

        public void loadDBclass()
        {
            radGridViewClass.Rows.Clear();

            radGridViewClass.ColumnCount = 3;

            int stt = 1;

            radGridViewClass.Columns[0].HeaderText = "STT";
            radGridViewClass.Columns[1].HeaderText = "Mã Lớp";
            radGridViewClass.Columns[2].HeaderText = "Tên lớp";

            foreach (var x in _serClass.GetClassrooms())
            {
                radGridViewClass.Rows.Add(stt++, x.Id, x.Name);
            }
        }

        public void loadDbParticipantToClass(string classId)
        {
            radGridViewParInClass.Rows.Clear();

            int stt = 1;

            radGridViewParInClass.ColumnCount = 5;

            radGridViewParInClass.Columns[0].HeaderText = "STT";
            radGridViewParInClass.Columns[1].HeaderText = "Mã Thí Sinh";
            radGridViewParInClass.Columns[2].HeaderText = "Tên Thí Sinh";
            radGridViewParInClass.Columns[3].HeaderText = "Giới Tính";
            radGridViewParInClass.Columns[4].HeaderText = "Email";

            foreach (var x in _serPar.GetAllParByClassIds(classId))
            {
                radGridViewParInClass.Rows.Add(stt++, x.Id, x.FullName, x.Gender == true ? "Nam" : "Nữ", x.Email);
            }
        }

        public void loadDbPar()
        {
            radGridViewParticipant.Rows.Clear();

            int stt = 1;

            radGridViewParticipant.ColumnCount = 6;

            radGridViewParticipant.Columns[0].HeaderText = "STT";
            radGridViewParticipant.Columns[1].HeaderText = "Mã Thí Sinh";
            radGridViewParticipant.Columns[2].HeaderText = "Tên Thí Sinh";
            radGridViewParticipant.Columns[3].HeaderText = "Giới Tính";
            radGridViewParticipant.Columns[4].HeaderText = "Email";
            radGridViewParticipant.Columns[5].HeaderText = "Mã lớp";

            radGridViewParticipant.Columns[5].IsVisible = false;

            foreach (var x in _serPar.getAllStudents())
            {
                radGridViewParticipant.Rows.Add(stt++, x.Id, x.FullName, x.Gender == true ? "Nam" : "Nữ", x.Email, x.ClassroomId);

                foreach (GridViewRowInfo row in radGridViewParticipant.Rows)
                {
                    if (row.Cells[5].Value != null)
                    {
                        row.IsVisible = false;
                    }
                }
            }
        }

        private void radGridViewClass_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _classIdWhenClick = radGridViewClass.CurrentRow.Cells[1].Value.ToString();

            radLblClassId.Text = _classIdWhenClick;
            radLblSumPar.Text = _serPar.GetAllParByClassIds(_classIdWhenClick).Count.ToString();

            loadDbParticipantToClass(_classIdWhenClick);
        }

        private void radGridViewParticipant_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _ParticipantIdWhenClick = radGridViewParticipant.CurrentRow.Cells[1].Value.ToString();
        }

        private void radGridViewParInClass_CellClick(object sender, GridViewCellEventArgs e)
        {
            _ParticipantIdOfClassWhenClick = radGridViewParInClass.CurrentRow.Cells[1].Value.ToString();
        }

        private void radBtnAdd_Click(object sender, EventArgs e)
        {
            string classId = radDdlClassId.SelectedItem.ToString();

            if (_serPar.updateClassIdOfPars(_ParticipantIdWhenClick, classId))
            {
                MessageBox.Show("Thêm vào lớp thành công");
            }
            else
            {
                MessageBox.Show("Thêm vào lớp thất bại");
            }

            loadDbParticipantToClass(classId);
            loadDbPar();
        }

        private void radBtnUpdate_Click(object sender, EventArgs e)
        {
            string classId = radDdlClassId.SelectedItem.ToString();

            if (_serPar.updateClassIdOfPars(_ParticipantIdOfClassWhenClick, classId))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            loadDbPar();
            loadDbParticipantToClass(classId);

        }

        private void radBtnRemove_Click(object sender, EventArgs e)
        {
            if (_serPar.updateClassIdOfPars(_ParticipantIdOfClassWhenClick, null))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            loadDbPar();
            loadDbParticipantToClass(radLblClassId.Text);
        }
    }
}
