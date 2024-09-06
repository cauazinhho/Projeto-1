namespace Projeto_1.View
{
    partial class TelaCadastroAnimais
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_raca = new TextBox();
            tbx_name = new TextBox();
            cbx_porte = new ComboBox();
            btn_cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 28);
            label1.Name = "label1";
            label1.Size = new Size(286, 38);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Animais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(140, 138);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(140, 188);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Raça:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(140, 230);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 3;
            label4.Text = "Porte:";
            // 
            // tbx_raca
            // 
            tbx_raca.Location = new Point(214, 193);
            tbx_raca.Name = "tbx_raca";
            tbx_raca.Size = new Size(100, 23);
            tbx_raca.TabIndex = 5;
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(214, 143);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(309, 23);
            tbx_name.TabIndex = 6;
            tbx_name.Text = " ";
            // 
            // cbx_porte
            // 
            cbx_porte.FormattingEnabled = true;
            cbx_porte.Items.AddRange(new object[] { "Pequeno ", "Medio ", "Grande" });
            cbx_porte.Location = new Point(212, 235);
            cbx_porte.Name = "cbx_porte";
            cbx_porte.Size = new Size(121, 23);
            cbx_porte.TabIndex = 7;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(136, 339);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(581, 56);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // TelaCadastroAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cadastrar);
            Controls.Add(cbx_porte);
            Controls.Add(tbx_name);
            Controls.Add(tbx_raca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastroAnimais";
            ShowIcon = false;
            Text = "Sistema de Cadastro de Animais";
            Load += TelaCadastroAnimais_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_raca;
        private TextBox tbx_name;
        private ComboBox cbx_porte;
        private Button btn_cadastrar;
    }
}