using System;

namespace Rent_A_Car_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            UserLogin user1 = new UserLogin();
            user1.UserName = "Bilal";
            user1.UserPassword = 416141;

            Cars car1 = new Cars();
            car1.CarName = "Opel Astra";
            car1.CarProductionYear = 2013;
            car1.CarGearType = "Automatic";
            car1.CarFuel = "Diesel";
            car1.CarPrice = 200;

            Cars car2 = new Cars();
            car2.CarName = "Citroen C5";
            car2.CarProductionYear = 2008;
            car2.CarGearType = "Manual";
            car2.CarFuel = "Diesel";
            car2.CarPrice = 150;

            Cars car3 = new Cars();
            car3.CarName = "Volkswagen";
            car3.CarProductionYear = 2016;
            car3.CarGearType = "Passat";
            car3.CarFuel = "Gasoline";
            car3.CarPrice = 400;

            Cars[] cars = new Cars[] { car1, car2, car3 };
            UserLogin[] users = new UserLogin[] { user1 };


            int returnValue = CheckPassword(user1.UserName, user1.UserPassword);

            if (returnValue == 1)
            {
                foreach (Cars carsList in cars)
                {
                    Console.WriteLine("Araba'nın Markası : " + carsList.CarName + "Araba'nın Modeli : " + carsList.CarGearType +
                        "Araba'nın Üretim Yılı : " + carsList.CarProductionYear + " Araba'nın Yakıt Tipi : " + carsList.CarFuel + "Araba'nın Fiyatı : " + carsList.CarPrice);
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifreniz yanlış");
            }
        }

        class Cars
        {
            public string CarName { get; set; }
            public string CarFuel { get; set; }
            public string CarGearType { get; set; }
            public int CarProductionYear { get; set; }
            public int CarPrice { get; set; }
        }

        class UserLogin
        {
            public string UserName { get; set; }
            public int UserPassword { get; set; }
        }

        public static int CheckPassword(string userName, int userPassword)
        {
            if (userName == "Bilal" && userPassword == 416141)
            {
                return (1);
            }
            else
            {
                return 0;
            }

        }
    }
}
