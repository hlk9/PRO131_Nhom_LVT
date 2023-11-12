using Examination_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Context
{
    public class ExaminationDbContext : DbContext
    {
        public ExaminationDbContext()
        {

        }
        ExaminationDbContext(DbContextOptions<ExaminationDbContext> options) : base(options)
        {

        }
        public DbSet<Models.Account> Accounts { get; set; }
        public DbSet<Models.Classroom> Classrooms { get; set; }
        public DbSet<Models.Participant> Participants { get; set; }
        public DbSet<Models.Permission> Permissions { get; set; }
        public DbSet<Models.UserPermission> UserPermissions { get; set; }
        public DbSet<Models.Staff> Staffs { get; set; }
        public DbSet<Models.Subject> Subjects { get; set; }
        public DbSet<Models.Exam> Exams { get; set; }
        public DbSet<Models.ExamDetail> ExamDetails { get; set; }
        public DbSet<Models.ExamResponse> ExamResponses { get; set; }
        public DbSet<Models.AnswerResponse> AnswerResponses { get; set; }
        public DbSet<Models.Question> Questions { get; set; }
        public DbSet<Models.Answer> Answers { get; set; }
        public DbSet<Models.QuestionType> QuestionTypes { get; set; }
        public DbSet<Models.QuestionLevel> QuestionLevels { get; set; }
        public DbSet<Models.ExamRoom> ExamRooms { get; set; }
        public DbSet<Models.ExamSchedule> ExamSchedules { get; set; }
        public DbSet<Models.ExamScheduleDetail> ExamScheduleDetails { get; set; }
        public DbSet<Models.ExamQuestion> ExamQuestions { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QuanLyThiTracNghiem;Integrated Security=True");


            optionsBuilder.UseSqlServer(@"server=db-test-for-pro-131.australiaeast.cloudapp.azure.com,1433;database=QuanLyThiTracNghiem;uid=VM;password=123456789Aa@");


            // "server=db-test-for-pro-131.australiaeast.cloudapp.azure.com,1433;database=QuanLyThiTracNghiem;uid=VM;password=123456789Aa@"
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Exam>()
                .HasIndex(e => e.ExamCode)
                .IsUnique();

            modelBuilder.Entity<ExamDetail>()
               .HasIndex(e => e.ExamDetailCode)
               .IsUnique();

            modelBuilder.Entity<Question>()
                 .HasMany(q => q.AnswerResponses)
                 .WithOne(ar => ar.Question)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Question>()
                 .HasMany(q => q.Answers)
                 .WithOne(a => a.Question)
                 .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Subject>()
              .HasMany(q => q.ExamResponses)
              .WithOne(a => a.Subject)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ExamQuestion>()
               .HasOne(eq => eq.Question)
               .WithOne()
               .HasForeignKey<ExamQuestion>(eq => eq.QuestionId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Account>()
         .HasOne(a => a.UserPermission)
         .WithOne(up => up.Account)
         .HasForeignKey<UserPermission>(up => up.AccountId)
         .OnDelete(DeleteBehavior.Restrict);


            #region seed data


            modelBuilder.Entity<Account>().HasData(

                new Account
                {
                    Id = "longhd",
                    UserName = "longhd",
                    Password = "123456",
                    LastLogin = null,
                    Status = 1,
                    UserPermissionId = 4
                },
                 new Account
                 {
                     Id = "chiupp",
                     UserName = "chiupp",
                     Password = "123456",
                     LastLogin = null,
                     Status = 1,
                     UserPermissionId = 4
                 },
                 new Account
                 {
                     Id = "admin",
                     UserName = "admin",
                     Password = "123456",
                     LastLogin = null,
                     Status = 1,
                     UserPermissionId = 1
                 }

                );

            //seed data for Participant table
            modelBuilder.Entity<Participant>().HasData(

                new Participant
                {
                    Id = "longhd",
                    FullName = "Hoàng Duy Long",
                    Email = "hoanglong.cmb@gmail.com",
                    PhoneNumber = "0987654321",
                    Address = "Hà Nội",
                    Gender = true,
                    DateOfBirth = new DateTime(2004, 11, 23),
                    Status = 1,
                    ClassroomId = "IT10302",
                    AccountId = "longhd",
                },
                new Participant
                {
                    Id = "chiupp",
                    FullName = "Chiu Pằng Pằng",
                    Email = "chiupangpang.cmb@gmail.com",
                    PhoneNumber = "0987654321",
                    Address = "Thập vạn Đại sơn",
                    Gender = true,
                    DateOfBirth = new DateTime(1990, 01, 13),
                    Status = 1,
                    ClassroomId = "IT10302",
                    AccountId = "chiupp",
                }
                );


            //seed data for Staff table
            modelBuilder.Entity<Staff>()
                .HasData(
                new Staff
                {
                    Id = "admin",
                    FullName = "Admin",
                    Email = "admin@gmail.com",
                    Gender = null,
                    DateOfBirth = new DateTime(2000, 01, 01),
                    PhoneNumber = "0987654321",
                    Address = "Hà Nội",
                    Status = 1,
                    AccountId = "admin",
                });

            //seed data for Classroom table

            modelBuilder.Entity<Classroom>()
                .HasData(

                new Classroom
                {
                    Id = "IT10302",
                    Name = "Lớp IT10302"
                },
                new Classroom
                {
                    Id = "IT10303",
                    Name = "Lớp IT10303"
                },
                new Classroom
                {
                    Id = "IT10304",
                    Name = "Lớp IT10304"
                },
                new Classroom
                {
                    Id = "IT10305",
                    Name = "Lớp IT10305"
                },
                new Classroom
                {
                    Id = "IT10306",
                    Name = "Lớp IT10306"
                }
                );

            //seed data for Permission table
            modelBuilder.Entity<Permission>()
            .HasData(

                new Permission
                {
                    Id = 1,
                    Name = "Quản trị viên"
                },
                new Permission
                {
                    Id = 2,
                    Name = "Giáo viên"
                },
                new Permission
                {
                    Id = 3,
                    Name = "Cán bộ"
                },
                new Permission
                {
                    Id = 4,
                    Name = "Thí sinh"
                }
            );

            //seed data for UserPermission table
            modelBuilder.Entity<UserPermission>()
                .HasData(
                new UserPermission
                {
                    Id = 1,
                    AccountId = "longhd",
                    PermissionId = 4
                },
                new UserPermission
                {
                    Id = 2,
                    AccountId = "chiupp",
                    PermissionId = 4
                },
                new UserPermission
                {
                    Id = 3,
                    AccountId = "admin",
                    PermissionId = 1
                }
                );

            //seed data for Subject table
            modelBuilder.Entity<Subject>()
            .HasData(
            new Subject
            {
                Id = "COM1071",
                Name = "Tin học"
            },
            new Subject
            {
                Id = "PRO131",
                Name = "Dự án 1"
            },
            new Subject
            {
                Id = "MATH-01",
                Name = "Toán sơ cấp"
            },
            new Subject
            {
                Id = "MATH-02",
                Name = "Toán nâng cao"
            },
            new Subject
            {
                Id = "ENG-01",
                Name = "Tiếng Anh sơ cấp"
            }
            );

            //seed data for Exam table
            modelBuilder.Entity<Exam>()
                .HasData(
                new Exam
                {
                    Id = 1,
                    ExamCode = "2023_Math_01",
                    Name = "Đề thi môn Toán sơ cấp",
                    SubjectId = "MATH-01",
                },
                new Exam
                {
                    Id = 2,
                    ExamCode = "2023_Math_02",
                    Name = "Đề thi môn Toán nâng cao",
                    SubjectId = "MATH-02",
                },
                new Exam
                {
                    Id = 3,
                    ExamCode = "2023_Eng_01",
                    Name = "Đề thi môn Tiếng Anh sơ cấp",
                    SubjectId = "ENG-01",
                },
                new Exam
                {
                    Id = 4,
                    ExamCode = "2023_Com1071",
                    Name = "Đề thi môn Tin học",
                    SubjectId = "COM1071",
                },
                new Exam
                {
                    Id = 5,
                    ExamCode = "2023_Pro131",
                    Name = "Đề thi môn Dự án 1",
                    SubjectId = "PRO131",
                },
                //seed more data, ExamCode is unique
                new Exam
                {
                    Id = 6,
                    ExamCode = "2024_Math_01",
                    Name = "Đề thi môn Toán sơ cấp",
                    SubjectId = "MATH-01",
                },
                new Exam
                {
                    Id = 7,
                    ExamCode = "2024_Math_02",
                    Name = "Đề thi môn Toán nâng cao",
                    SubjectId = "MATH-02",
                },
                new Exam
                {
                    Id = 8,
                    ExamCode = "2024_Eng_01",
                    Name = "Đề thi Cuối kỳ môn Tiếng Anh sơ cấp",
                    SubjectId = "ENG-01",
                },
                new Exam
                {
                    Id = 9,
                    ExamCode = "2024_Com1071",
                    Name = "Đề thi môn Tin học",
                    SubjectId = "COM1071",
                },
                new Exam
                {
                    Id = 10,
                    ExamCode = "2024_Pro131",
                    Name = "Đề thi môn Dự án 1",
                    SubjectId = "PRO131",
                },
                new Exam
                {
                    Id = 11,
                    ExamCode = "2025_Math_01",
                    Name = "Đề thi môn Toán sơ cấp",
                    SubjectId = "MATH-01",
                },
                new Exam
                {
                    Id = 12,
                    ExamCode = "2025_Math_02",
                    Name = "Đề thi môn Toán nâng cao",
                    SubjectId = "MATH-02",
                },
                 //seed more data, ExamCode is unique
                 new Exam
                 {
                     Id = 13,
                     ExamCode = "2026_Math_01",
                     Name = "Đề thi môn Toán sơ cấp",
                     SubjectId = "MATH-01",
                 },
                 new Exam
                 {
                     Id = 14,
                     ExamCode = "2026_Math_02",
                     Name = "Đề thi môn Toán nâng cao",
                     SubjectId = "MATH-02",
                 },
                 new Exam
                 {
                     Id = 15,
                     ExamCode = "2026_Eng_01",
                     Name = "Đề thi môn Tiếng Anh sơ cấp",
                     SubjectId = "ENG-01",
                 },
                 new Exam
                 {
                     Id = 16,
                     ExamCode = "2026_Com1071",
                     Name = "Đề thi môn Tin học",
                     SubjectId = "COM1071",
                 },
                 new Exam
                 {
                     Id = 17,
                     ExamCode = "2026_Pro131",
                     Name = "Đề thi môn Dự án 1",
                     SubjectId = "PRO131",
                 },
                 new Exam
                 {
                     Id = 18,
                     ExamCode = "2027_Math_01",
                     Name = "Đề thi môn Toán sơ cấp",
                     SubjectId = "MATH-01",
                 },
                 new Exam
                 {
                     Id = 19,
                     ExamCode = "2027_Math_02",
                     Name = "Đề thi môn Toán nâng cao",
                     SubjectId = "MATH-02",
                 },
                 new Exam
                 {
                     Id = 20,
                     ExamCode = "2027_Eng_01",
                     Name = "Đề thi môn Tiếng Anh sơ cấp",
                     SubjectId = "ENG-01",
                 },
                 new Exam
                 {
                     Id = 21,
                     ExamCode = "2027_Com1071",
                     Name = "Đề thi môn Tin học",
                     SubjectId = "COM1071",
                 },
                 new Exam
                 {
                     Id = 22,
                     ExamCode = "2027_Pro131",
                     Name = "Đề thi môn Dự án 1",
                     SubjectId = "PRO131",
                 },
                 new Exam
                 {
                     Id = 23,
                     ExamCode = "2028_Math_01",
                     Name = "Đề thi môn Toán sơ cấp",
                     SubjectId = "MATH-01",
                 },
                 new Exam
                 {
                     Id = 24,
                     ExamCode = "2028_Math_02",
                     Name = "Đề thi môn Toán nâng cao",
                     SubjectId = "MATH-02",
                 },
                 new Exam
                 {
                     Id = 25,
                     ExamCode = "2028_Eng_01",
                     Name = "Đề thi môn Tiếng Anh sơ cấp",
                     SubjectId = "ENG-01",
                 },
                 new Exam
                 {
                     Id = 26,
                     ExamCode = "2028_Com1071",
                     Name = "Đề thi môn Tin học",
                     SubjectId = "COM1071",
                 }

                );
            modelBuilder.Entity<ExamRoom>()
             .HasData(
             new ExamRoom
             {
                 Id = "P101",
                 Name = "Phòng 101",
                 Status = true,
                 Address = "Tầng 1, Nhà P",
                 Note = "Phòng thi có điều hòa",
                 Capacity = 50,
             },
             new ExamRoom
             {
                 Id = "P102",
                 Name = "Phòng 102",
                 Status = true,
                 Address = "Tầng 1, Nhà P",
                 Note = "Phòng thi có điều hòa",
                 Capacity = 50,
             },
             new ExamRoom
             {
                 Id = "P103",
                 Name = "Phòng 103",
                 Status = true,
                 Address = "Tầng 1, Nhà P",
                 Note = "Phòng thi có điều hòa",
                 Capacity = 50,
             },
             new ExamRoom
             {
                 Id = "P104",
                 Name = "Phòng 104",
                 Status = true,
                 Address = "Tầng 1, Nhà P",
                 Note = "Phòng thi có điều hòa",
                 Capacity = 50,
             }
             );

            //seed data for ExamSchedule table
            modelBuilder.Entity<ExamSchedule>()
                .HasData(
                new ExamSchedule
                {
                    Id = 1,
                    Name = "Kỳ thi cuối kỳ",
                    ExamId = 1,
                    StartTime = new DateTime(2021, 01, 01),
                    EndTime = new DateTime(2021, 01, 02),
                    ExamRoomId = "P104",
                    Subject = "Toán sơ cấp",
                    Description = "Kỳ thi cuối kỳ môn Toán sơ cấp",
                    CreatedBy = "admin",
                });

            //seed data for ExamRoom table

            //seed data for ExamScheduleDetail table
            modelBuilder.Entity<ExamScheduleDetail>()
                .HasData(
                new ExamScheduleDetail
                {
                    Id = 1,
                    ExamScheduleId = 1,
                    ParticipantId = "longhd"
                },
                new ExamScheduleDetail
                {
                    Id = 2,
                    ExamScheduleId = 1,
                    ParticipantId = "chiupp"
                }
                );

            //seed data for examdetail table
            modelBuilder.Entity<ExamDetail>()
                .HasData(
                new ExamDetail
                {
                    Id = 1,
                    ExamId = 1,
                    ExamDetailCode = "001",
                    Description = "Ma de 01",
                    Duration = 90,
                    TotalQuestion = 10,
                    PassMark = 5,
                    MaxiumMark = 10,
                    ReTestNumber = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedBy = null,
                    UpdatedAt = null,

                }
                );

            //seed data for question level table


            modelBuilder.Entity<QuestionLevel>()
            .HasData(
            new QuestionLevel
            {
                Id = 1,
                Name = "Dễ"
            },
            new QuestionLevel
            {
                Id = 2,
                Name = "Trung bình"
            },
            new QuestionLevel
            {
                Id = 3,
                Name = "Khó"
            }
            );

            //seed data for question type table
            modelBuilder.Entity<QuestionType>()
                .HasData(
                new QuestionType
                {
                    Id = 1,
                    Name = "Chọn câu trả lời đúng nhất"
                },
                new QuestionType
                {
                    Id = 2,
                    Name = "Chọn CÁC đáp án đúng"
                },
                new QuestionType
                {
                    Id = 3,
                    Name = "Chọn Đúng hoặc Sai"
                }
                );

            //seed data for Question table

            modelBuilder.Entity<Question>()
                .HasData(
                new Question
                {
                    Id = 1,
                    QuestionTypeId = 1,
                    QuestionLevelId = 1,
                    SubjectId = "MATH-01",
                    Content = "2 + 2 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 2,
                    QuestionTypeId = 1,
                    QuestionLevelId = 1,
                    SubjectId = "MATH-01",
                    Content = "2 + 3 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 3,
                    QuestionTypeId = 1,
                    QuestionLevelId = 1,
                    SubjectId = "MATH-01",
                    Content = "2 + 4 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 4,
                    QuestionTypeId = 1,
                    QuestionLevelId = 1,
                    SubjectId = "MATH-01",
                    Content = "2 + 5 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 5,
                    QuestionTypeId = 2,
                    QuestionLevelId = 3,
                    SubjectId = "MATH-01",
                    Content = "2 + 6 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 6,
                    QuestionTypeId = 3,
                    QuestionLevelId = 1,
                    SubjectId = "MATH-01",
                    Content = "2 + 7 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 7,
                    QuestionTypeId = 2,
                    QuestionLevelId = 2,
                    SubjectId = "MATH-01",
                    Content = "2 + 8 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 8,
                    QuestionTypeId = 3,
                    QuestionLevelId = 3,
                    SubjectId = "MATH-01",
                    Content = "2 + 9 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null
                },
                new Question
                {
                    Id = 9,
                    QuestionTypeId = 3,
                    QuestionLevelId = 2,
                    SubjectId = "MATH-01",
                    Content = "2 + 10 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedTime = null,
                    Docs = null

                },
                new Question
                {
                    Id = 10,
                    QuestionTypeId = 2,
                    QuestionLevelId = 3,
                    SubjectId = "MATH-01",
                    Content = "10 + 10 = ?",
                    Point = 1,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedTime = DateTime.Now,
                    ModifiedBy = "admin",
                    ModifiedTime = DateTime.Now,
                    Docs = null
                }

                );


            //seed data for answer table
            modelBuilder.Entity<Answer>()
                .HasData(
                new Answer
                {
                    Id = 1,
                    QuestionId = 1,
                    Content = "4",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 2,
                    QuestionId = 1,
                    Content = "5",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 3,
                    QuestionId = 1,
                    Content = "6",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 4,
                    QuestionId = 1,
                    Content = "7",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 5,
                    QuestionId = 2,
                    Content = "5",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 6,
                    QuestionId = 2,
                    Content = "6",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 7,
                    QuestionId = 2,
                    Content = "7",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 8,
                    QuestionId = 2,
                    Content = "8",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                new Answer
                {
                    Id = 9,
                    QuestionId = 3,
                    Content = "6",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 10,
                    QuestionId = 3,
                    Content = "7",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 11,
                    QuestionId = 3,
                    Content = "8",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 12,
                    QuestionId = 3,
                    Content = "9",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 13,
                    QuestionId = 4,
                    Content = "7",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 14,
                    QuestionId = 4,
                    Content = "8",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 15,
                    QuestionId = 4,
                    Content = "9",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 16,
                    QuestionId = 4,
                    Content = "10",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },

                //seed more data
                new Answer
                {
                    Id = 17,
                    QuestionId = 5,
                    Content = "10",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                new Answer
                {
                    Id = 18,
                    QuestionId = 5,
                    Content = "11",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                new Answer
                {
                    Id = 19,
                    QuestionId = 5,
                    Content = "12",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                new Answer
                {
                    Id = 20,
                    QuestionId = 5,
                    Content = "13",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                //seed more 20 data, each question has 4 answers
                new Answer
                {
                    Id = 21,
                    QuestionId = 6,
                    Content = "13",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 22,
                    QuestionId = 6,
                    Content = "14",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 23,
                    QuestionId = 6,
                    Content = "15",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"
                },
                new Answer
                {
                    Id = 24,
                    QuestionId = 6,
                    Content = "16",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 25,
                    QuestionId = 7,
                    Content = "17",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 26,
                    QuestionId = 7,
                    Content = "18",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                new Answer
                {
                    Id = 27,
                    QuestionId = 7,
                    Content = "19",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                new Answer
                {
                    Id = 28,
                    QuestionId = 7,
                    Content = "20",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                //seed more 20 data, each question has 4 answers
                new Answer
                {
                    Id = 29,
                    QuestionId = 8,
                    Content = "21",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 30,
                    QuestionId = 8,
                    Content = "22",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 31,
                    QuestionId = 8,
                    Content = "23",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 32,
                    QuestionId = 8,
                    Content = "24",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 33,
                    QuestionId = 9,
                    Content = "25",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 34,
                    QuestionId = 9,
                    Content = "26",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 35,
                    QuestionId = 9,
                    Content = "27",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                new Answer
                {
                    Id = 36,
                    QuestionId = 9,
                    Content = "28",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    UpdatedBy = null

                },
                //seed more 20 data, each question has 4 answers
                new Answer
                {
                    Id = 37,
                    QuestionId = 10,
                    Content = "29",
                    IsCorrect = true,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 38,
                    QuestionId = 10,
                    Content = "30",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 39,
                    QuestionId = 10,
                    Content = "31",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                },
                new Answer
                {
                    Id = 40,
                    QuestionId = 10,
                    Content = "32",
                    IsCorrect = false,
                    Status = true,
                    CreatedBy = "admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "admin"

                }
                );

            modelBuilder.Entity<ExamQuestion>()
                .HasData(
                new ExamQuestion
                {
                    Id = 1,
                    ExamDetailId = 1,
                    QuestionId = 1,
                },
                new ExamQuestion
                {
                    Id = 2,
                    ExamDetailId = 1,
                    QuestionId = 2,
                },
                new ExamQuestion
                {
                    Id = 3,
                    ExamDetailId = 1,
                    QuestionId = 3,
                },
                new ExamQuestion
                {
                    Id = 4,
                    ExamDetailId = 1,
                    QuestionId = 4,
                },
                new ExamQuestion
                {
                    Id = 5,
                    ExamDetailId = 1,
                    QuestionId = 5,
                },
                new ExamQuestion
                {
                    Id = 6,
                    ExamDetailId = 1,
                    QuestionId = 6,
                },
                new ExamQuestion
                {
                    Id = 7,
                    ExamDetailId = 1,
                    QuestionId = 7,
                },
                new ExamQuestion
                {
                    Id = 8,
                    ExamDetailId = 1,
                    QuestionId = 8,
                },
                new ExamQuestion
                {
                    Id = 9,
                    ExamDetailId = 1,
                    QuestionId = 9,
                },
                new ExamQuestion
                {
                    Id = 10,
                    ExamDetailId = 1,
                    QuestionId = 10,
                }
                );

            //seed AnswerResponse for Chiu Pang Pang
            modelBuilder.Entity<ExamResponse>()
                .HasData(
                new ExamResponse
                {
                    Id = 1,
                    ExamDetailId = 1,
                    ParticipantId = "chiupp",
                    SubjectId = "MATH-01",
                    SubmitTime = DateTime.Now,
                    Score = null,
                    Status = null,
                    IsPassed = false,
                    ScoredBy = null,
                    QuestionCorrect = null,
                    QuestionWrong = null,
                    QuestionNotAnswered = null,
                    FinishTime = 30,
                    ScoredMethod = null,
                    Note = null,
                }
                );


            modelBuilder.Entity<AnswerResponse>()
                .HasData(
                new AnswerResponse
                {
                    Id = 1,
                    ExamResponseId = 1,
                    QuestionId = 1,
                    AnswerId = 1,
                    IsCorrect = true,
                    AnswerAt = DateTime.Now,

                },
                //seed more 9 records and total is correct 5, wrong 5
                new AnswerResponse
                {
                    Id = 2,
                    ExamResponseId = 1,
                    QuestionId = 2,
                    AnswerId = 5,
                    IsCorrect = true,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 3,
                    ExamResponseId = 1,
                    QuestionId = 3,
                    AnswerId = 9,
                    IsCorrect = true,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 4,
                    ExamResponseId = 1,
                    QuestionId = 4,
                    AnswerId = 13,
                    IsCorrect = true,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 5,
                    ExamResponseId = 1,
                    QuestionId = 5,
                    AnswerId = 17,
                    IsCorrect = true,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 6,
                    ExamResponseId = 1,
                    QuestionId = 6,
                    AnswerId = 21,
                    IsCorrect = false,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 7,
                    ExamResponseId = 1,
                    QuestionId = 7,
                    AnswerId = 25,
                    IsCorrect = false,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 8,
                    ExamResponseId = 1,
                    QuestionId = 8,
                    AnswerId = 29,
                    IsCorrect = false,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 9,
                    ExamResponseId = 1,
                    QuestionId = 9,
                    AnswerId = 33,
                    IsCorrect = false,
                    AnswerAt = DateTime.Now,

                },
                new AnswerResponse
                {
                    Id = 10,
                    ExamResponseId = 1,
                    QuestionId = 10,
                    AnswerId = 37,
                    IsCorrect = false,
                    AnswerAt = DateTime.Now,

                }

                );


            #endregion 
        }


    }
}
