using System;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Automation_Microsoft_Rewards
{
    public partial class AutomationScreen : Form
    {
        public AutomationScreen()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "English";
        }
        // Estrutura de dados para o movimento do mouse
        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        public enum MouseEventFlags : uint
        {
            MOVE = 0x0001,
            LEFTDOWN = 0x0002,
            LEFTUP = 0x0004,
            RIGHTDOWN = 0x0008,
            RIGHTUP = 0x0010,
            MIDDLEDOWN = 0x0020,
            MIDDLEUP = 0x0040,
            XDOWN = 0x0080,
            XUP = 0x0100,
            WHEEL = 0x0800,
            ABSOLUTE = 0x8000 // Adicionando o flag ABSOLUTE
        }
        // Função da API do Windows para simular o clique do mouse
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);
        static void MoveMouse(int x, int y)
        {
            var screen = Screen.PrimaryScreen;
            // A resolução de tela é necessária para mapear as coordenadas absolutas
            int screenWidth = screen.Bounds.Width;  // Ajuste conforme a resolução da tela
            int screenHeight = screen.Bounds.Height; // Ajuste conforme a resolução da tela

            // A conversão para coordenadas absolutas: mapeia a posição para a tela
            int absX = (x * 0xFFFF) / screenWidth;
            int absY = (y * 0xFFFF) / screenHeight;

            INPUT input = new INPUT();
            input.type = 0; // Tipo de input (0 é para mouse)
            input.mi.dx = absX;
            input.mi.dy = absY;
            input.mi.mouseData = 0;
            input.mi.dwFlags = (uint)(MouseEventFlags.MOVE | MouseEventFlags.ABSOLUTE); // Adiciona o flag ABSOLUTE
            input.mi.time = 0;
            input.mi.dwExtraInfo = IntPtr.Zero;

            SendInput(1, new INPUT[] { input }, Marshal.SizeOf(typeof(INPUT)));
        }
        static void ClickMouse()
        {
            // Simular o pressionamento do botão esquerdo do mouse
            INPUT inputDown = new INPUT();
            inputDown.type = 0;
            inputDown.mi.dx = 0;
            inputDown.mi.dy = 0;
            inputDown.mi.mouseData = 0;
            inputDown.mi.dwFlags = (uint)MouseEventFlags.LEFTDOWN;
            inputDown.mi.time = 0;
            inputDown.mi.dwExtraInfo = IntPtr.Zero;

            // Simular o soltamento do botão esquerdo do mouse
            INPUT inputUp = new INPUT();
            inputUp.type = 0;
            inputUp.mi.dx = 0;
            inputUp.mi.dy = 0;
            inputUp.mi.mouseData = 0;
            inputUp.mi.dwFlags = (uint)MouseEventFlags.LEFTUP;
            inputUp.mi.time = 0;
            inputUp.mi.dwExtraInfo = IntPtr.Zero;

            // Enviar ambos os inputs (pressionar e soltar)
            SendInput(1, new INPUT[] { inputDown }, Marshal.SizeOf(typeof(INPUT)));
            Thread.Sleep(100); // Atraso para simular um clique real
            SendInput(1, new INPUT[] { inputUp }, Marshal.SizeOf(typeof(INPUT)));
        }
        static bool IsEdgeRunning()
        {
            // Obtém todos os processos com o nome "msedge" (Microsoft Edge)
            Process[] processes = Process.GetProcessesByName("msedge");

            // Se a lista de processos não for vazia, significa que o Edge está em execução
            return processes.Length > 0;
        }
        bool TimerStatus;
        private void  startAutomation_Click(object sender, EventArgs e)
        {
            if (IsEdgeRunning())
            {
                async Task Timer()
                {
                    int interval = 7000;
                    TimerStatus = true;
                    while (TimerStatus == true)
                    {
                        Movements();
                        await Task.Delay(interval);
                    }
                }
                Timer();
            }
            else
            {
                MessageBox.Show("First open Microsoft Edge");
            }
        }
        int i = 0;
        private void pauseAutomation_Click(object sender, EventArgs e)
        {
            TimerStatus = false;
            if (comboBox1.Text == "English")
            {
                MessageBox.Show("Stopped");
            }
            else
            {
                MessageBox.Show("Pausado");
            }
        }
        private void Movements()//Movimentos do mouse e teclado
        {
            String[] words = {"berserk","call","jumanji","pagani","corsa","daemon","dark souls","apex","fifa","gallardo","halo","ios","json","kotlin","lacoste","microsoft","nodejs","opl","pocket","qiron","rocket","salazar","trussher","uplay","vinha","windows","xaman","bmw","ferrari"};
            var screen = Screen.PrimaryScreen;
            int width = screen.Bounds.Width;
            int height = screen.Bounds.Height;
            MoveMouse((width / 2), 55);//Coordenadas onde se encontra a barra de pesquisa
            ClickMouse();
            SendKeys.Send(words[i]);
            SendKeys.Send("{Enter}");
            i++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "English")
            {
                languageLabel.Text = "Select your language";
                startAutomation.Text = "Start automation";
                pauseAutomation.Text = "Pause automation";
                helpButton.Text = "Help";
                restart.Text = "Restart";
            }
            else if (comboBox1.Text == "Português PT-BR") 
            {
                languageLabel.Text = "Selecione seu Idioma";
                startAutomation.Text = "Iniciar";
                pauseAutomation.Text = "Pausar";
                helpButton.Text = "Ajuda";
                restart.Text = "Reiniciar";
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "English")
            {
                MessageBox.Show("1) First Open the Microsoft Edge\n2) Open the automation software\n3) Click in Start Button");
            }
            else
            {
                MessageBox.Show("1) Primeiro abra o Microsoft Edge\n2) Abra o software de automação\n3) Aperte em iniciar");
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            i = 0;
            if(i == 0)
            {
                if (comboBox1.Text == "English")
                {
                    MessageBox.Show("Success");
                 
                }
                else
                {
                    MessageBox.Show("Sucesso");
                }
            }
            else
            {
                if (comboBox1.Text == "English")
                {
                    MessageBox.Show("Error");

                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
        }
    }
}
