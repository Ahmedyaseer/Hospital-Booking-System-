﻿using Hospital.BLL;
using Hospital.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL
{
    public class CalcTimeHelper:ICalcTimeHelper
    {
        public IDoctorRepo Db { get; }

        public CalcTimeHelper(IDoctorRepo db)
        {
            Db = db;
        }

        public string GetDate(DayOfWeek DayOfWeek)
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime desiredDate;
            string formattedDate;
            if ((int)currentDate.DayOfWeek <= (int)DayOfWeek)
            {
                desiredDate = currentDate.AddDays((int)DayOfWeek - (int)currentDate.DayOfWeek);
                formattedDate = desiredDate.ToString("dd/MM");


                return desiredDate.DayOfWeek.ToString() + " " + formattedDate;
            }
            else
            {

                desiredDate = currentDate.AddDays(((int)DayOfWeek + 7) - (int)currentDate.DayOfWeek);
                formattedDate = desiredDate.ToString("dd/MM");
                return desiredDate.DayOfWeek.ToString()+" " + formattedDate;
            }

        }
        static TimeSpan RoundToNearest10Minutes(TimeSpan time)
        {
            int minutes = (int)time.TotalMinutes;
            int roundedMinutes = (int)Math.Round((double)minutes / 10) * 10 ;

            return TimeSpan.FromMinutes(roundedMinutes);
        }

        public List<WorkScheduleTimeDto> calc(DayOfWeek Day, string id)
        {
            var currentDateTimeNow = DateTime.Now;
            var availableTimeSlots = new List<WorkScheduleTimeDto>();
            var doctor = Db.GetByIdWithInclude(d => d.Id.Equals(id), t => t.WorkSchedules);
            var currentTime = doctor.WorkSchedules.FirstOrDefault(ws => ws.DayOfWeek == Day)?.StartTime ?? TimeSpan.Zero;
            var endTime = doctor.WorkSchedules.FirstOrDefault(ws => ws.DayOfWeek == Day)?.EndTime ?? TimeSpan.Zero;
            if (Day == currentDateTimeNow.DayOfWeek)
            {
               currentTime = RoundToNearest10Minutes(currentDateTimeNow.TimeOfDay);
                while (currentTime <= endTime)
                {

                    availableTimeSlots.Add(new WorkScheduleTimeDto
                    {
                        time = currentTime,
                        status = checkStatus(id, currentTime, Day)
                    });
                    currentTime = currentTime.Add(TimeSpan.FromMinutes(doctor.watingList));
                }

            }
            else
            {
                while (currentTime <= endTime)
                {

                    availableTimeSlots.Add(new WorkScheduleTimeDto
                    {
                        time = currentTime,
                        status = checkStatus(id, currentTime, Day)
                    });
                    currentTime = currentTime.Add(TimeSpan.FromMinutes(doctor.watingList));
                }
            }


            
            return availableTimeSlots;
        }

        public bool checkStatus(string id, TimeSpan time, DayOfWeek Day)
        {
            var doc = Db.GetByIdWithInclude(d => d.Id == id, b => b.Bookings);
            var doclist = doc.Bookings.ToList();
            var check = doclist.Where(i => i.DateOfBook.DayOfWeek == Day && i.TimeOfBook == time).FirstOrDefault();


            if (check == null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}


