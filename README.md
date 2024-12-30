# 🍀 CSharp Eğitim Kampı

Bu repo, Murat Yücedağ'ın c# dilini anlattığı konular ve hazırlanılan projeler ile ilgilidir. Bu kamp c# diline sıfırdan başlayıp orta seviyeye çıkmayı amaçlamaktadır. Ne kadar c# diline biraz biliyor olsamda baştan başlamak ve böyle ilerlemek daha kalıcı hale getiriyor. Aşağıda projeler ile ilgili detaylı bilgilere ulaşabilirisiniz. 🩵

## 📍Proje 1
İlk projede Console.WriteLine() komutunu işledik. Konsola yazdırma komutu ile ilgili uygulamalar yapıldı.

## 📍Proje 2
Değişkenler konusu ile ilgili uygulamalar yapıldı. Farklı veri tiplerinde değişkenler tanımlamayı, kullanıcıdan değişkenleri alabilmeyi ve bunları kullanabilmeyi gördük.

## 📍Proje 3
Karar yapıları ile ilgili pratikler yapıldı. If-Else kullanrak farklı koşullar kullanarak yapılar oluşturuldu.

## 📍Proje 4
Döngüler konusunda uygulamalar yapıldı. Farklı döngü yapıları ile farklı senaryolarda nasıl çözümler oluşturulabileceği ile ilgili pratikler yapıldı.

## 📍Proje 5
Döngü yapıları ile oluşturulabilecek şekiller üzerine uygulamalar yapıldı.

## 📍Proje 6
Diziler konusunda pratikler yapıldı. Dizilerin nasıl tanımlanacağı, değerlerin nasıl ilenebileceği, kullanıcıdan nasıl alınabileceği konuları işlendi.

## 📍Proje 7
Foreach döngü yapısı nasıl kurulur ve kullanılır gördük. Sınıftaki öğrenci sayısının ve bu öğrencilerin sınav notlarının kullanıcı tarafından girilerek not ortalamalarını hesaplayan, karar yapılarını kullanrak dersten geçip geçmediğini bulan ve ekrana yazdıran sınav sistemi uygulaması yapıldı.

## 📍Proje 8
Metodlar konusu işlendi. Yazılan kodların tekrar kullanılabilir hale getirilmesi anlatıldı, geri değer dödüren ve döndürmeyen metodlar görüldü.

## 📍Proje 9
Database işlemleri gerçekleştirildi. MsSql veri tabanında bir veri seti hazırlandı ve proje, bu veri tabanına bağlanarak veriler ekranda gösterildi.

## 📍Proje 10
Visual studio ortamında MsSql veri tabanına bağlanarak Crud işlemleri gerçekleştirldi.

## 📍Proje 11
Bu projeyle birlikte 301 modülüne geçiş yapıldı ve bu kapsamda **Code First yapısı** ile **N katmanlı mimari** detaylı bir şekilde ele alındı. Ayrıca, **class yapıları** açıklanarak, **SOLID prensipleri** üzerinde duruldu ve **erişim belirleyiciler** hakkında önemli bilgiler aktarıldı.

## 📍Proje 12 
Yukarıda 11. proje üzerine uygulanan yeni konulardır.Bu konular; **Cod First** yapısı çerçevesi ile **Entity Layer'da** tablolar arası ilişkiler kodda  nasıl oluşturulur, **Access Layer'da** veri tabanındaki tabloların nasıl oluşturulduğunu ve **app.config'e** veri tabanının erişim adresinin nasıl eklendiğini gösterildi.

## 📍Proje 13
13. derste işlenen konular 11 numaralı projenin içindedir. **enable-migrations** ve **update-database** komutlarını kullanarak Sql'de Code First yaklaşımı ile tablo oluşturuldu. **Data Access Layer** altında **Abstract** klasörü oluşturuldu. Bu klasörde **Crud** işlemlerini gerçekleştirmek için **Repository** tasarım desenini kullanıldı, böylece merkezileştirilmiş bir yapı ile her entitiy için crud işlemi yazmak yerine hepsini bir yere bağlandı.

## 📍Proje 14
Bu projede **Entity Framework** ile ilgili uygulama yapıldı. Konu anlatılırken **ORM** nedir, **entity framework** nedir açılandı, **Ado.Net** ile olan farklarından, avantajlarından, dezavantajlarından bahsedildi. Projede **Database First** yaklaşımı kullanılarak windows form uygulaması ile database'in nasıl bağlanılacağı gösterildi.   

