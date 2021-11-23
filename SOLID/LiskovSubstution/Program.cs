using System;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir base class, kendisinden miras alan sınıflar tarafından değişikliğe uğramamalı.
             * 
             */
            IAlanHesaplanabilir geometri = DortgenGetir(5,12);
            
            Console.WriteLine(geometri.Alan());
            Console.ReadLine();
        }

        static IAlanHesaplanabilir DortgenGetir(int en, int boy = 1)
        {
            //Bir biçimde (koşul) geriye kare döndürdünüz.
            return boy > 1 ? new Dortgen { En = en, Boy = boy } : new Kare { En = en };

        }
    }

    public interface IAlanHesaplanabilir
    {
        double Alan();
    }
    public class Dortgen : IAlanHesaplanabilir
    {

        public virtual int En { get; set; }
        public virtual int Boy { get; set; }

        public double Alan()
        {
            return En * Boy;
        }


    }

    public class Kare : IAlanHesaplanabilir
    {
        public int En { get; set; }

        public double Alan()
        {
            return En * En;
        }
    }
}
