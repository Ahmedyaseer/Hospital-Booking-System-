using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL
{
    public class BookingRepo : GenericRepos<Booking>, IBookingRepo
    {
        private readonly HopitalContext db;

        public BookingRepo(HopitalContext db) : base(db)
        {
            this.db = db;
        }

        public void updataBookingStatus(Guid id)
        {
           var book = db.Bookings.Find(id);
            if (book != null)
            {
                book.status = false;
                db.Update(book);
                db.SaveChanges();

            }
        }
    }
}
