using System;
using System.Collections.Generic;

namespace WebStore.Domain.DTO.Orders
{
    /// <summary>Заказ</summary>
    public class OrderDTO
    {
        /// <summary>Идентификатор</summary>
        public int Id { get; set; }
        /// <summary>Наименование</summary>
        public string Name { get; set; }
        /// <summary>Телефонный номер</summary>
        public string Phone { get; set; }
        /// <summary>Адрес заказа</summary>
        public string Address { get; set; }
        /// <summary>Дата формирования заказа</summary>
        public DateTime Date { get; set; }
        /// <summary>Пункты заказа</summary>
        public IEnumerable<OrderItemDTO> Items { get; set; }
    }
}
