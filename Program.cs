using System;
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

           // CreateArticleModel(context);
            CreateArticleGroupModel(context);

            Console.WriteLine("Stop");
        }

        private static void CreateArticleModel(MainDbContext context)
        {
            var articleModelList = new ArticleModelBuilder(Path.Combine(PATH_TO_FOLDER_WITH_CSV_FILE, "t_articlescsv")).Build();

            foreach (var oneList in articleModelList.SplitInToParts(1))
            {
                foreach (var item in oneList)
                {
                    context.Articles.Add(item);
                }

                context.SaveChanges();
                Console.WriteLine("Save in DB");
            }
        }

        private static void CreateArticleGroupModel(MainDbContext context)
        {
            var articleGroupModelList = new ArticleGroupModelBuilder(Path.Combine(PATH_TO_FOLDER_WITH_CSV_FILE, "t_articles_groups.csv")).Build();

            foreach (var oneList in articleGroupModelList.SplitInToParts(1))
            {
                foreach (var item in oneList)
                {
                    context.ArticleGroup.Add(item);
                }

                context.SaveChanges();
                Console.WriteLine("Save in DB");
            }
        }
    }
}
