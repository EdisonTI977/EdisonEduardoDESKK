namespace EdisonEduardoAPP
{
    partial class FrmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtButton1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtButton2 = new TextBox();
            TxtButton3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TxtButton4 = new TextBox();
            BtnCadastro = new Button();
            SuspendLayout();
            // 
            // TxtButton1
            // 
            TxtButton1.Location = new Point(90, 75);
            TxtButton1.Name = "TxtButton1";
            TxtButton1.Size = new Size(299, 23);
            TxtButton1.TabIndex = 0;
            TxtButton1.Text = "Edison Eduardo";
            TxtButton1.TextChanged += TxtButton1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 57);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 57);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // TxtButton2
            // 
            TxtButton2.Location = new Point(424, 75);
            TxtButton2.Name = "TxtButton2";
            TxtButton2.Size = new Size(255, 23);
            TxtButton2.TabIndex = 3;
            // 
            // TxtButton3
            // 
            TxtButton3.Location = new Point(90, 137);
            TxtButton3.Name = "TxtButton3";
            TxtButton3.Size = new Size(218, 23);
            TxtButton3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 119);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 119);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // TxtButton4
            // 
            TxtButton4.Location = new Point(341, 137);
            TxtButton4.Name = "TxtButton4";
            TxtButton4.Size = new Size(218, 23);
            TxtButton4.TabIndex = 7;
            // 
            // BtnCadastro
            // 
            BtnCadastro.Location = new Point(296, 198);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(75, 37);
            BtnCadastro.TabIndex = 8;
            BtnCadastro.Text = "Cadastro";
            BtnCadastro.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCadastro);
            Controls.Add(TxtButton4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtButton3);
            Controls.Add(TxtButton2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtButton1);
            Name = "FrmCadastro";
            Text = "Form1";
            Load += FrmCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtButton1;
        private Label label1;
        private Label label2;
        private TextBox TxtButton2;
        private TextBox TxtButton3;
        private Label label3;
        private Label label4;
        private TextBox TxtButton4;
        private Button BtnCadastro;
    }
}
