using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Constants
{
    public static class Messages
    {

        public static string ProductAdded = "produkt daxil edildi";
        public static string ProductNameInvalid = "produkt adi sehdiz";
        public static string MaintenanceTime="Sistem baximda";
        public static string ProductListed="produktlar listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en cox 10 produkt olar";
        public static string ProductNameAlreadyExists="Bu adda produkt var";
        public static string CategoryLimitexceded="15 den cox kategoriya olmaz";
        public static string  AuthorizationDenied="Daxil ola bilmek ucub icazeniz yoxdur.";
        public static string UserRegistered ="Qeydiyyat olundu";
        public static string UserNotFound=" istifadeci tapilmadi";
        public static string PasswordError = " kod xetasi";
        public static string SuccessfulLogin = " basarili giris";
        public static string UserAlreadyExists = " istifadeci artiq var";
        public static string AccessTokenCreated = " token yaradildi";
    }
}
