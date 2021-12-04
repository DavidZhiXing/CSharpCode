// example:
//  hello [name] [lastname] how are you? [firstTime] this is your first time? [/firstTime]
//  if the firstTime is true, then the message between the [firstTime] and [/firstTime] will be shown
//  if the firstTime is false, then the message between the [firstTime] will hide.

public static void TestParseString()
{
    string str = "hello [name] [lastname] how are you? [firstTime] this is your first time? [/firstTime]";
    var firstLogin = false;
    var name = "John";
    var lastname = "Doe";
    var message = str.Replace("[name]", name).Replace("[lastname]", lastname);
    if (firstLogin)
    {
        message = Regex.Replace(message, @"\[firstTime\](.*?)\[/firstTime\]", "$1");
    }
    else
    {
        message = Regex.Replace(message, @"\[firstTime\].*?\[/firstTime\]", "");
    }
    Console.WriteLine(message);
}