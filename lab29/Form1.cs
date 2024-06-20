using System.Net.Sockets;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text;

namespace lab29
{
    public partial class Lab29 : Form
    {
        bool alive = false;
        UdpClient? client;
        const int TTL = 20;
        IPAddress groupAddress;
        string? multicast = null;
        int remote_port = 6666;
        int local_port = 6666;
        public Lab29()
        {
            InitializeComponent();
        }

        private void Connect(object sender, EventArgs e)
        {
            var user_name = input_name.Text;
            input_name.ReadOnly = true;
            var parts = input_multicast.Text.Split(':');
            multicast = parts[0];
            groupAddress = IPAddress.Parse(parts[0]);
            remote_port = int.Parse(parts[1]);
            local_port = int.Parse(input_local_port.Text);
            try
            {
                client = new UdpClient(local_port);
                client.JoinMulticastGroup(groupAddress, TTL);
                Task receiveTask = new(ReceiveMessages);
                receiveTask.Start();
                string message = $" > {user_name} joined the chat";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, multicast, remote_port);
                button_connect.Enabled = false;
                button_disconnect.Enabled = true;
                button_send.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint? remoteIp = null;
                    byte[]? data = client?.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        chat_log.Text = $"{time} - {message}\n{chat_log.Text}";
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendMessage(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", input_name.Text, input_message.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client?.Send(data, data.Length, multicast, remote_port);
                input_message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disconnect(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void ExitChat()
        {
            string message = $" > {input_name.Text} leaves the chat";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client?.Send(data, data.Length, multicast, remote_port);
            client?.DropMulticastGroup(groupAddress);
            alive = false;
            client?.Close();
            button_connect.Enabled = true;
            button_disconnect.Enabled = false;
            button_send.Enabled = false;
        }

        private void Lab29_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void SaveLogs(object sender, EventArgs e)
        {
            var logs = chat_log.Text;
            string filename = $"{DateTime.Now.Ticks}.txt";
            File.WriteAllText(filename, logs);
        }
    }
}
