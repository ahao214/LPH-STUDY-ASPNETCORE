using IdentityServer4.Models;



namespace Sample.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScopes = new[]
        {
            new ApiScope
            {
                Name ="sample_api",
                DisplayName="Sample API"
            },
        };


        public static IEnumerable<Client> Clients = new[]
        {
            new Client
            {
                ClientId="sample_client",
                ClientSecrets =
                {
                    new Secret("sample_client_secret".Sha256())
                },
                AllowedGrantTypes= GrantTypes.ClientCredentials,
                AllowedScopes={"sample_api"}
            },
        };

    }
}
