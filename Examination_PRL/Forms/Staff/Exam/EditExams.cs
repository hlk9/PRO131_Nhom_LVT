using Examination_BUS.Services;
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
        int _idWhenClick;
        public EditExams()
        {
            InitializeComponent();
            LoadDataExam();
        }

        public void LoadDataExam()
        {
            int stt = 1;
            radGrid_ExamEdit.ColumnCount = 5;

            radGrid_ExamEdit.Columns[0].HeaderText = "STT";
            radGrid_ExamEdit.Columns[1].HeaderText = "ID";
            radGrid_ExamEdit.Columns[2].HeaderText = "Mã Bài Thi";
            radGrid_ExamEdit.Columns[3].HeaderText = "Tên Bài Thi";
            radGrid_ExamEdit.Columns[4].HeaderText = "Mã Môn";

            radGrid_ExamEdit.Rows.Clear();

            foreach (var item in _service.GetAll())
            {
                radGrid_ExamEdit.Rows.Add(stt++, item.Id, item.ExamCode, item.Name, item.SubjectId);
            }
        }

        private void radBtnThem_Click(object sender, EventArgs e)
        {
            string idDe = null;
            string name = radTxtTenBaiThi.Text;
            string idMon = null;
            if (_service.AddExam(name, idDe, idMon))
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
            //int id = Convert.ToInt32(radxtID.Text);
            //string idDe = radTxtIdBaiThi.Text;
            //string name = radTxtTenBaiThi.Text;
            //string idMon = radTxtMaMon.Text;
            //if (_service.Update())
            //{
            //    MessageBox.Show("Sửa Bài Thi Thành Công");
            //}
            //else
            //{
            //    MessageBox.Show("Sửa Bài Thi Thất Bại");
            //}
            //LoadDataExam();
        }

        private void radGrid_ExamEdit_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = Convert.ToInt32(radGrid_ExamEdit.Rows[e.RowIndex].Cells[1].Value.ToString());
            var obj = _service.GetAll().Where(x => x.Id == _idWhenClick).FirstOrDefault();
            if (obj != null)
            {
                radxtID.Text = obj.Id.ToString();
                radTxtIdBaiThi.Text = obj.ExamCode;
                radTxtTenBaiThi.Text = obj.Name;
                radTxtMaMon.Text = obj.SubjectId;
            }

        }
    }
}
