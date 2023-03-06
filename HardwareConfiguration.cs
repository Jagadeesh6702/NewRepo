using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Import_Xml_to_Db
{
    [XmlRoot("hardwareconfiguration")]
    internal class HardwareConfiguration
    {
        public List<Configuration> Configurations { get; set; }
    }
    [XmlRoot("configuration")]
    class Configuration
    {
        [XmlElement("opco")]
        public string Opco { get; set; }
        [XmlElement("elementName")]
        public string ElementName { get; set; }
        [XmlElement("productNo")]
        public string ProductNo { get; set; }
        [XmlElement("productname")]
        public string ProductName { get; set; }
        [XmlElement("productrevision")]
        public string ProductRevision { get; set; }
        [XmlElement("serialNumber")]
        public string SerialNumber { get; set; }
        [XmlElement("vendor")]
        public string Vendor { get; set; }
        [XmlElement("unitlocation")]
        public string UnitLocation { get; set; }
        [XmlElement("HardWareType")]
        public string HardWareType { get; set; }    
    }
}
