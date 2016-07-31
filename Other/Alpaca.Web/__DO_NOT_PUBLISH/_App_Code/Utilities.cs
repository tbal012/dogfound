using System.Net;

public static class Utilities
{
    public static bool isValidIP(string ip)
    {
        IPAddress ot;
        bool valid = false;
        if (string.IsNullOrEmpty(ip)){
            valid = false;
        }
        else{
            valid = IPAddress.TryParse(ip, out ot);
        }
        return valid;
    }


}

public class Users
{
    public string Email { get; set; }
    public string UserName { get; set; }
    public string DisplayName { get; set; }
    public bool isMapped { get; set; }
}