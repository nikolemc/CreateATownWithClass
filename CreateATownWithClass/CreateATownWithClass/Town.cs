using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateATownWithClass
{
    class Town
    {
        //public School School { get; set; } //this is getting school
        //public Bank Bank { get; set; } //this is getting bank
        //public House House { get; set; } //this is getting house


        public List<School> mySchoolList = new List<School>();

        public List<School> MySchoolList
        {
            get { return mySchoolList; }
        }


        public List<Bank> myBankList = new List<Bank>();

        public List<Bank> MyBankList
        {
            get { return myBankList; }
        }

        public List<House> myHouseList = new List<House>();

        public List<House> MyHouseList
        {
            get { return myHouseList; }
        }

    }
}
