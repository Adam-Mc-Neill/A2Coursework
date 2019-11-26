using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.Objects
{
    public class Repairs
    {
        private int repairID;
        private int rentalID;
        private string damageDetails;
        private double repairCost;
        private DateTime repairDate;
        private DateTime repairPaymentDate;
        
        public Repairs ()
        {

        }
       
        public Repairs(int repairID,
        int rentalID,
        string damageDetails,
        double repairCost,
        DateTime repairDate,
        DateTime repairPaymentDate)
        {
            this.repairID = repairID;
            this.rentalID = rentalID;
            this.damageDetails = damageDetails;
            this.repairCost = repairCost;
            this.repairDate = repairDate;
            this.repairPaymentDate = repairPaymentDate;
        }


        public int RepairID
        {
            get { return repairID; }
            set { repairID = value; }
        }
        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
        }
        public string DamageDetails
        {
            get { return damageDetails; }
            set { damageDetails = value; }
        }
        public double RepairCost
        {
            get { return repairCost; }
            set { repairCost = value; }
        }
        public DateTime RepairDate
        {
            get { return repairDate; }
            set { repairDate = value; }
        }
        public DateTime RepairPaymentDate
        {
            get { return repairPaymentDate;}
            set {repairPaymentDate = value;}
        }
    }
    
}
