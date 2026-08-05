# JWT Authentication API

## Proje Hakkında

Bu proje, ASP.NET Core 8 Web API kullanılarak geliştirilmiş JWT tabanlı bir kimlik doğrulama sistemidir. Projede kullanıcı kayıt ve giriş işlemleri, JWT erişim belirteci (Access Token), yenileme belirteci (Refresh Token) ve rol bazlı yetkilendirme (Role-Based Authorization) yapıları uygulanmıştır.

Proje katmanlı mimari (Layered Architecture) yaklaşımıyla geliştirilmiş olup Repository Pattern ve Service Layer kullanılarak oluşturulmuştur.

---

## Kullanılan Teknolojiler

- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server
- JWT Bearer Authentication
- BCrypt.Net
- Swagger (OpenAPI)
- Angular
- CoreUI Angular
- Dependency Injection

---

## Proje Yapısı

```
JwtAuthenticationApi
│
├── Controllers
├── Data
├── DTOs
├── Interfaces
├── Migrations
├── Models
├── Repositories
├── Services
└── Program.cs
```

---

## Uygulanan Özellikler

- Kullanıcı kayıt işlemleri
- Kullanıcı giriş işlemleri
- JWT Authentication
- Access Token oluşturma
- Refresh Token oluşturma
- Refresh Token ile yeni Access Token üretme
- Rol bazlı yetkilendirme
- BCrypt ile parola şifreleme
- Entity Framework Core kullanılarak veritabanı işlemleri
- Repository Pattern
- Service Layer
- Swagger üzerinden API testleri
- Angular ile giriş ekranı entegrasyonu

---

## Mimari Yapı

Proje aşağıdaki katmanlı mimari yapısına göre geliştirilmiştir.

```
Controller
      │
      ▼
Service
      │
      ▼
Repository
      │
      ▼
SQL Server
```

---

## Kimlik Doğrulama Akışı

```
Kullanıcı Girişi
        │
        ▼
Kullanıcı Bilgilerinin Doğrulanması
        │
        ▼
JWT Access Token Oluşturulması
        │
        ▼
Yetkili Endpointlere Erişim
        │
        ▼
Access Token Süresi Dolarsa
        │
        ▼
Refresh Token Kullanılması
        │
        ▼
Yeni Access Token Oluşturulması
```

---

## API Endpointleri

| HTTP Metodu | Endpoint | Açıklama |
|-------------|----------|----------|
| POST | /api/Auth/register | Yeni kullanıcı kaydı |
| POST | /api/Auth/login | Kullanıcı girişi |
| POST | /api/Auth/refresh | Access Token yenileme |
| GET | /api/Auth/admin | Admin yetkisi gerektiren endpoint |

---

## Veritabanı

Projede aşağıdaki tablolar kullanılmaktadır.

- Users
- Roles
- UserRoles

---

## Güvenlik

- JWT Bearer Authentication
- Refresh Token Mekanizması
- BCrypt ile parola şifreleme
- Role-Based Authorization
- Güvenli parola saklama

---

## Ekran Görüntüleri

Bu bölümde aşağıdaki ekran görüntülerine yer verilebilir.

- Swagger
- Login
- Dashboard
- SQL Server tabloları

---

## Gelecekte Yapılabilecek Geliştirmeler

- Kullanıcı profil yönetimi
- Şifre sıfırlama
- E-posta doğrulama
- Docker desteği
- Unit Test
- CI/CD Pipeline

---

## Geliştirici

Murat Dahi

Bilgisayar Mühendisliği Öğrencisi

Bartın Üniversitesi
