namespace TicTacToe2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // okButton1
            // 
            this.okButton1.Animated = true;
            this.okButton1.AutoRoundedCorners = true;
            this.okButton1.BackColor = System.Drawing.Color.Transparent;
            this.okButton1.BorderRadius = 21;
            this.okButton1.CheckedState.Parent = this.okButton1;
            this.okButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton1.CustomImages.Parent = this.okButton1;
            this.okButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(188)))), ((int)(((byte)(81)))));
            this.okButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okButton1.ForeColor = System.Drawing.Color.White;
            this.okButton1.HoverState.Parent = this.okButton1;
            this.okButton1.Location = new System.Drawing.Point(53, 156);
            this.okButton1.Name = "okButton1";
            this.okButton1.ShadowDecoration.BorderRadius = 26;
            this.okButton1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(188)))), ((int)(((byte)(81)))));
            this.okButton1.ShadowDecoration.Enabled = true;
            this.okButton1.ShadowDecoration.Parent = this.okButton1;
            this.okButton1.Size = new System.Drawing.Size(180, 45);
            this.okButton1.TabIndex = 0;
            this.okButton1.Text = "OK";
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o primeiro a iniciar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(53, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "X";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(53, 115);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(33, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "O";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 229);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button okButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

