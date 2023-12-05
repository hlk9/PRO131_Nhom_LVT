using Examination_DAL.Models;
using Examination_PRL.Forms.Staff.ClassRoom;
using Examination_PRL.Forms.Staff.Exam;
using Examination_PRL.Forms.Staff.FullStaff;
using Examination_PRL.Forms.Staff.Home;
using Examination_PRL.Forms.Staff.QuestionForm;
using Examination_PRL.Forms.Staff.Result;
using Examination_PRL.Forms.Staff.Schedule;
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
    public partial class Dashboard : Telerik.WinControls.UI.RadForm
    {

        public delegate void UpdateDataDelegate();
        public event UpdateDataDelegate UpdateDataEvent = delegate { };
        Account usrAccount;
        public Dashboard(Account account)
        {
            usrAccount = account;
            InitializeComponent();
            GenerateLayout();
        }
        void GenerateLayout()
        {

            RadPageViewPage homePage = new RadPageViewPage("Trang chủ");
            homePage.ToolTipText = "Trang chủ";

            Bitmap bitMapHomeIcon = new Bitmap(Properties.Resources.home);
            Image homeIcon = bitMapHomeIcon;
            homePage.Image = homeIcon;
            Examination_PRL.Forms.Staff.Home.Home home = new Examination_PRL.Forms.Staff.Home.Home(usrAccount);
            home.TopLevel = false;
            homePage.Controls.Add(home);
            home.Show();
            home.Dock = DockStyle.Fill;


            RadPageViewPage schedulePage = new RadPageViewPage("Lịch thi"); //xem danh sách lịch thi

            Bitmap bitMapScheduleIcon = new Bitmap(Properties.Resources.schedule);
            Image scheduleIcon = bitMapScheduleIcon;
            schedulePage.Image = scheduleIcon;
            schedulePage.ToolTipText = "Lịch thi";

            ThoiGian thoiGian = new ThoiGian();
            thoiGian.TopLevel = false;
            schedulePage.Controls.Add(thoiGian);
            thoiGian.Show();
            thoiGian.Dock = DockStyle.Fill;
            thoiGian.Name = "thoiGianForm";


            RadPageViewPage manageSchedulePage = new RadPageViewPage("Quản lý lịch thi"); //sửa, xoá  
            schedulePage.SubPages.Add(manageSchedulePage);
            ScheduleManagement scheduleManagement = new ScheduleManagement(usrAccount);
            scheduleManagement.TopLevel = false;
            manageSchedulePage.Controls.Add(scheduleManagement);
            scheduleManagement.Show();
            scheduleManagement.Dock = DockStyle.Fill;
            scheduleManagement.Name = "scheduleManagementForm";


            RadPageViewPage studentPage = new RadPageViewPage("Thí sinh"); //xem danh sách thí sinh
            studentPage.ToolTipText = "Thí sinh";
            Bitmap bitMapStudentIcon = new Bitmap(Properties.Resources.student);
            Image studentIcon = bitMapStudentIcon;
            studentPage.Image = studentIcon;

            StudentsList studentsList = new StudentsList();
            studentsList.TopLevel = false;
            studentPage.Controls.Add(studentsList);
            studentsList.Show();
            studentsList.Dock = DockStyle.Fill;
            studentsList.Name = "studentsListForm";

            RadPageViewPage addStudentPage = new RadPageViewPage("Edit thí sinh");
            AddStudents addThiSinh = new AddStudents();
            addThiSinh.TopLevel = false;
            addStudentPage.Controls.Add(addThiSinh);
            addThiSinh.Show();
            addThiSinh.Dock = DockStyle.Fill;
            addThiSinh.Name = "addThiSinhForm";

            RadPageViewPage qltkStudentPage = new RadPageViewPage("QLTK Thí Sinh");
            QLTKStudent qltkstudent = new QLTKStudent();
            qltkstudent.TopLevel = false;
            qltkStudentPage.Controls.Add(qltkstudent);
            qltkstudent.Show();
            qltkstudent.Dock = DockStyle.Fill;
            qltkstudent.Name = "QLTK Thí Sinh";
            studentPage.SubPages.Add(addStudentPage);
            studentPage.SubPages.Add(qltkStudentPage);

            RadPageViewPage examPage = new RadPageViewPage("Đề thi"); //xem danh sách đề thi
            examPage.ToolTipText = "Đề thi";
            Bitmap bitMapExamIcon = new Bitmap(Properties.Resources.exam);
            Image examIcon = bitMapExamIcon;
            examPage.Image = examIcon;


            Exam_Overview exam_Overview = new Exam_Overview();
            exam_Overview.TopLevel = false;
            examPage.Controls.Add(exam_Overview);
            exam_Overview.Show();
            exam_Overview.Dock = DockStyle.Fill;
            exam_Overview.Name = "exam_OverviewForm";

            RadPageViewPage examGroup = new RadPageViewPage("Bài thi");
            EditExams editExams = new EditExams();
            editExams.TopLevel = false;
            examGroup.Controls.Add(editExams);
            editExams.Show();
            editExams.Dock = DockStyle.Fill;
            editExams.Name = "editExam";


            RadPageViewPage addExamPage = new RadPageViewPage("Thêm đề thi");
            AddExam addExam = new AddExam();
            addExam.TopLevel = false;
            addExamPage.Controls.Add(addExam);
            addExam.Show();
            addExam.Dock = DockStyle.Fill;
            addExam.Name = "addExamForm";

            //RadPageViewPage editExamPage = new RadPageViewPage("Sửa đề thi");
            //RadPageViewPage deleteExamPage = new RadPageViewPage("Xóa đề thi");
            examPage.SubPages.Add(addExamPage);
            //examPage.SubPages.Add(editExamPage);
            //examPage.SubPages.Add(deleteExamPage);

            RadPageViewPage questionPage = new RadPageViewPage("Câu hỏi");
            questionPage.ToolTipText = "Câu hỏi";
            Bitmap bitMapQuestionIcon = new Bitmap(Properties.Resources.quest);
            Image questionIcon = bitMapQuestionIcon;
            questionPage.Image = questionIcon;
            QuestionOverview questionOverview = new QuestionOverview();
            questionOverview.TopLevel = false;
            questionPage.Controls.Add(questionOverview);
            questionOverview.Show();
            questionOverview.Dock = DockStyle.Fill;
            questionOverview.Name = "questionOverviewForm";



            RadPageViewPage subjectPage = new RadPageViewPage("Môn"); //xem danh sách môn
            subjectPage.ToolTipText = "Môn";
            Bitmap bitMapSubjectIcon = new Bitmap(Properties.Resources.book);
            Image subjectIcon = bitMapSubjectIcon;
            subjectPage.Image = subjectIcon;
            Subject subject = new Subject();
            subject.TopLevel = false;
            subjectPage.Controls.Add(subject);
            subject.Show();
            subject.Dock = DockStyle.Fill;
            subject.Name = "subjectForm";


            RadPageViewPage classRoom = new RadPageViewPage("Lớp"); //xem danh sách lớp
            Bitmap bitMapClassRoomIcon = new Bitmap(Properties.Resources.group);
            Image classRoomIcon = bitMapClassRoomIcon;
            classRoom.Image = classRoomIcon;
            classRoom.ToolTipText = "Lớp";
            ClassRooms classRooms = new ClassRooms();
            classRooms.TopLevel = false;
            classRoom.Controls.Add(classRooms);
            classRooms.Show();
            classRooms.Dock = DockStyle.Fill;
            classRooms.Name = "classRoomsForm";

            RadPageViewPage addParticipantToClassPage = new RadPageViewPage("Thêm thí sinh vào lớp");
            AddParticipantToClass addParticipantToClass = new AddParticipantToClass();
            addParticipantToClass.TopLevel = false;
            addParticipantToClassPage.Controls.Add(addParticipantToClass);
            addParticipantToClass.Show();
            addParticipantToClass.Dock = DockStyle.Fill;

            classRoom.SubPages.Add(addParticipantToClassPage);

            RadPageViewPage roomPage = new RadPageViewPage("Phòng thi"); //xem danh sách phòng thi
            roomPage.ToolTipText = "Phòng thi";
            Bitmap bitMapRoomIcon = new Bitmap(Properties.Resources._class);
            Image roomIcon = bitMapRoomIcon;
            roomPage.Image = roomIcon;

            Room room = new Room();
            room.TopLevel = false;
            roomPage.Controls.Add(room);
            room.Show();
            room.Dock = DockStyle.Fill;
            room.Name = "roomForm";

            RadPageViewPage staffPage = new RadPageViewPage("Nhân viên"); //xem danh sách nhân viên

            staffPage.ToolTipText = "Nhân viên";
            Bitmap bitMapStaffIcon = new Bitmap(Properties.Resources.person);
            Image staffIcon = bitMapStaffIcon;
            staffPage.Image = staffIcon;
            OverViewNhanVien overViewNhanVien = new OverViewNhanVien();
            overViewNhanVien.TopLevel = false;
            staffPage.Controls.Add(overViewNhanVien);
            overViewNhanVien.Show();
            overViewNhanVien.Dock = DockStyle.Fill;
            overViewNhanVien.Name = "overViewNhanVienForm";

            RadPageViewPage addStaffPage = new RadPageViewPage("Edit nhân viên");
            AddNhanVien addNhanViens = new AddNhanVien();
            addNhanViens.TopLevel = false;
            addStaffPage.Controls.Add(addNhanViens);
            addNhanViens.Show();
            addNhanViens.Dock = DockStyle.Fill;
            addNhanViens.Name = "addNhanViensForm";

            staffPage.SubPages.Add(addStaffPage);

            RadPageViewPage resultPage = new RadPageViewPage("Kết quả");
            Result_Overview result_Overview = new Result_Overview();
            result_Overview.TopLevel = false;
            resultPage.Controls.Add(result_Overview);
            result_Overview.Show();
            result_Overview.Dock = DockStyle.Fill;
            result_Overview.Name = "resul_Overview";

            resultPage.ToolTipText = "Kết quả";
            Bitmap bitMapResultIcon = new Bitmap(Properties.Resources.result);
            Image resultIcon = bitMapResultIcon;
            resultPage.Image = resultIcon;

            RadPageViewPage resultByStudentPage = new RadPageViewPage("Kết quả của thí sinh");
            StudentResult studentResult = new StudentResult();
            studentResult.TopLevel = false;
            resultByStudentPage.Controls.Add(studentResult);
            studentResult.Show();
            studentResult.Dock = DockStyle.Fill;
            studentResult.Name = "studentResult";

            RadPageViewPage resultBySubjectPage = new RadPageViewPage("Kết quả theo môn");
            SubjectResult subjectResult = new SubjectResult();
            subjectResult.TopLevel = false;
            resultBySubjectPage.Controls.Add(subjectResult);
            subjectResult.Show();
            subjectResult.Dock = DockStyle.Fill;
            subjectResult.Name = "subjectResult";

            RadPageViewPage resultByExamPage = new RadPageViewPage("Kết quả theo bài thi");
            ExamResult examResult = new ExamResult();
            examResult.TopLevel = false;
            resultByExamPage.Controls.Add(examResult);
            examResult.Show();
            examResult.Dock = DockStyle.Fill;
            examResult.Name = "examResult";

            resultPage.SubPages.Add(resultByStudentPage);
            resultPage.SubPages.Add(resultBySubjectPage);
            resultPage.SubPages.Add(resultByExamPage);

            RadPageViewPage reportPage = new RadPageViewPage("Thống kê");
            Report_Overview report_Overview = new Report_Overview();
            report_Overview.TopLevel = false;
            reportPage.Controls.Add(report_Overview);
            report_Overview.Show();
            reportPage.Dock = DockStyle.Fill;
            report_Overview.Name = "report_Overview";

            Bitmap bitMapReportIcon = new Bitmap(Properties.Resources.report);
            Image reportIcon = bitMapReportIcon;
            reportPage.Image = reportIcon;
            reportPage.ToolTipText = "Báo cáo";

            RadPageViewPage reportByScorePage = new RadPageViewPage("Phổ điểm");
            ReportByScore reportByScore = new ReportByScore();
            reportByScore.TopLevel = false;
            reportByScorePage.Controls.Add(reportByScore);
            reportByScore.Show();
            reportByScore.Dock = DockStyle.Fill;
            reportByScore.Name = "reportByScore";

            reportPage.SubPages.Add(reportByScorePage);

            RadPageViewPage createAccountParticipantPage = new RadPageViewPage("Quản lý tài quản");
            CrudTK crudTK = new CrudTK();
            crudTK.TopLevel = false;
            createAccountParticipantPage.Controls.Add(crudTK);
            crudTK.Show();
            crudTK.Dock = DockStyle.Fill;
            crudTK.Name = "Account_Manager";

            RadPageViewPage listQAPage = new RadPageViewPage("Phản hồi của thí sinh");
            ListQA listQA = new ListQA();
            listQA.TopLevel = false;
            listQAPage.Controls.Add(listQA);
            listQA.Show();
            listQA.Dock = DockStyle.Fill;

            pvDashboard.Pages.Add(homePage);
            pvDashboard.Pages.Add(schedulePage);
            pvDashboard.Pages.Add(studentPage);
            pvDashboard.Pages.Add(qltkStudentPage);
            pvDashboard.Pages.Add(examGroup);
            pvDashboard.Pages.Add(examPage);
            pvDashboard.Pages.Add(subjectPage);
            pvDashboard.Pages.Add(roomPage);
            pvDashboard.Pages.Add(classRoom);
            pvDashboard.Pages.Add(staffPage);
            pvDashboard.Pages.Add(resultPage);
            pvDashboard.Pages.Add(reportPage);
            pvDashboard.Pages.Add(questionPage);
            pvDashboard.Pages.Add(createAccountParticipantPage);
            pvDashboard.Pages.Add(listQAPage);

            pvDashboard.AutoScroll = true;
            CollapseAllSubPages(pvDashboard);


        }

        private void CollapseAllSubPages(RadPageView pageView)
        {
            foreach (RadPageViewPage item in pageView.Pages)
            {
                if (item is RadPageViewPage)
                {
                    RadPageViewPage page = (RadPageViewPage)item;

                    foreach (Control control in page.Controls)
                    {
                        if (control is RadPageViewPage)
                        {
                            control.Visible = false;
                        }
                    }
                }
            }
        }

        private void AddQuestionPage_Click(object? sender, EventArgs e)
        {
            //Exam_Overview examOverviewForm = Application.OpenForms.OfType<Exam_Overview>().FirstOrDefault();
            //examOverviewForm?.UpdateDataEvent?.Invoke();

        }

        private void pvDashboard_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                RadPageViewPage radPageViewPage = pvDashboard.SelectedPage;
                RadForm form = radPageViewPage.Controls[0] as RadForm;

                switch (form.Name)
                {
                    case "studentsListForm":
                        (form as StudentsList).LoadData();
                        break;
                    case "examOverviewForm":
                        (form as Exam_Overview).LoadData();
                        break;
                    case "questionOverviewForm":
                        (form as QuestionOverview).LoadData();
                        break;
                    case "subjectForm":
                        (form as Subject).LoadData();
                        break;
                    case "classRoomsForm":
                        (form as ClassRooms).LoadData();
                        break;
                    case "roomForm":
                        (form as Room).LoadData();
                        break;
                    case "overViewNhanVienForm":
                        (form as OverViewNhanVien).LoadData();
                        break;
                    case "addNhanViensForm":
                        (form as AddNhanVien).LoadData();
                        break;
                    case "addThiSinhForm":
                        (form as AddStudents).LoadData();
                        break;
                    case "studentResult":
                        (form as StudentResult).LoadData();
                        (form as StudentResult).loadDataExam(null);
                        break;
                    case "subjectResult":
                        (form as SubjectResult).loadData();
                        (form as SubjectResult).loadExamSubject(null);
                        break;
                    case "examResult":
                        (form as ExamResult).loadData();
                        (form as ExamResult).loadExamDetail(-1);
                        break;
                    case "scheduleManagementForm":
                        (form as ScheduleManagement).LoadData();
                        break;
                    case "report_Overview":
                        (form as Report_Overview).LoadData();
                        break;
                    case "thoiGianForm":
                        (form as ThoiGian).LoadData();
                        break;
                    case "Account_Manager":
                        (form as CrudTK).LoadData_Staff();
                        break;
                    default:
                        break;
                }

            }
            catch
            {

            }
        }
    }
}
