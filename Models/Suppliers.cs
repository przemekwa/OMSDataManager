using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSDataManager.Models
{
    [Table("Dostawcy")]
    public partial class Suppliers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NRDOSTAWCY { get; set; }

        public int? NRSAPDOSTAWCY { get; set; }

        [StringLength(50)]
        public string NIP { get; set; }

        [StringLength(100)]
        public string NAZWA1 { get; set; }

        [StringLength(100)]
        public string NAZWA2 { get; set; }

        [StringLength(10)]
        public string KRAJ { get; set; }

        [StringLength(100)]
        public string ADRES { get; set; }

        [StringLength(10)]
        public string KODPOCZTOWY { get; set; }

        [StringLength(100)]
        public string MIASTO { get; set; }

        public byte? STATUS { get; set; }

        public short? BRANZA { get; set; }

        public int? TERMINRABATUPROM { get; set; }

        [StringLength(100)]
        public string OSOBAKONTAKTOWA { get; set; }

        [StringLength(100)]
        public string TELEFON1 { get; set; }

        [StringLength(100)]
        public string TELEFON2 { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATAIMPORTU { get; set; }
    }
}
