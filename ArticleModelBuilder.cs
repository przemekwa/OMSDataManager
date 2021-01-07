using OMSDataManager.Models;
using System;
using System.Collections.Generic;
using System.IO;

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
                var split = lines[i].SplitWithDoubleQuots(';');

                var am = new ArticleModel();

                am.ID = Guid.NewGuid();
                am.BRANZA = short.Parse(split[0]);
                am.ARTYKUL = int.Parse(split[1]);
                am.ZAKLAD = Utils.GetStructNullValue<short>(split[2]).Value;
                am.ZAKLADNAZWA = split[3];
                am.BRANZANAZWA = split[4];
                am.BRANZASPECJALNA = Utils.GetStructNullValue<int>(split[5]);
                am.ARTOPIS1 = split[6];
                am.ARTOPIS2 = split[7];
                am.GRUPA = Utils.GetStructNullValue<short>(split[8]);
                am.GRUPANAZWA = split[9];
                am.PODGRUPA = Utils.GetStructNullValue<short>(split[10]);
                am.PODGRUPANAZWA = split[11];
                am.GRUP_WAWI = Utils.GetStructNullValue<int>(split[12]);
                am.GRUPOWANIE = Utils.GetStructNullValue<short>(split[13]);
                am.GRUPOPIS = split[14];
                am.DOSTAWCA = Utils.GetStructNullValue<int>(split[15]);
                am.DOSTNAZWA = split[16];
                am.DOSTARTYKUL = split[17];
                am.PODDOSTAWCA = Utils.GetStructNullValue<int>(split[18]);
                am.ILOSCSPRZEDAZY = Utils.GetStructNullValue<short>(split[19]);
                am.ILOSCZAKUPU = Utils.GetStructNullValue<short>(split[20]);//tos
                am.JM = split[21];
                am.KZ_SORTART = split[22];
                am.WAGOWY = Utils.GetBoolValue(split[23]);
                am.KODEAN = Utils.GetStructNullValue<long>(split[24]);
                am.DYSPONENCI = split[25];
                //NRSEZONU 26
                //NRSORTCENT 27
                //NRSORTZAKL 28
                //KGO 29
                //ILEZGRUPOWANYCH 30
                am.DKZ = Utils.GetStructNullValue<short>(split[31]);
                am.VAT = Convert.ToInt16(Utils.GetStructNullValue<decimal>(split[32]));
                //PKTPP 33
                //DATAZAL 34
                am.ZALISTOWANY = split[35];
                am.ZAPAS = Utils.GetStructNullValue<decimal>(split[36]);
                am.STRWYS = Utils.GetStructNullValue<decimal>(split[37]);
                am.OBR15DNI = Utils.GetStructNullValue<decimal>(split[38]);
                am.DATAPZ = Utils.GetStructNullValue<int>(split[39]);
                am.DATASP = Utils.GetStructNullValue<int>(split[40]);
                am.DKZPORCEN = Utils.GetStructNullValue<short>(split[41]);
                am.KZABC = split[42];
                am.ZALEGLE = Utils.GetStructNullValue<decimal>(split[43]);
                am.DOSTEPNYOD = Utils.GetStructNullValue<int>(split[44]);
                //REGAL 45
                //POLKA 46
                //FACING 47
                //WYPELNIENIE 48
                //RYTMDYSPO 49
                am.KZVK = split[50];
                //VKNN 51
                //VKNN2 52
                am.VK0P = Utils.GetStructNullValue<decimal>(split[53]);
                //VK2P 54
                //KODPROMOCJI 55
                am.KZEK = split[56];
                am.EKLI = Utils.GetStructNullValue<decimal>(split[57]);
                am.EKRK = Utils.GetStructNullValue<decimal>(split[58]);
                am.EKNN = Utils.GetStructNullValue<decimal>(split[59]);
                am.EKRKP = Utils.GetStructNullValue<decimal>(split[60]);
                am.EKNP = Utils.GetStructNullValue<decimal>(split[61]);
                //KZVK0 62
                //CENASPRZEDAZY 63
                //CeNASPRZKONCES 64
                //KZEK0 65
                //CENAZAKUPU 66
                //CENAZAKUPURK 67
                //ILSPRZ07DNI 68
                am.ILSPRZ21DNI = Utils.GetStructNullValue<decimal>(split[69]);
                am.WASPRZ28DNI = Utils.GetStructNullValue<decimal>(split[70]);
                //WASPRZ28DNIEK 71
                am.MARZA28DNI = Utils.GetStructNullValue<decimal>(split[72]);
                am.ILOSCPRM28DNI = Utils.GetStructNullValue<decimal>(split[73]);
                am.WARTOSCPRM28DNI = Utils.GetStructNullValue<decimal>(split[74]);
                //MARZAPRM28DNI 75
                am.ILSPRZ6MIES = Utils.GetStructNullValue<decimal>(split[76]);
                am.WASPRZ6MIES = Utils.GetStructNullValue<decimal>(split[77]);
                //WASPRZ6MIESEK 78
                am.MARZAPLN6MIES = Utils.GetStructNullValue<decimal>(split[79]);
                am.ILOSCPRM6MIES = Utils.GetStructNullValue<decimal>(split[80]);
                am.WARTOSCPRM6MIES = Utils.GetStructNullValue<decimal>(split[81]);
                //MARZAPLNPRM6MIES 82
                am.ILSPRZBR = Utils.GetStructNullValue<decimal>(split[83]);
                //WASPRZBR 84
                am.MARZAPLNBR = Utils.GetStructNullValue<decimal>(split[85]);
                //ILSPRZPRBR 86
                am.WASPRZPRBR = Utils.GetStructNullValue<decimal>(split[87]);
                //MARZAPLNPRMBR 88
                //RANKING 89
                //RANKINGGRUPWAWI 90
                //DATAAKTUALIZACJI 91
                //id 92
                //artCount 93
                //articlePlantsCSV 94
                //CalculateDate 95
                //isArticleIn170Plant 96
                //NR_I5 97

                result.Add(am);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"{i} row(s)");
            }

            return result;
        }
    }
}
