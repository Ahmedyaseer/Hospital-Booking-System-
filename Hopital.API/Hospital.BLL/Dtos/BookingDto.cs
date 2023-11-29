using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL
{
    public class BookingDto
    {
        public string DateOfBook { get; set; }

        public string TimeOfBook { get; set; }
        public string PatSubmitDate { get; set; }
        public string PatSubmitTime { get; set; }
        public string? PatName { get; set; }
        public string? Email { get; set; }
        public bool? status { get; set; }
        public int number { get; set; }
        public string patId { get; set; }
        public string DoctorId { get; set; }
    }
}
