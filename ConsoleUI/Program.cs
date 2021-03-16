using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
            //BrandAddToDb();
            //ColorAddToDb();
            //CarAddToDb();
            //carGetByBrandId(2);
            //CarGetAll();
            //CarDetailsList();
            //CustomerAdd();
            //CustomerTest();

            int _secim;
            bool _loop = true;

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            do
            {
                ProjectLogo();
                MainMenu();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n SEÇİMİNİZ : ");
                Console.ResetColor();
                string _tempString = Console.ReadLine();


                if (_tempString == "")
                {
                    _secim = 0;
                }
                else
                {
                    _secim = Convert.ToInt32(_tempString);
                }

                Console.WriteLine();

                switch (_secim)
                {
                    case 1:
                        ListToBrands(brandManager);
                        Console.WriteLine();
                        ListToColors(colorManager);
                        Console.WriteLine();
                        AddToCar(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 2:
                        ListToCars(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 3:
                        ListToBrands(brandManager);
                        ListToCarsByBrandId(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 4:
                        ListToColors(colorManager);
                        ListToCarsByColorId(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 5:
                        UpdateToCar(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 6:
                        DeleteToCar(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 7:
                        ListToBrands(brandManager);
                        AddToBrand(brandManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 8:
                        ListToBrands(brandManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 9:
                        ListToColors(colorManager);
                        AddToColor(colorManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 10:
                        ListToColors(colorManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 11:
                        AddToUser(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 12:
                        ListToUsers(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 13:
                        UpdateToUser(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 14:
                        DeleteToUser(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 15:
                        ListToUsers(userManager);
                        Console.WriteLine();
                        AddToCustomer(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 16:
                        ListToCustomers(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 17:
                        ListToUsers(userManager);
                        Console.WriteLine();
                        ListToCustomers(customerManager);
                        Console.WriteLine();
                        UpdateToCustomer(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 18:
                        ListToCustomers(customerManager);
                        Console.WriteLine();
                        DeleteToCustomer(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 19:
                        ListToCars(carManager);
                        ListToCustomerDetails(customerManager);
                        Console.WriteLine();
                        AddToRental(rentalManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 20:
                        ListToRentalDetails(rentalManager);
                        Console.WriteLine();
                        UpdateToRentalReturnDate(rentalManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 21:
                        ListToRentalDetails(rentalManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim !!!");
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 99:
                        _loop = false;
                        break;
                }
            } while (_loop);


        }

        #region ANA MENÜ
        private static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine(String.Format(@" _________________________________________ ANA MENÜ ___________________________________________________"));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 1 ] - Araç Ekleme", "[ 11] - Kullanıcı Ekleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 2 ] - Araç Listeleme - <Tamamı>", "[ 12] - Kullanıcı Listeleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 3 ] - Araç Listeleme - <Markasına Göre>", "[ 13] - Kullanıcı Güncelleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 4 ] - Araç Listeleme - <Rengine Göre>", "[ 14] - Kullanıcı Silme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 5 ] - Araç Güncelleme", "[ 15] - Müşteri Ekleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 6 ] - Araç Silme", "[ 16] - Müşteri Listeleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 7 ] - Marka Ekleme", "[ 17] - Müşteri Güncelleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 8 ] - Marka Listeleme", "[ 18] - Müşteri Silme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 9 ] - Renk Ekleme", "[ 19] - Araç Kirala"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 10] - Renk Listeleme", "[ 20] - Araç Kiralama Güncelle"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", "", "[ 21] - Araç Kiralama Listesi"));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "[ 99] - ÇIKIŞ", ""));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format(@"|______________________________________________________________________________________________________|"));
        }
        #endregion

        #region PROJE ANA LOGOSU
        private static void ProjectLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                    ___    __    ___      ___   ____  _  _  ____   __    _ ");
            Console.WriteLine(@"                   / __)  /__\  ( _ \    ( _ \ ( ___)( \( )(_  _) /__\  ( ) ");
            Console.WriteLine(@"                  ( (__  /(__)\  )  /     )  /  )__)  ) (    )(  /(__)\  )(__ ");
            Console.WriteLine(@"                   \___)(__)(__)(_)\_)   (_)\_)(____)(_)\_) (__)(__)(__)(____)");
            Console.WriteLine();
            Console.ResetColor();
        }
        #endregion

        #region KULLANICI İŞLEMLERİ
        private static void DeleteToUser(UserManager userManager)
        {
            int _deleteUserId;
            ListToUsers(userManager);
            Console.WriteLine();

            Console.Write("Silmek istediğiniz Kayıt ID : ");
            _deleteUserId = Convert.ToInt32(Console.ReadLine());

            User deleteUser = new User { Id = _deleteUserId };

            var result = userManager.Delete(deleteUser);
            Console.WriteLine(result.Message);
        }

        private static void UpdateToUser(UserManager userManager)
        {
            string _firstName, _lastName, _email, _password;
            int _updateUserId;

            ListToUsers(userManager);
            Console.WriteLine();

            Console.Write("Güncellenecek UserID : ");
            _updateUserId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adı          :");
            _firstName = Console.ReadLine();
            Console.Write("Soyadı       :");
            _lastName = Console.ReadLine();
            Console.Write("Email        :");
            _email = Console.ReadLine();
            Console.Write("Şifre        :");
            _password = Console.ReadLine();

            User user = new User
            {
                Id = _updateUserId,
                FirstName = _firstName,
                LastName = _lastName,
                Email = _email,
                Password = _password
            };

            var result = userManager.Update(user);
            Console.WriteLine(result.Message);
        }

        private static void ListToUsers(UserManager userManager)
        {
            var result = userManager.GetAll();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-20}| {2,-20}| {3,-25}|", "ID", "AD", "SOYAD", "EMAIL"));
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var user in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-20}| {2,-20}| {3,-25}|", user.Id, user.FirstName, user.LastName, user.Email));
            }
            Console.WriteLine("-------------------------------------------------------------------------------");

        }

        private static void AddToUser(UserManager userManager)
        {
            string _firstName, _lastName, _email, _password;

            Console.Write("Kullanıcı Adı        : ");
            _firstName = Console.ReadLine();
            Console.Write("Kullanıcı Soyadı     : ");
            _lastName = Console.ReadLine();
            Console.Write("Kullanıcı Email      : ");
            _email = Console.ReadLine();
            Console.Write("Kullanıcı Şifre      : ");
            _password = Console.ReadLine();

            User user = new User
            {
                FirstName = _firstName,
                LastName = _lastName,
                Email = _email,
                Password = _password
            };

            var result = userManager.Add(user);
            Console.WriteLine(result.Message);
        }


        #endregion

        #region RENK İŞLEMLERİ
        private static void AddToColor(ColorManager colorManager)
        {
            string _colorName;
            Console.Write("\nEklemek istediğiniz yeni Renk Adı : ");
            _colorName = Console.ReadLine();

            Color color = new Color
            {
                ColorName = _colorName
            };

            var result = colorManager.Add(color);
            Console.WriteLine(result.Message);

        }
        private static void ListToColors(ColorManager colorManager)
        {
            var result = colorManager.GetAll();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", "ID", "RENK"));
            Console.WriteLine("-------------------------");

            Console.ResetColor();
            foreach (var colors in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", colors.Id, colors.ColorName));
            }
            Console.WriteLine("-------------------------");
        }
        #endregion

        #region ARAÇ İŞLEMLERİ
        private static void ListToCarsByColorId(CarManager carManager)
        {
            Console.Write("Listelemek istediğiniz Renk ID : ");
            int listColorId = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", "ID", "BRAND ID", "COLOR ID", "MODEL YEAR", "DAILY PRICE", "DESCRIPTION"));
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var car in carManager.GetAllByColorId(listColorId).Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description));
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

        private static void ListToCarsByBrandId(CarManager carManager)
        {
            Console.Write("Listelemek istediğiniz Marka ID : ");
            int listBrandId = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", "ID", "BRAND ID", "COLOR ID", "MODEL YEAR", "DAILY PRICE", "DESCRIPTION"));
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var car in carManager.GetAllByBrandId(listBrandId).Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description));
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

        private static void DeleteToCar(CarManager carManager)
        {
            ListToCars(carManager);

            int _deleteId;
            Console.WriteLine();

            Console.Write("Silmek istediğiniz Kayıt ID : ");
            _deleteId = Convert.ToInt32(Console.ReadLine());

            Car deleteCar = new Car { Id = _deleteId };

            carManager.Delete(deleteCar);
            Console.WriteLine();

            Console.WriteLine("<<< Listenin Son Hali >>>");
            ListToCars(carManager);
        }

        private static void AddToCar(CarManager carManager)
        {
            int _brandId, _colorId, _modelYear;
            decimal _dailyPrice;
            string _description;

            ListToCars(carManager);
            Console.WriteLine();

            Console.Write("Marka ID : ");
            _brandId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Renk ID : ");
            _colorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Günlük Fiyat : ");
            _dailyPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Model Yılı : ");
            _modelYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Açıklama : ");
            _description = Console.ReadLine();
            Console.WriteLine();


            Car car = new Car()
            {
                BrandId = _brandId,
                ColorId = _colorId,
                ModelYear = _modelYear,
                DailyPrice = _dailyPrice,
                Description = _description
            };

            //carManager.Add(car);
            var result = carManager.Add(car);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(result.Message);
            Console.ResetColor();
            Console.WriteLine();
            ListToCars(carManager);
        }

        private static void ListToCars(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5 }| {1,-30}| {2,-20}| {3,-15}| {4,-15}|", "ID", "CAR NAME", "BRAND NAME", "CAR COLOR", "DAILY PRICE"));
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var car in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5 }| {1,-30}| {2,-20}| {3,-15}| {4,-15}|", car.Id, car.CarName, car.BrandName, car.ColorName, car.DailyPrice));
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------");
        }

        private static void UpdateToCar(CarManager carManager)
        {
            int _updateCarId, _brandId, _colorId, _modelYear;
            decimal _dailyPrice;
            string _description;

            ListToCars(carManager);
            Console.WriteLine();

            Console.Write("Güncellemek istediğiniz Kayıt ID : ");
            _updateCarId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marka ID : ");
            _brandId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Renk ID : ");
            _colorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Günlük Fiyat : ");
            _dailyPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Model Yılı : ");
            _modelYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Açıklama : ");
            _description = Console.ReadLine();
            Console.WriteLine();

            Car updateCar = new Car
            {
                Id = _updateCarId,
                BrandId = _brandId,
                ColorId = _colorId,
                DailyPrice = _dailyPrice,
                ModelYear = _modelYear,
                Description = _description
            };

            carManager.Update(updateCar);

            Console.WriteLine("\n<<< Listenin Son Hali >>>");
            ListToCars(carManager);
        }
        #endregion

        #region MARKA İŞLEMLERİ
        private static void AddToBrand(BrandManager brandManager)
        {
            string _brandName;
            Console.Write("\nEklemek istediğiniz yeni Marka Adı : ");
            _brandName = Console.ReadLine();

            Brand brand = new Brand
            {
                BrandName = _brandName
            };

            brandManager.Add(brand);
        }
        private static void ListToBrands(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", "ID", "MARKA"));
            Console.WriteLine("-------------------------");

            Console.ResetColor();
            foreach (var brands in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", brands.Id, brands.BrandName));
            }
            Console.WriteLine("-------------------------");
        }
        #endregion

        #region MÜŞTERİ İŞLEMLERİ
        private static void ListToCustomers(CustomerManager customerManager)
        {
            var result = customerManager.GetAll();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-44}|", "ID", "USER ID", "COMPANY NAME"));
            Console.WriteLine("------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var customer in result.Data)
            {
                Console.WriteLine("| {0,-5}| {1,-10}| {2,-44}|", customer.Id, customer.UserId, customer.CompanyName);
            }
            Console.WriteLine("------------------------------------------------------------------");
        }
        private static void AddToCustomer(CustomerManager customerManager)
        {
            string _companyName;
            int _userId;
            string _nullUserId;

            Console.Write("Kullanıcı ID : ");
            _nullUserId = Console.ReadLine();

            if (_nullUserId == "" || _nullUserId == null)
            {
                Console.WriteLine("Kullanıcı ID boş geçilemez...");

            }
            else
            {
                _userId = Convert.ToInt32(_nullUserId);
                Console.Write("Şirket Adı   : ");
                _companyName = Console.ReadLine();

                Customer customer = new Customer
                {
                    UserId = _userId,
                    CompanyName = _companyName
                };
                var result = customerManager.Add(customer);
                Console.WriteLine(result.Message);
            }

        }
        private static void UpdateToCustomer(CustomerManager customerManager)
        {
            int _customerId, _userId;
            string _companyName;

            Console.Write("Güncellenecek Kayıt ID   : ");
            _customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yeni Kullanıcı ID        : ");
            _userId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yeni Şirket Adı          : ");
            _companyName = Console.ReadLine();

            Customer customer = new Customer
            {
                Id = _customerId,
                UserId = _userId,
                CompanyName = _companyName
            };

            var result = customerManager.Update(customer);
            Console.WriteLine(result.Message);
        }
        private static void DeleteToCustomer(CustomerManager customerManager)
        {
            int _deletedCustomerId;

            Console.Write("Silmek istediğiniz Kayıt ID : ");
            _deletedCustomerId = Convert.ToInt32(Console.ReadLine());

            Customer deleteCustomer = new Customer { Id = _deletedCustomerId };

            var result = customerManager.Delete(deleteCustomer);
            Console.WriteLine(result.Message);
        }
        private static void ListToCustomerDetails(CustomerManager customerManager)
        {
            var result = customerManager.GetCustomerDetails();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-15}| {1,-15}| {2,-15}| {3,-40}|", "MÜSTERİ ID", "MÜŞTERİ ADI", "MÜŞTERİ SOYADI", "ŞİRKET ADI"));
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var customer in result.Data)
            {
                Console.WriteLine("| {0,-15}| {1,-15}| {2,-15}| {3,-40}|", customer.Id, customer.FirstName, customer.LastName, customer.CompanyName);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }
        #endregion

        #region KİRALAMA İŞLEMLERİ
        private static void AddToRental(RentalManager rentalManager)
        {
            string _tempCustomer;
            int _carId, _customerId;
            DateTime _rentDate;
            //DateTime? _returnDate;

            Console.Write("Kiralaması yapacak 'Müşteri ID' : ");
            _tempCustomer = Console.ReadLine();
            if (_tempCustomer != null)
            {
                Console.Write("Kiralanacak Araç ID         : ");
                _carId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kiralama Tarihi[aa/gg/yyyy] : ");
                _rentDate = Convert.ToDateTime(Console.ReadLine());
                //_returnDate = null;
                _customerId = Convert.ToInt32(_tempCustomer);

                Rental rental = new Rental
                {
                    CarId = _carId,
                    CustomerId = _customerId,
                    RentDate = _rentDate,
                    //ReturnDate = _returnDate
                };

                var result = rentalManager.Add(rental);
                Console.WriteLine(result.Message);

            }
        }
        private static void UpdateToRentalReturnDate(RentalManager rentalManager)
        {
            int _updateRentalId;
            DateTime _returnDateUpdate;

            Console.Write("Araç iadesi yapılacak 'KIRALAMA ID' : ");
            _updateRentalId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aracın İade Tarihi [aa/gg/yyyy]     : ");
            _returnDateUpdate = Convert.ToDateTime(Console.ReadLine());

            Rental rental = new Rental
            {
                Id = _updateRentalId,
                ReturnDate = _returnDateUpdate
            };

            var result = rentalManager.UpdateReturnDate(rental);
            Console.WriteLine(result.Message);
        }
        private static void ListToRentalDetails(RentalManager rentalManager)
        {
            var result = rentalManager.GetCarRentalDetails();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-3}| {1,-20}| {2,-40}| {3,-30}| {4,-15}| {5,-12}| {6,-12}| {7,-23}| {8,-23}|", "ID", "MÜŞTERİ ADI-SOYADI", "ŞİRKET ADI", "ARAÇ", "MARKA", "RENK", "KİRA BEDELİ", "KİRA TARİHİ", "İADE TARİHİ"));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var rental in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-3}| {1,-20}| {2,-40}| {3,-30}| {4,-15}| {5,-12}| {6,-12}| {7,-23}| {8,-23}|",
                                                    rental.RentalId, rental.CustomerName + " " + rental.CustomerLastName,
                                                    rental.CustomerCompanyName, rental.CarName, rental.BrandName, rental.ColorName, rental.TotalPrice,
                                                    rental.RentDate.ToShortDateString(), rental.ReturnDate
                                                ));
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        #endregion

        private static void CustomerTest()
		{
			CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
			var result = customerManager.GetById(1);
			foreach (var customer in result.Data)
			{
				Console.WriteLine(customer.UserId + " -- " + customer.CompanyName);
			}
		}

		private static void CustomerAdd()
		{
			UserManager userManager = new UserManager(new EfUserDal());
			userManager.Add(new User { Id = 1, FirstName = "Hamza", LastName = "Kavak", Email = "hamzakavak@gmail.com", Password = "12345" });
			userManager.Add(new User { Id = 2, FirstName = "Erkam", LastName = "Kavak", Email = "erkavak@gmail.com", Password = "12345" });
			userManager.Add(new User { Id = 3, FirstName = "Mustafa", LastName = "Kavak", Email = "mstfkavak@gmail.com", Password = "123" });
			userManager.Add(new User { Id = 4, FirstName = "Mert", LastName = "Yalın", Email = "mrtYalin@gmail.com", Password = "12345" });
			userManager.Add(new User { Id = 5, FirstName = "Samet", LastName = "Sızı", Email = "sizisamet@gmail.com", Password = "12345" });


			CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
			customerManager.Add(new Customer { UserId = 1, CompanyName = "MalMülk İnşaat" });
			customerManager.Add(new Customer { UserId = 2, CompanyName = "Shady Records" });
			customerManager.Add(new Customer { UserId = 3, CompanyName = "İnterscope Records" });
			customerManager.Add(new Customer { UserId = 4, CompanyName = "Merch" });
			customerManager.Add(new Customer { UserId = 5, CompanyName = "Glipotions A.Ş" });
		}

		private static void CarDetailsList()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetCarDetails();
			if (result.Success)
			{
				foreach (var car in result.Data)
				{
					Console.WriteLine("{0}--{1}--{2}--{3}--{4}", car.Id, car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
				}
			}
		}

		private static void CarGetAll()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetAll();
			if (result.Success)
			{
				foreach (var car in result.Data)
				{
					Console.WriteLine("{0}--{1}--{2}", car.CarName, car.DailyPrice, car.ModelYear);
				}
			}
			else
			{
				Console.WriteLine(result.Message);
			}

		}

		private static void carGetByBrandId(int id)
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetAllByBrandId(id);
			if (result.Success)
			{
				foreach (var car in result.Data)
				{
					//Console.WriteLine();
					Console.WriteLine("{0}--{1}--{2}", car.CarName, car.DailyPrice, car.ModelYear);
				}
			}

		}

		private static void BrandAddToDb()
		{
			BrandManager brandManager = new BrandManager(new EfBrandDal());
			brandManager.Add(new Brand { Id = 1, BrandName = "Mercedes" });
			brandManager.Add(new Brand { Id = 2, BrandName = "Bmw" });
			brandManager.Add(new Brand { Id = 3, BrandName = "Volkswagen" });
			brandManager.Add(new Brand { Id = 4, BrandName = "Ford" });
			brandManager.Add(new Brand { Id = 5, BrandName = "Skoda" });
		}

		private static void ColorAddToDb()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			colorManager.Add(new Color { Id = 1, ColorName = "Siyah" });
			colorManager.Add(new Color { Id = 2, ColorName = "Kırmızı" });
			colorManager.Add(new Color { Id = 3, ColorName = "Gri" });
			colorManager.Add(new Color { Id = 4, ColorName = "Beyaz" });
		}

		private static void CarAddToDb()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			//carManager.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, CarName = "Benz", DailyPrice = 220000, Description = "Sport Car", ModelYear = 2019 });
			//carManager.Add(new Car { Id = 2, BrandId = 1, ColorId = 4, CarName = "4-matic", DailyPrice = 250000, Description = "Sport Car", ModelYear = 2020 });
			//carManager.Add(new Car { Id = 3, BrandId = 2, ColorId = 2, CarName = "M3", DailyPrice = 200000, Description = "Hatchback", ModelYear = 2015 });
			//carManager.Add(new Car { Id = 4, BrandId = 3, ColorId = 1, CarName = "Passat", DailyPrice = 130000, Description = "Sedan", ModelYear = 2016 });
			//carManager.Add(new Car { Id = 5, BrandId = 5, ColorId = 3, CarName = "Süper-B", DailyPrice = 120000, Description = "Hatchback", ModelYear = 2015 });
			
			carManager.Add(new Car { Id = 6, BrandId = 5, ColorId = 3, CarName = "B", DailyPrice = 120000, Description = "Hatchback", ModelYear = 2015 });
			carManager.Add(new Car { Id = 7, BrandId = 5, ColorId = 3, CarName = "3", Description = "Hatchback", ModelYear = 2015 });
		}
	}
}
