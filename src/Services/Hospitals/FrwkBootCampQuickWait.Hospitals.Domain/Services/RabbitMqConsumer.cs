using FrwkBootCampQuickWait.Hospitals.Domain.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace FrwkBootCampQuickWait.Hospitals.Domain.Services
{
    public abstract class RabbitMqConsumer
    {
        private readonly ConnectionFactory _connectionFactory;
        private readonly IConnection _connection;
        private readonly IModel _channel;
        public string ContextQueue { get; }

        protected RabbitMqConsumer(RabbitSettings rabbitSettings)
        {
            _connectionFactory = new ConnectionFactory() { HostName = rabbitSettings.Host };
            _connection = _connectionFactory.CreateConnection();
            _channel = _connection.CreateModel();
        }

        public async Task ConsumeAsync(string topicName, string queueName)
        {
            _channel.QueueBind(queue: $"{queueName}",
                                  exchange: $"{ContextQueue}.{topicName}",
                                  routingKey: "");

            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var routingKey = ea.RoutingKey;
            };

            _channel.BasicConsume(queue: queueName,
                                 autoAck: true,
                                 consumer: consumer);

            await Task.CompletedTask;
        }
    }
}
