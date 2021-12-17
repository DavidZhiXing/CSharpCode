// Convert double type to string type with three decimal places
public class double_to_string {
    public static void Main() {
        double d = 123.456789;
        string s = d.ToString("0.000");
        Console.WriteLine(s);
    }
}

// md5 endcode

public static string MD5(string str)
{
    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
    bytes = md5.ComputeHash(bytes);
    md5.Clear();
    string ret = "";
    for (int i = 0; i < bytes.Length; i++)
    {
        ret += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
    }
    return ret.PadLeft(32, '0');
}

