using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.Threading;

namespace TestFormMVC
{
    public partial class Form1 : Form
    {
        DriverTcp driver;

        public Form1()
        {
            InitializeComponent();
            driver = new DriverTcp();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTemp02_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTemp01.Text = "P (bar): \n" +Math.Round(DriverTcp.pump.InletPressure,3).ToString();
            lblTemp02.Text = "P (bar): \n" + Math.Round(DriverTcp.pump.OutletPressure,3).ToString();
            lblTemp03.Text = "T (°C): \n"+Math.Round(DriverTcp.pump.Temperature,3).ToString();
            lblRPM.Text = "RPM: \n"+Math.Round(DriverTcp.pump.Velocity, 3).ToString();
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

        private void btnConnect_Click(object sender, EventArgs e)
        {

            DriverTcp.running = true;
            var th = new Thread(DriverTcp.Connect);
            th.Start();

 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DriverTcp.running = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
