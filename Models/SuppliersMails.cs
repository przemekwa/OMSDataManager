using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMSDataManager.Models
{
    [Table("Dostawcy_AdresyMailowe")]
    public class SuppliersMails
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NRDOSTAWCY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string DZIAL { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BRANZA { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PODDOSTAWCA { get; set; }

        [StringLength(1)]
        public string KRAJ { get; set; }

        [StringLength(100)]
        public string EMAIL1 { get; set; }

        [StringLength(100)]
        public string EMAIL2 { get; set; }

        [StringLength(100)]
        public string EMAIL3 { get; set; }

        [StringLength(100)]
        public string EMAIL4 { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime DataAktualizacji { get; set; }
    }
}
