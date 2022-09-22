using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Ürün sayısı 10' unu geçti.";
        public static string ProductNameAlreadyExists ="Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceeded = "Category sayısı limiti geçtiği için ekleme yapılamadı.";
    }
}
