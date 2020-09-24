using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe2._0
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        public static object selected;

        /* protected override void WndProc(ref Message m)
         {
             switch (m.Msg)
             {
                 case 0x84:
                     base.WndProc(ref m);
                     if ((int)m.Result == 0x1)
                         m.Result = (IntPtr)0x2;
                     return;
             }

             base.WndProc(ref m);
         }
         */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked != false || radioButton2.Checked != false)
            {
                if (radioButton1.Checked == true)
                {
                    selected = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    selected = radioButton2.Text;
                }                

                if (frm2 == null)
                {
                    frm2 = new Form2();   //Create form if not created
                    frm2.FormClosed += frm2_FormClosed;  //Add eventhandler to cleanup after form closes
                }

                frm2.jogador = Form1.selected.ToString();
                frm2.label1.Text = "Jogador Atual: " + frm2.jogador;
                frm2.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
            }
            else
            {
                MessageBox.Show("Você deve selecionar o jogador que irá iniciar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = null;  //If form is closed make sure reference is set to null
            Show();

        }
        private void openform2(object obj)
        {
            Application.Run(new Form2());
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        /*
        protected override void OnPaint(PaintEventArgs e)
        {
           ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }       
        */
    }
}
