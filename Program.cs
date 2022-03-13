using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnCapsulationOrnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Encapsulation (Kapsülleme): Genel olarak C# kapsülleme işlemi fonksiyonlara dışarıdan yanlışlıkla
            //  kod(veri) değişikliğini önlemek için kullanılır. 

            //C# da class’ların properties‘leri tanımlanarak verilerin bozulmaları veya değiştirilmeleri engellen bilir.
            //Properties‘leri olan bir class tanımlarsak   encapsulation yapılmış yani kapsüllenmiş alanlara doğrudan erişilemez.
            //Bunun yerine gereksinimlerimize göre verileri okumak ve yazmak için get ve set işlemlerini kullanmamız gerekir.
            /*Get ve Set Metotları
             * Get Metodu: Bir verinin değeri okunmak istendiğinde o özelliğe ait get metodu çalışacaktır. 
             * Bu metot değişken çağrıldığında çalışır.
             * Diğer bir deyişle bir field‘ın  değerini geri döndürme olayıdır.
             * Set Metodu: Bir veriye atama yapılmak istendiği zaman set metodu çalışır.
             * Değişkenlere değer atandığında çağrılır
             * Değişken kontrolü bu metotla yapılır.
             * Set metodu içerisine value anahtar sözcüğü ile erişilir.
             * value anahtar sözcüğünün önceden belirtilmiş herhangi bir türü yoktur.
             * Özelliğe atanacak değer hangi türden ise value da o türden olur.
             */
            Uyeler uye4 = new Uyeler();

            //------------------------------------------------------------------------------------------------------------
            uye4.yas = 91; //yas özelliğinin SET metodu çalıştı
            uye4.sayi = 12; //sayi özelliğinin SET metodu çalıştı

            Console.WriteLine(uye4.yas);// yas özelliğinin GET metodu çalıştı. 

            Console.WriteLine(uye4.sayi);// sayi özelliğinin GET metodu çalıştı. 
            Console.ReadLine();
            // Burada Uyeler sınıfından oluşturulan uye4 nesnesinin properties‘lerine atamalar yapılmıştır.
            // uye4.Yas=91; ataması bize hata verecektir çünkü kullanıcı değişken bizim istediğimiz aralıkta bir değer atamamıştır.
            // yani _yas değişkenine erişimi belli aralıklarda kısıtladığımız için Message Boxt‘a 

            //“Yaş aralığı 10’dan küçük 80’den büyük olmaz”

            //bu hatayı alacağız çünkü bu hatayı istediğimiz aralığın dışında bir atama yapması durumunda biz tanımladık.
            //---------------------------------------------------------------------------------------------------
        }
    }

    class Uyeler
        //------------------------------------------------------------------------------------------------------------------------------
    {// Dışardan kimse gelip _sayi değerine ulaşmasın (private genelde "_" alt tire ile tanımlanır)
        private int _sayi;
        // "properties"
        public int sayi
        {
            get { return _sayi; }
            set { _sayi = value; }
        }
        //_sayi değişkeni private erişim belirteci ile gizlenmiş Sayi değişkeni ise public erişim belirteci ile genele açılmıştır.
        //Farklı bir classtan _sayi değişkeni üzerinde değişiklik yapmak istenildiğinde Sayi değişkeni üzerinden get ve set komutları ile
        //_sayi değişkeni üzerinde işlem yapılması sağlanmıştır.Burada her hangi bir koşul belirtilmediğinden
        //Sayi üzerinden erişimi direk sağlanmıştır. 

        //---------------------------------------------------------------------------------------------------------------------------
        private int _yas; // field 

        public int yas //  _yas public erişim belirteci ile genele açıldı 
        {
            get { return _yas; } 
            set
            {
                if (value >= 10 && value <= 80)
                {
                    _yas = value;
                }
                else
                {
                    Console.WriteLine("Yaş aralığı 10'dan küçük 80'den büyük olmaz");
                }
            }

        }
        //Burada private ile gizlenmiş _yas değişkenine public erşim belirteci genele açılmış Yas değişkeni üzerinden Yas’ yani value 10′ eşit
        //veya büyük olduğunda ve 80’e eşit veya küçük olduğunda _yas atama yapası söylenmiştir. Bu şekilde _yas ifadesine bizim belirttiğimiz
        //şartlar gerçekleştiğinde erişilmesi sağlanmıştır.
        //---------------------------------------------------------------------------------------------------------------------------




    }
}
