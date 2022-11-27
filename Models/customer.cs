using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class customer
    {
        [Required]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        [Phone]
        public string Phone { get; set; }
        public int Pincode { get; set; }

    }
}
