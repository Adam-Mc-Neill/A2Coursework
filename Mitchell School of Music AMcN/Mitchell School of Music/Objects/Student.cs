using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.Objects
{
    public class Student
    {
         private int studentID;
        private string studentForename;
        private string studentSurname;
        private string studentAddressLine1;
        private string studentAddressLine2;
        private string studentCity;
        private string studentPostCode;
        private string studentPhone;
        private string studentGender;
        private string studentInstrument;
        private string studentRequiresRental;
        

        public Student()
        {

        }

        public Student( int studentID, string studentForename, string studentSurname, string studentAddressLine1, string studentAddressLine2, string studentCity, string studentPostCode, string studentPhone, string studentGender, string studentInstrument, string studentRequiresRental)
        {
            this.studentID = studentID;
            this.studentForename = studentForename;
            this.studentSurname = studentSurname;
            this.studentAddressLine1 = studentAddressLine1;
            this.studentAddressLine2 = studentAddressLine2;
            this.studentCity = StudentCity;
            this.studentPostCode = studentPostCode;
            this.studentPhone = studentPhone;
            this.studentGender = studentGender;
            this.studentInstrument = studentInstrument;
            this.studentRequiresRental = studentRequiresRental;
            
        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string StudentForename
        {
            get { return studentForename; }
            set { studentForename = value; }
        }
        public string StudentSurname
        {
            get { return studentSurname; }
            set { studentSurname = value; }
        }
        public string StudentAddressLine1
        {
            get { return studentAddressLine1; }
            set { studentAddressLine1 = value; }
        }
        public string StudentAddressLine2
        {
            get { return studentAddressLine2; }
            set { studentAddressLine2 = value; }
        }
         public string StudentCity
        {
            get { return studentCity; }
            set { studentCity = value; }
        }
        public string StudentPostCode
        {
            get { return studentPostCode; }
            set { studentPostCode = value; }
        }
        public string StudentPhone
        {
            get { return studentPhone; }
            set { studentPhone = value; }
        }
         public string StudentGender
        {
            get { return studentGender; }
            set { studentGender = value; }
        }
         public string StudentInstrument
        {
            get { return studentInstrument; }
            set { studentInstrument = value; }
        }
         public string StudentRequiresRental
        {
            get { return studentRequiresRental; }
            set { studentRequiresRental = value; }
        }
    }
    
}
