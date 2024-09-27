﻿using GeekShopping.MessageBus;

namespace GeekShopping.PaymentAPI.MessageSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage baseMessage, string queueName);
    }
}