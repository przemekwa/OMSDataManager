using OMSDataManager.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OMSDataManager
{
    public class ArticleGroupModelBuilder : IModelBuilder<ArticleGroup>
    {
        private string filePath;

        public ArticleGroupModelBuilder(string filePath)
        {
            this.filePath = filePath;
        }

        public List<ArticleGroup> Build()
        {
            var result = new List<ArticleGroup>();

            var lines = File.ReadAllLines(filePath);

            Console.WriteLine($"Start read file {filePath}");

            var rowsLength = Program.MAX_ROWS == -1 ? lines.Length : Program.MAX_ROWS;

            for (int i = 1; i < rowsLength; i++)
            {
                var split = lines[i].SplitWithDoubleQuots(',');

                var ag = new ArticleGroup();

                ag.ARTYKUL = Utils.GetStructNullValue<int>(split[0]).Value;
                ag.GRUPA_MASTER = Utils.GetStructNullValue<int>(split[1]).Value;
                ag.GRUPA_JEDNOSTKA = Utils.GetStructNullValue<int>(split[2]).Value;
                ag.GRUPA_WAWI = Utils.GetStructNullValue<int>(split[3]).Value;
                ag.DataAktualizacji = DateTime.Now;

                result.Add(ag);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{i} row(s)");
            }

            return result;
        }
    }
}
