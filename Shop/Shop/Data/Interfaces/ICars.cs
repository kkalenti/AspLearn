using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface ICars
    {
        /// <summary>
        /// Все автомобили
        /// </summary>
        IEnumerable<Car> AllCars { get;/* set;*/ }

        /// <summary>
        /// Все избранные автомобили
        /// </summary>
        IEnumerable<Car> FavoriteCars { get; /*set;*/ }

        /// <summary>
        /// Возвращает объект автомобиля по его Id
        /// </summary>
        /// <param name="carId">Id автомобиля</param>
        /// <returns>Объект автомобиль</returns>
        Car GetCar(int carId);
    }
}