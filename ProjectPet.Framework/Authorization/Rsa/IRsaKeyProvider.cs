using System.Security.Cryptography;

namespace ProjectPet.Framework.Authorization.Rsa;
public interface IRsaKeyProvider
{
    RSA GetPrivateRsa();
    RSA GetPublicRsa();
}
