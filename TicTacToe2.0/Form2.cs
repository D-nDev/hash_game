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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        int vez = 0; // contagem de jogadas, caso ultrapasse 9(Número total de jogadas no jogo da velha) e não haja um vencedor, resultará em empate(ou velha).
        public string jogador;
        public Form2()
        {
            jogador = Form1.selected.ToString();
            InitializeComponent();
            jogador_atual();
        }
        private void input1_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input1.Text != "X" && input1.Text != "O")
                {
                    input1.Text = "O";                   
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input1.Text != "X" && input1.Text != "O")
                {
                    input1.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input2_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input2.Text != "X" && input2.Text != "O")
                {
                    input2.Text = "O";
                    jogador = "X";
                    vez++;
                }

                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input2.Text != "X" && input2.Text != "O")
                {
                    input2.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input3_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input3.Text != "X" && input3.Text != "O")
                {
                    input3.Text = "O";
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input3.Text != "X" && input3.Text != "O")
                {
                    input3.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input4_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input4.Text != "X" && input4.Text != "O")
                {
                    input4.Text = "O";
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input4.Text != "X" && input4.Text != "O")
                {
                    input4.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input5_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input5.Text != "X" && input5.Text != "O")
                {
                    input5.Text = "O";
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input5.Text != "X" && input5.Text != "O")
                {
                    input5.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input6_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input6.Text != "X" && input6.Text != "O")
                {
                    input6.Text = "O";
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input6.Text != "X" && input6.Text != "O")
                {
                    input6.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input7_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input7.Text != "X" && input7.Text != "O")
                {
                    input7.Text = "O";
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input7.Text != "X" && input7.Text != "O")
                {
                    input7.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input8_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input8.Text != "X" && input8.Text != "O")
                {
                    input8.Text = "O";
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input8.Text != "X" && input8.Text != "O")
                {
                    input8.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }

        private void input9_Click(object sender, EventArgs e)
        {
            base.OnClick(e);

            if (jogador == "O")
            {
                if (input9.Text != "X" && input9.Text != "O")
                {
                    input9.Text = "O";
                    jogador = "X";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (jogador == "X")
            {
                if (input9.Text != "X" && input9.Text != "O")
                {
                    input9.Text = "X";
                    jogador = "O";
                    vez++;
                }
                else
                {
                    MessageBox.Show("Jogada inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Check();
            jogador_atual();
        }
        public void Check()
        {
            // diagonal
            if (input1.Text == "X" && input5.Text == "X" && input9.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "X";
                novamente();
            }
            else if (input1.Text == "O" && input5.Text == "O" && input9.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }


            else if (input3.Text == "X" && input5.Text == "X" && input7.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "X";
                novamente();
            }
            else if (input3.Text == "O" && input5.Text == "O" && input7.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            // horizontal
            else if (input1.Text == "X" && input2.Text == "X" && input3.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "X";
                novamente();
            }

            else if (input4.Text == "X" && input5.Text == "X" && input6.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "X";
                novamente();
            }

            else if (input7.Text == "X" && input8.Text == "X" && input9.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "X";
                novamente();
            }




            else if (input1.Text == "O" && input2.Text == "O" && input3.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            else if (input4.Text == "O" && input5.Text == "O" && input6.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            else if (input7.Text == "O" && input8.Text == "O" && input9.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            // vertical
            else if (input1.Text == "X" && input4.Text == "X" && input7.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            else if (input2.Text == "X" && input5.Text == "X" && input8.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "X";
                novamente();
            }

            else if (input3.Text == "X" && input6.Text == "X" && input9.Text == "X")
            {
                MessageBox.Show("O jogador X é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "X";
                novamente();
            }




            else if (input1.Text == "O" && input4.Text == "O" && input7.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            else if (input2.Text == "O" && input5.Text == "O" && input8.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            else if (input3.Text == "O" && input6.Text == "O" && input9.Text == "O")
            {
                MessageBox.Show("O jogador O é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogador = "O";
                novamente();
            }

            else
            {
                if (vez >= 9)
                {
                    MessageBox.Show("Deu velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(jogador == "O")
                    {
                        jogador = "X";
                    }
                    else if(jogador == "X")
                    {
                        jogador = "O";
                    }
                    novamente();
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (input1.Text != "" || input2.Text != "" || input3.Text != "" || input4.Text != "" || input5.Text != "" || input6.Text != "" || input7.Text != "" || input8.Text != "" || input9.Text != "")
            {
                DialogResult dialog2 = MessageBox.Show("O jogo está em andamento. Deseja realmente sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog2 == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else if (dialog2 == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        public void jogador_atual()
        {
            label1.Text = "Jogador Atual: " + jogador;
        }

        Form1 frmm = new Form1();
        public void novamente()
        {
            DialogResult dialog = MessageBox.Show("Deseja Jogar novamente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                vez = 0;
                input1.ResetText();
                input2.ResetText();
                input3.ResetText();
                input4.ResetText();
                input5.ResetText();
                input6.ResetText();
                input7.ResetText();
                input8.ResetText();
                input9.ResetText();

                Owner.Show(); //Show the previous form                
                Hide();
            }
            else if (dialog == DialogResult.No)
            {
                Environment.Exit(0);
            }
        }
        private void rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para vencer o jogador deve formar uma sequência em formato vertical, horizontal ou diagonal.", "Regras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
