using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateATownWithClass
{
    class School
    {
        public string PropertyName { get; set; }
        public string BuildingType { get; set; }
        public int NumberofRoom { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double SquareFootage { get; }
        public int Floors { get; set; }
        public int Bathrooms { get; set; }
        public double Volume { get; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int CurrentOccupants { get { return _CurrentOccupants; } }
        private int _CurrentOccupants;
        public int NumberOfStudents { get; set; }
        private bool InSession { get; set; }
        private int NumberOfTeachers { get; set; }
       

        public School(string School)
        {
            this.BuildingType = School;
            
        }

        public string DisplayName()
        {
            return this.PropertyName;

        }
        public override string ToString()
        {
            return ($"{BuildingType} : {PropertyName}");

        }

        public string FullAddress
        {
            get
            {
                return Address1 + Address2 + City + State + Zip;
            }
        }


        public void IncreateOccupants()
        {
            this._CurrentOccupants++;

        }

        public void DecreaseOccupants()
        {
            this._CurrentOccupants--;

        }

        public string TeacherStudentRatio()
        {

            Reduce(CalcGCD(NumberOfTeachers, NumberOfStudents));
            return $"{this.NumberOfTeachers}:{this.NumberOfStudents}";

        }

        private int CalcGCD(int _NumberOfTeachers, int _NumberOfStudents) //Update the TeacherStudentRadio to return the lowest form (example: 2:10, should be 1:5)
        {
            while (_NumberOfStudents != 0)
            {
                int tempNumber = _NumberOfStudents;
                _NumberOfStudents = _NumberOfTeachers % _NumberOfStudents;
                _NumberOfTeachers = tempNumber;
            }
            return _NumberOfTeachers; //value will be No of Teachers as GCD
        }

        private void Reduce(int GCD) //GCD Greatest Common Denominator
        {
            NumberOfTeachers /= GCD;  //Numerator
            NumberOfStudents /= GCD; //Denominator
        }

        

        public School(int NumberofTeachers, int NumberofStudents) //Add a constructor to the school that sets the number of teachers and the numbers of students
        {
            this.NumberOfTeachers = NumberOfTeachers;
            this.NumberOfStudents = NumberOfStudents;
        }



    }
}
