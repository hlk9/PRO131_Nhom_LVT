﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using OfficeOpenXml;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Examination_BUS.Services;
using Examination_PRL.Forms.Staff.ClassRoom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examination_PRL.Forms.Staff.Student
{
    public partial class AddStudentExcel : Telerik.WinControls.UI.RadForm
    {

        ParticipantService _ser = new ParticipantService();

        public AddStudentExcel()
        {
            InitializeComponent();
        }

        private void radBtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                radTxtFile.Text = openFileDialog.FileName;
            }
        }

        private void importExcelStudent(string path)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage newPackage = new ExcelPackage(new FileInfo(path));
                ExcelWorksheet workSheetStudent = newPackage.Workbook.Worksheets[0];
                int rowCount = workSheetStudent.Dimension.Rows;
                int columns = workSheetStudent.Dimension.Columns;

                for (int row = 2; row <= rowCount; row++)
                {
                    string id = workSheetStudent.Cells[row, 1].Value.ToString();
                    string name = workSheetStudent.Cells[row, 2].Value.ToString();
                    bool gender = Convert.ToBoolean(workSheetStudent.Cells[row, 3].Value);
                    DateTime dateOfBirth = Convert.ToDateTime(workSheetStudent.Cells[row, 4].Value);
                    string email = workSheetStudent.Cells[row, 5].Value.ToString();
                    string phone = workSheetStudent.Cells[row, 6].Value.ToString();
                    string address = workSheetStudent.Cells[row, 7].Value.ToString();
                    byte status = 1;
                    string classRoomId;
                    if (workSheetStudent.Cells[row, 9].Value != null)
                    {
                        classRoomId = workSheetStudent.Cells[row, 9].Value.ToString();
                    }
                    else
                    {
                        classRoomId = null;
                    }
                    

                    _ser.createStudents(id, name, address, email, phone, gender, status, dateOfBirth, classRoomId);
             
                }

                MessageBox.Show($"Thêm Thành Công {rowCount - 1} Thí Sinh");
            }
            catch
            {
                MessageBox.Show("Thêm Thất Bại");
            }
        }

        private void radBtnSave_Click(object sender, EventArgs e)
        {
            if (radTxtFile.Text != null)
            {
                importExcelStudent(radTxtFile.Text);
            }
        }
    }
}
