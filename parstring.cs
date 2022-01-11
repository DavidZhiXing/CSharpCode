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

// take a element from the array and return the new array
public static T[] GetElement<T>(T[] array, int index)
{
    var newArray = new T[array.Length - 1];
    for (int i = 0; i < array.Length; i++)
    {
        if (i < index)
        {
            newArray[i] = array[i];
        }
        else if (i > index)
        {
            newArray[i - 1] = array[i];
        }
    }
    return newArray;
}

// take a element from the array and return the new array via linq
public static T[] GetElement<T>(T[] array, int index)
{
    return array.Where((x, i) => i != index).ToArray();
}

// given a T array, return a new array with random elements
public static T[] GetRandomElements<T>(T[] array)
{
    var newArray = new T[array.Length];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        var randomIndex = random.Next(0, array.Length);
        newArray[i] = array[randomIndex];
    }
    return newArray;
}

// given a  sequence T array, return a new array with random sequence via linq
public static T[] GetRandomElements<T>(T[] array)
{
    return array.OrderBy(x => Guid.NewGuid()).ToArray();
}
