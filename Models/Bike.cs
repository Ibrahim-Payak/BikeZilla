using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BikeZilla.Extension;

namespace BikeZilla.Models
{
    public class Bike
    {
        public int Id { get; set; }

        public Make Make { get; set; }
        [RegularExpression("^[1-9]*$",ErrorMessage ="Select Make")]
        public int MakeId { get; set; }

        public Model Model { get; set; }
        [RegularExpression("^[1-9]*$", ErrorMessage ="Select Model")]
        public int ModelId { get; set; } //by adding Id at end, it will consider foreign key to precedding part of that property

        [Required(ErrorMessage ="Provide Year")]
        //custom attribute
        [YearTillDateRangeAnnotation(2000, ErrorMessage ="Invalid Year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Provide Mileage")]
        [Range(1, int.MaxValue)]
        public int Mileage { get; set; }

        public String Features { get; set; }

        [Required(ErrorMessage = "Provide Seller Name")]
        public String SellarName { get; set; }
        
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public String SellarEmail { get; set; }

        [Required(ErrorMessage = "Provide Seller Phone")]
        public String SellerPhone { get; set; }

        [Required(ErrorMessage = "Provide Price")]
        public int Price { get; set; }

        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Select Currecy")]
        public String Currency { get; set; }

        public String ImagePath { get; set; }
    }
}