## 📍Proje 15 
Yapılan değişiklikler 14. projenin içindedir. Entity Framework metodlar konusu (toList, Add, Update, Delete, GetById) uygulama yapılarak anlatıldı. 

## 📍Proje 16
İşlenen konular 14. projenin içindedir. Bu derste Entity Framework Metodları pekiştirilmek adına bir tur projesi gerçekleştirildi. Bu projenin kodlarına 14. projede FrmLocation.cs dosyasının içinden erişebilirisiniz.

## 📍Proje 17
Bu derste Lınq Sorgular anlatıldı. Max, Count, Where, Select gibi metotlar ve sorgularla bir istatistik tablo hazırlandı. 14. projenin içinde FrmStatictics.cs dosyasının içinden kodlara ulaşabilirsiniz. Aşağıda tablonun görüntüsü yer almaktadır.  

![image alt](https://github.com/Gamzekasyol/CSharp-EgitimKampi/blob/4b717adb70dd08a4d7d54464db4b22197a47825c/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202024-12-02%20022517.png)

## 📍Proje 18
11. projenin içerisinde DataAccessLayer katmanının altında Repositories Folder --> GenericRepository sınıfı eklendi. GenericRepository sınıfında oluşturulan metotların içerisi dolduruldu. EntityState komutu açılandı. EntityFramework Folder --> Ef sınıfları oluşturuldu.

## 📍Proje 19
Yapılan değişiklikler 11. projenin içerisindedir. DataBusiness Katmanına Abstract ve Concrate folderları ve bu folderlara classlar eklendi. Bu classlarda metotlar dolduruldu ve bazı validasyonlar eklendi. PresentationLayer katmanındaki FrmCategory formu dolduruldu.

## 📍Proje 20
İşlnen konular proje 11'in içindedir. **Dependency Injection(DI)**'nın ne olduğu açıklanmış, makaleler gösterilmiş ve proje üzerinde anlatılmıştır. Ayrıca **Presentation** katmanında oluşturduğumuz **FrmCategory** isimli formda ki butonların işlevleri yazılmıştır(Örneğin listele butonunun kodlarını yazdık). 

## 📍Proje 21
İşlnen konular proje 11'in içindedir. Bu derse önceki dersin tekrarı niteliğinde uygulama yapılmıştır. **FrmProduct** isimli forma butonlar eklenip işlevleri yazılmıştır. Burada farlı olarak 2 listeleme butonu kullanılmıştır. Çünkü listleme esnasında tablolar bağlı olduğu için istemediğimiz ya da doğru şekilde gelmeyen veriler bulunmaktadır. Bunun için bu derste **Entity'e özgü metot nasıl yazılır** gösterilmiştir.   

## 📍Proje 22
Kamp sürecinin **501 modülü** olan **Dapper** konusuna giriş yapıldı. Dapper nedir, neden kullanılır açıklandı. Sql'de dapper için yeni bir veri tabanı oluşturuldu. Projeye folderlar ve classlar eklendi. bu sırada **Dto** konusundan behsedildi. Classların neden oluşturuldukarı açılandı. **Asenkron Programlama** ve **asenkron metotların** ne olduğu neden kullanıldığı açıklandı ve örnekler verildi. Projede asenkron metotlar kullanılmıştır.

## 📍Proje 23
**Dapper** konusunda devam edilmiştir. İlk olarak veri tabanı ile proje bağlanmıştır. Önceki derste tanımlanan metotların işlevleri yazılmıştır. Butonlar gerekli işlevlerine göre bu metotlar ile bağlanmıştır. Proje böylece tamamlanmıştır. Bu projede dapper kullanarak veri tabanına **ekleme, silme, güncelleme, listeleme ve ıd'ye göre getirme** işlemleri gerçekleştirilmiştir. Son olarak bir ürünün toplam adetini, en pahalısını getirme vb gibi istatistiksel bilgileri nasıl queryler yazarak sonuçlar alınabileceği ile ilgili örnek yapılmıştır. 

## 📍Proje 24
**MongoDb** konusuna 601 modülüne giriş yapıldı. Nedir, neden kullanılır, avantajları nelerdir konuları açıklandı. Projede **MongoDbconnection** classında veri tabanı ile bağlantısını sağlayıp bir collection oluşturuldu. Diğer folderlar ve classlar oluşturuldu ve UI tasarımı yapıldı.

## 📍Proje 25
MongoDb konusuna devam edildi. Ekleme, silme, güncelleme, listeleme, ıd'ye göre getirme işlemleri **CustomerOperations** classında yapıldı. Arayüzdeki butonlar bu classta yazılan metotlar ile bağlandı.
