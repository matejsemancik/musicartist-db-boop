//Osetrit oznamovanie exceptions (napr. do spodneho status baru v GUI)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaza_Skupin
{
    public class HudSkupina
    {
        private string _nazov;
        public string Nazov
        {
            get { return this._nazov; }
            set
            {
                _nazov = value;
            }
        }
        private int _rok_vzniku;
        public int Rok_vzniku
        {
            get { return this._rok_vzniku; }
            set
            {
                _rok_vzniku = value;
            }
        }

        private List<string> diskografia = new List<string>();

        public HudSkupina(string _nazov, int _rok_vzniku)
        {
            this.Nazov = _nazov;
            this.Rok_vzniku = _rok_vzniku;
        }

        public void addAlbum(string meno)
        {
            diskografia.Add(meno);
        }

        public void removeAlbum(int index)
        {
            try
            {
                diskografia.RemoveAt(index);
            }
            catch (Exception e)
            {
                //osetrenie
            }
        }

        public void removeAlbum(string meno)
        {
            try
            {
                diskografia.Remove(meno);
            }
            catch (Exception e)
            {
                //osetrenie dorobit
            }
        }

        public void clearAlbums()
        {
            diskografia.Clear();
        }
        public List<string> getDiskografia()
        {
            return diskografia;
        }
    }
}
