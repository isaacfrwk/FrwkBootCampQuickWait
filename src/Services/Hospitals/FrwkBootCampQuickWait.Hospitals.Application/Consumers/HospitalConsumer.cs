using FrwkBootCampQuickWait.Hospitals.Domain.Configuration;
using FrwkBootCampQuickWait.Hospitals.Domain.Services;
using Microsoft.Extensions.Hosting;

namespace FrwkBootCampQuickWait.Hospitals.Application.Consumers
{
    public sealed class HospitalConsumer : RabbitMqConsumer, IHostedService
    {
        protected override string ContextQueue => "hospital";
        
        public HospitalConsumer(RabbitSettings rabbitSettings) : base(rabbitSettings)
        {
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await ConsumeAsync("add", "add.new");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
