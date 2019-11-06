using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.Data.Models
{
    /// <summary>
    /// Класс для заказов
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id заказа
        /// </summary>
        [BindNever]
        public int Id { get; set; }

        /// <summary>
        /// Имя заказчика
        /// </summary>
        [Display(Name = "Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия заказчика
        /// </summary>
        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Введите фамилию")]
        public string Surname { get; set; }

        /// <summary>
        /// Адресс заказчика
        /// </summary>
        [Display(Name = "Введите адресс")]
        [StringLength(50, MinimumLength = 10, ErrorMessage =
            "Длинна строки должна быть более 10 и менее 50 символов")]
        [Required(ErrorMessage = "Введите адресс")]
        public string Address { get; set; }

        /// <summary>
        /// Номер телефона заказчика
        /// </summary>
        [Display(Name = "Введите номер телефона")]
        [StringLength(13, MinimumLength = 10, ErrorMessage =
            "Длинна должна быть более 10 и менее 13 символов")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Введите номер телефона")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Электронная почта заказчика
        /// </summary>
        [Display(Name = "Введите почтовый ящик")]
        [StringLength(20, MinimumLength = 5, ErrorMessage =
            "Длинна должна быть более 5 и менее 20 символов")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Введите почтовый ящик")]
        public string Email { get; set; }

        /// <summary>
        /// Время заказа
        /// </summary>
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// Детали заказа
        /// </summary>
        public List<OrderDetail> OrderDetails { get; set; }
    }
}