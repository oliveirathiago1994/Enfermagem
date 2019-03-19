namespace enfunip.apresentacao
{
    partial class FrmMainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainmenu));
            this.imglogo = new System.Windows.Forms.PictureBox();
            this.boxfixed = new System.Windows.Forms.TreeView();
            this.lbl_userfix = new System.Windows.Forms.Label();
            this.lbl_functionfix = new System.Windows.Forms.Label();
            this.lbl_datafix = new System.Windows.Forms.Label();
            this.lbl_userbd = new System.Windows.Forms.Label();
            this.lbl_functionbd = new System.Windows.Forms.Label();
            this.lbl_databd = new System.Windows.Forms.Label();
            this.barra_menu = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoEmAbertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualidadeDoAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.barra_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglogo
            // 
            this.imglogo.BackColor = System.Drawing.Color.Transparent;
            this.imglogo.Enabled = false;
            this.imglogo.Image = global::enfunip.Properties.Resources.logounip3;
            this.imglogo.ImageLocation = "";
            this.imglogo.Location = new System.Drawing.Point(452, 271);
            this.imglogo.Name = "imglogo";
            this.imglogo.Size = new System.Drawing.Size(465, 202);
            this.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imglogo.TabIndex = 0;
            this.imglogo.TabStop = false;
            // 
            // boxfixed
            // 
            this.boxfixed.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.boxfixed.Location = new System.Drawing.Point(61, 514);
            this.boxfixed.Name = "boxfixed";
            this.boxfixed.Size = new System.Drawing.Size(304, 139);
            this.boxfixed.TabIndex = 1;
            // 
            // lbl_userfix
            // 
            this.lbl_userfix.AutoSize = true;
            this.lbl_userfix.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_userfix.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userfix.Location = new System.Drawing.Point(70, 530);
            this.lbl_userfix.Name = "lbl_userfix";
            this.lbl_userfix.Size = new System.Drawing.Size(56, 16);
            this.lbl_userfix.TabIndex = 2;
            this.lbl_userfix.Text = "Usuário:";
            this.lbl_userfix.Click += new System.EventHandler(this.lbl_userfix_Click);
            // 
            // lbl_functionfix
            // 
            this.lbl_functionfix.AutoSize = true;
            this.lbl_functionfix.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_functionfix.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_functionfix.Location = new System.Drawing.Point(70, 576);
            this.lbl_functionfix.Name = "lbl_functionfix";
            this.lbl_functionfix.Size = new System.Drawing.Size(55, 16);
            this.lbl_functionfix.TabIndex = 3;
            this.lbl_functionfix.Text = "Função:";
            // 
            // lbl_datafix
            // 
            this.lbl_datafix.AutoSize = true;
            this.lbl_datafix.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_datafix.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datafix.Location = new System.Drawing.Point(70, 623);
            this.lbl_datafix.Name = "lbl_datafix";
            this.lbl_datafix.Size = new System.Drawing.Size(70, 16);
            this.lbl_datafix.TabIndex = 4;
            this.lbl_datafix.Text = "Data/Hora:";
            // 
            // lbl_userbd
            // 
            this.lbl_userbd.AutoSize = true;
            this.lbl_userbd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_userbd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userbd.Location = new System.Drawing.Point(135, 530);
            this.lbl_userbd.Name = "lbl_userbd";
            this.lbl_userbd.Size = new System.Drawing.Size(11, 16);
            this.lbl_userbd.TabIndex = 5;
            this.lbl_userbd.Text = "l";
            // 
            // lbl_functionbd
            // 
            this.lbl_functionbd.AutoSize = true;
            this.lbl_functionbd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_functionbd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_functionbd.Location = new System.Drawing.Point(135, 576);
            this.lbl_functionbd.Name = "lbl_functionbd";
            this.lbl_functionbd.Size = new System.Drawing.Size(11, 16);
            this.lbl_functionbd.TabIndex = 6;
            this.lbl_functionbd.Text = "l";
            // 
            // lbl_databd
            // 
            this.lbl_databd.AutoSize = true;
            this.lbl_databd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_databd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_databd.Location = new System.Drawing.Point(146, 623);
            this.lbl_databd.Name = "lbl_databd";
            this.lbl_databd.Size = new System.Drawing.Size(11, 16);
            this.lbl_databd.TabIndex = 7;
            this.lbl_databd.Text = "l";
            // 
            // barra_menu
            // 
            this.barra_menu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.barra_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.barra_menu.Location = new System.Drawing.Point(0, 0);
            this.barra_menu.Name = "barra_menu";
            this.barra_menu.Padding = new System.Windows.Forms.Padding(2);
            this.barra_menu.Size = new System.Drawing.Size(1352, 24);
            this.barra_menu.TabIndex = 8;
            this.barra_menu.Text = "Pacientes";
            this.barra_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_pac_ItemClicked);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDePacientesToolStripMenuItem,
            this.novoAtendimentoToolStripMenuItem,
            this.atendimentoEmAbertoToolStripMenuItem,
            this.cadastroDePacientesToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // consultaDePacientesToolStripMenuItem
            // 
            this.consultaDePacientesToolStripMenuItem.Name = "consultaDePacientesToolStripMenuItem";
            this.consultaDePacientesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultaDePacientesToolStripMenuItem.Text = "Consulta de Pacientes";
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            this.novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            this.novoAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.novoAtendimentoToolStripMenuItem.Text = "Novo Atendimento";
            // 
            // atendimentoEmAbertoToolStripMenuItem
            // 
            this.atendimentoEmAbertoToolStripMenuItem.Name = "atendimentoEmAbertoToolStripMenuItem";
            this.atendimentoEmAbertoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.atendimentoEmAbertoToolStripMenuItem.Text = "Atendimento em Aberto";
            // 
            // cadastroDePacientesToolStripMenuItem
            // 
            this.cadastroDePacientesToolStripMenuItem.Name = "cadastroDePacientesToolStripMenuItem";
            this.cadastroDePacientesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroDePacientesToolStripMenuItem.Text = "Cadastro de Pacientes";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem,
            this.consultarFuncionárioToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            // 
            // consultarFuncionárioToolStripMenuItem
            // 
            this.consultarFuncionárioToolStripMenuItem.Name = "consultarFuncionárioToolStripMenuItem";
            this.consultarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarFuncionárioToolStripMenuItem.Text = "Consultar Funcionário";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarToolStripMenuItem,
            this.consultarAgendaToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendarToolStripMenuItem.Text = "Agendar";
            this.agendarToolStripMenuItem.Click += new System.EventHandler(this.agendarToolStripMenuItem_Click);
            // 
            // consultarAgendaToolStripMenuItem
            // 
            this.consultarAgendaToolStripMenuItem.Name = "consultarAgendaToolStripMenuItem";
            this.consultarAgendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarAgendaToolStripMenuItem.Text = "Consultar Agenda";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.registroToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qualidadeDoAtendimentoToolStripMenuItem,
            this.relToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // qualidadeDoAtendimentoToolStripMenuItem
            // 
            this.qualidadeDoAtendimentoToolStripMenuItem.Name = "qualidadeDoAtendimentoToolStripMenuItem";
            this.qualidadeDoAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.qualidadeDoAtendimentoToolStripMenuItem.Text = "Qualidade do Atendimento";
            // 
            // relToolStripMenuItem
            // 
            this.relToolStripMenuItem.Name = "relToolStripMenuItem";
            this.relToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.relToolStripMenuItem.Text = "Relatório de Atendimentos";
            this.relToolStripMenuItem.Click += new System.EventHandler(this.relToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suporteToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.atualizaçãoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // atualizaçãoToolStripMenuItem
            // 
            this.atualizaçãoToolStripMenuItem.Name = "atualizaçãoToolStripMenuItem";
            this.atualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.atualizaçãoToolStripMenuItem.Text = "Atualização";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logOutToolStripMenuItem.Text = "LogOut";
            // 
            // FrmMainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 715);
            this.Controls.Add(this.lbl_databd);
            this.Controls.Add(this.lbl_functionbd);
            this.Controls.Add(this.lbl_userbd);
            this.Controls.Add(this.lbl_datafix);
            this.Controls.Add(this.lbl_functionfix);
            this.Controls.Add(this.lbl_userfix);
            this.Controls.Add(this.boxfixed);
            this.Controls.Add(this.imglogo);
            this.Controls.Add(this.barra_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barra_menu;
            this.Name = "FrmMainmenu";
            this.Text = "Enfermagem Unip";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.barra_menu.ResumeLayout(false);
            this.barra_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imglogo;
        private System.Windows.Forms.TreeView boxfixed;
        private System.Windows.Forms.Label lbl_userfix;
        private System.Windows.Forms.Label lbl_functionfix;
        private System.Windows.Forms.Label lbl_datafix;
        private System.Windows.Forms.Label lbl_userbd;
        private System.Windows.Forms.Label lbl_functionbd;
        private System.Windows.Forms.Label lbl_databd;
        private System.Windows.Forms.MenuStrip barra_menu;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoEmAbertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualidadeDoAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}