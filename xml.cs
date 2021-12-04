public static partial class XML
{
    
    // example.xml
    // <?xml version="1.0" encoding="utf-8"?>
    // <Project ID="1">
    //     <Name>Test</Name>
    //     <Start>100</Start>
    //     <End>200</End>
    // </Project>

    // find all tag name "Project" and Name="Test"
    // retrive start and end value
    public static void Test()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("example.xml");
        var projects = doc.Descendants("Project").Where(p => p.Element("Name").Value == "Test");
        foreach (var project in projects)
        {
            Console.WriteLine(project.Attribute("Start").Value);
            Console.WriteLine(project.Attribute("End").Value);
        }
    }
}