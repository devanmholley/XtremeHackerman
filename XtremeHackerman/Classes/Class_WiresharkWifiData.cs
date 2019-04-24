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
    public class WiresharkwifiData
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
            WiresharkwifiData wifiData = new WiresharkwifiData();
            wifiData.No = "1";
            wifiData.Time = "0.0263";
            wifiData.Source = "125.55.87.96";
            wifiData.Destination = "122.12.4.55";
            wifiData.Protocol = "TCP";
            wifiData.Length = "200";
            wifiData.Info = "Application Data - WiFi";

            // Convert Object to JSON string format
            string jsonData = JsonConvert.SerializeObject(wifiData);

            return jsonData;
        }


        public static string JSONDeserialize()
        {
            string json = @"{
                'No': '1',
                'Time': '0.0263',
                'Source': '125.55.87.96',
                'Destination': '122.12.4.55',
                'Protocol': 'TCP',
                'Length': '200',
                'Info': 'Application Data - WiFi',
            }";
            //WiresharkwifiData wifiJSONData = JsonConvert.DeserializeObject<WiresharkwifiData>(File.ReadAllText("Resources/Form_Wireshark/wifiConnectionData.json"));
            WiresharkwifiData wifiJSONData = JsonConvert.DeserializeObject<WiresharkwifiData>(json);


            return wifiJSONData.ToString();
        }
    }
}