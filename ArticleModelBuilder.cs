using OMSDataManager.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OMSDataManager
{
    public class ArticleModelBuilder : IModelBuilder<ArticleModel>
    {
        private string filePath;

        public ArticleModelBuilder(string filePath)
        {
            this.filePath = filePath;
        }

        public List<ArticleModel> Build()
        {
            var result = new List<ArticleModel>();

            var lines = File.ReadAllLines(filePath);

            Console.WriteLine($"Start read file {filePath}");

            var rowsLength = Program.MAX_ROWS == -1 ? lines.Length : Program.MAX_ROWS;

            for (int i = 1; i < rowsLength; i++)
            {
                var split = lines[i].SplitWithDoubleQuots(',');

                var am = new ArticleModel();

                am.ID = Guid.NewGuid();
                am.ARTOPIS1 = split[0];
                am.ARTYKUL = int.Parse(split[1]);
                am.BRANZA = short.Parse(split[2]);
                am.DATAPZ = Utils.GetStructNullValue<int>(split[3]);
                am.DATASP = Utils.GetStructNullValue<int>(split[4]);
                am.DKZ = Utils.GetStructNullValue<short>(split[5]);
                am.DOSTARTYKUL = split[6];
                am.DOSTAWCA = Utils.GetStructNullValue<int>(split[7]);
                am.DOSTEPNYOD = Utils.GetStructNullValue<int>(split[8]);
                am.DOSTNAZWA = split[9];
                am.EKLI = Utils.GetStructNullValue<decimal>(split[10]);
                am.EKNN = Utils.GetStructNullValue<decimal>(split[11]);
                am.EKNP = Utils.GetStructNullValue<decimal>(split[12]);
                am.EKRK = Utils.GetStructNullValue<decimal>(split[13]);
                am.EKRKP = Utils.GetStructNullValue<decimal>(split[14]);
                am.GRUP_WAWI = Utils.GetStructNullValue<int>(split[15]);
                am.GRUPA = Utils.GetStructNullValue<short>(split[16]);
                am.GRUPANAZWA = split[17];
                am.GRUPOWANIE = Utils.GetStructNullValue<short>(split[18]);
                am.ILOSCPRM28DNI = Utils.GetStructNullValue<decimal>(split[19]);
                am.ILOSCPRM6MIES = Utils.GetStructNullValue<decimal>(split[20]);
                am.ILOSCSPRZEDAZY = Utils.GetStructNullValue<short>(split[21]);
                am.ILSPRZ21DNI = Utils.GetStructNullValue<decimal>(split[22]);
                am.ILSPRZ6MIES = Utils.GetStructNullValue<decimal>(split[23]);
                am.ILSPRZBR = Utils.GetStructNullValue<decimal>(split[24]);
                am.KZ_SORTART = split[25];
                am.KZABC = split[26];
                am.MARZA28DNI = Utils.GetStructNullValue<decimal>(split[27]);
                am.MARZAPLN6MIES = Utils.GetStructNullValue<decimal>(split[28]);
                am.MARZAPLNBR = Utils.GetStructNullValue<decimal>(split[29]);
                am.OBR15DNI = Utils.GetStructNullValue<decimal>(split[30]);
                am.PODGRUPA = Utils.GetStructNullValue<short>(split[31]);
                am.PODGRUPANAZWA = split[32];
                am.PODDOSTAWCA = Utils.GetStructNullValue<int>(split[33]);
                am.STRWYS = Utils.GetStructNullValue<decimal>(split[34]);
                am.VAT = Utils.GetStructNullValue<short>(split[35]);
                am.VK0P = Utils.GetStructNullValue<decimal>(split[36]);
                am.WARTOSCPRM28DNI = Utils.GetStructNullValue<decimal>(split[37]);
                am.WARTOSCPRM6MIES = Utils.GetStructNullValue<decimal>(split[38]);
                am.WASPRZ28DNI = Utils.GetStructNullValue<decimal>(split[39]);
                am.WASPRZ6MIES = Utils.GetStructNullValue<decimal>(split[40]);
                am.WASPRZPRBR = Utils.GetStructNullValue<decimal>(split[41]);
                am.ZAKLAD = Utils.GetStructNullValue<short>(split[42]).Value;
                am.ZAKLADNAZWA = split[43];
                am.ZALEGLE = Utils.GetStructNullValue<decimal>(split[44]);
                am.ZALISTOWANY = split[45];
                am.ZAPAS = Utils.GetStructNullValue<decimal>(split[46]);


                result.Add(am);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{i} row(s)");
            }

            return result;
        }
    }
}
