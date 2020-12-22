using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstProject.Models
{
    [Table("Kisiler")]
    public class Kisiler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(7), Required]
        public string personelSicilNo { get; set; }
        [StringLength(20), Required]
        public string personelAdSoyad { get; set; }
        public string cepTelefonu { get; set; }
        public string dahiliNo { get; set; }
        public string  dahiliNo2 { get; set; }
        public virtual Unvanlar Unvan { get; set; }

        public virtual Birimler Birimler { get; set; }

    }
}