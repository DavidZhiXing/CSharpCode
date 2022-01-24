public class Xml2Csharp
{
    /// <summary>
    /// Convert an xml file to a csharp class file.
    /// </summary>

    public static void Convert(string xmlFile, string csharpFile)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(xmlFile);

        XmlNode root = doc.DocumentElement;

        string className = root.Attributes["name"].Value;

        string namespaceName = root.Attributes["namespace"].Value;

        string classText = "";

        classText += "namespace " + namespaceName + "\n";
        classText += "{\n";
        classText += "    public class " + className + "\n";
        classText += "    {\n";

        foreach (XmlNode node in root.ChildNodes)
        {
            if (node.Name == "property")
            {
                string propertyName = node.Attributes["name"].Value;
                string propertyType = node.Attributes["type"].Value;

                classText += "        public " + propertyType + " " + propertyName + ";\n";
            }
        }

        classText += "    }\n";
        classText += "}\n";

        File.WriteAllText(csharpFile, classText);
    }

    public static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: xml2csharp.exe <xml file> <csharp file>");
            return;
        }

        Convert(args[0], args[1]);
    }

    /// <summary>
    /// Convert an json string to a csharp class file.
    /// </summary>

    public static void ConvertJson(string jsonString, string csharpFile)
    {
        JsonData json = JsonMapper.ToObject(jsonString);

        string className = json["name"].ToString();

        string namespaceName = json["namespace"].ToString();

        string classText = "";

        classText += "namespace " + namespaceName + "\n";
        classText += "{\n";
        classText += "    public class " + className + "\n";
        classText += "    {\n";

        foreach (JsonData node in json["properties"])
        {
            string propertyName = node["name"].ToString();
            string propertyType = node["type"].ToString();

            classText += "        public " + propertyType + " " + propertyName + ";\n";
        }

        classText += "    }\n";
        classText += "}\n";

        File.WriteAllText(csharpFile, classText);
    }

    /// <summary>
    /// Convert an xml string to a csharp class file.
    /// </summary>
    
    // example: xml string :
    
//     <?xml version="1.0" encoding="UTF-8"?>
// <realestates>
// <externalId>100011</externalId>
// <ttitle>RestAPI - Immobilienscout24 Testobjekt! +++BITTE+++ NICHT kontaktieren - Industry</ttitle>
// <creationDate>2013-12-06T15:12:09</creationDate>
// <lastModificationDate>2014-07-08T15:12:09</lastModificationDate>
// <thermalCharacteristic>32.678</thermalCharacteristic>
// <energyConsumptionContainsWarmWater>YES</energyConsumptionContainsWarmWater>
// <buildingEnergyRatingType>ENERGY_CONSUMPTION</buildingEnergyRatingType>
// <additionalArea>435.017</additionalArea>
// <numberOfFloors>three</numberOfFloors>
// <additionalCosts>
// <value>249.014</value>
// <currency>EUR</currency>
// <marketingType>RENT</marketingType>
// <priceIntervalType>MONTH</priceIntervalType>
// </additionalCosts>
// </realestates>

// example: csharp class :

// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Realestates));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Realestates)serializer.Deserialize(reader);
// }

// [XmlRoot(ElementName="additionalCosts")]
// public class AdditionalCosts { 

// 	[XmlElement(ElementName="value")] 
// 	public double Value { get; set; } 

// 	[XmlElement(ElementName="currency")] 
// 	public string Currency { get; set; } 

// 	[XmlElement(ElementName="marketingType")] 
// 	public string MarketingType { get; set; } 

// 	[XmlElement(ElementName="priceIntervalType")] 
// 	public string PriceIntervalType { get; set; } 
// }

// [XmlRoot(ElementName="realestates")]
// public class Realestates { 

// 	[XmlElement(ElementName="externalId")] 
// 	public int ExternalId { get; set; } 

// 	[XmlElement(ElementName="ttitle")] 
// 	public string Ttitle { get; set; } 

// 	[XmlElement(ElementName="creationDate")] 
// 	public DateTime CreationDate { get; set; } 

// 	[XmlElement(ElementName="lastModificationDate")] 
// 	public DateTime LastModificationDate { get; set; } 

// 	[XmlElement(ElementName="thermalCharacteristic")] 
// 	public double ThermalCharacteristic { get; set; } 

// 	[XmlElement(ElementName="energyConsumptionContainsWarmWater")] 
// 	public string EnergyConsumptionContainsWarmWater { get; set; } 

// 	[XmlElement(ElementName="buildingEnergyRatingType")] 
// 	public string BuildingEnergyRatingType { get; set; } 

// 	[XmlElement(ElementName="additionalArea")] 
// 	public double AdditionalArea { get; set; } 

// 	[XmlElement(ElementName="numberOfFloors")] 
// 	public string NumberOfFloors { get; set; } 

// 	[XmlElement(ElementName="additionalCosts")] 
// 	public AdditionalCosts AdditionalCosts { get; set; } 
// }

    public static void ConvertXml(string xmlString, string csharpFile)
    {
        XmlDocument doc = new XmlDocument();

        doc.LoadXml(xmlString);

        XmlNode root = doc.DocumentElement;

        string className = root.Attributes["name"].Value;

        string namespaceName = root.Attributes["namespace"].Value;

        string classText = "";

        classText += "namespace " + namespaceName + "\n";
        classText += "{\n";
        classText += "    public class " + className + "\n";
        classText += "    {\n";

        foreach (XmlNode node in root.ChildNodes)
        {
            if (node.Name == "property")
            {
                string propertyName = node.Attributes["name"].Value;
                string propertyType = node.Attributes["type"].Value;

                classText += "        public " + propertyType + " " + propertyName + ";\n";
            }
        }

        classText += "    }\n";
        classText += "}\n";

        File.WriteAllText(csharpFile, classText);
    }

}