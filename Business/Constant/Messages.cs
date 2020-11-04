using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    public static class Messages //her seferinde new lenmesin diye static
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAldreadyExists = "Bu kullancı mevcut";
        public static string UserRegistered = "Kullanıcı başarı ile kaydedildi.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
        
    }
}
