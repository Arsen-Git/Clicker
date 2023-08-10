using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TcpChat
{
    public partial class TCPchat : Form
    {
        private delegate void AppendLogProc(string message);
        private UInt16 port = 8881;
        private TcpListener server;
        private TcpClient client;
        private List<Socket> clients=new List<Socket>();
        private bool active;
        public TCPchat()
        {
            InitializeComponent();
        }

        private void AppendLog(string message)
        {
            if (InvokeRequired) Invoke(new AppendLogProc(AppendLog), message);
            else 
            {
                TxtLog.AppendText(message + Environment.NewLine);
            } 
        }

        int maxCount = 0;
        int clientsCount = 0;
        private void ClientTalk()
        {
            Socket socket;
            string who;
            socket = server.AcceptSocket();
            who = socket.RemoteEndPoint.ToString();
            AppendLog(who + ": connected");
            clients.Add(socket);
            clientsCount = clients.Count;
            if(clientsCount > 1)
            {
                byte[] checkBuff = new byte[] { 0,0,0,1 };
                foreach (Socket sock in clients) sock.Send(checkBuff);
            }
            while (active)
            {
                if (socket.Poll(50000, SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buff = new byte[size];
                    socket.Receive(buff);
                    string message = UTF8Encoding.UTF8.GetString(buff); //who+": "+
                    int clientClickCount = Int32.Parse(message);
                    if (clientClickCount > maxCount)
                    {
                        maxCount = clientClickCount;
                    }
                    buff = UTF8Encoding.UTF8.GetBytes(maxCount.ToString());
                    foreach (Socket sock in clients) sock.Send(buff);
                }
            }
            AppendLog(who + ": disconnected");
            clients.Remove(socket);
        }

        private void ServerLoop()
        {
            server = new TcpListener(IPAddress.Any,port);
            server.Start();
            AppendLog("Server connected");
            active = true;
            while(active)
            {
                if(server.Pending()) new Thread(ClientTalk).Start();
            }
            server.Stop();
            AppendLog("Server connected");
        }

        private void ClientLoop()
        {
            client = new TcpClient("localhost", port);
            Socket socket = client.Client;
            BtnConnect.Text = "Connected";
            TxtLog.Visible = false;
            ChkServer.Visible = false;
            AppendLog("Connected");
            active = true;
            while (active)
            {
                if (socket.Poll(50000, SelectMode.SelectRead))
                {
                    int size = socket.Available;
                    if (size <= 0) break;
                    byte[] buff = new byte[size];
                    socket.Receive(buff);
                    if (buff.GetLength(0) == 4 && buff[3] == 1) 
                    {
                        BtnClick.Enabled = true;
                        continue;
                    }
                    string message = UTF8Encoding.UTF8.GetString(buff);
                    int ClientsCount = Int32.Parse(message);
                    if (ClientsCount == 100)
                    {
                        BtnClick.Text = "Round ended";
                        BtnClick.Enabled = false;
                    }
                    labelTop.Text = "Top result: " + message;
                }
            }
            AppendLog("Disconnected");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (active)
            {
                active = false;
            }
            else
            {
                if (ChkServer.Checked) new Thread(ServerLoop).Start();
                else
                {
                    new Thread(ClientLoop).Start();
                }
                BtnConnect.Enabled = false;
                BtnConnect.ForeColor = Color.Green;
            }
        }
        int ClickCount = 0;
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (ChkServer.Checked)
            {

            }
            else
            {
                if (ClickCount < 99)
                {
                    ClickCount++;
                }else 
                {
                    ClickCount = 100;
                    BtnClick.BackColor = Color.Green;
                }
                
                labelResult.Text = "Your result: " + ClickCount;
                client.Client.Send(UTF8Encoding.UTF8.GetBytes(ClickCount.ToString()));
            }
        }

        private void TCPchat_FormClosing(object sender, FormClosingEventArgs e)
        {
            active = false;
        }
    }
}
