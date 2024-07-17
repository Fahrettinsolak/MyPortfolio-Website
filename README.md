# MyPortfolio-Website

Bu proje, kişisel portföyünüzü sergilemek amacıyla geliştirilmiş bir ASP.NET Core web uygulamasıdır. Proje, kişisel bilgilerinizi, deneyimlerinizi, yeteneklerinizi ve projelerinizi sergilemek için çeşitli bileşenler ve veritabanı yapıları kullanır. 

## Proje Yapısı

### 1. Connected Services
Bu bölümde, proje tarafından kullanılan harici hizmetler bulunur.

### 2. Dependencies
Bu klasör, projenin bağımlı olduğu NuGet paketlerini içerir.

### 3. Properties
Bu klasörde, projenin genel yapılandırma ayarları yer alır.

### 4. wwwroot
Bu klasör, statik dosyaların (CSS, JavaScript, img) yer aldığı dizindir.

### 5. Controllers
Bu klasör, uygulamanın iş mantığını kontrol eden ve HTTP isteklerini yöneten denetleyicileri içerir.

### 6. DAL (Data Access Layer)
Bu katman, veritabanı ile iletişim kurar ve veri işlemlerini gerçekleştirir.
- **Context**: Veritabanı bağlamını temsil eder. 
  - `MyPortfolioContext.cs`
- **Entities**: Veritabanı tablolarına karşılık gelen model sınıflarını içerir.
  - `About.cs`
  - `Contact.cs`
  - `Experience.cs`
  - `Feature.cs`
  - `Message.cs`
  - `Portfolio.cs`
  - `Skill.cs`
  - `SocialMedia.cs`
  - `Testimonial.cs`
  - `ToDoList.cs`

### 7. Migrations
Bu klasör, Entity Framework Core tarafından oluşturulan veritabanı geçiş dosyalarını içerir.

### 8. Models
Bu klasör, uygulamanın iş mantığını temsil eden model sınıflarını içerir.

### 9. ViewComponents
Bu klasör, uygulamada kullanılan bileşenleri içerir.
- **LayoutViewComponents**: Layout bileşenleri içerir.
  - `_LayoutHeadComponentPartial.cs`
  - `_LayoutNavbarComponentPartial.cs`
  - `_LayoutScriptComponentPartial.cs`
  - `_LayoutSidebarComponentPartial.cs`
- **Diğer Bileşenler**:
  - `_AboutComponentPartial.cs`
  - `_ContactComponentPartial.cs`
  - `_ExperienceComponentPartial.cs`
  - `_FeatureComponentPartial.cs`
  - `_FooterComponentPartial.cs`
  - `_HeadComponentPartial.cs`
  - `_NavbarComponentPartial.cs`
  - `_PortfolioComponentPartial.cs`
  - `_SkillComponentPartial.cs`
  - `_StatisticComponentPartial.cs`
  - `_TestimonialComponentPartial.cs`

### 10. Views
Bu klasör, Razor View dosyalarını içerir.
- **Default**
- **Experience**
  - `CreateExperience.cshtml`

## Kurulum

1. **Projeyi Klonlayın:**
   ```bash
   git clone https://github.com/kullaniciadi/MyPortfolio.git
   cd MyPortfolio
2. **Bağımlılıkları Yükleyin:**
   ```bash
    dotnet restore
3. **Veritabanını Güncelleyin:**
   ```bash
   dotnet ef database update
4. **Uygulamayı Çalıştırın:**
   ```bash
   dotnet run

## Kullanım

- Anasayfa: Projenin ana sayfası kişisel bilgilerinizi ve portföyünüzü sergiler.
- Deneyimler: Geçmiş iş deneyimlerinizi ve projelerinizi listeleyebilirsiniz.
- Yetenekler: Sahip olduğunuz yetenekleri sergileyebilirsiniz.
- İletişim: Ziyaretçilerin sizinle iletişim kurmasını sağlayabilirsiniz.

## Ekran Görüntüleri

- Proje ile ilgili bazı görseller.

### Ana Sayfa

![Proje Ana Sayfa Kısmı](https://github.com/user-attachments/assets/68cb25f5-4a95-4d13-9d23-62bbe9e35fa1)

### Hakkımda Sayfası

![Proje Hakkımda Kısmı](https://github.com/user-attachments/assets/12b1df95-b86f-4132-a703-fd7f93ba34bc)

### Deneyimler Sayfası

![Proje Deneyimler Kısmı](https://github.com/user-attachments/assets/5d0897ab-74d0-4f4d-b1ea-351243778c93)

### Admin Panel Sayfası 

![Proje Admin Panel Kısmı](https://github.com/user-attachments/assets/ada977fb-fca6-4800-bd1a-0454fb4c8f4c)


## Katkıda Bulunanlar

- İsim: Fahrettin Solak
- İletişim: fhrttnsolak96@gmail.com
