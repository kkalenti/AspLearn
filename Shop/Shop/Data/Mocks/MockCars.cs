using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : ICars
    {
        private readonly ICarsCategory _category = new MockCategory();

        public IEnumerable<Car> AllCars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        FullDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "https://www.tesla.com/content/dam/tesla-site/sx-redesign/Image/socialcard/MS.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _category.AllCategories.First()
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "https://www.winnerauto.ua/uploads/gallery_photo/photo/0170/91.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = _category.AllCategories.Last()
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий и стильный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "https://Image.tipcars.com/fotky_velke/33550669_9/2018/E/bmw-m3-top-m-performance-paket.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _category.AllCategories.Last()
                    },
                    new Car {
                        Name = "Mercedes C class",
                        ShortDescription = "Уютный и большой",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "https://0b38966e54e8bebf4a9b-c91cf87d0ed24f4939ca44173a86a2bc.ssl.cf1.rackcdn.com/55SWF8EBXKU284256/486f758369faedbf248aba14b75f9151.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        IsAvailable = false,
                        Category = _category.AllCategories.Last()
                    },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "https://d2t6ms4cjod3h9.cloudfront.net/wp-content/uploads/2018/11/LEAF_Nissan_Energy_Share-source.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _category.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Car> FavouriteCars { get; set; }

        public Car GetCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}