using OMSDataManager.Models;
using System.Data.Entity;

namespace OMSDataManager
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
        {

        }
        public MainDbContext(string connectionStringName) : base(connectionStringName)
        {
        }


        public virtual DbSet<ArticleModel> Articles { get; set; }
        public virtual DbSet<ArticleGroup> ArticleGroup { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SuppliersMails> SuppliersMails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuppliersMails>()
             .Property(e => e.DZIAL)
             .IsUnicode(false);

            modelBuilder.Entity<SuppliersMails>()
                .Property(e => e.KRAJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SuppliersMails>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<SuppliersMails>()
                .Property(e => e.EMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<SuppliersMails>()
                .Property(e => e.EMAIL3)
                .IsUnicode(false);

            modelBuilder.Entity<SuppliersMails>()
                .Property(e => e.EMAIL4)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.NIP)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.NAZWA1)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.NAZWA2)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.KRAJ)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.ADRES)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.KODPOCZTOWY)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.MIASTO)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.OSOBAKONTAKTOWA)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.TELEFON1)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.TELEFON2)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ZAKLADNAZWA)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.BRANZANAZWA)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ARTOPIS1)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ARTOPIS2)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.GRUPANAZWA)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.PODGRUPANAZWA)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.GRUPOPIS)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.DOSTNAZWA)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.DOSTARTYKUL)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.JM)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.KZ_SORTART)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WAGOWY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.DYSPONENCI)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.KGO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.DATAZALOZENIA)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ZALISTOWANY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ZAPAS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.STRWYS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.OBR15DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.KZABC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ZALEGLE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.KZVK)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.VKNN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.VKNN2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.VK0P)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.VK2P)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.KZEK)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.EKLI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.EKRK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.EKNN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.EKRKP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.EKNP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.KZVK0)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.CENASPRZEDAZY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.CENASPRZKONCES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.KZEK0)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.CENAZAKUPU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.CENAZAKUPURK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ILSPRZ07DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ILSPRZ21DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WASPRZ28DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WASPRZ28DNIEK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.MARZA28DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ILOSCPRM28DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WARTOSCPRM28DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.MARZAPRM28DNI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ILSPRZ6MIES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WASPRZ6MIES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WASPRZ6MIESEK)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.MARZAPLN6MIES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ILOSCPRM6MIES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WARTOSCPRM6MIES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.MARZAPLNPRM6MIES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ILSPRZBR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WASPRZBR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.MARZAPLNBR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.ILSPRZPRBR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.WASPRZPRBR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.MARZAPLNPRMBR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.RANKING)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleModel>()
                .Property(e => e.articlePlantsCSV)
                .IsUnicode(false);


        }
    }
}
