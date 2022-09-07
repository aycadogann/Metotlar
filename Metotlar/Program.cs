using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_dönüsTipi metot_adı(parametre_listesi/arguman)
            //{
                //komutlar
                //return
            //}
            int a=2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);
            
            Metotlar örnek=new Metotlar();
            örnek.EkranaYazdir(sonuc.ToString());

            int sonuc2=örnek.ArttırVeTopla(ref a,ref b);
            örnek.EkranaYazdir(sonuc2.ToString());
        }

        static int Topla(int deger1,int deger2)
        {
            return deger1+deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
        
    }
}
