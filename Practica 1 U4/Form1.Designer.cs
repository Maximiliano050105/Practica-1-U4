namespace Practica_1_U4
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtCliente = new TextBox();
            txtMonto = new TextBox();
            btnAbrir = new Button();
            btnDeposito = new Button();
            btnRetiro = new Button();
            lstDepositos = new ListBox();
            lstRetiros = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSaldo = new TextBox();
            btnNuevo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRetiro);
            groupBox2.Controls.Add(btnDeposito);
            groupBox2.Location = new Point(12, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 77);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transacciones";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Controls.Add(txtSaldo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lstRetiros);
            groupBox3.Controls.Add(lstDepositos);
            groupBox3.Location = new Point(12, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 188);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(86, 22);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(144, 23);
            txtCliente.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(86, 71);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(144, 23);
            txtMonto.TabIndex = 3;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(256, 20);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(100, 23);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir cuenta";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(19, 34);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(99, 23);
            btnDeposito.TabIndex = 5;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            // 
            // btnRetiro
            // 
            btnRetiro.Location = new Point(162, 34);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(99, 23);
            btnRetiro.TabIndex = 6;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = true;
            // 
            // lstDepositos
            // 
            lstDepositos.FormattingEnabled = true;
            lstDepositos.ItemHeight = 15;
            lstDepositos.Location = new Point(0, 47);
            lstDepositos.Name = "lstDepositos";
            lstDepositos.Size = new Size(120, 124);
            lstDepositos.TabIndex = 0;
            // 
            // lstRetiros
            // 
            lstRetiros.FormattingEnabled = true;
            lstRetiros.ItemHeight = 15;
            lstRetiros.Location = new Point(141, 47);
            lstRetiros.Name = "lstRetiros";
            lstRetiros.Size = new Size(120, 124);
            lstRetiros.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Depositos";
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 19);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Retiros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 85);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(278, 114);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(278, 148);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(409, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtMonto;
        private TextBox txtCliente;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnAbrir;
        private Button btnRetiro;
        private Button btnDeposito;
        private TextBox txtSaldo;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox lstRetiros;
        private ListBox lstDepositos;
        private Button btnNuevo;
    }
}
