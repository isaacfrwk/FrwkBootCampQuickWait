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
        private readonly RabbitSettings _rabbitSettings;
        protected abstract string ContextQueue { get;}

        protected RabbitMqConsumer(RabbitSettings rabbitSettings)
        {
            _connectionFactory = new ConnectionFactory() { HostName = rabbitSettings.Host};
            _connection = _connectionFactory.CreateConnection();
            _channel = _connection.CreateModel();
            _rabbitSettings = rabbitSettings;
        }

        public async Task ConsumeAsync(string topicName, string queueName)
        {
            var queue = $"{_rabbitSettings.Queue}.{ContextQueue}.{queueName}";
            var topic = $"{_rabbitSettings.Queue}.{ContextQueue}.{topicName}";

            _channel.QueueDeclare(queue, true, false, false);
            _channel.ExchangeDeclare(topic, "topic", true, false);

            _channel.QueueBind(queue: queue,
                                  exchange: topic,
                                  routingKey: "");

            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var routingKey = ea.RoutingKey;
            };

            _channel.BasicConsume(queue: queue,
                                 autoAck: true,
                                 consumer: consumer);

            await Task.CompletedTask;
        }
    }
}
