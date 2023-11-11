using Examination_DAL.Models;
using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuanLyThiTracNghiem;Integrated Security=True");
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


            //modelBuilder.Entity<Account>().HasData(

            //    new Account
            //    {
            //        Id = "longhd",
            //        UserName= "longhd",
            //        Password = "123456",
            //        LastLogin = null,                    
            //        Status = 1,


            //    }
            //    );

            ////seed data for Participant table
            //modelBuilder.Entity<Participant>().HasData(

            //    new Participant
            //    {
            //        Id = "longhd",
            //        FullName = "Hoàng Duy Long",
            //        Email = "hoanglong.cmb@gmail.com",
            //        PhoneNumber = "0987654321",
            //        Address = "Hà Nội",
            //        Gender = true,
            //        DateOfBirth = new DateTime(2004, 01, 23), 
            //        Status = 1,
            //        ClassroomId = null,
            //        AccountId = "longhd",
            //    }
            //    );






        }


    }
}
