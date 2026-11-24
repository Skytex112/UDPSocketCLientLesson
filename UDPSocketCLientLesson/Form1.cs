using System.Net;
using System.Net.Sockets;
using System.Text;
namespace UDPSocketCLientLesson
{

    public partial class Form1 : Form
    {
        Socket _socket;

        EndPoint _serverEP;

        public Form1()
        {
            InitializeComponent();
            _socket = new Socket(AddressFamily.InterNetwork,
                                 SocketType.Dgram,
                                 ProtocolType.Udp);

            _serverEP = new IPEndPoint(IPAddress.Loopback, 5000);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (_socket.Connected)
            {
                answerBox.Text = "You allready connected";
                return;
            }

            try
            {
                byte[] request = Encoding.UTF8.GetBytes(sendingBox.Text);
                _socket.SendTo(request, _serverEP);



                byte[] buffer = new byte[1024];
                int recieved = _socket.ReceiveFrom(buffer, ref _serverEP);

                string value = Encoding.UTF8.GetString(buffer);

                answerBox.Text = value;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }

        }

        private async void button1_Click(object sender, EventArgs e)
        {


            try
            {
                string msg = sendingBox.Text;
                byte[] data = Encoding.UTF8.GetBytes(msg);

                // Відправка на сервер
                await _socket.SendToAsync(data,SocketFlags.None, _serverEP);

                // Отримання відповіді (блокуюче)
                byte[] buffer = new byte[1024];

                EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 5000);
                SocketReceiveFromResult result = await _socket.ReceiveFromAsync(buffer, SocketFlags.None, remoteEP);

                string reply = Encoding.UTF8.GetString(buffer, 0, result.ReceivedBytes);
                answerBox.Text = reply;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private async void SendUDP(object sender, EventArgs e)
        {
            try
            {
                string msg = sendingBox.Text;
                byte[] data = Encoding.UTF8.GetBytes(msg);

                await _socket.SendToAsync(data, _serverEP); 

                byte[] buffer = new byte[1024];
                SocketReceiveFromResult result = await _socket.ReceiveFromAsync(buffer, SocketFlags.None, _serverEP);
                string reply = Encoding.UTF8.GetString(buffer, 0, result.ReceivedBytes);
                answerBox.Text = reply;
            }
            catch(Exception ex )
            {
                MessageBox.Show("Some error");
            }
        }
        
    }
}
