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
        [Key]
        public int AboutID{ get; set; }
        [StringLength(200)]
        public string AboutDetails { get; set; }
        [StringLength(200)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutImg { get; set; }
        public string AboutImg2 { get; set; }
    }
}
