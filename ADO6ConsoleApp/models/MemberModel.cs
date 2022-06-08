using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO6ConsoleApp.models
{
    class MemberModel
    {

        private string _Name;
        private string _Surname;
        private string _IdNumber;
        private string _Gender;
        private string _Position, _Programme, _Qualification, _Occupation, _City, _Salary;
        private int _yearsOfExperience;
        private DateTime _Starts;
        private DateTime _Ends;
        public MemberModel(string name, string surname, string IdNum, string gender, string pos, string programme, string qua, int exp, DateTime start, DateTime end, string occupation, string city, string salary)
        {
            this._Name = name;
            this._Surname = surname;
            this._IdNumber = IdNum;
            this._Gender = gender;
            this._Position = pos;
            this._Programme = programme;
            this._Qualification = qua;
            this._yearsOfExperience = exp;
            this._Occupation = occupation;
            this._City = city;
            this._Salary = salary;
            this._Starts = start;
            this._Ends = end;

        }

        public MemberModel()
        {
        }

        [Required]
        [StringLength(50)]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        [Required]
        [StringLength(50)]
        public string surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }
        [Required]
        [StringLength(50)]
        public string IdNumber
        {
            get { return _IdNumber; }
            set { _IdNumber = value; }
        }
  
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        [Required]
        [StringLength(50)]
        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
   
        public string Programme
        {
            get { return _Programme; }
            set { _Programme = value; }
        }

        public string Qualification
        {
            get { return _Qualification; }
            set { _Qualification = value; }
        }
     
        public string Occupation
        {
            get { return _Occupation; }
            set { _Occupation = value; }
        }
        [Required]
        [StringLength(50)]
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
   
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
     
        public int YearsOfExperience
        {
            get { return _yearsOfExperience; }
            set { _yearsOfExperience= value; }
        }
    }
}
