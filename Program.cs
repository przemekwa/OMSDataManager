using OMSDataManager.Models;
using System;
using System.Data.Entity;
using System.IO;

namespace OMSDataManager
{
    public class Program
    {
        const string PATH_TO_FOLDER_WITH_CSV_FILE = @"C:\Users\walkowskip\Downloads\pcb\pcb\";
        public const int MAX_ROWS = 100; // all rows set -1;

        static void Main(string[] args)
        {
            Console.WriteLine(@"   ____  __  ________    ____        __           __  ___                                 ");
            Console.WriteLine(@"  / __ \/  |/  / ___/   / __ \____ _/ /_____ _   /  |/  ____ _____  ____ _____ ____  _____");
            Console.WriteLine(@" / / / / /|_/ /\__ \   / / / / __ `/ __/ __ `/  / /|_/ / __ `/ __ \/ __ `/ __ `/ _ \/ ___/");
            Console.WriteLine(@"/ /_/ / /  / /___/ /  / /_/ / /_/ / /_/ /_/ /  / /  / / /_/ / / / / /_/ / /_/ /  __/ /    ");
            Console.WriteLine(@"\____/_/  /_//____/  /_____/\__,_/\__/\__,_/  /_/  /_/\__,_/_/ /_/\__,_/\__, /\___/_/     ");
            Console.WriteLine(@"                                                                      /____/                                 ");

            Console.WriteLine("Start");
            var context = new MainDbContext("Data Source=localhost;Initial Catalog=SelgrosMainDB_OMS;User Id=SelgrosPGLogin;Password=SelgrosPGLogin;");

            Create<ArticleModel>(
               context,
               context.Articles,
               new ArticleModelBuilder(Path.Combine(PATH_TO_FOLDER_WITH_CSV_FILE, "products.csv")));

            Console.WriteLine();

            Create<ArticleGroup>(
                context,
                context.ArticleGroup,
                new ArticleGroupModelBuilder(Path.Combine(PATH_TO_FOLDER_WITH_CSV_FILE, "t_articles_groups.csv")));

            Console.WriteLine();

            Create<Suppliers>(
                context,
                context.Suppliers,
                new SuppliersModelBuilder(Path.Combine(PATH_TO_FOLDER_WITH_CSV_FILE, "suppliers.csv")));

            Console.WriteLine();

            Create<SuppliersMails>(
               context,
               context.SuppliersMails,
               new SuppliersMailsModelBuilder(Path.Combine(PATH_TO_FOLDER_WITH_CSV_FILE, "suppliers_emails.csv")));

            Console.WriteLine();

            Create<FuturePrices>(
                context,
                context.FuturePrices,
                new FuturePricesBuilder(Path.Combine(PATH_TO_FOLDER_WITH_CSV_FILE, "future_prices.csv")));

            Console.WriteLine("Stop");
        }

        private static void Create<T>(MainDbContext context, DbSet<T> dbSet, IModelBuilder<T> modelBuilder) where T: class
        {
            var list = modelBuilder.Build();

            foreach (var oneList in list.SplitInToParts(1))
            {
                Console.WriteLine();
                Console.Write("Save in DB - ");

                foreach (var item in oneList)
                {
                    dbSet.Add(item);
                }

                var erros = context.GetValidationErrors();

                context.SaveChanges();

                Console.Write("save successful");
                
            }
        }

    }
}
