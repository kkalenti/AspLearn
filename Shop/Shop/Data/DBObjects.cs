using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System.Linq;

namespace Shop.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContent content)
        {

            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Cars.Any())
            {
                content.Cars.AddRange(Cars.Select(c => c.Value));
            }

            content.SaveChanges();
        }

        

        private static Dictionary<string, Category> _category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Электромобили", Description = "Современный вид транспорта"},
                        new Category
                        {
                            CategoryName = "Классические автомобили",
                            Description = "Машины с двигателем внутреннего сгорания"
                        }
                    };

                    _category = new Dictionary<string, Category>();

                    foreach (var element in list)
                    {
                        _category.Add(element.CategoryName, element);
                    }

                }
                return _category;
            }
        }

        private static Dictionary<string, Car> _car;

        public static Dictionary<string, Car> Cars
        {
            get
            {
                if (_car == null)
                {
                    var list = new Car[]
                    {
                         new Car {
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        FullDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "/img/Tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/Ford.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий и стильный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/BMW.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "Mercedes C class",
                        ShortDescription = "Уютный и большой",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/Mersedes.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        IsAvailable = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        FullDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/Nissan.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Электромобили"]
                    }
                    };

                    _car = new Dictionary<string, Car>();

                    foreach (var element in list)
                    {
                        _car.Add(element.Name, element);
                    }

                }
                return _car;
            }
        }
    }
}