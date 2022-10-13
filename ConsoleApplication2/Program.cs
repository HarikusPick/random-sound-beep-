using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soyut_Sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            //SoyutSinif soyutsinif = new SoyutSinif();   

            // Böyle bir tanımlama yapılamaz Abstract sınıfın bir örneği(instance) alınamaz

            // Sadece kalıtım için kullanılabilir

            TuretilenSinif tureyensinif = new TuretilenSinif();


            // yazdir metodu SoyutSinif ına ait bir metot 
            
            tureyensinif.yazdir("Merhaba\n");

            
            // yaz() metodu SoyutSiniftan miras alınmış ve TuretileSinif içinde

            // değiştirilerek (override) artık TüretilenSinif ın bir metodudur.

            tureyensinif.yaz();

            tureyensinif.Ad = "Ahmet";

            tureyensinif.Soyad = "Kara";

            tureyensinif.Telefon = "1 111 111 11 11 ";


            Console.WriteLine(tureyensinif.Ad + "  " + tureyensinif.Soyad + 
                ": "+tureyensinif.Telefon);
            
            Console.ReadKey();




            /*
             *
             * Program Çıktısı:
             * 
             *  Merhaba

                Türetilen sinifta değiştirildim

                Ahmet  Kara: 1 111 111 11 11
             *
             */
        }
    }


    // Abstract sınıf(soyut sınıf) oluşturma

    // Abstract sınıfların nesnesi üretilemez

    // Abstract sınıflardan türemiş olan sınıfların nesneleri üretilebilir.

    // Bu duruma çok biçimlik (polymorphism) denir.

    // Abstract sınıf kalıtım amacıyla kullanılır.

    abstract class SoyutSinif
    {
        //Abstrac sinif içinde normal bir metot 


        public void yazdir(string yazi) 
        {
            Console.WriteLine(yazi);
        }


        // Abstrac sinif içinde abstract bir metod oluşturma

        public abstract void yaz();


        //abstact bir metot sonradan yani miras alındığı sınıf içinde değiştirilmesine

        // olanak verir (override).

        // Abstract metot static olamaz.

        // Abstract metot virtual olamaz.

        // Abstract metot private olarak tanımlanamaz.

        // Abstract sınıf içinde metodun tanımlaması veya açıklaması yapılmaz.

        // Ad isminde soyut bir property oluşturma  

        // Soyut metod için geçerli olan özelikler soyut property içinde geçerlidir


        public abstract string Ad
        { 
            get; 
            set; 
        }

        // Soyad isminde soyut bir property oluşturma 

        // Soyut metod için geçerli olan özelikler soyut property içinde geçerlidir


        public abstract string Soyad
        { 
            get; 
            set; 
        }


        public abstract string Telefon 
        { 
            get; 
            set; 
        }
    }

 
    class TuretilenSinif:SoyutSinif
    {
        // Abstract metodu (override) değiştir 

        public override void yaz()
        {
            Console.WriteLine("Türetilen sinifta değiştirildim\n");
        }

        private string ad;

        private string soyad;

        private string telefon;


        // Abstract 

        public override string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }


        public override string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }


        public override string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }
    }
}

}