using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Superhrdinove
{
    class Superhrdina
    {
        private string jmeno;
        private int urovenSily;
        private int zdravi;
        private string superschopnost;

        public Superhrdina(string jmeno, string superschopnost)
        {
            this.jmeno = jmeno;
            this.superschopnost = superschopnost;
            Random rnd = new Random();
            this.urovenSily = rnd.Next(1, 101);
            this.zdravi = rnd.Next(1, 101);
        }

        public string GetJmeno()
        {
            return jmeno;
        }

        public void Attack(Superhrdina s)
        {
            Console.WriteLine($"{jmeno} útočí na {s.GetJmeno()} svou schopností {superschopnost}!");
        }

        public void Introduce()
        {
            Console.WriteLine($"Jsem {jmeno} a moje superschopnost je {superschopnost}!");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{jmeno} - Zdraví: {zdravi}, Síla: {urovenSily}");
        }

        public void Train(int hodnota)
        {
            urovenSily += hodnota;
            zdravi -= 10;
            if (zdravi < 0) zdravi = 0;
            Console.WriteLine($"{jmeno} trénoval a nyní má sílu {urovenSily}, ale jeho zdraví kleslo na {zdravi}.");
        }
    }


}
