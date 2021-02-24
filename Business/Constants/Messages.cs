using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        internal static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor!!!";
    }
}
