using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDbContext _dbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IEnumerable<Car> AllCars => _dbContext.Cars.Include(c => c.Category);

        public IEnumerable<Car> FavoriteCars => _dbContext.Cars.Where(p => p.IsFavourite).
            Include(c => c.Category);

        public Car GetCar(int carId) => _dbContext.Cars.FirstOrDefault(p => p.Id == carId);
    }
}