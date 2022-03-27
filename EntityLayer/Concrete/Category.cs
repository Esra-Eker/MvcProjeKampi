using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }
        
        public bool CategoryStatus { get; set; }

        //Category ile Heading i ilişkilendiricem. 1'e çok ilişki kurucam. Category 1, Heading çok.
        public ICollection<Heading> Headings { get; set; } //Category sınıfında ICollection isminde bi property oluşturdum. Ve Heading sınıfıyla ilişkili olacaksın dedim.Heading sınıfıyla ilişkili olacaksın ve ismin Headings olacak dedim.
        
    }
}
