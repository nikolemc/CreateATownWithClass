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
        public string Address1 { get; }
        public string Address2 { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }
        public int CurrentOccupants { get { return _CurrentOccupants; } }
        private int _CurrentOccupants;
        public int NumberOfStudents { get; set; }
        private bool InSession { get; set; }
        private int NumberofTeachers { get; set; }

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
                      
                return "${this.NumberofTeacher}:{this.NumberOfStudent}";
            
        }

    }
}
