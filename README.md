# PatikaPratikCodeFirstBasic

Bu depo, Entity Framework kullanarak Code First yaklaşımı ile geliştirilen temel bir projeyi içermektedir. Proje, Patika.dev pratikleri kapsamında oluşturulmuş olup, .NET ile Code First yaklaşımı kullanılarak nasıl bir veritabanı oluşturulacağını göstermektedir.

## 📋 İçindekiler

- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Proje Yapısı](#proje-yapısı)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## 🚀 Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:


1. Projeyi Visual Studio'da açın:

PatikaPratikCodeFirstBasic.sln dosyasını açın.

2.NuGet paketlerini geri yükleyin:

Visual Studio'da çözüm üzerine sağ tıklayıp NuGet Paketlerini Geri Yükle seçeneğini seçin.

3.Veritabanını güncelleyin:

Visual Studio’nun Package Manager Console bölümünü açın ve şu komutu çalıştırın:
update-database

## 💻 Kullanım
Proje, Entity Framework Code First yaklaşımı kullanılarak geliştirilmiştir. Veritabanı oluşturulmuş migration’lar ve seed dataları ile birlikte çalışmaktadır. Veritabanını oluşturmak ve gerekli migration’ları uygulamak için yukarıdaki adımları izleyebilirsiniz.
## 🗂️ Proje Yapısı
Proje yapısı şu şekildedir:

Entities: Veritabanı tablolarını temsil eden sınıflar.
Migrations: Veritabanı migration’larının yönetildiği klasör.
Context: Veritabanı işlemlerinin gerçekleştirildiği DbContext sınıfı.
## 🛠️ Kullanılan Teknolojiler
.NET Core
Entity Framework Core
Visual Studio
