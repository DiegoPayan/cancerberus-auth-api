using System.Collections.Generic;
using IdentityServer4.Models;

namespace cancerberus
{
  public static class Config
  {
    public static IEnumerable<ApiResource> GetApiResources()
    {
      return new List<ApiResource> {
        new ApiResource("meSafeApi", "Api de datos de meSafe")
      };
    }
    public static IEnumerable<Client> GetClients()
    {
      return new List<Client> {
        new Client {
          ClientId = "meSafeApp",
          AllowedGrantTypes = GrantTypes.ClientCredentials,
          ClientSecrets = {
            new Secret("SuperSecretMeSafeApiPassword".Sha256())
          },
          AllowedScopes = {"meSafeApi"},
        }
      };
    }
  }
}