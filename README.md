# 50DersteMvc

Bu proje, ASP.NET MVC teknolojilerini öğrenmek ve uygulamak amacıyla geliştirilmiştir. Murat Yücedağ'ın "50 Derste MVC" eğitim serisi temel alınarak hazırlanmıştır. Proje, veritabanı işlemleri, modelleme, controller yönetimi ve frontend entegrasyonu gibi konuları kapsamaktadır.

## 📌 Proje Yapısı

Proje, Model-View-Controller (MVC) mimarisine uygun olarak aşağıdaki bileşenleri içermektedir:

- **Models**: Veritabanı tablolarını temsil eden sınıflar.
- **Views**: Kullanıcı arayüzü bileşenleri (Razor ve HTML kullanılarak hazırlanmıştır).
- **Controllers**: İş mantığını yöneten ve kullanıcı isteklerini işleyen sınıflar.
- **MSSQL & Entity Framework**: Veritabanı işlemlerini yönetmek için kullanılmıştır.

## 🚀 Kullanılan Teknolojiler

- ASP.NET MVC
- Entity Framework
- MSSQL Server
- jQuery & AJAX
- Bootstrap

## ⚙️ Kurulum

1. **Projeyi klonlayın:**
   ```sh
   git clone https://github.com/bhmberkan/50DersteMvc.git
   ```
2. **Bağımlılıkları yükleyin:**
   ```sh
   dotnet restore
   ```
3. **Veritabanını oluşturun:**
   - `appsettings.json` dosyasında veritabanı bağlantı ayarlarını düzenleyin.
   - Aşağıdaki komutu kullanarak migrasyonları uygulayın:
     ```sh
     dotnet ef database update
     ```
4. **Projeyi çalıştırın:**
   ```sh
   dotnet run
   ```

## 📌 Özellikler

- CRUD (Create, Read, Update, Delete) işlemleri
- LINQ sorguları ile veritabanı işlemleri
- Kullanıcı yönetimi ve yetkilendirme
- jQuery ile dinamik içerik güncelleme
- Bootstrap ile responsive tasarım

## 📌 Katkıda Bulunma

Projeye katkıda bulunmak için **pull request** açabilirsiniz. Hata bildirimi veya yeni özellik önerileri için **issues** sekmesini kullanabilirsiniz.

## 📷  Fotograflar

![image](https://github.com/user-attachments/assets/3ba5f8b8-1a3f-4144-a14e-9c5e2041e98e)
<br>
![image](https://github.com/user-attachments/assets/538ec538-c0c0-4d4c-b33a-b9a55718cd51)
<br>
![image](https://github.com/user-attachments/assets/7e7e95a8-5c79-47c7-aef5-8f85a6149ead)
<br>
![image](https://github.com/user-attachments/assets/9af96e25-936d-46d6-bedd-d12506a76774)
<br>
![image](https://github.com/user-attachments/assets/0419a323-0153-4127-ac53-f8f726d1e8d4)
<br>
![image](https://github.com/user-attachments/assets/46185b2b-6e61-444f-891d-f08664dd3944)
<br>
![image](https://github.com/user-attachments/assets/62e65b12-cee7-41d6-ac99-74b6ded5efb7)
<br>
![image](https://github.com/user-attachments/assets/4dd4a46f-ade3-442c-a3b8-e3960fcbdaaf)
<br>

Müşteriler kısmında ilişkili tablolarda silme işlemi yapmışım. Proje için readme dosyası oluştururken fark ettim.
situation alanı ekleyerek durumunu aktif veya pasif hale getirmek daha iyi bir çözüm olacaktır.

![image](https://github.com/user-attachments/assets/fe1d284a-ca0e-4685-bca6-3099b6bc8171)
<br> 

Satışlar kısmında ilk tabloda ürünlerin ıd leri ikinci tabloda ise bu id ye ait ürünleri çektim.
Burada amacım backend mantığını kavramak frontend çalışmadım.

![image](https://github.com/user-attachments/assets/0dc088e4-6da7-4152-8681-41fcc68ccd06)
<br>

Yardım kısmına tıklayınca bir popup ekranı oluşturdum. 


---

📌 **Berkan Burak Turgut** tarafından geliştirilmiştir. Destek olmak için ⭐ vererek projeyi beğenebilirsiniz!

