using System.Xml.Serialization;
using System.Collections.Generic;

namespace DayZTypesXMLEditor
{
	[XmlRoot(ElementName = "flags")]
	public class Flags
	{
		[XmlAttribute(AttributeName = "count_in_cargo")]
		public string CountInCargo { get; set; }
		[XmlAttribute(AttributeName = "count_in_hoarder")]
		public string CountInHoarder { get; set; }
		[XmlAttribute(AttributeName = "count_in_map")]
		public string CountInMap { get; set; }
		[XmlAttribute(AttributeName = "count_in_player")]
		public string CountInPlayer { get; set; }
		[XmlAttribute(AttributeName = "crafted")]
		public string Crafted { get; set; }
		[XmlAttribute(AttributeName = "deloot")]
		public string DeLoot { get; set; }
	}

	[XmlRoot(ElementName = "category")]
	public class Category
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "usage")]
	public class Usage
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "type")]
	public class Type
	{
		[XmlElement(ElementName = "nominal")]
		public string Nominal { get; set; }
		[XmlElement(ElementName = "lifetime")]
		public string Lifetime { get; set; }
		[XmlElement(ElementName = "restock")]
		public string Restock { get; set; }
		[XmlElement(ElementName = "min")]
		public string Min { get; set; }
		[XmlElement(ElementName = "quantmin")]
		public string QuantMin { get; set; }
		[XmlElement(ElementName = "quantmax")]
		public string QuantMax { get; set; }
		[XmlElement(ElementName = "cost")]
		public string Cost { get; set; }
		[XmlElement(ElementName = "flags")]
		public Flags Flags { get; set; }
		[XmlElement(ElementName = "category")]
		public Category Category { get; set; }
		[XmlElement(ElementName = "usage")]
		public List<Usage> Usage { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "value")]
		public List<Value> Value { get; set; }
	}

	[XmlRoot(ElementName = "value")]
	public class Value
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "types")]
	public class TypesXml
	{
		[XmlElement(ElementName = "type")]
		public List<Type> Types { get; set; }
	}

}
