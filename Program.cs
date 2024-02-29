using System;
namespace arrays{
    class Program{
        public static void Main(string[] args){
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi","kopek","kus","maymun"};
            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);

            Console.Write("lütfen diziin eleman sayisini giriniz");
            int diziUzunluğu = int.Parse(Console
            .ReadLine());
            int[] sayiDizisi = new int[diziUzunluğu];
            for(int i = 0;i<diziUzunluğu;i++){
                Console.Write("lütfen {0}. sayisi giriniz" ,i+1);
            }
            int toplam = 0;
            foreach(var item in sayiDizisi){
                toplam += item;
            }
            Console.WriteLine("ortalama : "+ toplam/diziUzunluğu);
        }
    }
}