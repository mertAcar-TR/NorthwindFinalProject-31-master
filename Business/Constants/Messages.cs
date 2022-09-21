using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategorida en fazla 10 ürün olabilir";
        public static string ProductAlreadyExistError="Bu isimde bir ürün zaten var";
        public static string CountOfCategory="Kategori sınırı geçti";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt eklendi";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı zaten ekli";
        public static string AccessTokenCreated="Erişim tokenı oluşturuldu";
    }
}
