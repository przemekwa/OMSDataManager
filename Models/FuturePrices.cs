using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMSDataManager.Models
{
    [Table("CenyZakupuPrzyszle")]
    public class FuturePrices
    {
        [Key]
        public Guid? ID { get; set; }
        public int ARTYKUL { get; set; }
        public int DATAOD { get; set; }
        public int DATADO { get; set; }
        public decimal? CENAEKLI { get; set; }
        public decimal? CENAEKRK { get; set; }
        public DateTime DataAktualizacji { get; set; }
        public int DOSTAWCA { get; set; }
        public int ZAKLAD { get; set; }
        [StringLength(3)]
        public string KZEK { get; set; }
        public short? BAZA01 { get; set; }
        public short? ZNAK01 { get; set; }
        public decimal? RABAT01 { get; set; }
        public short? BAZA02 { get; set; }
        public short? ZNAK02 { get; set; }
        public decimal? RABAT02 { get; set; }
        public short? BAZA03 { get; set; }
        public short? ZNAK03 { get; set; }
        public decimal? RABAT03 { get; set; }
        public short? BAZA04 { get; set; }
        public short? ZNAK04 { get; set; }
        public decimal? RABAT04 { get; set; }
        public short? BAZA05 { get; set; }
        public short? ZNAK05 { get; set; }
        public decimal? RABAT05 { get; set; }
        public short? BAZA06 { get; set; }
        public short? ZNAK06 { get; set; }
        public decimal? RABAT06 { get; set; }
        [StringLength(10)]
        public string TEST { get; set; }
        public DateTime? DATAIMPORTU { get; set; }
        public short? ZNACZNIK { get; set; }
        public decimal? CENAEKNN_A { get; set; }
        public decimal? CENAEKNN_P { get; set; }
    }
}
