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
    public class WiresharkbluetoothData
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
            WiresharkbluetoothData bluetoothData = new WiresharkbluetoothData();
            bluetoothData.No = "1";
            bluetoothData.Time = "0.5627";
            bluetoothData.Source = "104.45.88.97";
            bluetoothData.Destination = "104.67.4.5";
            bluetoothData.Protocol = "TCP";
            bluetoothData.Length = "58";
            bluetoothData.Info = "Application Data - Bluetooth";

            // Convert Object to JSON string format
            string jsonData = JsonConvert.SerializeObject(bluetoothData);

            return jsonData;
        }


        public static string JSONDeserialize()
        {
            string json = @"{
                'No': '1',
                'Time': '0.5627
                'Source': '104.45.88.97',
                'Destination': '104.67.4.5',
                'Protocol': 'TCP',
                'Length': '58',
                'Info': 'Application Data - Bluetooth',
            }";
            //WiresharkbluetoothData bluetoothJSONData = JsonConvert.DeserializeObject<WiresharkbluetoothData>(File.ReadAllText("Resources/Form_Wireshark/bluetoothConnectionData.json"));
            WiresharkbluetoothData bluetoothJSONData = JsonConvert.DeserializeObject<WiresharkbluetoothData>(json);


            return bluetoothJSONData.ToString();
        }
    }
}