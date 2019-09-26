using System.Collections.Generic;
using System.Linq;
using Shop.Interfaces;
using Shop.Models;

namespace Shop.Mocks
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
                    new Car
                    {
                        Name = "Tesla",
                        ShortDescription = "",
                        FullDescription = "",
                        Image = "",
                        Price = 4500,
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