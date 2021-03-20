using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public class Messages
	{
		public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
		public static string ProductsListed = "Araba(lar) Listelendi";
		public static string MaintenanceTime = "Sistem Bakımda!";
		public static string CarNamedInvalid = "Araba ismi en az 2 karakter olmalıdır!";
		public static string CarAdded = "Araba Eklendi";
		public static string BrandNamedInvalid = "Marka ismi en az 2 karakter olmalıdır!";
		public static string BrandAdded ="Marka Eklendi! ";
		public static string Deleted = "Silindi! ";
		public static string Updated = "Güncellendi! ";
		public static string Added = "Eklendi! ";
		public static string Listed = "Listelendi! ";
		public static string UserNamedInvalid="Kullanıcı adı 3 harften az olamaz!";
		public static string UserAdded="Kullanıcı Eklendi";
		public static string UserUpdate="Kullanıcı Güncellendi";
		public static string UserDeleted="Kullanıcı Silindi";
		public static string RentalAdded = "Kiralama işlemi başlatıldı!";
		public static string RentalUpdated = "Kiralama işlemi Güncellendi";
		public static string CustomerAdded = "Müşteri Eklendi";
		public static string CustomerDeleted = "Müşteri Silindi";
		public static string CustomerUpdated = "Müşteri Güncellendi";


		public static string RentalDeleted = "Kiralama işlemi Silindi";
		public static string RentalUpdateReturnDateError = "Kiralama dönüş tarihi güncelleme işlemi başarısız!!";
		public static string RentalUpdateReturnDate = "Kiralama dönüş tarihi güncelleme işlemi başarılı!";
		public static string RentalAddedError = "Kiralama işlemi Başarısız";
		public static string CarDetails = "Arabalar detaylı olarak listelendi!";
		public static string RentalDetails = "Kiralanan araçlar listelendi!";


		public static string ImageLimitExpiredForCar = "Bir arabaya maximum 5 fotoğraf eklenebilir";
		public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);
		public static string CarImageMustBeExists = "Böyle bi resim bulunamadı";
		public static string CarHaveNoImage = "Arabaya ait bi resim yok";


		public static string AuthorizationDenied = "Yetkiniz yok.";
		public static string UserRegistered = "Kullanıcı kaydoldu.";
		public static string UserNotFound = "Kullanıcı Bulunamadı!";
		public static string PasswordError = "Parola Hatalı";
		public static string SuccessfulLogin = "Giriş Başarılı";
		public static string UserAlreadyExists = "Kullanıcı zaten bulunuyor!";
		public static string AccessTokenCreated = "Token oluşturuldu..";
	}
}
