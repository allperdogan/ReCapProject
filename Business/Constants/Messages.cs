using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ImageAdded = "Resim eklendi";
        public static string CarImageLimitReached = "Resim yükleme limiti";
        public static string CarImageAlreadyHave = "Resim zaten var";
        public static string ImagesListedById = "Id için resimler listelendi";
        public static string ImageUpdated = "Resim güncellendi";
        public static string CarImageDeleted = "Resim silindi";
        public static string ImagesListed = "Resimler listelendi";
        public static string ImagesListedByCarId = "Araba modeli için resimler listelendi";
        public static string? AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "User kayıt oldu";
        public static User UserNotFound;
        public static User PasswordError;
        public static string SuccessfulLogin = "Başarılı giriş ";
        public static string UserAlreadyExists = "User zaten var";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
