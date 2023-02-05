using System.Windows.Forms;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Share_My_External_IP


{   
    public partial class Form1 : Form
    {
        //variáveis globais dentro do Forms
        bool move = false;
        Point initialPosition;

        public Form1()
        {
            InitializeComponent();

            static async Task<string> GetExternalIp()
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://api.ipify.org?format=json");
                    var content = await response.Content.ReadAsStringAsync();
                    return content.Split(":")[1].Split("}")[0].Trim('"');
                }
            }

            this.linkLabel1.Text = "Buscando IP externo...";

            Task.Run(async () => {
                while (true)
                {
                    var ipAddress = await GetExternalIp();
                    this.linkLabel1.Invoke((MethodInvoker)delegate {
                        this.linkLabel1.Text = ipAddress;
                    });
                    Thread.Sleep(60 * 60 * 1000);
                }
            });
        }

        //Função de movimentação da janela
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            initialPosition = new Point(e.X, e.Y);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Point newPoint = PointToScreen(e.Location);
                Location = new Point(newPoint.X - initialPosition.X, newPoint.Y - initialPosition.Y);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(10);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
            }
            else
            {
                notifyIcon.Visible = false;
            }
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_MouseClick(object sender, EventArgs e)
        {
            Clipboard.SetText(linkLabel1.Text);
            notifyIcon.BalloonTipText = "IP: " + linkLabel1.Text + " Copiado para Área de Transferência!";
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(10);
            notifyIcon.BalloonTipText = "App Minimizado para bandeja!";
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
            }
            else
            {
                notifyIcon.Visible = false;
            }
                
        }

        private void abrirForm(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = false;
            }
            else
            {
                notifyIcon.Visible = true;
            }
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem("Abrir", null, abrirForm));
            contextMenu.Items.Add(new ToolStripMenuItem("Copiar IP", null, linkLabel1_MouseClick));
            contextMenu.Items.Add(new ToolStripMenuItem("Fechar", null, btn_close_Click));
            notifyIcon.ContextMenuStrip = contextMenu;
        }

    }
}