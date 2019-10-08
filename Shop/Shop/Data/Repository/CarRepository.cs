using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDbContent _dbContent;

        public CarRepository(AppDbContent appDbContent)
        {
            _dbContent = appDbContent;
        }

        public IEnumerable<Car> AllCars => _dbContent.Cars.Include(c => c.Category);

        public IEnumerable<Car> FavoriteCars => _dbContent.Cars.Where(p => p.IsFavourite).
            Include(c => c.Category);

        public Car GetCar(int carId) => _dbContent.Cars.FirstOrDefault(p => p.Id == carId);
    }
}