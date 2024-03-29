﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages 
    {


        // tool görevi görüyor. Basit metinler topluğu.
        public static string MaintenanceTime = "Sistem Bakımda, Sonra Gel :)";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameInvalid = "Ürün ismi  geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 ürün olabir";
        public static string ProductNameAlreadyExists = "Aynı isimde Ürün eklenemez :)";

        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı. Yeni ürün eklenemiyor.";
        public static string CategoryAdded = "Kategori  Eklendi";
        public static string CategoryDelete = "Kategori Silindi";
        public static string CategoryUpdate = "Kategori Güncellendi";
        public static string CategoryNameAlreadyExists = "Aynı isimde Kategori eklenemez :)";


        public static string UserAdded="Kullanıcı eklendi";
        public static string userDeleted= "Kullanıcı Silindi";
        public static string userUpdate = "Kullanıcı Güncelendi";
        public static string userList = "Kullanıcılar Listelendi";
        public static string userByIdList = "Kullanıcı Listelendi";

        public static string OrderAdded="Sipraris ekelendi";
        public static string OrderDelete = "Sipraris Silindi";
        public static string OrderUpdate = "Sipraris Güncellendi";

        public static string EmployeeAdded= "çalışan Eklendi";
        public static string EmployeeUpdated = "çalışan Günçellendi";
        public static string EmployeeDeleted = "çalışan Silindi";
        public static string EmployeeGetAllList = "çalışanlar Listelendi";
        public static string EmployeeGetByIdList = "çalışan Listelendi";

        public static string ProductImageAdded="Ürün resmi Eklendi";
        public static string ProductImageDeleted = "Ürün resmi Silindi";
        public static string ProductImageUpdate = "Ürün resmi Güncellendi";
        public static string ProductImageGetAll = "Ürünler resmi Listelendi";
        public static string ProductImageGetById = "Ürün resmi Getirirdi";
        internal static string ProductImageLimit="Ürün resmi ekleme limetine ulaşdınız (Snır = 5 Adet)";
    }
}
