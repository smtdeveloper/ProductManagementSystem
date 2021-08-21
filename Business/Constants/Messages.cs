using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages 
    { 
        // tool görevi görüyor. Basit metinler topluğu.

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameInvalid = "Ürün ismi  geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda, Sonra Gel :)";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 ürün olabir";
        public static string ProductNameAlreadyExists = "Aynı isimde Ürün eklenemez :)";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı. Yeni ürün eklenemiyor :( ";
        public static string AuthorizationDenied= "Yetkiniz Yok";
        public static string UserAdded="Kullanıcı eklendi";
        public static string CategoryAdded="Kategori  Eklendi";
        public static string CategoryDelete= "Kategori Silindi";
        public static string CategoryUpdate = "Kategori Güncellendi";
    }
}
