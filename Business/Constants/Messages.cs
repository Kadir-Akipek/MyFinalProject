﻿namespace Business.Constants
{
    public static class Messages
    {
        //constant = sabit, northwind'e özel proje sabitlerini buraya koyacağız
        //basit bir mesaj yazacağımız için static kullanacağız

        public static string ProductAdded = "Ürün başarıyla eklendi"; //static verdiğimizde new'leme işlemi olmaz, tek instance olur 
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated="Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";

    }
}
