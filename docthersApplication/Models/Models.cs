using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace docthersApplication.Models
{
    public class Membership
    {//to track patients
        public Membership()
        {
            PatientsWithMembership = new HashSet<Patient>();
        }

        public String Id { set; get; }
        public ICollection<Patient> PatientsWithMembership { get; set; }
    }
    public class Relationship
    {
        public Relationship()
        {
            Patients = new HashSet<Patient>();
        }
        public int Id { get; set; }
        public String Description { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }

    public class Distribution
    {
        public int Id { get; set; }
        [StringLength(255)]
        public String Description { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public String Town { get; set; }
        public String Area { get; set; }
        public String City { get; set; }
    }

    public class Patient
    {   
        public int Id { get; set; }
        [StringLength(255)]
        public String Name { get; set; }
        [StringLength(255)]
        public String CNIC { get; set; }
        [StringLength(255)]
        public String PrimaryContactNumber { get; set; }
        [StringLength(255)]
        public String SecondaryContactNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Year { get; set; }
        public int? Age { get; set; }
        public Boolean SmartPhoneAvailable { get; set; }
        [StringLength(255)]
        public String SmartPhoneNumber { get; set; }
        public Membership Membership { get; set; }
        public Relationship Relationship { get; set; }
        public Patient RelatedTo { get; set; }
    }
}