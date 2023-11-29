using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL
{
    public interface IDoctorWorkTime
    {
        List<doctorschedulesDto> GetAvailableTimeSlots(string id);
        void AddBooking(BookingDto booking);
         void updateBookingStatus(Guid id);
    }
}
