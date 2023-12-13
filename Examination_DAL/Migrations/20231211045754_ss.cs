using System;
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
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
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
                        onDelete: ReferentialAction.Cascade);
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
                    ExamScheduleId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_ExamResponses_ExamSchedules_ExamScheduleId",
                        column: x => x.ExamScheduleId,
                        principalTable: "ExamSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_ExamResponses_ExamScheduleId",
                table: "ExamResponses",
                column: "ExamScheduleId");

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
                column: "AccountId");

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
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "ExamDetails");

            migrationBuilder.DropTable(
                name: "ExamSchedules");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "QuestionLevels");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropTable(
                name: "ExamRooms");

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
