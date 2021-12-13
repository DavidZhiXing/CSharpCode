// Convert double type to string type with three decimal places
public class double_to_string {
    public static void Main() {
        double d = 123.456789;
        string s = d.ToString("0.000");
        Console.WriteLine(s);
    }
}

