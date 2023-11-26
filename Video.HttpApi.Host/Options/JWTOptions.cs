namespace Video.HttpApi.Host.Options
{
    public class JWTOptions
    {

        public string SecretKey { get; set; } = null!;
        public string Issuer { get; set; } = null!;
        public string Audience { get; set; } = null!;
        public int ExpireMinutes { get; set; }


    }
}
