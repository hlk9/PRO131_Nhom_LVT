using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms
{
    public partial class EditExams : Telerik.WinControls.UI.RadForm
    {
        ExamServices _service = new ExamServices();
        SubjectServices _subjectServices = new SubjectServices();
        List<string> _lstSubjectID = new List<string>();
        int _idWhenClick;
        public EditExams()
        {
            InitializeComponent();
            LoadDataExam();
            LoadCMB();
        }

        public void LoadDataExam()
        {
            int stt = 1;
            radGrid_ExamEdit.ColumnCount = 5;

            radGrid_ExamEdit.Columns[0].HeaderText = "STT";
            radGrid_ExamEdit.Columns[1].HeaderText = "ID";
            radGrid_ExamEdit.Columns[2].HeaderText = "Mã Bài Thi";
            radGrid_ExamEdit.Columns[3].HeaderText = "Mã Môn";
            radGrid_ExamEdit.Columns[4].HeaderText = "Tên Bài Thi";

            radGrid_ExamEdit.Rows.Clear();

            foreach (var item in _service.GetAll())
            {
                radGrid_ExamEdit.Rows.Add(stt++, item.Id, item.ExamCode, item.SubjectId, item.Name);
            }

            try

            {
                radGrid_ExamEdit.CurrentRow = radGrid_ExamEdit.Rows[0];

            }
            catch
            {

            }

        }
        public void LoadCMB()
        {
            foreach (var item in _subjectServices.GetSubjects())
            {
                _lstSubjectID.Add(item.Id);
                radCMB.Items.Add(item.Id);
            }
            radCMB.SelectedIndex = 0;
        }

        private void radBtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radxtID.Text) || string.IsNullOrWhiteSpace(radTxtIdBaiThi.Text) || string.IsNullOrWhiteSpace(radTxtTenBaiThi.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu");
                return;
            }

            Exam AddExam = new Exam();
            // AddExam.Id = _idWhenClick;
            AddExam.ExamCode = radTxtIdBaiThi.Text;
            AddExam.SubjectId = radCMB.SelectedItem.Text;
            AddExam.Name = radTxtTenBaiThi.Text;
            if (_service.AddExam(AddExam))
            {
                MessageBox.Show("Thêm Bài Thi Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Bài Thi Thất Bại");
            }
            LoadDataExam();
        }

        private void radBtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radxtID.Text) || string.IsNullOrWhiteSpace(radTxtIdBaiThi.Text) || string.IsNullOrWhiteSpace(radTxtTenBaiThi.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu");
                return;
            }

            Exam updateExam = new Exam();
            updateExam.Id = _idWhenClick;
            updateExam.ExamCode = radTxtIdBaiThi.Text;
            updateExam.SubjectId = radCMB.SelectedItem.Text;
            updateExam.Name = radTxtTenBaiThi.Text;
            if (_service.Update(updateExam))
            {


                MessageBox.Show("Sửa Bài Thi Thành Công");
            }
            else
            {
                MessageBox.Show("Sửa Bài Thi Thất Bại");
            }
            LoadDataExam();
        }


        private void radGrid_ExamEdit_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = Convert.ToInt32(radGrid_ExamEdit.Rows[e.RowIndex].Cells[1].Value.ToString());
            var obj = _service.GetAll().Where(x => x.Id == _idWhenClick).FirstOrDefault();
            if (obj != null)
            {
                radxtID.Text = obj.Id.ToString();
                radTxtIdBaiThi.Text = obj.ExamCode;
                var box = _lstSubjectID.FindIndex(x => x == obj.SubjectId);
                radCMB.SelectedIndex = box;
                radTxtTenBaiThi.Text = obj.Name;
            }
        }

        private void radCMB_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                Subject subject = _subjectServices.GetOneWithID(radCMB.SelectedItem.Text);
                radTxtTenBaiThi.Text = subject.Name;
            }
            catch
            {
                radTxtTenBaiThi.Text = "";
            }
        }

        private void radBtnClear_Click(object sender, EventArgs e)
        {
            radxtID.Text = "";
            radTxtIdBaiThi.Text = "";
            radTxtTenBaiThi.Text = "";
        }
    }
}
