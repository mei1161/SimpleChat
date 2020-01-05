using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MeiChat
{
    public partial class SimpleChat : Form
    {
        Thread threadReceive;
        bool start = false;
        int PeerPort;
        IPAddress PeerAddress;
        public SimpleChat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ServerStop();
            }
            else
            {
                ServerStart();
            }

        }

        void ServerStart()
        {

            if (!IPAddress.TryParse(Address.Text, out PeerAddress))
            {
                MessageBox.Show("invalid address");
                return;
            }

            if (!int.TryParse(Port.Text, out PeerPort))
            {
                MessageBox.Show("invalid port");
                return;
            }

            start = true;
            threadReceive = new Thread(new ThreadStart(ReceivedByPeer));
            threadReceive.IsBackground = true;
            threadReceive.Start();

            btn_server.Text = "stop server";
            gpb_config.Enabled = false;
            btn_send.Enabled = true;
        }

        void ServerStop()
        {
            start = false;

            PeerAddress = IPAddress.Parse("127.0.0.1");
            SendToPeer("Stopping receiver....");
            btn_server.Text = "start server";
            gpb_config.Enabled = true;
            btn_send.Enabled = false;
        }

        void ReceivedByPeer()
        {
            Socket socketReceive = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndPointReceive = new IPEndPoint(IPAddress.Parse("0.0.0.0"), PeerPort);
            socketReceive.Bind(iPEndPointReceive);
            socketReceive.Listen(10);
            while (start)
            {
                Socket temp = null;
                try
                {
                    temp = socketReceive.Accept();
                    byte[] messageReceivedByServer = new byte[100];
                    int sizeOfReceivedMessage = temp.Receive(messageReceivedByServer, SocketFlags.None);
                    Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                    string str = sjisEnc.GetString(messageReceivedByServer);
                    listBox1.Items.Add(str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.HelpLink + "\n" + ex.InnerException
                            + "\n" + ex.Source + "\n" + ex.TargetSite);
                }
                finally
                {
                    temp.Close();
                }
            }
            socketReceive.Close();
            socketReceive.Dispose();
        }

        void SendToPeer(String Message)
        { 
            IPEndPoint iPEndPointSend = new IPEndPoint(PeerAddress, PeerPort);
            Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            byte[] messageSentFromClient;
            try
            {
                socketSend.Connect(iPEndPointSend);
                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                messageSentFromClient = sjisEnc.GetBytes(Message);
                socketSend.Send(messageSentFromClient, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.HelpLink + "\n" + ex.InnerException
                        + "\n" + ex.Source + "\n" + ex.TargetSite);
            }
            finally
            {
                socketSend.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Message = txb_name.Text + " : " + textBox1.Text;
            SendToPeer(Message);
            listBox1.Items.Add(Message);
            textBox1.Text = null;
        }

        private void SimpleChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadReceive != null && threadReceive.ThreadState == ThreadState.Running)
            {
                MessageBox.Show("Please Stop Server");
                e.Cancel = true;
            }
        }
    }
}
