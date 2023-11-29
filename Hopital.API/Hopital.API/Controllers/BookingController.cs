
using Hospital.BLL;
using Hospital.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Hopital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController:ControllerBase
    {
        private readonly IDoctorWorkTime db;


        public BookingController(IDoctorWorkTime db )
        {
            this.db = db;
        
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<List<doctorschedulesDto>> GetDoctorAvaliableTime(string id)
        {
            var doctortime = db.GetAvailableTimeSlots(id);

            if (doctortime == null)

            {
                return NotFound();

            }
            return doctortime;



        }
       
        [HttpPost]
        public ActionResult Add(BookingDto booking)
        {

            db.AddBooking(booking);
        
                return Ok();
            
        }
        [HttpGet]
        [Route("finishbook/{id}")]

        public ActionResult updatabookstatus(Guid id)
        {
            db.updateBookingStatus (id);
            return Ok();
        }



    }
}
