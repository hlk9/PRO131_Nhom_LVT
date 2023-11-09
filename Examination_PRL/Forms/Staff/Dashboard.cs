﻿using System;
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
    public partial class Dashboard : Telerik.WinControls.UI.RadForm
    {
        public Dashboard()
        {
            InitializeComponent();
            GenerateLayout();
        }
        void GenerateLayout()
        {



            RadPageViewPage homePage = new RadPageViewPage("Trang chủ");

            //RadSvgImage homeIcon;
            //homeIcon = RadSvgImage.Deserialize(File.ReadAllText(@"C:\Users\hlk\Downloads\icons\home.svg"));
            //Size iconSize = homeIcon.Size;
            //homePage.Item.Size = iconSize;
            //homePage.Item.SvgImage = homeIcon;

            RadPageViewPage schedulePage = new RadPageViewPage("Lịch thi"); //xem danh sách lịch thi
            RadPageViewPage createSchedulePage = new RadPageViewPage("Tạo lịch thi");
            RadPageViewPage manageSchedulePage = new RadPageViewPage("Quản lý lịch thi"); //sửa, xoá
            schedulePage.SubPages.Add(createSchedulePage);
            schedulePage.SubPages.Add(manageSchedulePage);

            RadPageViewPage studentPage = new RadPageViewPage("Thí sinh"); //xem danh sách thí sinh
            RadPageViewPage addStudentPage = new RadPageViewPage("Thêm thí sinh");
            RadPageViewPage editStudentPage = new RadPageViewPage("Sửa thí sinh");
            RadPageViewPage deleteStudentPage = new RadPageViewPage("Xóa thí sinh");
            studentPage.SubPages.Add(addStudentPage);
            studentPage.SubPages.Add(editStudentPage);
            studentPage.SubPages.Add(deleteStudentPage);

            RadPageViewPage examPage = new RadPageViewPage("Đề thi"); //xem danh sách đề thi
            RadPageViewPage addExamPage = new RadPageViewPage("Thêm đề thi");
            RadPageViewPage editExamPage = new RadPageViewPage("Sửa đề thi");
            RadPageViewPage deleteExamPage = new RadPageViewPage("Xóa đề thi");
            examPage.SubPages.Add(addExamPage);
            examPage.SubPages.Add(editExamPage);
            examPage.SubPages.Add(deleteExamPage);

            RadPageViewPage questionPage = new RadPageViewPage("Câu hỏi");
            RadPageViewPage addQuestionPage = new RadPageViewPage("Thêm câu hỏi");
            RadPageViewPage editQuestionPage = new RadPageViewPage("Sửa câu hỏi");
            RadPageViewPage deleteQuestionPage = new RadPageViewPage("Xóa câu hỏi");
            questionPage.SubPages.Add(addQuestionPage);
            questionPage.SubPages.Add(editQuestionPage);
            questionPage.SubPages.Add(deleteQuestionPage);


            RadPageViewPage subjectPage = new RadPageViewPage("Môn"); //xem danh sách môn
            RadPageViewPage addSubjectPage = new RadPageViewPage("Thêm môn");
            RadPageViewPage editSubjectPage = new RadPageViewPage("Sửa môn");
            RadPageViewPage deleteSubjectPage = new RadPageViewPage("Xóa môn");
            subjectPage.SubPages.Add(addSubjectPage);
            subjectPage.SubPages.Add(editSubjectPage);
            subjectPage.SubPages.Add(deleteSubjectPage);



            RadPageViewPage roomPage = new RadPageViewPage("Phòng thi"); //xem danh sách phòng thi
            RadPageViewPage addRoomPage = new RadPageViewPage("Thêm phòng thi");
            RadPageViewPage editRoomPage = new RadPageViewPage("Sửa phòng thi");
            RadPageViewPage deleteRoomPage = new RadPageViewPage("Xóa phòng thi");
            roomPage.SubPages.Add(addRoomPage);
            roomPage.SubPages.Add(editRoomPage);
            roomPage.SubPages.Add(deleteRoomPage);

            RadPageViewPage staffPage = new RadPageViewPage("Nhân viên"); //xem danh sách nhân viên
            RadPageViewPage addStaffPage = new RadPageViewPage("Thêm nhân viên");
            RadPageViewPage editStaffPage = new RadPageViewPage("Sửa nhân viên");
            RadPageViewPage deleteStaffPage = new RadPageViewPage("Xóa nhân viên");
            staffPage.SubPages.Add(addStaffPage);
            staffPage.SubPages.Add(editStaffPage);
            staffPage.SubPages.Add(deleteStaffPage);






            RadPageViewPage resultPage = new RadPageViewPage("Kết quả");
            RadPageViewPage resultByStudentPage = new RadPageViewPage("Kết quả của thí sinh");
            RadPageViewPage resultBySubjectPage = new RadPageViewPage("Kết quả theo môn");
            RadPageViewPage resultByExamPage = new RadPageViewPage("Kết quả theo đề thi");
            RadPageViewPage resultByRoomPage = new RadPageViewPage("Kết quả theo phòng thi");
            resultPage.SubPages.Add(resultByStudentPage);
            resultPage.SubPages.Add(resultBySubjectPage);
            resultPage.SubPages.Add(resultByExamPage);
            resultPage.SubPages.Add(resultByRoomPage);

            RadPageViewPage reportPage = new RadPageViewPage("Báo cáo");
            RadPageViewPage reportByStudentPage = new RadPageViewPage("Báo cáo theo thí sinh");
            RadPageViewPage reportBySubjectPage = new RadPageViewPage("Báo cáo theo môn");
            RadPageViewPage reportByExamPage = new RadPageViewPage("Báo cáo theo đề thi");
            RadPageViewPage reportByRoomPage = new RadPageViewPage("Báo cáo theo phòng thi");
            reportPage.SubPages.Add(reportByStudentPage);
            reportPage.SubPages.Add(reportBySubjectPage);
            reportPage.SubPages.Add(reportByExamPage);
            reportPage.SubPages.Add(reportByRoomPage);

            pvDashboard.Pages.Add(homePage);
            pvDashboard.Pages.Add(schedulePage);
            pvDashboard.Pages.Add(studentPage);
            pvDashboard.Pages.Add(examPage);
            pvDashboard.Pages.Add(subjectPage);
            pvDashboard.Pages.Add(roomPage);
            pvDashboard.Pages.Add(staffPage);
            pvDashboard.Pages.Add(resultPage);
            pvDashboard.Pages.Add(reportPage);
            pvDashboard.Pages.Add(questionPage);

            pvDashboard.AutoScroll = true;

        }




    }
}