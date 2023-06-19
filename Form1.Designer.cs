namespace Teste3Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnCadastro = new Button();
            txtDeposito = new TextBox();
            btndeposito = new Button();
            txtLevantamento = new TextBox();
            btnLevantamento = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LabelTitular = new Label();
            LabelNrDaConta = new Label();
            label4 = new Label();
            txtSaldo = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 270);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nome titular...";
            textBox1.Size = new Size(204, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 351);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "nr Conta...";
            textBox2.Size = new Size(204, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 448);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Deposito...";
            textBox3.Size = new Size(204, 31);
            textBox3.TabIndex = 2;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(53, 535);
            btnCadastro.Margin = new Padding(4, 5, 4, 5);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(107, 38);
            btnCadastro.TabIndex = 3;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txtDeposito
            // 
            txtDeposito.Location = new Point(444, 270);
            txtDeposito.Margin = new Padding(4, 5, 4, 5);
            txtDeposito.Name = "txtDeposito";
            txtDeposito.PlaceholderText = "Valor a depositar";
            txtDeposito.Size = new Size(183, 31);
            txtDeposito.TabIndex = 9;
            txtDeposito.TextChanged += txtDeposito_TextChanged;
            // 
            // btndeposito
            // 
            btndeposito.Location = new Point(479, 324);
            btndeposito.Margin = new Padding(4, 5, 4, 5);
            btndeposito.Name = "btndeposito";
            btndeposito.Size = new Size(107, 38);
            btndeposito.TabIndex = 11;
            btndeposito.Text = "Deposito";
            btndeposito.UseVisualStyleBackColor = true;
            btndeposito.Click += btndeposito_Click;
            // 
            // txtLevantamento
            // 
            txtLevantamento.Location = new Point(444, 403);
            txtLevantamento.Margin = new Padding(4, 5, 4, 5);
            txtLevantamento.Name = "txtLevantamento";
            txtLevantamento.PlaceholderText = "Valor a levantar";
            txtLevantamento.Size = new Size(183, 31);
            txtLevantamento.TabIndex = 12;
            txtLevantamento.TextChanged += txtLevantamento_TextChanged;
            // 
            // btnLevantamento
            // 
            btnLevantamento.Location = new Point(466, 459);
            btnLevantamento.Margin = new Padding(4, 5, 4, 5);
            btnLevantamento.Name = "btnLevantamento";
            btnLevantamento.Size = new Size(134, 38);
            btnLevantamento.TabIndex = 13;
            btnLevantamento.Text = "Levantamento";
            btnLevantamento.UseVisualStyleBackColor = true;
            btnLevantamento.Click += btnLevantamento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(194, 569);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 14;
            label1.Text = "Detalhes Da Conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 622);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 15;
            label2.Text = "Titular :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 670);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 16;
            label3.Text = "Nr da conta  :";
            // 
            // LabelTitular
            // 
            LabelTitular.AutoSize = true;
            LabelTitular.Location = new Point(331, 622);
            LabelTitular.Margin = new Padding(4, 0, 4, 0);
            LabelTitular.Name = "LabelTitular";
            LabelTitular.Size = new Size(0, 25);
            LabelTitular.TabIndex = 17;
            // 
            // LabelNrDaConta
            // 
            LabelNrDaConta.AutoSize = true;
            LabelNrDaConta.Location = new Point(355, 670);
            LabelNrDaConta.Margin = new Padding(4, 0, 4, 0);
            LabelNrDaConta.Name = "LabelNrDaConta";
            LabelNrDaConta.Size = new Size(0, 25);
            LabelNrDaConta.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 715);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 19;
            label4.Text = "Saldo :";
            // 
            // txtSaldo
            // 
            txtSaldo.AutoSize = true;
            txtSaldo.Location = new Point(355, 715);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(0, 25);
            txtSaldo.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(235, 30);
            label5.TabIndex = 21;
            label5.Text = "Dados  Para Cadastro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(415, 215);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(224, 30);
            label6.TabIndex = 22;
            label6.Text = "Operacoes Da Conta";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(296, 28);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 30);
            label7.TabIndex = 24;
            label7.Text = "DDB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 750);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSaldo);
            Controls.Add(label4);
            Controls.Add(LabelNrDaConta);
            Controls.Add(LabelTitular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLevantamento);
            Controls.Add(txtLevantamento);
            Controls.Add(btndeposito);
            Controls.Add(txtDeposito);
            Controls.Add(btnCadastro);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(662, 806);
            MinimumSize = new Size(662, 806);
            Name = "Form1";
            Text = "Douglas Dinivio Bila";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnCadastro;
        private TextBox txtDeposito;
        private Button btndeposito;
        private TextBox txtLevantamento;
        private Button btnLevantamento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LabelTitular;
        private Label LabelNrDaConta;
        private Label label4;
        private Label txtSaldo;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
    }
}