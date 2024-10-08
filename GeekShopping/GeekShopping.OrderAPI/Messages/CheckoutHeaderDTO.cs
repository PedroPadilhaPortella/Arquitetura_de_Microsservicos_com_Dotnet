﻿using GeekShopping.MessageBus;
using GeekShopping.OrderAPI.DTO;

namespace GeekShopping.OrderAPI.Messages
{
    public class CheckoutHeaderDTO: BaseMessage
    {
        public string UserId { get; set; }
        public string CouponCode { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpireDate { get; set; }
        public int CartTotalItems { get; set; }
        public IEnumerable<CartDetailDTO> CartDetails { get; set; }
    }
}
