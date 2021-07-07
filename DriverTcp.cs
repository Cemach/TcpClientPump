using System;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace TestFormMVC
{
    public class DriverTcp
    {

        public static bool running;

        public static PumpModel pump;

        public DriverTcp()
        {
         
            running = true;
            pump = new PumpModel();
        }

        public static void Connect()
        {
            String server = "127.0.0.1";
            Int32 port = 13000;
            TcpClient client = new TcpClient(server, port);
            var stream = client.GetStream();

            Byte[] data = new Byte[3];
            String response = String.Empty;

            while (running)
            {
                Int32 bytes = stream.Read(data, 0, data.Length);
                response = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Int32 length = Convert.ToInt32(response);
                Byte[] dataMain = new Byte[length];
                Int32 bytesMain = stream.Read(dataMain, 0, dataMain.Length);
                response = System.Text.Encoding.ASCII.GetString(dataMain, 0, bytesMain);
                pump = DeserializeObject<PumpModel>(response);

                Thread.Sleep(1000);

            }
            // Close everything.
            stream.Close();
            client.Close();

        }
        static T DeserializeObject<T>(string str)
        {
            string xml = str;
            T result;
            var serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                return result = (T)serializer.Deserialize(reader);
            }
        }
    }
}
