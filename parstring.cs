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

// exmaple:
//   how are you? /happy 
//   /happy will replace the happy emoji with a smiley face icon
//   /sad will replace the happy emoji with a sad face icon

public static void TestParseEmoji()
{
    string str = "how are you? /happy";
    var message = str.Replace("/happy", ":)");
    message = message.Replace("/sad", ":(");
    Console.WriteLine(message);
}

public static string CovertTagToEmojiFilePath(string tag)
{
    var emojiFilePath = 
    tag = Regex.Replace(tag, @"\[(.*?)\]", "");
    return 
}