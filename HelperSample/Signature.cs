using System.Web.Helpers;

namespace HelperSample
{
    public class Signature
    {
        public static string Get(string token)
        {
            return Crypto.SHA1(token);
        }
    }
}
