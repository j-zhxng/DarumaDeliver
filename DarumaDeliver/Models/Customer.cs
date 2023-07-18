using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DarumaDeliver.Models
{
    public class Customer
    {
        
   
            [Display(Name = "Customer ID")]
            public int StudentID { get; set; }



            [Display(Name = "Customer Surname")]
            public string LastName { get; set; }


            [Display(Name = "Customer Name")]
            public string FirstName { get; set; }

            [NotMapped]
            public string FullName
            {
                get { return FirstName + "" + LastName; }
            }


            [Display(Name = "Email")]
            public string Email { get; set; }


            [Display(Name = "Enrollment Date")]
            public DateTime EnrollmentID { get; set; }



            [Display(Name = "Date of Birth")]
            public DateTime DOB { get; set; }




           
     
    }
}
