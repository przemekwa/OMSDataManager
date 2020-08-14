using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSDataManager.Models
{
    [Table("Artykuly")]
    public partial class ArticleModel
    {
        [Key]
        public Guid? ID { get; set; }

        public short BRANZA { get; set; }

        public int ARTYKUL { get; set; }

        public short ZAKLAD { get; set; }

        [StringLength(50)]
        public string ZAKLADNAZWA { get; set; }

        [StringLength(50)]
        public string BRANZANAZWA { get; set; }

        public int? BRANZASPECJALNA { get; set; }

        [StringLength(50)]
        public string ARTOPIS1 { get; set; }

        [StringLength(50)]
        public string ARTOPIS2 { get; set; }

        public short? GRUPA { get; set; }

        [StringLength(50)]
        public string GRUPANAZWA { get; set; }

        public short? PODGRUPA { get; set; }

        [StringLength(50)]
        public string PODGRUPANAZWA { get; set; }

        public int? GRUP_WAWI { get; set; }

        public int? GRUPOWANIE { get; set; }

        [StringLength(50)]
        public string GRUPOPIS { get; set; }

        public int? DOSTAWCA { get; set; }

        [StringLength(50)]
        public string DOSTNAZWA { get; set; }

        [StringLength(50)]
        public string DOSTARTYKUL { get; set; }

        public int? PODDOSTAWCA { get; set; }

        public short? ILOSCSPRZEDAZY { get; set; }

        public short? ILOSCZAKUPU { get; set; }

        [StringLength(3)]
        public string JM { get; set; }

        [StringLength(1)]
        public string KZ_SORTART { get; set; }

        [StringLength(1)]
        public string WAGOWY { get; set; }

        public long? KODEAN { get; set; }

        [StringLength(50)]
        public string DYSPONENCI { get; set; }

        public short? NRSEZONU { get; set; }

        public short? NRSORTCENT { get; set; }

        public short? NRSORTZAKL { get; set; }

        [Column(TypeName = "money")]
        public decimal? KGO { get; set; }

        public short? ILEZGRUPOWANYCH { get; set; }

        public short? DKZ { get; set; }

        public short? VAT { get; set; }

        public short? PKTPP { get; set; }

        [StringLength(10)]
        public string DATAZALOZENIA { get; set; }

        [StringLength(1)]
        public string ZALISTOWANY { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZAPAS { get; set; }

        [Column(TypeName = "money")]
        public decimal? STRWYS { get; set; }

        [Column(TypeName = "money")]
        public decimal? OBR15DNI { get; set; }

        public int? DATAPZ { get; set; }

        public int? DATASP { get; set; }

        public short? DKZPORCEN { get; set; }

        [StringLength(1)]
        public string KZABC { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZALEGLE { get; set; }

        public int? DOSTEPNYOD { get; set; }

        public short? REGAL { get; set; }

        public short? POLKA { get; set; }

        public short? FACING { get; set; }

        public short? WYPELNIENIE { get; set; }

        public short? RYTMDYSPO { get; set; }

        [StringLength(3)]
        public string KZVK { get; set; }

        [Column(TypeName = "money")]
        public decimal? VKNN { get; set; }

        [Column(TypeName = "money")]
        public decimal? VKNN2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? VK0P { get; set; }

        [Column(TypeName = "money")]
        public decimal? VK2P { get; set; }

        public int? KODPROMOCJI { get; set; }

        [StringLength(3)]
        public string KZEK { get; set; }

        [Column(TypeName = "money")]
        public decimal? EKLI { get; set; }

        [Column(TypeName = "money")]
        public decimal? EKRK { get; set; }

        [Column(TypeName = "money")]
        public decimal? EKNN { get; set; }

        [Column(TypeName = "money")]
        public decimal? EKRKP { get; set; }

        [Column(TypeName = "money")]
        public decimal? EKNP { get; set; }

        [StringLength(3)]
        public string KZVK0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CENASPRZEDAZY { get; set; }

        [Column(TypeName = "money")]
        public decimal? CENASPRZKONCES { get; set; }

        [StringLength(3)]
        public string KZEK0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CENAZAKUPU { get; set; }

        [Column(TypeName = "money")]
        public decimal? CENAZAKUPURK { get; set; }

        [Column(TypeName = "money")]
        public decimal? ILSPRZ07DNI { get; set; }

        [Column(TypeName = "money")]
        public decimal? ILSPRZ21DNI { get; set; }

        [Column(TypeName = "money")]
        public decimal? WASPRZ28DNI { get; set; }

        [Column(TypeName = "money")]
        public decimal? WASPRZ28DNIEK { get; set; }

        [Column(TypeName = "money")]
        public decimal? MARZA28DNI { get; set; }

        [Column(TypeName = "money")]
        public decimal? ILOSCPRM28DNI { get; set; }

        [Column(TypeName = "money")]
        public decimal? WARTOSCPRM28DNI { get; set; }

        [Column(TypeName = "money")]
        public decimal? MARZAPRM28DNI { get; set; }

        [Column(TypeName = "money")]
        public decimal? ILSPRZ6MIES { get; set; }

        [Column(TypeName = "money")]
        public decimal? WASPRZ6MIES { get; set; }

        [Column(TypeName = "money")]
        public decimal? WASPRZ6MIESEK { get; set; }

        [Column(TypeName = "money")]
        public decimal? MARZAPLN6MIES { get; set; }

        [Column(TypeName = "money")]
        public decimal? ILOSCPRM6MIES { get; set; }

        [Column(TypeName = "money")]
        public decimal? WARTOSCPRM6MIES { get; set; }

        [Column(TypeName = "money")]
        public decimal? MARZAPLNPRM6MIES { get; set; }

        [Column(TypeName = "money")]
        public decimal? ILSPRZBR { get; set; }

        [Column(TypeName = "money")]
        public decimal? WASPRZBR { get; set; }

        [Column(TypeName = "money")]
        public decimal? MARZAPLNBR { get; set; }

        [Column(TypeName = "money")]
        public decimal? ILSPRZPRBR { get; set; }

        [Column(TypeName = "money")]
        public decimal? WASPRZPRBR { get; set; }

        [Column(TypeName = "money")]
        public decimal? MARZAPLNPRMBR { get; set; }

        [StringLength(50)]
        public string RANKING { get; set; }

        public short? RANKINGGRUPWAWI { get; set; }

        public DateTime? DATAAKTUALIZACJI { get; set; }

        public int artCount { get; set; }

        [StringLength(500)]
        public string articlePlantsCSV { get; set; }

        public DateTime? CalculateDate { get; set; }

        public bool? isArticleIn170Plant { get; set; }

        public int? NR_I5 { get; set; }

    }

}