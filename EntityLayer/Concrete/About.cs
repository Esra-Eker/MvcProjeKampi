using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key] //Classların mutlaka Key i olmalı.
        public int AboutID { get; set; }

        [StringLength(1000)] //Maximum uzunluk 1000 karakter olsun dedim. Hangi propertyin üzerinde tanımlarsak o property için geçerli olur.
        public string AboutDetails1 { get; set; }

        [StringLength(1000)]
        public string AboutDetails2 { get; set; }

        [StringLength(100)]
        public string AboutImage1 { get; set; }

        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
