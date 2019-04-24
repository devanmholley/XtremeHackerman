using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace XtremeHackerman.Classes
{
    // DataContract
    public  class WiresharkEthernetData
    {
        // Data Members
        public string No { get; set; }

        public string Time { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public string Protocol { get; set; }

        public string Length { get; set; }

        public string Info { get; set; }

        public static string JSONSerialize()
        {
            // Serialization
            WiresharkEthernetData ethernetData = new WiresharkEthernetData();
            ethernetData.No = "1";
            ethernetData.Time = "0.0001";
            ethernetData.Source = "104.55.87.96";
            ethernetData.Destination = "192.166.4.5";
            ethernetData.Protocol = "TCP";
            ethernetData.Length = "221";
            ethernetData.Info = "Application Data - Ethernet";

            // Convert Object to JSON string format
            string jsonData = JsonConvert.SerializeObject(ethernetData);

            return jsonData;
        }


        public static string JSONDeserialize()
        {
            string json = @"{
                'No': '1',
                'Time': '0.0001',
                'Source': '104.55.87.96',
                'Destination': '192.166.4.5',
                'Protocol': 'TCP',
                'Length': '221',
                'Info': 'Application Data - Ethernet',
            }";
            //WiresharkEthernetData ethernetJSONData = JsonConvert.DeserializeObject<WiresharkEthernetData>(File.ReadAllText("Resources/Form_Wireshark/EthernetConnectionData.json"));
            WiresharkEthernetData ethernetJSONData = JsonConvert.DeserializeObject<WiresharkEthernetData>(json);


            return ethernetJSONData.ToString();
        }
    }
}