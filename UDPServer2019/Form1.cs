using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPServer2019
{
    public partial class Form1 : Form
    {
        private Boolean done = true;
        private UdpClient server;
        private ArrayList arrayList;
        private IPEndPoint groupEP;
        private IPEndPoint localEP;
        private IPEndPoint remoteEP;
        private IPAddress[] myaddresses;
        private BinaryFormatter bf;
        private MemoryStream memoryStream;
        
      

        public Form1()
        {
            InitializeComponent();
            arrayList = new ArrayList();
            

        }

        public void StartServer()
        {

            if (TextServerAddress.Text == "")
            {
                myaddresses = Dns.GetHostAddresses(Dns.GetHostName());
                localEP = new IPEndPoint(myaddresses[1], 56000);
                TextServerAddress.Text = localEP.Address.ToString();
                TextServerPort.Text = localEP.Port.ToString();
            }
            localEP = new IPEndPoint(IPAddress.Parse(TextServerAddress.Text), int.Parse(TextServerPort.Text));
            

            try
            {
                server = new UdpClient(localEP);
                server.EnableBroadcast = true;               
                TextMessage.Text += "Server started...";
                TextMessage.Text += "\r\n";

            }
            catch (Exception ex)
            {
                TextMessage.Text += ex.ToString();
                TextMessage.Text += ex.Message.ToString();
                server.Close();
                server.Dispose();
            }
            
        }

        public void Receive()
        {
            try
            {
                while (done)
                {
                    groupEP = null;
                    groupEP = new IPEndPoint(IPAddress.Any, 56001);
                    bf = new BinaryFormatter();
                    TextMessage.Text += "\r\n";
                    TextMessage.Text += "Waiting for Data...";
                    TextMessage.Text += "\r\n";
                    byte[] bytes = server.Receive(ref groupEP);
                    TextMessage.Text += "\r\n";
                    TextMessage.Text += string.Format("Received broadcast from {0}", groupEP.ToString());
                    TextMessage.Text += "\r\n";
                    RadioButtonGotClientAddress.Checked = true;
                    memoryStream = new MemoryStream(bytes);
                    memoryStream.Position = 0;
                    ArrayList myobject = (ArrayList)bf.Deserialize(memoryStream);
                    TextMessage.Text += myobject[2].ToString();
                    ButtonReceive.Enabled = true;
                    done = false;
                    
                }

            }
            catch (Exception e)
            {
                TextMessage.Text += "\r\n";
                TextMessage.Text += e.ToString();
                TextMessage.Text += "\r\n";
                TextMessage.Text += e.Message;
                TextMessage.Text += "\r\n";
                               
                
            }
            TextMessage.Text += "\r\n";
            TextMessage.Text += "Exiting Receive";
            TextMessage.Text += "\r\n";
        }
        public void Send()
        {

            remoteEP = new IPEndPoint(IPAddress.Broadcast, 56001);
            ButtonSend.Enabled = false;
            server.EnableBroadcast = true;
            bf = new BinaryFormatter();
            arrayList.Add(DateTime.Now);
            arrayList.Add("David Morrow");
            arrayList.Add(TextSend.Text);
            string mystring = string.Format("I am {0} {2}, this message sent on {1}", arrayList[1], arrayList[2], arrayList[0]);
            arrayList.Add(mystring);
            memoryStream = new MemoryStream();
            bf.Serialize(memoryStream, arrayList);
            byte[] bytesToSend = memoryStream.ToArray();
            try
            {
                server.Client.SendTo(bytesToSend, remoteEP);
            }
            catch (Exception ex)
            {
                TextMessage.Text += ex.ToString();
                TextMessage.Text += ex.Message.ToString();
            }
            
            TextMessage.Text += "\r\n";
            TextMessage.Text += "Data Sent";
            TextMessage.Text += "\r\n";
            TextSend.Text = "";
            Thread.Sleep(2000);
            ButtonSend.Enabled = true;
           
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            StartServer();
            ButtonStart.Enabled = false;
                        
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {

            Send();
            
                ButtonSend.Enabled = false;
                Thread.Sleep(2000);
            ButtonSend.Enabled = true;


        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            server.Close();
            server.Dispose();
            ButtonClose.Enabled = false;
            
                Thread.Sleep(2000);
                ButtonClose.Enabled = true;
            ButtonStart.Enabled = true;
          

        }

        private void ButtonReceive_Click(object sender, EventArgs e)
        {
           
            
                ButtonReceive.Enabled = false;
                Receive();
             

        }
    }
}
