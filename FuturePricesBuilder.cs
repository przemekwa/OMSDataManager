using OMSDataManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OMSDataManager
{
    public class FuturePricesBuilder : IModelBuilder<FuturePrices>
    {
        private string filePath;

        public FuturePricesBuilder(string filePath)
        {
            this.filePath = filePath;
        }

        public List<FuturePrices> Build()
        {
            var result = new List<FuturePrices>();

            var lines = File.ReadAllLines(filePath);
            
            Console.WriteLine($"Start read file {filePath}");
            var rowsLength = Program.MAX_ROWS == -1 ? lines.Length : Program.MAX_ROWS;
            var now = DateTime.Now;
            for (int i = 1; i < rowsLength; i++)
            {
                var split = lines[i].SplitWithDoubleQuots(';');

                var fp = new FuturePrices();
                
                fp.ID = Guid.NewGuid();//0
                fp.ARTYKUL = int.Parse(split[1]);
                if (string.IsNullOrEmpty(split[2]) == false)
                {
                    DateTime.TryParse(split[2], out var date);
                    fp.DATAOD = int.Parse(date.ToString("yyyyMMdd"));
                }
                if (string.IsNullOrEmpty(split[3]) == false)
                {
                    DateTime.TryParse(split[3], out var date);
                    fp.DATADO = int.Parse(date.ToString("yyyyMMdd"));
                }
                fp.CENAEKLI = Utils.GetStructNullValue<decimal>(split[4]);
                fp.CENAEKRK = Utils.GetStructNullValue<decimal>(split[5]);
                fp.DataAktualizacji = now;
                //fp.DOSTAWCA = int.Parse(split[7]);
                fp.ZAKLAD = int.Parse(split[8]);
                fp.KZEK = string.IsNullOrEmpty(split[9]) ? null : split[9];
                fp.BAZA01 = Utils.GetStructNullValue<short>(split[10]);
                fp.ZNAK01 = Utils.GetStructNullValue<short>(split[11]);
                fp.RABAT01 = Utils.GetStructNullValue<decimal>(split[12]);
                fp.BAZA02 = Utils.GetStructNullValue<short>(split[13]);
                fp.ZNAK02 = Utils.GetStructNullValue<short>(split[14]);
                fp.RABAT02 = Utils.GetStructNullValue<decimal>(split[15]);
                fp.BAZA03 = Utils.GetStructNullValue<short>(split[16]);
                fp.ZNAK03 = Utils.GetStructNullValue<short>(split[17]);
                fp.RABAT03 = Utils.GetStructNullValue<decimal>(split[18]);
                fp.BAZA04 = Utils.GetStructNullValue<short>(split[19]);
                fp.ZNAK04 = Utils.GetStructNullValue<short>(split[20]);
                fp.RABAT04 = Utils.GetStructNullValue<decimal>(split[21]);
                fp.BAZA05 = Utils.GetStructNullValue<short>(split[22]);
                fp.ZNAK05 = Utils.GetStructNullValue<short>(split[23]);
                fp.RABAT05 = Utils.GetStructNullValue<decimal>(split[24]);
                fp.BAZA06 = Utils.GetStructNullValue<short>(split[25]);
                fp.ZNAK06 = Utils.GetStructNullValue<short>(split[26]);
                fp.RABAT06 = Utils.GetStructNullValue<decimal>(split[27]);
                fp.TEST = string.IsNullOrEmpty(split[28]) ? null : split[28];
                fp.DATAIMPORTU = now;
                fp.CENAEKNN_A = Utils.GetStructNullValue<decimal>(split[30]);
                fp.CENAEKNN_P = Utils.GetStructNullValue<decimal>(split[31]);

                result.Add(fp);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{i} row(s)");
            }

            return result;
        }
    }
}
