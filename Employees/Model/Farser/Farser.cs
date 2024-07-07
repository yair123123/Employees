using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employees.Model.Farser
{
    internal class Farser
    {
        static public string FromDobToString(DateOnly dob)
        {
            return "56";
        }
        static public Gender GetSelectedGender()

        {
            foreach (var control in EmployeeForm.groupBox_gender.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    switch (control)
                    {
                        case "MALE":
                            return Gender.MALE;
                        case "FEMALE":
                            return Gender.FEMALE;
                    }
                }
            }
            return Gender.MALE;
        }

        static public FamilyStatus GetSelectedFamilyStatus()
        {
            foreach (var control in EmployeeForm.groupBox_femily_status.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    switch (radioButton.Text)
                    {
                        case "Bachelor":
                            return FamilyStatus.Bachelor;                            
                        case "Divorcee":
                            return FamilyStatus.Divorcee;                            
                        case "Married":
                            return FamilyStatus.Married;
                        case "Widower":
                            return FamilyStatus.Widower;
                    }
                }
            }
            return FamilyStatus.Widower;
        }
    }
}
