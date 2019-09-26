using System.Collections;
using System.Collections.Generic;
using Shop.Models;

namespace Shop.Interfaces
{
    public interface ICars
    {
        /// <summary>
        /// Все автомобили
        /// </summary>
        IEnumerable<Car> AllCars { get; set; }

        /// <summary>
        /// Все избранные автомобили
        /// </summary>
        IEnumerable<Car> FavouriteCars { get; set; }

        /// <summary>
        /// Возвращает объект автомобиля по его Id
        /// </summary>
        /// <param name="carId">Id автомобиля</param>
        /// <returns>Объект автомобиль</returns>
        Car GetCar(int carId);
    }
}