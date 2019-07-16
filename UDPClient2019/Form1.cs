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

namespace UDPClient2019
{
    public partial class Form1 : Form
    {
        private UdpClient Client;
        private IPEndPoint localEP;
        private IPEndPoint remoteEP;
        private Boolean done = true;
        private ArrayList arrayList;
        private IPEndPoint groupEP;
        private BinaryFormatter bf;
        private MemoryStream memoryStream;
        private Thread sendThread;
        private Thread receiveThread;
        private Boolean gotServerAddress = false;
        private string StatusText;
        private IPAddress[] myaddresses;
        

        public Form1()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
            arrayList = new ArrayList();
            

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
                ButtonSend.Enabled = false;
                Send();      
                Thread.Sleep(2000);
                ButtonSend.Enabled = true;



        }

        private void Startup()
        {
           
            if (TextAddress.Text == "")
            {
                myaddresses = Dns.GetHostAddresses(Dns.GetHostName());
                localEP = new IPEndPoint(myaddresses[1], 56001);
                TextAddress.Text = localEP.Address.ToString();
                TextPort.Text = localEP.Port.ToString();
            }
            
            
            localEP = new IPEndPoint(IPAddress.Parse(TextAddress.Text), int.Parse(TextPort.Text));
            Client = new UdpClient(localEP);
            Client.EnableBroadcast = true;            
            TextStatus.Text += "\r\n";
            TextStatus.Text += "Client Started up";
            TextStatus.Text += "\r\n";


        }

        private void Receive()
        {
            try
            {
                while (done)
                {
                    groupEP = null;
                    groupEP = new IPEndPoint(IPAddress.Any, 0);
                    arrayList = new ArrayList();
                    bf = new BinaryFormatter();
                    byte[] bytes = Client.Receive(ref groupEP);
                    RadioButtonGotServerAddress.Checked = true;
                    ButtonReceive.Enabled = true;
                    TextStatus.Text += "\r\n";
                    TextStatus.Text += string.Format("Received broadcast from {0}", groupEP.ToString());
                    TextStatus.Text += "\r\n";
                    memoryStream = new MemoryStream(bytes);
                    memoryStream.Position = 0;
                    ArrayList myobject = new ArrayList();
                    myobject = (ArrayList)bf.Deserialize(memoryStream);
                    TextMessage.Text += myobject[2].ToString();
                    done = false;
                    

                }
            }
            catch (Exception e)
            {
                TextStatus.Text += e.ToString();
                TextStatus.Text += "\r\n";
                TextStatus.Text += e.Message;
                TextStatus.Text += "\r\n";
                
            }
            TextMessage.Text += "\r\n";
            TextMessage.Text += "Exiting Receive";
            TextMessage.Text += "\r\n";

        }

        private void Send()
        {
            remoteEP = null;
            remoteEP = new IPEndPoint(IPAddress.Broadcast, 56000);
            arrayList.Add(DateTime.Now);
            arrayList.Add("Client");
            arrayList.Add(TextMessage.Text);
            string mystring = string.Format($"I am {0}, {3}, this message sent on {1}", arrayList[1], arrayList[2], arrayList[0]);
            arrayList.Add(mystring);
            memoryStream = new MemoryStream();
            bf = new BinaryFormatter();
            bf.Serialize(memoryStream, arrayList);
            byte[] bytesToSend = memoryStream.ToArray();
            if (remoteEP != null)
            {
                try
                {
                    Client.Client.SendTo(bytesToSend, remoteEP);
                }
                catch (Exception ex)
                {
                    TextStatus.Text += ex.ToString();
                    TextStatus.Text += ex.Message.ToString();
                    
                }
                
               TextStatus.Text += "\r\n";
               TextStatus.Text += "Data Sent";
                TextStatus.Text += "\r\n";
                TextMessage.Text = "";
            }
            
            
           
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            
            ButtonStart.Enabled = false;
            Startup();
            

        }

        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            Client.Close();
            Client.Dispose();
            ButtonEnd.Enabled = false;
            Thread.Sleep(2000);
            ButtonEnd.Enabled = true;
            ButtonStart.Enabled = true;
        }

        private void ButtonReceive_Click(object sender, EventArgs e)
        {
            
            ButtonReceive.Enabled = false;
            Receive();
        }
    }
}
