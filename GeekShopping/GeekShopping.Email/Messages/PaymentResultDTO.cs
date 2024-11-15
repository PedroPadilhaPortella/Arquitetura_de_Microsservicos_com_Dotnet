﻿using GeekShopping.MessageBus;

namespace GeekShopping.Email.Messages
{
    public class PaymentResultDTO: BaseMessage
    {
        public long OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}