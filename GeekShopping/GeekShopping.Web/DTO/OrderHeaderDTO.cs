﻿namespace GeekShopping.Web.DTO
{
    public class OrderHeaderDTO
    {
        public long Id { get; set; }

        public string UserId { get; set; }

        public string CouponCode { get; set; }

        public decimal PurchaseAmount { get; set; }

        public decimal DiscountAmount { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime OrderTime { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string CardNumber { get; set; }

        public string CVV { get; set; }

        public string ExpireDate { get; set; }

        public int CartTotalItems { get; set; }

        public bool PaymentStatus { get; set; }

        public List<OrderDetailDTO> OrderDetails { get; set; }
    }
}