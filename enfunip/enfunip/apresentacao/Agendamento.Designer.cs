namespace enfunip.apresentacao
{
    partial class Agendamento
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtLocalAgenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.txtHoraAgenda = new System.Windows.Forms.MaskedTextBox();
            this.dtAgenda = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(283, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 26);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(149, 268);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 26);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.Green;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgendar.Location = new System.Drawing.Point(15, 268);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(128, 26);
            this.btnAgendar.TabIndex = 28;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 300);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(773, 147);
            this.listBox1.TabIndex = 27;
            // 
            // txtLocalAgenda
            // 
            this.txtLocalAgenda.Location = new System.Drawing.Point(15, 206);
            this.txtLocalAgenda.Name = "txtLocalAgenda";
            this.txtLocalAgenda.Size = new System.Drawing.Size(390, 20);
            this.txtLocalAgenda.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Local";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(15, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(93, 20);
            this.txtUser.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hora";
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(12, 78);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(96, 26);
            this.btnPaciente.TabIndex = 20;
            this.btnPaciente.Text = "SELECIONAR";
            this.btnPaciente.UseVisualStyleBackColor = true;
            // 
            // txtHoraAgenda
            // 
            this.txtHoraAgenda.Location = new System.Drawing.Point(283, 140);
            this.txtHoraAgenda.Mask = "90:00";
            this.txtHoraAgenda.Name = "txtHoraAgenda";
            this.txtHoraAgenda.Size = new System.Drawing.Size(46, 20);
            this.txtHoraAgenda.TabIndex = 19;
            this.txtHoraAgenda.ValidatingType = typeof(System.DateTime);
            // 
            // dtAgenda
            // 
            this.dtAgenda.Location = new System.Drawing.Point(15, 140);
            this.dtAgenda.Name = "dtAgenda";
            this.dtAgenda.Size = new System.Drawing.Size(227, 20);
            this.dtAgenda.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Paciente";
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtLocalAgenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.txtHoraAgenda);
            this.Controls.Add(this.dtAgenda);
            this.Controls.Add(this.label1);
            this.Name = "Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtLocalAgenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.MaskedTextBox txtHoraAgenda;
        private System.Windows.Forms.DateTimePicker dtAgenda;
        private System.Windows.Forms.Label label1;
    }
}