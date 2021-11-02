using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace DayZTypesXMLEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var typesXml = (TypesXml)new XmlSerializer(typeof(TypesXml)).Deserialize(File.OpenRead(args[0]));
            
            var newTypesXml = new TypesXml
            {
                Types = new List<Type>()
            };

            if (typesXml is null) 
            {
                Console.WriteLine("typesXml is null, tell mangosd to look at this");
                Console.ReadLine();
                return;
            }

            var wantedStuff = new List<string>();
            wantedStuff.Add("M82");
            wantedStuff.Add("AS50");
            wantedStuff.Add("Alligator");
            wantedStuff.Add("DVL10");
            wantedStuff.Add("M200");
            wantedStuff.Add("ScarH");
            wantedStuff.Add("P90");
            wantedStuff.Add("M1918");

            foreach (var type in typesXml.Types)
            {
                if (!wantedStuff.Any(x => type.Name.Contains(x))) continue;

                var newType = new Type
                {
                    Category = type.Category,
                    Cost = type.Cost,
                    Flags = type.Flags,
                    Lifetime = "7200",
                    Min = "2",
                    Name = type.Name,
                    Nominal = "4",
                    QuantMin = "-1",
                    QuantMax = "-1",
                    Restock = "1200",
                    Usage = type.Usage,
                    Value = new List<Value>
                    {
                        new()
                        {
                            Name = "Tier3"
                        },
                        new()
                        {
                            Name = "Tier4"
                        }
                    }
                };

                newTypesXml.Types.Add(newType);
            }

            using var stringWriter = new StringWriter();
            new XmlSerializer(typeof(TypesXml)).Serialize(stringWriter, newTypesXml);

            File.WriteAllText($"output_{Path.GetFileName(args[0])}", stringWriter.ToString());
        }
    }
}
