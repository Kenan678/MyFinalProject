using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Constants
{
    public static class Messages
    {

        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime="Sistem bakimda";
        public static string ProductListed="Urunler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en cox 10 urun olar";
        public static string ProductNameAlreadyExists="Bu adda urun var";
        public static string CategoryLimitexceded="15 den cox kategoriya olmaz";
    }
}
