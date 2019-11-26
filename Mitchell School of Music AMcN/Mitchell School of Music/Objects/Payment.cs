using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.Objects
{
    class Payment
    {
        private int paymentID;
        private int studentID;
        private int rentalID;
        private int repairID;
        private double amount;
        private DateTime paymentDate;
        private string paymentDetails;
        
        

        public Payment()
        {

        }

        public Payment(int paymentID, int studentID, int rentalID, int repairID, double amount, DateTime paymentDate, string paymentDetails)
        {
            this.paymentID = paymentID;
            this.studentID = studentID;
            this.rentalID = rentalID;
            this.repairID = repairID;
            this.amount = amount;
            this.paymentDate = paymentDate;
            this.paymentDetails = paymentDetails;
            
        }

        public int PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
        }
        public int RepairID
        {
            get { return repairID; }
            set { repairID = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        public string PaymentDetails
        {
            get { return paymentDetails; }
            set { paymentDetails = value; }
        }
    }
    
}
