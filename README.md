# SOAP Teknolojisi Kullanarak Kişi Bilgilerini Doğrulama Projesi

Bu C# projesi, SOAP teknolojisi kullanarak belirli bir URL'ye bağlanarak kişi bilgilerinin doğruluğunu kontrol eder. Proje, isim, soyisim, doğum yılı ve TC kimlik numarası bilgilerini alır ve bu bilgileri belirtilen URL'ye göndererek doğrulama yapar. Eğer bilgiler doğru ise, konsola "Maske verildi" mesajı yazdırır.

## Kullanım

Proje, Visual Studio veya benzeri bir C# geliştirme ortamında açılabilir. Projeyi açtıktan sonra, gerekli SOAP teknolojisi bağlantılarını ve bağlantı adreslerini sağlamanız gerekmektedir. Ayrıca, SOAP servisine erişim yetkilerinin olması önemlidir.

Kod içerisindeki gerekli yerlere servis bağlantı adresi ve diğer bilgilerinizi ekleyerek projeyi kullanmaya başlayabilirsiniz.

## Projeyi Çalıştırma

Projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. Proje dosyalarını bir C# geliştirme ortamında açın (örneğin, Visual Studio).
2. Projeyi derleyin ve çalıştırın.
3. Konsolda belirtilen talimatları izleyin ve gerekli kişi bilgilerini girin.
4. Bilgiler doğru ise, "Maske verildi" mesajını göreceksiniz.

## Proje Yapısı ve SOLID Prensipleri

Proje, SOLID prensiplerine uygun bir şekilde tasarlanmıştır. Aşağıdaki özellikler bu prensipleri yansıtır:

- **Single Responsibility Principle (SRP):** Her sınıf veya metot, tek bir sorumluluğa sahiptir ve bu şekilde tasarlanmıştır.
- **Open/Closed Principle (OCP):** Kod, değişikliklere kapalı, ancak genişletmeye açıktır. Yeni gereksinimler eklendiğinde mevcut kodları değiştirmeye gerek kalmaz.
- **Liskov Substitution Principle (LSP):** Türetilmiş sınıflar, temel sınıfın yerine kullanılabilir.
- **Interface Segregation Principle (ISP):** Kullanılmayan metotlar veya özellikler içermeyen sade arayüzler kullanılır.
- **Dependency Inversion Principle (DIP):** Bağımlılıklar arasında sıkı bir bağlantı yerine soyutlamalar kullanılarak zayıf bağlantılar sağlanır.

## Gereksinimler

- .NET Framework veya .NET Core çalıştırılabilir bir ortam.

## Katkıda Bulunma

Eğer projeye katkıda bulunmak istiyorsanız, lütfen bir çekme isteği (pull request) gönderin veya bir sorun (issue) açın. Katkılarınızı memnuniyetle karşılarız!

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için [LİSANS](LICENSE) dosyasını inceleyebilirsiniz.
