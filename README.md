# JWT Authentication API

##  Proje Hakkında

Bu proje, .NET 8 Web API kullanılarak geliştirilen JWT tabanlı kimlik doğrulama sistemidir.

Projede;

- Kullanıcı kayıt işlemleri
- Kullanıcı giriş işlemleri
- JWT Authentication
- Access Token
- Refresh Token
- Rol bazlı yetkilendirme (Role-Based Authorization)

yapılarının geliştirilmesi hedeflenmektedir.

---

# 🚀 Kullanılan Teknolojiler

- .NET 8 Web API
- Entity Framework Core
- SQL Server
- Swagger
- JWT Authentication (Yakında)

---

# 📁 Proje Yapısı

```
JwtAuthenticationApi
│
├── Controllers
├── Models
├── Data
├── DTOs
├── Services
├── Interfaces
├── Repositories
```

---

# ✅ Bugüne Kadar Yapılanlar

## 1. Proje Oluşturuldu

- .NET 8 Web API projesi oluşturuldu.
- Swagger aktif edildi.
- Authentication Type = None seçildi.

---

## 2. Entity Framework Core Kuruldu

Kurulan paketler:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

---

## 3. Proje Klasör Yapısı Oluşturuldu

Oluşturulan klasörler:

- Controllers
- Models
- Data
- DTOs
- Services
- Interfaces
- Repositories

---

## 4. Entity Sınıfları Oluşturuldu

Oluşturulan entityler:

- User
- Role
- UserRole

---

## 5. ApplicationDbContext Oluşturuldu

ApplicationDbContext içerisine;

- Users
- Roles
- UserRoles

DbSet'leri eklendi.

---

# 📚 Bugün Öğrenilen Konular

- Entity nedir?
- DbContext nedir?
- DbSet nedir?
- Property nedir?
- Constructor nedir?
- DbContextOptions ne işe yarar?
- base(options) neden kullanılır?
- Navigation Property nedir?
- Code First yaklaşımı nedir?

---

# 📅 Sonraki Adımlar

- SQL Server bağlantısını yapmak
- Connection String eklemek
- Program.cs yapılandırması
- İlk Migration oluşturmak
- Veritabanını oluşturmak
- Register API
- Login API
- JWT Authentication
- Access Token
- Refresh Token
- Role Based Authorization
