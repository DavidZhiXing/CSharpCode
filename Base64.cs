// Base64 Encode a string

public static class Base64
{
    public static string Encode(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    public static string Decode(string base64EncodedData)
    {
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }

    // Example
    public static void Main()
    {
        var plainText = "2.0.0";
        var base64Encoded = Base64.Encode(plainText);
        var base64Decoded = Base64.Decode(base64Encoded);
        System.Console.WriteLine(base64Encoded);
        System.Console.WriteLine(base64Decoded);

    }
}