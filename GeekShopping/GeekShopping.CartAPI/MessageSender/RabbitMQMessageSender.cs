﻿using GeekShopping.CartAPI.Messages;
using GeekShopping.MessageBus;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace GeekShopping.CartAPI.MessageSender
{
    public class RabbitMQMessageSender : IRabbitMQMessageSender
    {
        private readonly string _hostName;
        private readonly string _password;
        private readonly string _userName;
        private IConnection _connection;

        public RabbitMQMessageSender()
        {
            _hostName = "localhost";
            _password = "guest";
            _userName = "guest";
        }

        public void SendMessage(BaseMessage message, string queueName)
        {
            try {
                if(ConnectionExists()) {
                    using var channel = _connection.CreateModel();
                    channel.QueueDeclare(queue: queueName, false, false, false, arguments: null);
                    byte[] body = GetMessageAsByteArray(message);
                    channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
                }
            } catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void CreateConnection()
        {
            try {
                var factory = new ConnectionFactory {
                    HostName = _hostName,
                    UserName = _userName,
                    Password = _password
                };
                _connection = factory.CreateConnection();
            } catch(Exception) {

            }
        }

        private bool ConnectionExists()
        {
            if (_connection != null) return true;
            CreateConnection();
            return false;
        }

        private byte[] GetMessageAsByteArray(BaseMessage message)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize<CheckoutHeaderDTO>((CheckoutHeaderDTO)message, options);
            return Encoding.UTF8.GetBytes(json);
        }
    }
}