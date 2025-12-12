namespace ProjectBackend.Domain.Contracts
{
    public class JwtSettings
    {
        public string ? Key { get; set; }
        public string ValidIssuer { get; set; }
        public string ValidAudince { get; set; }
        public double Expires { get; set; }
        public string? ValidAudience { get; internal set; }
    }
}
