using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSDataManager.Models
{
    [Table("Artykuly_Grupowanie")]
    public partial class ArticleGroup
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ARTYKUL { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPA_MASTER { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPA_WAWI { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPA_JEDNOSTKA { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DataAktualizacji { get; set; }
    }
}
