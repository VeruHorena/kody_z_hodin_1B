using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentOOP
{
    class Student
    {
        private string jmeno;
        private int vek;
        private string adresa;
        private List<int> znamky;


        public void setJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public string getJmeno()
        {
            return this.jmeno;
        }

        public void setVek (int vek)
        {
            this.vek = vek;
        }
        public int getVek()
        {
            return this.vek;
        }

        public void setAdresa(string adresa)
        {
            this.adresa = adresa;
        }

        public string getAdresa()
        {
            return this.adresa;
        }

        public Student()
        {
            this.setJmeno("prazdne");
            this.setVek(0);
            this.setAdresa("prazdne");
            znamky = new List<int>();
        }

        public Student(string jmeno, int vek, string adresa)
        {
            this.setJmeno (jmeno);
            this.setVek(vek);
            this.setAdresa(adresa);
            znamky = new List<int>();
                
        }

        public List<int> getZnamky()
        {
            return this.znamky;
        }

        public void setZnamky(int znamka)
        {
            this.znamky.Add(znamka);
        }

        public void PredstavSe()
        {
            Console.WriteLine($"Jmeno: {this.getJmeno()} Vek: {this.getVek()} Adresa: {this.getAdresa()}");

        }
    }
}
