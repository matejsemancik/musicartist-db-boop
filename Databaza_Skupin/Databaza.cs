using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Databaza_Skupin
{
    class Databaza
    {
        private SortedDictionary<string, HudSkupina> listSkupin = new SortedDictionary<string, HudSkupina>();

        public Databaza()
        {
            // Test
            /*listSkupin.Add("Trolling monkeys", new HudSkupina("Trolling monkeys", 2015));
            HudSkupina sk;
            if(listSkupin.TryGetValue("Trolling monkeys", out sk))
            {
                sk.addAlbum("Banana Music vol.1");
                sk.addAlbum("Banana Music vol.2");
            }*/
        }

        public void export(string path)
        {
            StreamWriter writer = File.CreateText(path);
            StringBuilder csvRow = new StringBuilder();
            csvRow.Clear();

            foreach (KeyValuePair<string, HudSkupina> skupiny in listSkupin)
            {
                csvRow.Append("\"" + skupiny.Value.Nazov + "\", ");

                if (skupiny.Value.getDiskografia().Count > 0)
                {
                    csvRow.Append(skupiny.Value.Rok_vzniku);
                    int pocetAlbumov = skupiny.Value.getDiskografia().Count;
                    for (int i = 0; i < pocetAlbumov; i++)
                    {
                        csvRow.Append(", \"" + skupiny.Value.getDiskografia()[i] + "\"");
                    }
                } else
                {
                    csvRow.Append(skupiny.Value.Rok_vzniku);
                }
                writer.WriteLine(csvRow.ToString());
                csvRow.Clear();
            }

            writer.Close();
        }

        public void import(string path)
        {
            StreamReader reader = File.OpenText(path);
            listSkupin.Clear();
            string csvRow = null;
            while ((csvRow = reader.ReadLine()) != null)
            {
                char[] delimiter = {','};
                string[] strArrayDelimited = csvRow.Split(delimiter);
                List<string> strCleaned = new List<string>();
                foreach (string str in strArrayDelimited)
                {
                    if (str != "")
                    {
                        string newString = str.TrimStart(' ').TrimStart('\"').TrimEnd('\"');
                        strCleaned.Add(newString);
                    }
                }

                listSkupin.Add(strCleaned[0], new HudSkupina(strCleaned[0], Convert.ToInt32(strCleaned[1])));
                HudSkupina hudSkupina;
                if(listSkupin.TryGetValue(strCleaned[0], out hudSkupina))
                {
                    strCleaned.RemoveAt(0); //mazem prve 2 udaje aby mi zostali iba albumy
                    strCleaned.RemoveAt(0);
                    foreach(string str in strCleaned)
                    {
                        hudSkupina.addAlbum(str);
                    }
                }
            }
            reader.Close();
        }

        public List<string> zoznamSkupin()
        {
            List<string> list = new List<string>();
            foreach(KeyValuePair<string, HudSkupina> skupiny in listSkupin)
            {
                list.Add(skupiny.Key);
            }
            return list;
        }

        public void pridajSkupinu(string nazov, HudSkupina novaSkupina) //berie objekt - flexibilnejsie pre zmeny v programe
        {
            try
            {
                listSkupin.Add(nazov, novaSkupina);
            }
            catch (Exception e)
            {
                e = new Exception("Nefunguje to");
                //osetrenie dorobit
            }
        }

        public void pridajSkupinu(string nazov, int rok_vzniku)
        {
            listSkupin.Add(nazov, new HudSkupina(nazov, rok_vzniku));
        }


        public void vymazSkupinu(string nazov)
        {
            try
            {
                listSkupin.Remove(nazov);
            }
            catch (Exception e)
            {
                //osetrenie dorobit
            }
        }

        public HudSkupina getSkupina(string nazov)
        {
            HudSkupina skupina;
            if(listSkupin.TryGetValue(nazov, out skupina))
            {
                return skupina;
            } else
            {
                throw new Exception("Taka skupina tu neni");
            }
        }

    }
}
