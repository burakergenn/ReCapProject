using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        //sanırım bunları gruplayıp ayrı mesaj classlarında yapsam daha kolay erişim sağlanabilir.
        public static string CarAdded = "Araç eklendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string BrandDeleted = "Marka silindi";
        public static string ColorDeleted = "Renk silindi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string BrandNameInvalid = "Marka ismi geçersiz,2 harften fazla olmalıdır";
        public static string ColorNameInvalid = "Renk ismi geçersiz,2 harften fazla olmalıdır";
        public static string CarsListed = "Araçlar Listelendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string GetCarDetails = "Araç Detayları";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string DailyPriceError = "Araç günlük bedeli 0 dan büyük olmalıdır." ;
        public static string CustomerCompanyNameInvalid = "Müşteri şirket ismi geçersiz";


    }
}
