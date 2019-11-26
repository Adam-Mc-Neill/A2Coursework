using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class Instrument
    {
        private int instrumentID;
        private string instrumentType;
        private string instrumentName;
        private string instrumentBrand;
        private int stockistID;
        private double instrumentCost;
        private DateTime dateOfPurchase;
        

        public Instrument()
        {

        }

        public Instrument(int instrumentID, string instrumentType, string instrumentName,string instrumentBrand,int stockistID, double instrumentCost, DateTime dateOfPurchase)
        {
            this.instrumentID = instrumentID;
            this.instrumentType = instrumentType;
            this.instrumentName = instrumentName;
            this.instrumentBrand = instrumentBrand;
            this.stockistID = stockistID;
            this.instrumentCost = instrumentCost;
            this.dateOfPurchase = dateOfPurchase;
            
        }

        public int InstrumentID
        {
            get { return instrumentID; }
            set { instrumentID = value; }
        }
        public string InstrumentType
        {
            get { return instrumentType; }
            set { instrumentType = value; }
        }
        public string InstrumentName
        {
            get { return instrumentName; }
            set { instrumentName = value; }
        }
        public string InstrumentBrand
        {
            get { return instrumentBrand; }
            set { instrumentBrand = value; }
        }
        public int StockistID
        {
            get { return stockistID; }
            set { stockistID = value; }
        }
        public double InstrumentCost
        {
            get { return instrumentCost; }
            set { instrumentCost = value; }
        }
        public DateTime DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
    }
}
