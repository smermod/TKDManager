using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKDManager.ConfigSections
{
	public class PrintCoordinatesSection : ConfigurationSection 
	{
		[ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
		public PrintCoordinatesInstanceCollection Instances 
		{
			get { return (PrintCoordinatesInstanceCollection)this[""]; }
			set { this[""] = value; }
		}
	}
	public class PrintCoordinatesInstanceCollection : ConfigurationElementCollection 
	{
		protected override ConfigurationElement CreateNewElement() 
		{
			return new PrintCoordinatesInstanceElement();
		}

		protected override object GetElementKey(ConfigurationElement element) 
		{
			return ((PrintCoordinatesInstanceElement)element).Key;
		}

		public new PrintCoordinatesInstanceElement this[string elementName]
		{
			get
			{
				return this.OfType<PrintCoordinatesInstanceElement>().FirstOrDefault(item => item.Key == elementName);
			}
		}
	}

	public class PrintCoordinatesInstanceElement : ConfigurationElement 
	{
		[ConfigurationProperty("key", IsKey = true, IsRequired = true)]
		public string Key 
		{
			get { return (string) base["key"]; }
			set { base["key"] = value; }
		}

		[ConfigurationProperty("x", IsRequired = true)]
		public float X 
		{
			get { return (float) base["x"]; }
			set { base["x"] = value; }
		} 
		[ConfigurationProperty("y", IsRequired = true)]
		public float Y 
		{
			get { return (float) base["y"]; }
			set { base["y"] = value; }
		} 
	} 
}
