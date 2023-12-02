﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examination_DAL.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    UserPermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamRooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Address = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    IdParticipant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(1000)", maxLength: 1000, nullable: false),
                    SubmitTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionLevels",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    AccountId = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    ClassroomId = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    AccountId = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Participants_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PermissionId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPermissions_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    QuestionLevelId = table.Column<byte>(type: "tinyint", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    Point = table.Column<double>(type: "float", nullable: true),
                    Docs = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionLevels_QuestionLevelId",
                        column: x => x.QuestionLevelId,
                        principalTable: "QuestionLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamDetailCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    PassMark = table.Column<double>(type: "float", nullable: false),
                    TotalQuestion = table.Column<int>(type: "int", nullable: false),
                    MaxiumMark = table.Column<double>(type: "float", nullable: false),
                    ReTestNumber = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamDetails_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamDetails_Staffs_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    ExamRoomId = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ClassRoomId = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamSchedules_Classrooms_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamSchedules_ExamRooms_ExamRoomId",
                        column: x => x.ExamRoomId,
                        principalTable: "ExamRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamSchedules_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamSchedules_Staffs_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "NVARCHAR(500)", maxLength: 500, nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamDetailId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_ExamDetails_ExamDetailId",
                        column: x => x.ExamDetailId,
                        principalTable: "ExamDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamDetailId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    SubmitTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    IsPassed = table.Column<bool>(type: "bit", nullable: true),
                    QuestionCorrect = table.Column<int>(type: "int", nullable: true),
                    QuestionWrong = table.Column<int>(type: "int", nullable: true),
                    QuestionNotAnswered = table.Column<int>(type: "int", nullable: true),
                    ScoredBy = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    FinishTime = table.Column<double>(type: "float", nullable: true),
                    ScoredMethod = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    StaffId = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamResponses_ExamDetails_ExamDetailId",
                        column: x => x.ExamDetailId,
                        principalTable: "ExamDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamResponses_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamResponses_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamResponses_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamScheduleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScheduleId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamScheduleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamScheduleDetails_ExamSchedules_ExamScheduleId",
                        column: x => x.ExamScheduleId,
                        principalTable: "ExamSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamScheduleDetails_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnswerResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: true),
                    ExamResponseId = table.Column<int>(type: "int", nullable: false),
                    AnswerAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerResponses_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AnswerResponses_ExamResponses_ExamResponseId",
                        column: x => x.ExamResponseId,
                        principalTable: "ExamResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerResponses_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "LastLogin", "Password", "Status", "UserName", "UserPermissionId" },
                values: new object[,]
                {
                    { "admin", null, "123456", (byte)1, "admin", 1 },
                    { "chiupp", null, "123456", (byte)1, "chiupp", 4 },
                    { "longhd", null, "123456", (byte)1, "longhd", 4 }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "IT10302", "Lớp IT10302" },
                    { "IT10303", "Lớp IT10303" },
                    { "IT10304", "Lớp IT10304" },
                    { "IT10305", "Lớp IT10305" },
                    { "IT10306", "Lớp IT10306" }
                });

            migrationBuilder.InsertData(
                table: "ExamRooms",
                columns: new[] { "Id", "Address", "Capacity", "Name", "Note", "Status" },
                values: new object[,]
                {
                    { "P101", "Tầng 1, Nhà P", 50, "Phòng 101", "Phòng thi có điều hòa", true },
                    { "P102", "Tầng 1, Nhà P", 50, "Phòng 102", "Phòng thi có điều hòa", true },
                    { "P103", "Tầng 1, Nhà P", 50, "Phòng 103", "Phòng thi có điều hòa", true },
                    { "P104", "Tầng 1, Nhà P", 50, "Phòng 104", "Phòng thi có điều hòa", true }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Quản trị viên" },
                    { (byte)2, "Giáo viên" },
                    { (byte)3, "Cán bộ" },
                    { (byte)4, "Thí sinh" }
                });

            migrationBuilder.InsertData(
                table: "QuestionLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Dễ" },
                    { (byte)2, "Trung bình" },
                    { (byte)3, "Nâng cao" },
                    { (byte)4, "Vận dụng cao" }
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Chọn câu trả lời đúng nhất" },
                    { (byte)2, "Chọn các đáp án đúng" },
                    { (byte)3, "Chọn Đúng hoặc Sai" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { "COM1071", null, "Tin học", (byte)0 },
                    { "ENG-01", null, "Tiếng Anh sơ cấp", (byte)0 },
                    { "MATH-01", null, "Toán sơ cấp", (byte)0 },
                    { "MATH-02", null, "Toán nâng cao", (byte)0 },
                    { "MATH-03", null, "Toán Sieu cao cấp", (byte)0 },
                    { "PRO131", null, "Dự án 1", (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "ExamCode", "Name", "SubjectId" },
                values: new object[,]
                {
                    { 1, "2023_Math_01", "Đề thi môn Toán sơ cấp", "MATH-01" },
                    { 2, "2023_Math_02", "Đề thi môn Toán nâng cao", "MATH-02" },
                    { 3, "2023_Eng_01", "Đề thi môn Tiếng Anh sơ cấp", "ENG-01" },
                    { 4, "2023_Com1071", "Đề thi môn Tin học", "COM1071" },
                    { 5, "2023_Pro131", "Đề thi môn Dự án 1", "PRO131" },
                    { 6, "2024_Math_01", "Đề thi môn Toán sơ cấp", "MATH-01" },
                    { 7, "2024_Math_02", "Đề thi môn Toán nâng cao", "MATH-02" },
                    { 8, "2024_Eng_01", "Đề thi Cuối kỳ môn Tiếng Anh sơ cấp", "ENG-01" },
                    { 9, "2024_Com1071", "Đề thi môn Tin học", "COM1071" },
                    { 10, "2024_Pro131", "Đề thi môn Dự án 1", "PRO131" },
                    { 11, "2025_Math_01", "Đề thi môn Toán sơ cấp", "MATH-01" },
                    { 12, "2025_Math_02", "Đề thi môn Toán nâng cao", "MATH-02" },
                    { 13, "2026_Math_01", "Đề thi môn Toán sơ cấp", "MATH-01" },
                    { 14, "2026_Math_02", "Đề thi môn Toán nâng cao", "MATH-02" },
                    { 15, "2026_Eng_01", "Đề thi môn Tiếng Anh sơ cấp", "ENG-01" },
                    { 16, "2026_Com1071", "Đề thi môn Tin học", "COM1071" },
                    { 17, "2026_Pro131", "Đề thi môn Dự án 1", "PRO131" },
                    { 18, "2027_Math_01", "Đề thi môn Toán sơ cấp", "MATH-01" },
                    { 19, "2027_Math_02", "Đề thi môn Toán nâng cao", "MATH-02" },
                    { 20, "2027_Eng_01", "Đề thi môn Tiếng Anh sơ cấp", "ENG-01" },
                    { 21, "2027_Com1071", "Đề thi môn Tin học", "COM1071" },
                    { 22, "2027_Pro131", "Đề thi môn Dự án 1", "PRO131" },
                    { 23, "2028_Math_01", "Đề thi môn Toán sơ cấp", "MATH-01" },
                    { 24, "2028_Math_02", "Đề thi môn Toán nâng cao", "MATH-02" },
                    { 25, "2028_Eng_01", "Đề thi môn Tiếng Anh sơ cấp", "ENG-01" },
                    { 26, "2028_Com1071", "Đề thi môn Tin học", "COM1071" },
                    { 27, "2028_Math_03", "Đề thi môn Toán SIEEU nâng cao", "MATH-03" }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "AccountId", "Address", "ClassroomId", "DateOfBirth", "Email", "FullName", "Gender", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { "chiupp", "chiupp", "Thập vạn Đại sơn", "IT10302", new DateTime(1990, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "chiupangpang.cmb@gmail.com", "Chiu Pằng Pằng", true, "0987654321", (byte)1 },
                    { "longhd", "longhd", "Hà Nội", "IT10302", new DateTime(2004, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoanglong.cmb@gmail.com", "Hoàng Duy Long", true, "0987654321", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedTime", "Docs", "ModifiedBy", "ModifiedTime", "Point", "QuestionLevelId", "QuestionTypeId", "Status", "SubjectId" },
                values: new object[,]
                {
                    { 1, "2 + 2 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9106), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-01" },
                    { 2, "2 + 3 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9108), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-01" },
                    { 3, "2 + 4 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9110), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-01" },
                    { 4, "2 + 5 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9112), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-01" },
                    { 5, "2 + 6 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9113), null, null, null, 0.75, (byte)3, (byte)2, true, "MATH-01" },
                    { 6, "2 + 7 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9115), null, null, null, 0.25, (byte)1, (byte)3, true, "MATH-01" },
                    { 7, "2 + 8 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9116), null, null, null, 0.5, (byte)2, (byte)2, true, "MATH-01" },
                    { 8, "2 + 9 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9118), null, null, null, 0.75, (byte)3, (byte)3, true, "MATH-01" },
                    { 9, "2 + 10 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9119), null, null, null, 0.5, (byte)2, (byte)3, true, "MATH-01" },
                    { 10, "10 + 10 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9120), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9121), 0.75, (byte)3, (byte)2, true, "MATH-01" },
                    { 11, "2 + 2 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9124), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9124), 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 12, "2 + 3 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9126), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9126), 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 13, "2 + 4 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9127), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9128), 0.25, (byte)1, (byte)1, true, "MATH-02" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedTime", "Docs", "ModifiedBy", "ModifiedTime", "Point", "QuestionLevelId", "QuestionTypeId", "Status", "SubjectId" },
                values: new object[,]
                {
                    { 14, "2 + 5 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9129), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9129), 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 15, "2 + 6 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9131), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9131), 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 16, "2 + 7 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9132), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9133), 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 17, "2 + 8 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9134), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 18, "2 + 9 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9138), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 19, "2 + 10 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9139), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-02" },
                    { 20, "10 + 10 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9140), null, null, null, 0.25, (byte)1, (byte)2, true, "MATH-02" },
                    { 21, "2 + 2 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9142), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 22, "2 + 3 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9143), null, null, null, 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 23, "2 + 4 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9144), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9145), 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 24, "2 + 5 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9146), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9147), 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 25, "2 + 6 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9153), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9153), 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 26, "2 + 7 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9155), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9155), 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 27, "2 + 8 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9158), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9159), 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 28, "2 + 9 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9160), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9160), 0.25, (byte)1, (byte)1, true, "MATH-03" },
                    { 29, "2 + 10 = ?", "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9161), null, "admin", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9162), 0.25, (byte)1, (byte)1, true, "MATH-03" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "AccountId", "Address", "DateOfBirth", "Email", "FullName", "Gender", "PhoneNumber", "Status" },
                values: new object[] { "admin", "admin", "Hà Nội", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", null, "0987654321", (byte)1 });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "AccountId", "PermissionId" },
                values: new object[,]
                {
                    { 1, "longhd", (byte)4 },
                    { 2, "chiupp", (byte)4 },
                    { 3, "admin", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "IsCorrect", "QuestionId", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "4", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9182), "admin", true, 1, true, null, null },
                    { 2, "5", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9184), "admin", false, 1, true, null, null },
                    { 3, "6", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9185), "admin", false, 1, true, null, null },
                    { 4, "7", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9186), "admin", false, 1, true, null, null },
                    { 5, "5", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9187), "admin", true, 2, true, null, null },
                    { 6, "6", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9188), "admin", false, 2, true, null, null },
                    { 7, "7", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9189), "admin", false, 2, true, null, null },
                    { 8, "8", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9190), "admin", false, 2, true, null, null },
                    { 9, "6", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9191), "admin", true, 3, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9192), "admin" },
                    { 10, "7", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9193), "admin", false, 3, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9193), "admin" },
                    { 11, "8", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9194), "admin", false, 3, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9195), "admin" },
                    { 12, "9", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9196), "admin", false, 3, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9196), "admin" },
                    { 13, "7", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9197), "admin", true, 4, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9198), "admin" },
                    { 14, "8", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9199), "admin", false, 4, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9200), "admin" },
                    { 15, "9", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9201), "admin", false, 4, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9201), "admin" },
                    { 16, "10", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9202), "admin", false, 4, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9203), "admin" },
                    { 17, "8", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9204), "admin", true, 5, true, null, null },
                    { 18, "Tám", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9205), "admin", true, 5, true, null, null },
                    { 19, "12", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9206), "admin", false, 5, true, null, null },
                    { 20, "13", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9207), "admin", false, 5, true, null, null },
                    { 21, "13", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9208), "admin", true, 6, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9209), "admin" },
                    { 22, "14", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9209), "admin", false, 6, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9210), "admin" },
                    { 23, "15", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9211), "admin", false, 6, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9211), "admin" },
                    { 24, "16", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9213), "admin", false, 6, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9214), "admin" },
                    { 25, "10", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9215), "admin", true, 7, true, null, null },
                    { 26, "Mười", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9216), "admin", true, 7, true, null, null },
                    { 27, "19", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9217), "admin", false, 7, true, null, null },
                    { 28, "Ten", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9218), "admin", true, 7, true, null, null },
                    { 29, "21", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9219), "admin", true, 8, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9219), "admin" },
                    { 30, "22", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9220), "admin", false, 8, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9221), "admin" },
                    { 31, "23", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9222), "admin", false, 8, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9223), "admin" },
                    { 32, "24", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9224), "admin", false, 8, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9224), "admin" },
                    { 33, "25", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9225), "admin", true, 9, true, null, null },
                    { 34, "26", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9226), "admin", false, 9, true, null, null },
                    { 35, "27", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9227), "admin", false, 9, true, null, null },
                    { 36, "28", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9228), "admin", false, 9, true, null, null },
                    { 37, "XX", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9229), "admin", true, 10, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9230), "admin" },
                    { 38, "30", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9231), "admin", false, 10, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9231), "admin" },
                    { 39, "31", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9232), "admin", false, 10, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9233), "admin" },
                    { 40, "20", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9234), "admin", true, 10, true, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9234), "admin" }
                });

            migrationBuilder.InsertData(
                table: "ExamDetails",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Duration", "ExamDetailCode", "ExamId", "MaxiumMark", "PassMark", "ReTestNumber", "Status", "TotalQuestion", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9049), "admin", "Ma de 01", 90, "001", 1, 10.0, 5.0, 1, true, 10, null, null },
                    { 2, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9062), "admin", "Ma de 02 - MATH 03", 90, "MATH-03_002", 27, 10.0, 5.0, 1, true, 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "ExamDetails",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Duration", "ExamDetailCode", "ExamId", "MaxiumMark", "PassMark", "ReTestNumber", "Status", "TotalQuestion", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9064), "admin", "Ma de 02", 90, "002", 2, 10.0, 5.0, 1, true, 10, null, null },
                    { 4, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9066), "admin", "Ma de 03", 90, "003", 3, 10.0, 5.0, 1, true, 10, null, null },
                    { 5, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9068), "admin", "Ma de 04", 90, "004", 4, 10.0, 5.0, 1, true, 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "ExamSchedules",
                columns: new[] { "Id", "ClassRoomId", "CreatedBy", "Description", "EndTime", "ExamId", "ExamRoomId", "Name", "StartTime", "Status", "Subject" },
                values: new object[] { 1, null, "admin", "Kỳ thi cuối kỳ môn Toán sơ cấp", new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "P104", "Kỳ thi cuối kỳ", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Toán sơ cấp" });

            migrationBuilder.InsertData(
                table: "ExamQuestions",
                columns: new[] { "Id", "ExamDetailId", "QuestionId", "Score" },
                values: new object[,]
                {
                    { 1, 1, 1, null },
                    { 2, 1, 2, null },
                    { 3, 1, 3, null },
                    { 4, 1, 4, null },
                    { 5, 1, 5, null },
                    { 6, 1, 6, null },
                    { 7, 1, 7, null },
                    { 8, 1, 8, null },
                    { 9, 1, 9, null },
                    { 10, 1, 10, null },
                    { 11, 2, 11, null },
                    { 12, 2, 12, null },
                    { 13, 2, 13, null },
                    { 14, 2, 14, null },
                    { 15, 2, 15, null },
                    { 16, 2, 16, null },
                    { 17, 2, 17, null },
                    { 18, 2, 18, null },
                    { 19, 2, 19, null },
                    { 20, 2, 20, null },
                    { 21, 3, 1, null },
                    { 22, 3, 2, null },
                    { 23, 3, 3, null },
                    { 24, 3, 4, null },
                    { 25, 3, 5, null },
                    { 26, 3, 6, null },
                    { 27, 3, 7, null },
                    { 28, 3, 8, null },
                    { 29, 3, 9, null },
                    { 30, 3, 10, null },
                    { 31, 4, 1, null },
                    { 32, 4, 2, null },
                    { 33, 4, 3, null },
                    { 34, 4, 4, null },
                    { 35, 4, 5, null },
                    { 36, 4, 6, null },
                    { 37, 4, 7, null },
                    { 38, 4, 8, null },
                    { 39, 4, 9, null },
                    { 40, 4, 10, null },
                    { 41, 5, 1, null },
                    { 42, 5, 2, null }
                });

            migrationBuilder.InsertData(
                table: "ExamQuestions",
                columns: new[] { "Id", "ExamDetailId", "QuestionId", "Score" },
                values: new object[,]
                {
                    { 43, 5, 3, null },
                    { 44, 5, 4, null },
                    { 45, 5, 5, null },
                    { 46, 5, 6, null },
                    { 47, 5, 7, null },
                    { 48, 5, 8, null },
                    { 49, 5, 9, null },
                    { 50, 5, 10, null }
                });

            migrationBuilder.InsertData(
                table: "ExamResponses",
                columns: new[] { "Id", "ExamDetailId", "FinishTime", "IsPassed", "Note", "ParticipantId", "QuestionCorrect", "QuestionNotAnswered", "QuestionWrong", "Score", "ScoredBy", "ScoredMethod", "StaffId", "Status", "SubjectId", "SubmitTime" },
                values: new object[] { 1, 1, 30.0, false, null, "chiupp", null, null, null, null, null, null, null, null, "MATH-01", new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.InsertData(
                table: "ExamScheduleDetails",
                columns: new[] { "Id", "ExamScheduleId", "ParticipantId" },
                values: new object[,]
                {
                    { 1, 1, "longhd" },
                    { 2, 1, "chiupp" }
                });

            migrationBuilder.InsertData(
                table: "AnswerResponses",
                columns: new[] { "Id", "AnswerAt", "AnswerId", "ExamResponseId", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9307), 1, 1, true, 1 },
                    { 2, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9309), 5, 1, true, 2 },
                    { 3, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9310), 9, 1, true, 3 },
                    { 4, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9311), 13, 1, true, 4 },
                    { 5, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9312), 17, 1, true, 5 },
                    { 6, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9313), 21, 1, false, 6 },
                    { 7, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9314), 25, 1, false, 7 },
                    { 8, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9315), 29, 1, false, 8 },
                    { 9, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9316), 33, 1, false, 9 },
                    { 10, new DateTime(2023, 12, 1, 22, 39, 52, 59, DateTimeKind.Local).AddTicks(9317), 37, 1, false, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerResponses_AnswerId",
                table: "AnswerResponses",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerResponses_ExamResponseId",
                table: "AnswerResponses",
                column: "ExamResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerResponses_QuestionId",
                table: "AnswerResponses",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamDetails_CreatedBy",
                table: "ExamDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ExamDetails_ExamDetailCode",
                table: "ExamDetails",
                column: "ExamDetailCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExamDetails_ExamId",
                table: "ExamDetails",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_ExamDetailId",
                table: "ExamQuestions",
                column: "ExamDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_QuestionId",
                table: "ExamQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResponses_ExamDetailId",
                table: "ExamResponses",
                column: "ExamDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResponses_ParticipantId",
                table: "ExamResponses",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResponses_StaffId",
                table: "ExamResponses",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResponses_SubjectId",
                table: "ExamResponses",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_ExamCode",
                table: "Exams",
                column: "ExamCode",
                unique: true,
                filter: "[ExamCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduleDetails_ExamScheduleId",
                table: "ExamScheduleDetails",
                column: "ExamScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduleDetails_ParticipantId",
                table: "ExamScheduleDetails",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_ClassRoomId",
                table: "ExamSchedules",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_CreatedBy",
                table: "ExamSchedules",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_ExamId",
                table: "ExamSchedules",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_ExamRoomId",
                table: "ExamSchedules",
                column: "ExamRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_AccountId",
                table: "Participants",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ClassroomId",
                table: "Participants",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionLevelId",
                table: "Questions",
                column: "QuestionLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SubjectId",
                table: "Questions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_AccountId",
                table: "Staffs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermissions_AccountId",
                table: "UserPermissions",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPermissions_PermissionId",
                table: "UserPermissions",
                column: "PermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerResponses");

            migrationBuilder.DropTable(
                name: "ExamQuestions");

            migrationBuilder.DropTable(
                name: "ExamScheduleDetails");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "UserPermissions");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "ExamResponses");

            migrationBuilder.DropTable(
                name: "ExamSchedules");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "ExamDetails");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "ExamRooms");

            migrationBuilder.DropTable(
                name: "QuestionLevels");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
