using Microsoft.AspNetCore.Mvc;

namespace CoreMVCIntro_0.Controllers
{
    public class HomeController : Controller
    {
        //MVC'de Controller icerisinde olan metotlara biz aynı zamanda Action da deriz...Aslında IActionResult döndüren metotlara Action deriz...

        //MVC'de Action'lar cok önemlidir...Cünkü BackEnd işlemlerinizi, HTTP'ye göre görev yapmak istedigimiz tüm işlemlerimizi Controller'daki ACtion'lar yapar...


        //Eger MVC'de bir Action'a HTTP request tipi vermezseniz, Action otomatik olarak HTTPGet yönteminde calısır...

        //MVC'de url'e yazdıgınız controller projede yoksa veya controller varsa ama icerisindeki action yoksa aynı hatayı alırsınız (Resource cannot be found) LocalHost Sayfası bulunamıyor...

        //Lakin Controller ve ACtion varsa ama ACtion'in döndürecegi View ilgili Views klasorunun icerisinde ilgili klasorlerde (ilgili Controller ismindeki klasorde veya Shared klasorunde) bulunmuyorsa o zaman unhandled exception hatasını gösteren sayfayı alırsınız...

        //MVC'de projenizin sayfayı size getirebilmesi icin sadece Controller ve ACtion yetmez...Action'in döndürecegi bir View olması gerekir...Yani bir sayfa olması gerekir...

       
        public IActionResult Index()
        {

            //View() metodunun  eger argümanı yoksa, hangi ACtion icerisinde cagrılıyor ise o Action ismine denk düsen bir View'i mimarinizin Views klasorunde sahip oldugu Controller ismine ait klasorun icerisinde arayacaktır...Yani icinde bulundugu Action ile aynı isme sahip olan bir View'i döndürmeye calısır...
            
            return View();
        }

        public IActionResult Deneme()
        {

           


            return View();
        }

        public IActionResult Test()
        {
            return View();
        }


       
    }
}
