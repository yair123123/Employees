using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    public enum Gender 
    { 
    MALE , FEMALE
    }

    public enum FamilyStatus
    {
        Bachelor,
        Divorcee,
        Married,
        Widower,
    }

    public class EmployeeModel
    {
        internal string tz;

        public int Id { get; set; }
        public int Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Bod { get; set; }
        public FamilyStatus Status { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string Home_num { get; set; }
        public string City { get; set; }
       
        public string FullName 
        { 
            get
            {
                return FirstName+" "+LastName;
            }
            set
            {
            }
                
        } 
        public EmployeeModel
            (
            int tz,
            string firstname,
            string lastname,
            Gender gender 
            ,DateTime bod,
            FamilyStatus status,
            string sellolar,
            string phone,
            string street,
            string homeNum,
            string city
            )
        {
            Id = 0;
            Tz = tz; 
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            Bod = bod;
            Status = status;
            CellPhone = sellolar;
            Phone = phone;
            Street = street;
            Home_num = homeNum;
            City = city;

        }


    }
}
