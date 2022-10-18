using System.Configuration;

namespace _SocialNetwork;

public class Helper
{
    public static string CnnVal() => ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
}