﻿using System;

namespace OMSDataManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMSDataManager");

            var context = new MainDbContext("Data Source=localhost;Initial Catalog=SelgrosMainDB_OMS;User Id=SelgrosPGLogin;Password=SelgrosPGLogin;");

            var articleModelList = new ArticleModelBuilder(@"C:\Users\walkowskip\Downloads\pcb\pcb\t_articles.csv").Build();

            foreach (var oneList in articleModelList.SplitInToParts(1))
            {
                foreach (var item in oneList)
                {
                    context.Articles.Add(item);
                }

                context.SaveChanges();
            }


            //context.Articles.Add(new Models.ArticleModel
            //{
            //    ID = Guid.NewGuid(),
            //    artCount = 0,
            //    articlePlantsCSV = "",
            //    ARTOPIS1 = "",
            //    ARTOPIS2 = "",
            //    ARTYKUL = 12344,
            //    BRANZA = 23,
            //    BRANZANAZWA = "ss",
            //    BRANZASPECJALNA = 23,
            //    CalculateDate = DateTime.Now,
            //    CENASPRZEDAZY = 34,
            //    CENASPRZKONCES = 45,
            //    CENAZAKUPU = 4,
            //    CENAZAKUPURK = 3,
            //    DATAAKTUALIZACJI = DateTime.Now,
            //    DATAPZ = 2,
            //    DOSTAWCA = 3435,
            //    DOSTNAZWA = "",
            //});

            //context.SaveChanges();
        }
    }
}