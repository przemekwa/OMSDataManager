using System;

namespace OMSDataManager
{
    class Program
    {
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

            var articleModelList = new ArticleModelBuilder(@"C:\Users\walkowskip\Downloads\pcb\pcb\t_articles.csv").Build();

            foreach (var oneList in articleModelList.SplitInToParts(1))
            {
                foreach (var item in oneList)
                {
                    context.Articles.Add(item);
                }

                context.SaveChanges();
                Console.WriteLine("Save in DB");
            }

            Console.WriteLine("Stop");
        }
    }
}
