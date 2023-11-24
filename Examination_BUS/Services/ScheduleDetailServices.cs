using Examination_BUS.ViewModel;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ScheduleDetailServices
    {
        ScheduleDetailRepository _scheduleDetailRepository;
        ExamRepository _examRepository;
        ScheduleRepository _examScheduleRepository;
        ExamRoomResposiroty _examRoomResposiroty;
        ParticipantResposiroty _participantRepository;
        ExamDetailRepository _examDetailRepository;

        public ScheduleDetailServices()
        {
            _scheduleDetailRepository = new ScheduleDetailRepository();
            _examRepository = new ExamRepository();
            _examScheduleRepository = new ScheduleRepository();
            _examRoomResposiroty = new ExamRoomResposiroty();
            _participantRepository = new ParticipantResposiroty();
            _examDetailRepository = new ExamDetailRepository();

        }

        public List<ExamScheduleDetail> GetAllScheduleDetails()
        {
            return _scheduleDetailRepository.GetAllScheduleDetails();
        }

        public ExamScheduleDetail GetScheduleDetailById(int id)
        {
            return _scheduleDetailRepository.GetScheduleDetailById(id);
        }

        public bool AddScheduleDetail(ExamScheduleDetail scheduleDetail)
        {
            return _scheduleDetailRepository.AddScheduleDetail(scheduleDetail);
        }

        public bool UpdateScheduleDetail(ExamScheduleDetail scheduleDetail)
        {
            return _scheduleDetailRepository.UpdateScheduleDetail(scheduleDetail);
        }

        public bool DeleteScheduleDetail(int id)
        {
            return _scheduleDetailRepository.DeleteScheduleDetail(id);
        }

        public List<ExamScheduleDetail> GetScheduleDetailByOneScheduleId(int id)
        {
            return _scheduleDetailRepository.GetScheduleDetailByScheduleId(id);
        }

        public List<ExamScheduleDetail> GetScheduleDetailByParticipantId(string id)
        {
            return _scheduleDetailRepository.GetScheduleDetailByParticipantId(id);
        }

        public List<ScheduleWithExamInforViewModel> GetScheduleAndExamByParticipantID(string id)
        {
            var data = (from scheduleDetail in _scheduleDetailRepository.GetScheduleDetailByParticipantId(id)
                       join schedule in _examScheduleRepository.GetListSchedule()
                       on scheduleDetail.ExamScheduleId equals schedule.Id
                       join exam in _examRepository.GetAll()
                       on schedule.ExamId equals exam.Id
                       join examDetail in _examDetailRepository.GetAll()
                       on exam.Id equals examDetail.ExamId
                       join room in _examRoomResposiroty.getAllRooms()
                       on schedule.ExamRoomId equals room.Id
                       select new ScheduleWithExamInforViewModel
                       {
                           ScheduleDetailId = scheduleDetail.Id,
                           ExamDuration = examDetail.Duration,
                           ExamName = exam.Name,
                           ExamRoomId = room.Id,                           
                           ExamScheduleId = schedule.Id,
                           ExamDes = examDetail.Description,
                           ExamStartTime = schedule.StartTime,
                           ExamEndTime = schedule.EndTime,             
                           ParticipantId = scheduleDetail.ParticipantId,
                           ExamRepeat = examDetail.ReTestNumber,
                           ExamDetailCode = examDetail.ExamDetailCode,
                       }).ToList();
            return data;
        }

    }
}
