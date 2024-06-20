using System.Security.Cryptography;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace lab24
{
    public partial class Lab24 : Form
    {
        private Thread thread_des;
        private Thread thread_md2;
        private Thread thread_aes;

        public Lab24()
        {
            InitializeComponent();
        }

        private void UpdateInput(object sender, EventArgs e)
        {
            //thread_des?.Abort();
            //thread_md2?.Abort();
            //thread_aes?.Abort();

            thread_des = new Thread(new ThreadStart(DES));
            thread_md2 = new Thread(new ThreadStart(Md2));
            thread_aes = new Thread(new ThreadStart(AES));

            thread_des.Start();
            thread_md2.Start();
            thread_aes.Start();
        }

        private void DES()
        {
            byte[] key = [1, 2, 3, 4, 5, 6, 7, 8];
            byte[] iv = [1, 2, 3, 4, 5, 6, 7, 8];
            SymmetricAlgorithm algorithm = System.Security.Cryptography.DES.Create();
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
            var text = string.Empty;
            if (input_data.InvokeRequired)
            {
                input_data.Invoke(new MethodInvoker(delegate { text = input_data.Text; }));
            }
            byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            var enc_hex = BitConverter.ToString(outputBuffer).Replace("-", string.Empty);
            if (result_des.InvokeRequired)
            {
                result_des.Invoke(new MethodInvoker(delegate { result_des.Text = enc_hex; }));
            }
        }

        private void Md2()
        {
            var md2 = new MD2();
            var text = string.Empty;
            if (input_data.InvokeRequired)
            {
                input_data.Invoke(new MethodInvoker(delegate { text = input_data.Text; }));
            }
            var hash = md2.CalcHash(Encoding.Unicode.GetBytes(text));
            var hash_hex = BitConverter.ToString(hash).Replace("-", string.Empty);
            if (result_md2.InvokeRequired)
            {
                result_md2.Invoke(new MethodInvoker(delegate { result_md2.Text = hash_hex; }));
            }
        }

        private void AES()
        {
            string EncryptionKey = "password";
            var text = string.Empty;
            if (input_data.InvokeRequired)
            {
                input_data.Invoke(new MethodInvoker(delegate { text = input_data.Text; }));
            }
            byte[] clearBytes = Encoding.Unicode.GetBytes(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new(EncryptionKey, "salty"u8.ToArray());
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    if (result_aes.InvokeRequired)
                    {
                        result_aes.Invoke(new MethodInvoker(delegate { result_aes.Text = Convert.ToBase64String(ms.ToArray()); }));
                    }
                }
            }
        }


        private void Quit(object sender, FormClosedEventArgs e)
        {
            thread_des?.Abort();
            thread_md2?.Abort();
            thread_aes?.Abort();
        }
    }
}
