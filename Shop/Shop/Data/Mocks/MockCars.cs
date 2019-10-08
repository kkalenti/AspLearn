using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    /// <summary>
    /// Заглушка для автомобилей
    /// </summary>
    public class MockCars : ICars
    {
        private readonly ICarsCategory _category = new MockCategory();

        /// <summary>
        /// Инициализируем список автомобилей
        /// </summary>
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
                        Image = "/img/Tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _category.AllCategories.First()
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/Ford.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = _category.AllCategories.Last()
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий и стильный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/BMW.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _category.AllCategories.Last()
                    },
                    new Car {
                        Name = "Mercedes C class",
                        ShortDescription = "Уютный и большой",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/Mersedes.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        IsAvailable = false,
                        Category = _category.AllCategories.Last()
                    },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/Nissan.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _category.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Car> FavoriteCars { get; set; }

        public Car GetCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}