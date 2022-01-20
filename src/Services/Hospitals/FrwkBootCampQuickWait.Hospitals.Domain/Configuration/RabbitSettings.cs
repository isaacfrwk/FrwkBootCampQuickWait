namespace FrwkBootCampQuickWait.Hospitals.Domain.Configuration
{
    public sealed class RabbitSettings : Settings
    {
        public string Host { get; set; }
        public string Queue { get; set; }
    }
}
