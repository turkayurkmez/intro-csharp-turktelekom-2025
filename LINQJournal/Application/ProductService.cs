using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ProductService
    {
        private List<Product> products = null;

        public List<Product> GetProducts()
        {
            if (products == null)
            {
                products = new List<Product>
                {
                    new Product { Id = 1, Name = "iPhone 15", Description = "Apple'ın en yeni akıllı telefonu, gelişmiş kamera ve performans", Category = "Elektronik", Price = 35000m },
                    new Product { Id = 2, Name = "Samsung Galaxy S24", Description = "Samsung'un amiral gemisi akıllı telefonu, AI özellikli", Category = "Elektronik", Price = 30000m },
                    new Product { Id = 3, Name = "MacBook Air M3", Description = "Apple'ın ultra ince dizüstü bilgisayarı, M3 çip ile güçlü performans", Category = "Bilgisayar", Price = 45000m },
                    new Product { Id = 4, Name = "Dell XPS 13", Description = "Premium ultrabook, yüksek çözünürlüklü ekran ve uzun pil ömrü", Category = "Bilgisayar", Price = 40000m },
                    new Product { Id = 5, Name = "Sony WH-1000XM5", Description = "Gürültü önleyici kablosuz kulaklık, mükemmel ses kalitesi", Category = "Ses Sistemleri", Price = 12000m },
                    new Product { Id = 6, Name = "Bose QuietComfort 45", Description = "Konforlu gürültü önleyici kulaklık, uzun pil ömrü", Category = "Ses Sistemleri", Price = 10000m },
                    new Product { Id = 7, Name = "iPad Pro 12.9", Description = "Apple'ın profesyonel tableti, M2 çip ve Apple Pencil desteği", Category = "Tablet", Price = 38000m },
                    new Product { Id = 8, Name = "Samsung Galaxy Tab S9", Description = "Android tabletlerin en iyisi, S Pen dahil", Category = "Tablet", Price = 25000m },
                    new Product { Id = 9, Name = "Nike Air Max 270", Description = "Rahat ve şık spor ayakkabı, günlük kulanım için ideal", Category = "Ayakkabı", Price = 4500m },
                    new Product { Id = 10, Name = "Adidas Ultraboost 22", Description = "Koşu ayakkabısı, yüksek enerji geri dönüşü", Category = "Ayakkabı", Price = 5200m },
                    new Product { Id = 11, Name = "Levi's 501 Jeans", Description = "Klasik kot pantolon, timeless tasarım", Category = "Giyim", Price = 800m },
                    new Product { Id = 12, Name = "Zara Blazer", Description = "Şık ve modern blazer ceket, ofis ve günlük kullanım", Category = "Giyim", Price = 1200m },
                    new Product { Id = 13, Name = "H&M Basic T-Shirt", Description = "Pamuklu basic tişört, çeşitli renk seçenekleri", Category = "Giyim", Price = 150m },
                    new Product { Id = 14, Name = "Uniqlo Hoodie", Description = "Yumuşak ve sıcak kapüşonlu sweatshirt", Category = "Giyim", Price = 450m },
                    new Product { Id = 15, Name = "Canon EOS R5", Description = "Profesyonel aynasız fotoğraf makinesi, 45MP sensör", Category = "Fotoğraf", Price = 85000m },
                    new Product { Id = 16, Name = "Nikon D850", Description = "DSLR fotoğraf makinesi, yüksek çözünürlük", Category = "Fotoğraf", Price = 75000m },
                    new Product { Id = 17, Name = "GoPro Hero 12", Description = "Su geçirmez aksiyon kamerası, 4K video çekim", Category = "Fotoğraf", Price = 15000m },
                    new Product { Id = 18, Name = "Kitchenaid Mikser", Description = "Profesyonel mutfak mikseri, çeşitli renk seçenekleri", Category = "Ev Aletleri", Price = 8500m },
                    new Product { Id = 19, Name = "Dyson V15 Detect", Description = "Kablosuz süpürge, lazer teknolojisi ile toz algılama", Category = "Ev Aletleri", Price = 18000m },
                    new Product { Id = 20, Name = "Philips Airfryer", Description = "Yağsız fritöz, sağlıklı pişirme için ideal", Category = "Ev Aletleri", Price = 3500m },
                    new Product { Id = 21, Name = "Nespresso Vertuo", Description = "Kapsüllü kahve makinesi, çeşitli boyut seçenekleri", Category = "Ev Aletleri", Price = 4200m },
                    new Product { Id = 22, Name = "Instant Pot Duo", Description = "Çok fonksiyonlu elektrikli tencere, hızlı pişirme", Category = "Ev Aletleri", Price = 2800m },
                    new Product { Id = 23, Name = "PlayStation 5", Description = "Sony'nin en yeni oyun konsolu, 4K gaming", Category = "Oyun", Price = 22000m },
                    new Product { Id = 24, Name = "Xbox Series X", Description = "Microsoft'un güçlü oyun konsolu, hızlı yükleme", Category = "Oyun", Price = 20000m },
                    new Product { Id = 25, Name = "Nintendo Switch OLED", Description = "Hibrit oyun konsolu, OLED ekran", Category = "Oyun", Price = 12000m },
                    new Product { Id = 26, Name = "Razer DeathAdder V3", Description = "Gaming mouse, yüksek hassasiyet sensörü", Category = "Oyun", Price = 2200m },
                    new Product { Id = 27, Name = "Logitech MX Master 3S", Description = "Kablosuz mouse, çoklu cihaz desteği", Category = "Bilgisayar Aksesuarları", Price = 3500m },
                    new Product { Id = 28, Name = "Keychron K8", Description = "Mekanik klavye, Mac ve PC uyumlu", Category = "Bilgisayar Aksesuarları", Price = 4800m },
                    new Product { Id = 29, Name = "Samsung 27'' Monitor", Description = "4K çözünürlüklü monitör, renk doğruluğu yüksek", Category = "Bilgisayar Aksesuarları", Price = 15000m },
                    new Product { Id = 30, Name = "LG UltraWide 34''", Description = "Ultrawide monitör, çoklu görev için ideal", Category = "Bilgisayar Aksesuarları", Price = 25000m },
                    new Product { Id = 31, Name = "Rolex Submariner", Description = "Lüks dalış saati, paslanmaz çelik kasa", Category = "Saat", Price = 350000m },
                    new Product { Id = 32, Name = "Apple Watch Series 9", Description = "Akıllı saat, sağlık takibi ve fitness özellikli", Category = "Saat", Price = 15000m },
                    new Product { Id = 33, Name = "Casio G-Shock", Description = "Dayanıklı spor saati, su geçirmez", Category = "Saat", Price = 2800m },
                    new Product { Id = 34, Name = "Seiko Prospex", Description = "Dalış saati, otomatik hareket", Category = "Saat", Price = 8500m },
                    new Product { Id = 35, Name = "Ray-Ban Aviator", Description = "Klasik pilot güneş gözlüğü, UV koruması", Category = "Aksesuar", Price = 4500m },
                    new Product { Id = 36, Name = "Oakley Holbrook", Description = "Spor güneş gözlüğü, dayanıklı çerçeve", Category = "Aksesuar", Price = 3200m },
                    new Product { Id = 37, Name = "Louis Vuitton Çanta", Description = "Lüks deri çanta, klasik tasarım", Category = "Çanta", Price = 45000m },
                    new Product { Id = 38, Name = "Gucci Omuz Çantası", Description = "Designer omuz çantası, premium malzeme", Category = "Çanta", Price = 38000m },
                    new Product { Id = 39, Name = "Herschel Sırt Çantası", Description = "Günlük kullanım sırt çantası, laptop bölmeli", Category = "Çanta", Price = 1800m },
                    new Product { Id = 40, Name = "Fjällräven Kånken", Description = "İkonik sırt çantası, dayanıklı malzeme", Category = "Çanta", Price = 2500m },
                    new Product { Id = 41, Name = "The North Face Ceket", Description = "Outdoor ceket, su geçirmez ve nefes alabilir", Category = "Outdoor", Price = 4500m },
                    new Product { Id = 42, Name = "Patagonia Fleece", Description = "Çevreci polar ceket, geri dönüştürülmüş malzeme", Category = "Outdoor", Price = 3800m },
                    new Product { Id = 43, Name = "Columbia Hiking Bot", Description = "Trekking botu, su geçirmez ve dayanıklı", Category = "Outdoor", Price = 2800m },
                    new Product { Id = 44, Name = "Merrell Trail Ayakkabı", Description = "Patika koşusu ayakkabısı, kavrama yüksek", Category = "Outdoor", Price = 2200m },
                    new Product { Id = 45, Name = "Osprey Çanta", Description = "Trekking sırt çantası, 65L hacim", Category = "Outdoor", Price = 5500m },
                    new Product { Id = 46, Name = "Tesla Model 3", Description = "Elektrikli sedan, otonom sürüş özellikli", Category = "Otomobil", Price = 1200000m },
                    new Product { Id = 47, Name = "BMW 3 Serisi", Description = "Premium sedan, sportif sürüş deneyimi", Category = "Otomobil", Price = 1800000m },
                    new Product { Id = 48, Name = "Mercedes C-Class", Description = "Lüks sedan, konfor ve teknoloji", Category = "Otomobil", Price = 2000000m },
                    new Product { Id = 49, Name = "Audi A4", Description = "Sportif sedan, quattro 4x4 sistemi", Category = "Otomobil", Price = 1750000m },
                    new Product { Id = 50, Name = "Volkswagen Golf", Description = "Kompakt hatchback, ekonomik ve güvenilir", Category = "Otomobil", Price = 850000m },
                    new Product { Id = 51, Name = "Bosch Çamaşır Makinesi", Description = "A+++ enerji sınıfı, 9 kg kapasiteli", Category = "Beyaz Eşya", Price = 15000m },
                    new Product { Id = 52, Name = "Siemens Bulaşık Makinesi", Description = "Sessiz çalışma, 14 kişilik kapasiteli", Category = "Beyaz Eşya", Price = 12000m },
                    new Product { Id = 53, Name = "LG Buzdolabı", Description = "No Frost teknoloji, 600L hacim", Category = "Beyaz Eşya", Price = 25000m },
                    new Product { Id = 54, Name = "Samsung Smart TV 55''", Description = "4K QLED televizyon, akıllı TV özellikli", Category = "Elektronik", Price = 28000m },
                    new Product { Id = 55, Name = "Sony Bravia 65''", Description = "OLED teknoloji, sinema kalitesi görüntü", Category = "Elektronik", Price = 45000m },
                    new Product { Id = 56, Name = "Beko Fırın", Description = "Ankastre fırın, çoklu pişirme programları", Category = "Beyaz Eşya", Price = 8500m },
                    new Product { Id = 57, Name = "Arçelik Ocak", Description = "Cam vitroceramik ocak, 4 gözlü", Category = "Beyaz Eşya", Price = 4200m },
                    new Product { Id = 58, Name = "Vestel Aspiratör", Description = "Mutfak davlumbazı, yüksek emme gücü", Category = "Beyaz Eşya", Price = 2800m },
                    new Product { Id = 59, Name = "Tefal Tava Seti", Description = "Yapışmaz tava seti, 3 parça", Category = "Mutfak", Price = 1200m },
                    new Product { Id = 60, Name = "Korkmaz Çelik Tencere", Description = "Paslanmaz çelik tencere seti, 8 parça", Category = "Mutfak", Price = 2500m },
                    new Product { Id = 61, Name = "Zwilling Bıçak Seti", Description = "Alman yapımı şef bıçak seti, 5 parça", Category = "Mutfak", Price = 3800m },
                    new Product { Id = 62, Name = "Wusthof Şef Bıçağı", Description = "Profesyonel şef bıçağı, 20 cm", Category = "Mutfak", Price = 1500m },
                    new Product { Id = 63, Name = "KitchenAid Blender", Description = "Güçlü blender, smoothie ve çorba için", Category = "Mutfak", Price = 4500m },
                    new Product { Id = 64, Name = "Vitamix A3500", Description = "Profesyonel blender, program ayarlı", Category = "Mutfak", Price = 18000m },
                    new Product { Id = 65, Name = "Cuisinart Food Processor", Description = "Çok fonksiyonlu mutfak robotu", Category = "Mutfak", Price = 6500m },
                    new Product { Id = 66, Name = "Magimix Citrus Press", Description = "Narenciye sıkacağı, paslanmaz çelik", Category = "Mutfak", Price = 2200m },
                    new Product { Id = 67, Name = "Le Creuset Çömlek", Description = "Emaye döküm tencere, çok renkli seçenekler", Category = "Mutfak", Price = 4800m },
                    new Product { Id = 68, Name = "Lodge Döküm Tava", Description = "Geleneksel döküm demir tava", Category = "Mutfak", Price = 800m },
                    new Product { Id = 69, Name = "All-Clad Paslanmaz Tava", Description = "Üç katmanlı paslanmaz çelik tava", Category = "Mutfak", Price = 3200m },
                    new Product { Id = 70, Name = "OXO Mutfak Aletleri", Description = "Ergonomik mutfak gereçleri seti", Category = "Mutfak", Price = 1800m },
                    new Product { Id = 71, Name = "Dyson Supersonic", Description = "Saç kurutma makinesi, hızlı ve sessiz", Category = "Kişisel Bakım", Price = 12000m },
                    new Product { Id = 72, Name = "Philips Sonicare", Description = "Elektrikli diş fırçası, plak temizliği", Category = "Kişisel Bakım", Price = 2800m },
                    new Product { Id = 73, Name = "Braun Tıraş Makinesi", Description = "Şarjlı tıraş makinesi, hassas cilt için", Category = "Kişisel Bakım", Price = 3500m },
                    new Product { Id = 74, Name = "Gillette Fusion", Description = "5 bıçaklı tıraş makinesi, yumuşak tıraş", Category = "Kişisel Bakım", Price = 450m },
                    new Product { Id = 75, Name = "L'Oreal Şampuan", Description = "Onarıcı şampuan, boyalı saçlar için", Category = "Kişisel Bakım", Price = 180m },
                    new Product { Id = 76, Name = "Nivea Nemlendirici", Description = "Günlük nemlendirici krem, hassas cilt", Category = "Kişisel Bakım", Price = 120m },
                    new Product { Id = 77, Name = "CeraVe Temizleyici", Description = "Yüz temizleyici, hyalüronik asit içerikli", Category = "Kişisel Bakım", Price = 350m },
                    new Product { Id = 78, Name = "The Ordinary Serum", Description = "Vitamin C serumu, cilt aydınlatıcı", Category = "Kişisel Bakım", Price = 280m },
                    new Product { Id = 79, Name = "Nike Dri-Fit Tişört", Description = "Spor tişörtü, nem emici kumaş", Category = "Spor Giyim", Price = 450m },
                    new Product { Id = 80, Name = "Adidas Climalite Şort", Description = "Koşu şortu, hızlı kuruyan malzeme", Category = "Spor Giyim", Price = 350m },
                    new Product { Id = 81, Name = "Under Armour Leggings", Description = "Kadın spor taytı, yüksek elastikiyet", Category = "Spor Giyim", Price = 650m },
                    new Product { Id = 82, Name = "Puma Spor Ayakkabı", Description = "Antrenman ayakkabısı, çok amaçlı kullanım", Category = "Spor Giyim", Price = 2200m },
                    new Product { Id = 83, Name = "Reebok CrossFit Ayakkabı", Description = "Fonksiyonel antrenman ayakkabısı", Category = "Spor Giyim", Price = 2800m },
                    new Product { Id = 84, Name = "New Balance Koşu Ayakkabısı", Description = "Maraton koşusu için tasarlanmış", Category = "Spor Giyim", Price = 3500m },
                    new Product { Id = 85, Name = "Yoga Mat", Description = "Anti-slip yoga matı, 6mm kalınlık", Category = "Spor Ekipmanları", Price = 450m },
                    new Product { Id = 86, Name = "Dumbbell Set", Description = "Ayarlanabilir dumbbell seti, 20kg", Category = "Spor Ekipmanları", Price = 1800m },
                    new Product { Id = 87, Name = "Resistance Band", Description = "Direnç bandı seti, 5 farklı seviye", Category = "Spor Ekipmanları", Price = 250m },
                    new Product { Id = 88, Name = "Fitbit Versa 4", Description = "Fitness tracker, nabız ölçümü", Category = "Spor Ekipmanları", Price = 8500m },
                    new Product { Id = 89, Name = "Garmin Forerunner", Description = "GPS koşu saati, antrenman programlı", Category = "Spor Ekipmanları", Price = 12000m },
                    new Product { Id = 90, Name = "Protein Tozu", Description = "Whey protein, çikolata aromalı, 2kg", Category = "Beslenme", Price = 850m },
                    new Product { Id = 91, Name = "Creatine Monohydrate", Description = "Kreatin takviyesi, performans artırıcı", Category = "Beslenme", Price = 320m },
                    new Product { Id = 92, Name = "BCAA Supplement", Description = "Dallanmış zincir amino asit takviyesi", Category = "Beslenme", Price = 420m },
                    new Product { Id = 93, Name = "Multivitamin", Description = "Günlük vitamin mineral takviyesi", Category = "Beslenme", Price = 180m },
                    new Product { Id = 94, Name = "Fish Oil", Description = "Omega-3 balık yağı kapsülleri", Category = "Beslenme", Price = 280m },
                    new Product { Id = 95, Name = "Green Tea Extract", Description = "Yeşil çay özütü, antioksidan", Category = "Beslenme", Price = 220m },
                    new Product { Id = 96, Name = "Probiyotik", Description = "Bağırsak sağlığı için probiyotik", Category = "Beslenme", Price = 380m },
                    new Product { Id = 97, Name = "Collagen Peptides", Description = "Kolajen peptitleri, cilt sağlığı", Category = "Beslenme", Price = 520m },
                    new Product { Id = 98, Name = "Magnesium Supplement", Description = "Magnezyum takviyesi, kas gevşetici", Category = "Beslenme", Price = 150m },
                    new Product { Id = 99, Name = "Vitamin D3", Description = "D3 vitamini, bağışıklık destekleyici", Category = "Beslenme", Price = 120m },
                    new Product { Id = 100, Name = "Zinc Supplement", Description = "Çinko takviyesi, bağışıklık güçlendirici", Category = "Beslenme", Price = 180m }
                };
            }

            return products;
        }
    }
}
