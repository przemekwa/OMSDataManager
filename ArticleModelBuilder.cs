using OMSDataManager.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OMSDataManager
{
    class ArticleModelBuilder
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
            
            for (int i = 1; i < 100; i++)
            {
                var split = lines[i].SplitWithDoubleQuots(',');

                var am = new ArticleModel();

                am.ID = Guid.NewGuid();
                am.ARTOPIS1 = split[0];
                am.ARTYKUL = int.Parse(split[1]);
                am.BRANZA = short.Parse(split[2]);
                am.DATAPZ = GetStructNullValue<int>(split[3]);
                am.DATASP = GetStructNullValue<int>(split[4]);
                am.DKZ= GetStructNullValue<short>(split[5]);
                am.DOSTARTYKUL = split[6];
                am.DOSTAWCA = GetStructNullValue<int>(split[7]);
                am.DOSTEPNYOD = GetStructNullValue<int>(split[8]);
                am.DOSTNAZWA = split[9];
                am.EKLI = GetStructNullValue<decimal>(split[10]);
                am.EKNN = GetStructNullValue<decimal>(split[11]);
                am.EKNP = GetStructNullValue<decimal>(split[12]);
                am.EKRK = GetStructNullValue<decimal>(split[13]);
                am.EKRKP = GetStructNullValue<decimal>(split[14]);
                am.GRUP_WAWI = GetStructNullValue<int>(split[15]);
                am.GRUPA = GetStructNullValue<short>(split[16]);
                am.GRUPANAZWA = split[17];
                am.GRUPOWANIE = GetStructNullValue<short>(split[18]);
                am.ILOSCPRM28DNI = GetStructNullValue<decimal>(split[19]);
                am.ILOSCPRM6MIES = GetStructNullValue<decimal>(split[20]);
                am.ILOSCSPRZEDAZY = GetStructNullValue<short>(split[21]);
                am.ILSPRZ21DNI = GetStructNullValue<decimal>(split[22]);
                am.ILSPRZ6MIES = GetStructNullValue<decimal>(split[23]);
                am.ILSPRZBR = GetStructNullValue<decimal>(split[24]);
                am.KZ_SORTART = split[25];
                am.KZABC = split[26];
                am.MARZA28DNI = GetStructNullValue<decimal>(split[27]);
                am.MARZAPLN6MIES = GetStructNullValue<decimal>(split[28]);
                am.MARZAPLNBR = GetStructNullValue<decimal>(split[29]);
                am.OBR15DNI = GetStructNullValue<decimal>(split[30]);
                am.PODGRUPA = GetStructNullValue<short>(split[31]);
                am.PODGRUPANAZWA = split[32];
                am.PODDOSTAWCA = GetStructNullValue<int>(split[33]);
                am.STRWYS = GetStructNullValue<decimal>(split[34]);
                am.VAT = GetStructNullValue<short>(split[35]);
                am.VK0P = GetStructNullValue<decimal>(split[36]);
                am.WARTOSCPRM28DNI = GetStructNullValue<decimal>(split[37]);
                am.WARTOSCPRM6MIES = GetStructNullValue<decimal>(split[38]);
                am.WASPRZ28DNI = GetStructNullValue<decimal>(split[39]);
                am.WASPRZ6MIES = GetStructNullValue<decimal>(split[40]);
                am.WASPRZPRBR = GetStructNullValue<decimal>(split[41]);
                am.ZAKLAD = GetStructNullValue<short>(split[42]).Value;
                am.ZAKLADNAZWA = split[43];
                am.ZALEGLE = GetStructNullValue<decimal>(split[44]);
                am.ZALISTOWANY = split[45];
                am.ZAPAS = GetStructNullValue<decimal>(split[46]);


                result.Add(am);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write( $"{i} row(s)");
            }

            return result;
        }

        private T? GetStructNullValue<T>(string v) where T: struct
        {
            if (string.IsNullOrEmpty(v))
            {
                return null;
            }

            T result = default;

            try
            {
                result = (T)Convert.ChangeType(v.Replace(".", ","), typeof(T));
            }
            catch (Exception)
            {
                Console.WriteLine($"Error in {v} for {typeof(T).Name}");
              
            }

            return result;
        }
    }
}
