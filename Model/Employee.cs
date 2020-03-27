// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Employee
    {
        private int empId;
        private string fullName;
        private string email;
        private string password;
        private string mobile;
        private string address;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmpId
        {
            get
            {
                return this.empId;
            }
            set
            {
                this.empId = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
    }
}
