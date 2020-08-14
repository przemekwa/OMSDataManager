using OMSDataManager.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OMSDataManager
{
    public class SuppliersModelBuilder : IModelBuilder<Suppliers>
    {
        private string filePath;

        public SuppliersModelBuilder(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Suppliers> Build()
        {
            var result = new List<Suppliers>();

            var lines = File.ReadAllLines(filePath);

            Console.WriteLine($"Start read file {filePath}");

            var rowsLength = Program.MAX_ROWS == -1 ? lines.Length : Program.MAX_ROWS;

            for (int i = 1; i < rowsLength; i++)
            {
                var split = lines[i].SplitWithDoubleQuots(',');

                var sup = new Suppliers();

                sup.NRDOSTAWCY = Utils.GetStructNullValue<int>(split[0]).Value;
                sup.NRSAPDOSTAWCY = Utils.GetStructNullValue<int>(split[1]);
                sup.NAZWA1 = split[2];
                sup.NAZWA2 = split[3];
                sup.DATAIMPORTU = DateTime.Now;
                
                result.Add(sup);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{i} row(s)");
            }

            return result;
        }
    }
}
