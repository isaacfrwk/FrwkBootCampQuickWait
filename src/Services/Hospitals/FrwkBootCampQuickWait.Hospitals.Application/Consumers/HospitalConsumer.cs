using FrwkBootCampQuickWait.Hospitals.Domain.Configuration;
using FrwkBootCampQuickWait.Hospitals.Domain.Services;

namespace FrwkBootCampQuickWait.Hospitals.Application.Consumers
{
    public sealed class HospitalConsumer : RabbitMqConsumer
    {
        public HospitalConsumer(RabbitSettings rabbitSettings) : base(rabbitSettings)
        {
        }
    }
}
