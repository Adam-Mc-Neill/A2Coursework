using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.Objects
{
    public class Rental
    {
        private int rentalID;
        private int instrumentID;
        private int studentID;
        private DateTime dateRented;
        private DateTime returnDate;
        private DateTime paymentDate;
        

        public Rental()
        {

        }

        public Rental(int rentalID,
         int instrumentID,
         int studentID,
         DateTime dateRented,
         DateTime returnDate,
         DateTime paymentDate)
       
        {
            this.rentalID = rentalID;
            this.instrumentID = instrumentID;
            this.studentID = studentID;
            this.dateRented = dateRented;
            this.returnDate = returnDate;
            this.paymentDate = paymentDate;
            
        }

        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
        }
        public int InstrumentID
        {
            get { return instrumentID; }
            set { instrumentID = value; }
        }
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public DateTime DateRented
        {
            get { return dateRented; }
            set { dateRented = value; }
        }
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
    }
    
}
