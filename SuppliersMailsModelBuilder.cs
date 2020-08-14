using OMSDataManager.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OMSDataManager
{
    public class SuppliersMailsModelBuilder : IModelBuilder<SuppliersMails>
    {
        private string filePath;

        public SuppliersMailsModelBuilder(string filePath)
        {
            this.filePath = filePath;
        }

        public List<SuppliersMails> Build()
        {
            var result = new List<SuppliersMails>();

            var lines = File.ReadAllLines(filePath);

            Console.WriteLine($"Start read file {filePath}");

            var rowsLength = Program.MAX_ROWS == -1 ? lines.Length : Program.MAX_ROWS;

            for (int i = 1; i < rowsLength; i++)
            {
                var split = lines[i].SplitWithDoubleQuots(',');

                var sup = new SuppliersMails();

                sup.NRDOSTAWCY = Utils.GetStructNullValue<int>(split[0]).Value;
                sup.BRANZA = Utils.GetStructNullValue<int>(split[1]).Value;
                sup.KRAJ = split[2];
                sup.EMAIL1 = split[3];
                sup.EMAIL2 = split[4];
                sup.EMAIL3 = split[5];
                sup.EMAIL4 = split[6];
                sup.DataAktualizacji = DateTime.Now;
                sup.DZIAL = "no in file";
                sup.ID = i;
                
                result.Add(sup);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{i} row(s)");
            }

            return result;
        }
    }
}
