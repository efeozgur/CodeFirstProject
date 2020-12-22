using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstProject.Models
{
    [Table("Unvanlar")]
    public class Unvanlar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(75), Required]
        public string Unvan { get; set; }
        public virtual List<Kisiler> Kisiler { get; set; }

        

    }
}