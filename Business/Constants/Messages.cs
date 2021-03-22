using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static olunca new lemiyoruz //Temel mesajlar
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string ProductCountCategoryError = "Category Miktarı problemi!!!";
        public static string ProductNameAlreadyExists = "Bu isimde ürün var !!!";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor!!!";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kullanıcı kayıtedildi.";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string UserAlreadyExists="Kullanıcı zaten var.";
        public static string AccessTokenCreated="Erişim jetonu oluşturuldu.";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string ProductUpdated="Ürün güncellemesi";
    }
}
