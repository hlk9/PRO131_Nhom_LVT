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

namespace Examination_PRL.Forms.Staff.Exam
{
    public partial class SelectOrAddNewExam : Telerik.WinControls.UI.RadForm
    {
        ExamServices examServices = new ExamServices();
        string curentExamCode = "";
        int currentExamId = -1;

        public SelectOrAddNewExam()
        {
            InitializeComponent();
            LoadData();
            examGridView.ContextMenuOpening += ExamGridView_ContextMenuOpening;



        }

        private void ExamGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {


            e.ContextMenu.Items.Clear();
            RadMenuItem currentExam = new RadMenuItem("Đang chọn: " + curentExamCode);
            currentExam.ForeColor = Color.Teal;
            e.ContextMenu.Items.Add(currentExam);

            RadMenuSeparatorItem separator = new RadMenuSeparatorItem();
            e.ContextMenu.Items.Add(separator);

            RadMenuItem editItem = new RadMenuItem("Sửa bài thi này");
            editItem.Click += EditItem_Click;
            e.ContextMenu.Items.Add(editItem);
            RadMenuItem deleteItem = new RadMenuItem("Xoá bài thi này");
            deleteItem.Click += DeleteItem_Click;
            e.ContextMenu.Items.Add(deleteItem);

        }

        private void DeleteItem_Click(object? sender, EventArgs e)
        {
            if (examGridView.SelectedRows.Count > 0)
            {

            }
        }

        private void EditItem_Click(object? sender, EventArgs e)
        {
            if (examGridView.SelectedRows.Count > 0)
            {
                examGridView.BeginEdit();
            }
        }

        void LoadData()
        {
            examGridView.Rows.Clear();
            int stt = 1;
            examGridView.ColumnCount = 5;
            examGridView.Columns[0].HeaderText = "ID";
            examGridView.Columns[0].IsVisible = false;
            examGridView.Columns[1].HeaderText = "STT";
            examGridView.Columns[2].HeaderText = "Mã bài thi";
            examGridView.Columns[3].HeaderText = "Tên bài thi";
            examGridView.Columns[4].HeaderText = "Mã môn";

            foreach (var item in examServices.GetAll())
            {
                examGridView.Rows.Add(item.Id, stt++, item.ExamCode, item.Name, item.SubjectId);
            }

        }

        private void examGridView_CellClick(object sender, GridViewCellEventArgs e)
        {

        }

        private void examGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                currentExamId = int.Parse(examGridView.CurrentRow.Cells[0].Value.ToString());
                curentExamCode = examGridView.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                curentExamCode = "";
            }
        }

        private void examGridView_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            Examination_DAL.Models.Exam exam = new Examination_DAL.Models.Exam();
            exam.Id = int.Parse(examGridView.CurrentRow.Cells[0].Value.ToString());
            exam.ExamCode = examGridView.CurrentRow.Cells[2].Value.ToString();
            exam.Name = examGridView.CurrentRow.Cells[3].Value.ToString();
            exam.SubjectId = examGridView.CurrentRow.Cells[4].Value.ToString();
            bool editCompleted = examServices.Update(exam);
            if (editCompleted)
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void examGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            return;
        }
    }
}
