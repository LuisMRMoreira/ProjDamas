namespace ProjetoDamas
{
    partial class ViewOponenteServidor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOponenteServidor));
            this.pBarraCinzenta = new System.Windows.Forms.Panel();
            this.pBarraTranparentePreta = new System.Windows.Forms.Panel();
            this.pJogadorLocal = new System.Windows.Forms.PictureBox();
            this.pInfoVencedor = new System.Windows.Forms.Panel();
            this.lNomeVencedor = new System.Windows.Forms.Label();
            this.lNomeVencedorN = new System.Windows.Forms.Label();
            this.lCountryVencedor = new System.Windows.Forms.Label();
            this.lCountryVencedorN = new System.Windows.Forms.Label();
            this.pBarraLatencia2 = new System.Windows.Forms.Panel();
            this.pLatencia = new System.Windows.Forms.Panel();
            this.pBarraLatencia1 = new System.Windows.Forms.Panel();
            this.pBarraLatencia4 = new System.Windows.Forms.Panel();
            this.pBarraLatencia3 = new System.Windows.Forms.Panel();
            this.lGameOpponent = new System.Windows.Forms.Label();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.pBUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lNomeOponente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lCountryOponente = new System.Windows.Forms.Label();
            this.tTOpponentFound = new System.Windows.Forms.ToolTip(this.components);
            this.tTLantency = new System.Windows.Forms.ToolTip(this.components);
            this.bSearchOppoent = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.pServerIP = new System.Windows.Forms.Panel();
            this.pServerIPImage = new System.Windows.Forms.Panel();
            this.pBServerIPImage = new System.Windows.Forms.PictureBox();
            this.ctBServerIP = new ProjetoDamas.CueTextBox();
            this.pOpponent = new System.Windows.Forms.Panel();
            this.pSeacrhOpponent = new System.Windows.Forms.Panel();
            this.cBSearchInTheServer = new System.Windows.Forms.CheckBox();
            this.pOpponentNickname = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBOpponentNicknameImage = new System.Windows.Forms.PictureBox();
            this.cTBOpponentNickname = new ProjetoDamas.CueTextBox();
            this.pBarraTranparentePreta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pJogadorLocal)).BeginInit();
            this.pInfoVencedor.SuspendLayout();
            this.pLatencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.pServerIP.SuspendLayout();
            this.pServerIPImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBServerIPImage)).BeginInit();
            this.pOpponent.SuspendLayout();
            this.pSeacrhOpponent.SuspendLayout();
            this.pOpponentNickname.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBOpponentNicknameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pBarraCinzenta
            // 
            this.pBarraCinzenta.BackColor = System.Drawing.Color.DimGray;
            this.pBarraCinzenta.Location = new System.Drawing.Point(4, 4);
            this.pBarraCinzenta.Name = "pBarraCinzenta";
            this.pBarraCinzenta.Size = new System.Drawing.Size(11, 265);
            this.pBarraCinzenta.TabIndex = 0;
            // 
            // pBarraTranparentePreta
            // 
            this.pBarraTranparentePreta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBarraTranparentePreta.Controls.Add(this.pBarraCinzenta);
            this.pBarraTranparentePreta.Location = new System.Drawing.Point(273, 70);
            this.pBarraTranparentePreta.Name = "pBarraTranparentePreta";
            this.pBarraTranparentePreta.Size = new System.Drawing.Size(20, 273);
            this.pBarraTranparentePreta.TabIndex = 1;
            // 
            // pJogadorLocal
            // 
            this.pJogadorLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pJogadorLocal.BackColor = System.Drawing.Color.Transparent;
            this.pJogadorLocal.Image = global::ProjetoDamas.Properties.Resources.DamaPreta;
            this.pJogadorLocal.Location = new System.Drawing.Point(64, 74);
            this.pJogadorLocal.Name = "pJogadorLocal";
            this.pJogadorLocal.Size = new System.Drawing.Size(153, 171);
            this.pJogadorLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pJogadorLocal.TabIndex = 2;
            this.pJogadorLocal.TabStop = false;
            // 
            // pInfoVencedor
            // 
            this.pInfoVencedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pInfoVencedor.BackColor = System.Drawing.Color.Transparent;
            this.pInfoVencedor.Controls.Add(this.lNomeVencedor);
            this.pInfoVencedor.Controls.Add(this.lNomeVencedorN);
            this.pInfoVencedor.Controls.Add(this.lCountryVencedor);
            this.pInfoVencedor.Controls.Add(this.lCountryVencedorN);
            this.pInfoVencedor.Location = new System.Drawing.Point(30, 253);
            this.pInfoVencedor.Name = "pInfoVencedor";
            this.pInfoVencedor.Size = new System.Drawing.Size(237, 72);
            this.pInfoVencedor.TabIndex = 89;
            // 
            // lNomeVencedor
            // 
            this.lNomeVencedor.AutoSize = true;
            this.lNomeVencedor.BackColor = System.Drawing.Color.Transparent;
            this.lNomeVencedor.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lNomeVencedor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lNomeVencedor.Location = new System.Drawing.Point(14, 9);
            this.lNomeVencedor.Name = "lNomeVencedor";
            this.lNomeVencedor.Size = new System.Drawing.Size(62, 19);
            this.lNomeVencedor.TabIndex = 81;
            this.lNomeVencedor.Text = "Name: ";
            // 
            // lNomeVencedorN
            // 
            this.lNomeVencedorN.AutoSize = true;
            this.lNomeVencedorN.BackColor = System.Drawing.Color.Transparent;
            this.lNomeVencedorN.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lNomeVencedorN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lNomeVencedorN.Location = new System.Drawing.Point(129, 9);
            this.lNomeVencedorN.Name = "lNomeVencedorN";
            this.lNomeVencedorN.Size = new System.Drawing.Size(24, 19);
            this.lNomeVencedorN.TabIndex = 82;
            this.lNomeVencedorN.Text = "...";
            // 
            // lCountryVencedor
            // 
            this.lCountryVencedor.AutoSize = true;
            this.lCountryVencedor.BackColor = System.Drawing.Color.Transparent;
            this.lCountryVencedor.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lCountryVencedor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lCountryVencedor.Location = new System.Drawing.Point(14, 44);
            this.lCountryVencedor.Name = "lCountryVencedor";
            this.lCountryVencedor.Size = new System.Drawing.Size(83, 19);
            this.lCountryVencedor.TabIndex = 83;
            this.lCountryVencedor.Text = "Country: ";
            // 
            // lCountryVencedorN
            // 
            this.lCountryVencedorN.AutoSize = true;
            this.lCountryVencedorN.BackColor = System.Drawing.Color.Transparent;
            this.lCountryVencedorN.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lCountryVencedorN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lCountryVencedorN.Location = new System.Drawing.Point(129, 44);
            this.lCountryVencedorN.Name = "lCountryVencedorN";
            this.lCountryVencedorN.Size = new System.Drawing.Size(24, 19);
            this.lCountryVencedorN.TabIndex = 84;
            this.lCountryVencedorN.Text = "...";
            // 
            // pBarraLatencia2
            // 
            this.pBarraLatencia2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBarraLatencia2.Location = new System.Drawing.Point(16, 20);
            this.pBarraLatencia2.Name = "pBarraLatencia2";
            this.pBarraLatencia2.Size = new System.Drawing.Size(6, 19);
            this.pBarraLatencia2.TabIndex = 90;
            // 
            // pLatencia
            // 
            this.pLatencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pLatencia.BackColor = System.Drawing.Color.Transparent;
            this.pLatencia.Controls.Add(this.pBarraLatencia1);
            this.pLatencia.Controls.Add(this.pBarraLatencia4);
            this.pLatencia.Controls.Add(this.pBarraLatencia3);
            this.pLatencia.Controls.Add(this.pBarraLatencia2);
            this.pLatencia.Location = new System.Drawing.Point(578, 361);
            this.pLatencia.Name = "pLatencia";
            this.pLatencia.Size = new System.Drawing.Size(47, 42);
            this.pLatencia.TabIndex = 2;
            this.tTLantency.SetToolTip(this.pLatencia, "Latency");
            // 
            // pBarraLatencia1
            // 
            this.pBarraLatencia1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBarraLatencia1.Location = new System.Drawing.Point(6, 27);
            this.pBarraLatencia1.Name = "pBarraLatencia1";
            this.pBarraLatencia1.Size = new System.Drawing.Size(6, 12);
            this.pBarraLatencia1.TabIndex = 91;
            // 
            // pBarraLatencia4
            // 
            this.pBarraLatencia4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBarraLatencia4.Location = new System.Drawing.Point(36, 3);
            this.pBarraLatencia4.Name = "pBarraLatencia4";
            this.pBarraLatencia4.Size = new System.Drawing.Size(6, 37);
            this.pBarraLatencia4.TabIndex = 92;
            // 
            // pBarraLatencia3
            // 
            this.pBarraLatencia3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBarraLatencia3.Location = new System.Drawing.Point(26, 11);
            this.pBarraLatencia3.Name = "pBarraLatencia3";
            this.pBarraLatencia3.Size = new System.Drawing.Size(6, 28);
            this.pBarraLatencia3.TabIndex = 91;
            // 
            // lGameOpponent
            // 
            this.lGameOpponent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lGameOpponent.AutoSize = true;
            this.lGameOpponent.BackColor = System.Drawing.Color.Transparent;
            this.lGameOpponent.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.lGameOpponent.ForeColor = System.Drawing.Color.DimGray;
            this.lGameOpponent.Location = new System.Drawing.Point(172, 9);
            this.lGameOpponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGameOpponent.Name = "lGameOpponent";
            this.lGameOpponent.Size = new System.Drawing.Size(258, 45);
            this.lGameOpponent.TabIndex = 90;
            this.lGameOpponent.Text = "Game Opponent";
            // 
            // pbReturn
            // 
            this.pbReturn.BackColor = System.Drawing.Color.Transparent;
            this.pbReturn.Image = global::ProjetoDamas.Properties.Resources.a429924cb33912470dd40d51a2f760ec_go_back_icon_clip_art_at_clkercom_vector_clip_art_online__300_300;
            this.pbReturn.Location = new System.Drawing.Point(12, 12);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(29, 28);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturn.TabIndex = 91;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // pBUser
            // 
            this.pBUser.BackColor = System.Drawing.Color.Transparent;
            this.pBUser.Image = ((System.Drawing.Image)(resources.GetObject("pBUser.Image")));
            this.pBUser.Location = new System.Drawing.Point(42, 4);
            this.pBUser.Margin = new System.Windows.Forms.Padding(2);
            this.pBUser.Name = "pBUser";
            this.pBUser.Size = new System.Drawing.Size(153, 171);
            this.pBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBUser.TabIndex = 92;
            this.pBUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNomeOponente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lCountryOponente);
            this.panel1.Location = new System.Drawing.Point(3, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 72);
            this.panel1.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Name: ";
            // 
            // lNomeOponente
            // 
            this.lNomeOponente.AutoSize = true;
            this.lNomeOponente.BackColor = System.Drawing.Color.Transparent;
            this.lNomeOponente.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lNomeOponente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lNomeOponente.Location = new System.Drawing.Point(129, 9);
            this.lNomeOponente.Name = "lNomeOponente";
            this.lNomeOponente.Size = new System.Drawing.Size(24, 19);
            this.lNomeOponente.TabIndex = 82;
            this.lNomeOponente.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "Country: ";
            // 
            // lCountryOponente
            // 
            this.lCountryOponente.AutoSize = true;
            this.lCountryOponente.BackColor = System.Drawing.Color.Transparent;
            this.lCountryOponente.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold);
            this.lCountryOponente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lCountryOponente.Location = new System.Drawing.Point(129, 44);
            this.lCountryOponente.Name = "lCountryOponente";
            this.lCountryOponente.Size = new System.Drawing.Size(24, 19);
            this.lCountryOponente.TabIndex = 84;
            this.lCountryOponente.Text = "...";
            // 
            // bSearchOppoent
            // 
            this.bSearchOppoent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSearchOppoent.BackColor = System.Drawing.Color.Transparent;
            this.bSearchOppoent.FlatAppearance.BorderSize = 0;
            this.bSearchOppoent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearchOppoent.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearchOppoent.ForeColor = System.Drawing.Color.DimGray;
            this.bSearchOppoent.Location = new System.Drawing.Point(152, 364);
            this.bSearchOppoent.Margin = new System.Windows.Forms.Padding(2);
            this.bSearchOppoent.Name = "bSearchOppoent";
            this.bSearchOppoent.Size = new System.Drawing.Size(299, 38);
            this.bSearchOppoent.TabIndex = 95;
            this.bSearchOppoent.Text = "Search opponent";
            this.bSearchOppoent.UseVisualStyleBackColor = false;
            this.bSearchOppoent.Click += new System.EventHandler(this.bSearchOppoent_Click);
            // 
            // bPlay
            // 
            this.bPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bPlay.BackColor = System.Drawing.Color.Transparent;
            this.bPlay.FlatAppearance.BorderSize = 0;
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlay.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlay.ForeColor = System.Drawing.Color.DimGray;
            this.bPlay.Location = new System.Drawing.Point(120, 361);
            this.bPlay.Margin = new System.Windows.Forms.Padding(2);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(299, 38);
            this.bPlay.TabIndex = 96;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = false;
            this.bPlay.Visible = false;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // pServerIP
            // 
            this.pServerIP.BackColor = System.Drawing.SystemColors.Control;
            this.pServerIP.Controls.Add(this.pServerIPImage);
            this.pServerIP.Controls.Add(this.ctBServerIP);
            this.pServerIP.Location = new System.Drawing.Point(3, 76);
            this.pServerIP.Name = "pServerIP";
            this.pServerIP.Size = new System.Drawing.Size(240, 32);
            this.pServerIP.TabIndex = 97;
            // 
            // pServerIPImage
            // 
            this.pServerIPImage.BackColor = System.Drawing.Color.IndianRed;
            this.pServerIPImage.Controls.Add(this.pBServerIPImage);
            this.pServerIPImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pServerIPImage.Location = new System.Drawing.Point(0, 0);
            this.pServerIPImage.Name = "pServerIPImage";
            this.pServerIPImage.Size = new System.Drawing.Size(42, 32);
            this.pServerIPImage.TabIndex = 10;
            // 
            // pBServerIPImage
            // 
            this.pBServerIPImage.BackColor = System.Drawing.Color.Transparent;
            this.pBServerIPImage.Image = global::ProjetoDamas.Properties.Resources.IP_icon;
            this.pBServerIPImage.Location = new System.Drawing.Point(2, 2);
            this.pBServerIPImage.Margin = new System.Windows.Forms.Padding(2);
            this.pBServerIPImage.Name = "pBServerIPImage";
            this.pBServerIPImage.Size = new System.Drawing.Size(38, 28);
            this.pBServerIPImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBServerIPImage.TabIndex = 9;
            this.pBServerIPImage.TabStop = false;
            // 
            // ctBServerIP
            // 
            this.ctBServerIP.BackColor = System.Drawing.SystemColors.Control;
            this.ctBServerIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctBServerIP.Cue = "Server IP";
            this.ctBServerIP.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctBServerIP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ctBServerIP.Location = new System.Drawing.Point(45, 3);
            this.ctBServerIP.MaxLength = 20;
            this.ctBServerIP.Name = "ctBServerIP";
            this.ctBServerIP.Size = new System.Drawing.Size(192, 22);
            this.ctBServerIP.TabIndex = 16;
            this.ctBServerIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctBServerIP_KeyPress);
            // 
            // pOpponent
            // 
            this.pOpponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pOpponent.BackColor = System.Drawing.Color.Transparent;
            this.pOpponent.Controls.Add(this.panel1);
            this.pOpponent.Controls.Add(this.pBUser);
            this.pOpponent.Location = new System.Drawing.Point(340, 57);
            this.pOpponent.Name = "pOpponent";
            this.pOpponent.Size = new System.Drawing.Size(247, 273);
            this.pOpponent.TabIndex = 2;
            // 
            // pSeacrhOpponent
            // 
            this.pSeacrhOpponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pSeacrhOpponent.BackColor = System.Drawing.Color.Transparent;
            this.pSeacrhOpponent.Controls.Add(this.cBSearchInTheServer);
            this.pSeacrhOpponent.Controls.Add(this.pOpponentNickname);
            this.pSeacrhOpponent.Controls.Add(this.pServerIP);
            this.pSeacrhOpponent.Location = new System.Drawing.Point(340, 51);
            this.pSeacrhOpponent.Name = "pSeacrhOpponent";
            this.pSeacrhOpponent.Size = new System.Drawing.Size(247, 265);
            this.pSeacrhOpponent.TabIndex = 94;
            // 
            // cBSearchInTheServer
            // 
            this.cBSearchInTheServer.AutoSize = true;
            this.cBSearchInTheServer.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold);
            this.cBSearchInTheServer.ForeColor = System.Drawing.Color.IndianRed;
            this.cBSearchInTheServer.Location = new System.Drawing.Point(5, 165);
            this.cBSearchInTheServer.Name = "cBSearchInTheServer";
            this.cBSearchInTheServer.Size = new System.Drawing.Size(166, 21);
            this.cBSearchInTheServer.TabIndex = 100;
            this.cBSearchInTheServer.Text = "Search in the server";
            this.cBSearchInTheServer.UseVisualStyleBackColor = true;
            this.cBSearchInTheServer.CheckedChanged += new System.EventHandler(this.cBSearchInTheServer_CheckedChanged);
            // 
            // pOpponentNickname
            // 
            this.pOpponentNickname.BackColor = System.Drawing.SystemColors.Control;
            this.pOpponentNickname.Controls.Add(this.panel3);
            this.pOpponentNickname.Controls.Add(this.cTBOpponentNickname);
            this.pOpponentNickname.Location = new System.Drawing.Point(5, 122);
            this.pOpponentNickname.Name = "pOpponentNickname";
            this.pOpponentNickname.Size = new System.Drawing.Size(238, 32);
            this.pOpponentNickname.TabIndex = 98;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.pBOpponentNicknameImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 32);
            this.panel3.TabIndex = 10;
            // 
            // pBOpponentNicknameImage
            // 
            this.pBOpponentNicknameImage.BackColor = System.Drawing.Color.Transparent;
            this.pBOpponentNicknameImage.Image = ((System.Drawing.Image)(resources.GetObject("pBOpponentNicknameImage.Image")));
            this.pBOpponentNicknameImage.Location = new System.Drawing.Point(2, 2);
            this.pBOpponentNicknameImage.Margin = new System.Windows.Forms.Padding(2);
            this.pBOpponentNicknameImage.Name = "pBOpponentNicknameImage";
            this.pBOpponentNicknameImage.Size = new System.Drawing.Size(38, 28);
            this.pBOpponentNicknameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBOpponentNicknameImage.TabIndex = 99;
            this.pBOpponentNicknameImage.TabStop = false;
            // 
            // cTBOpponentNickname
            // 
            this.cTBOpponentNickname.BackColor = System.Drawing.SystemColors.Control;
            this.cTBOpponentNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cTBOpponentNickname.Cue = "Opponent Nickname";
            this.cTBOpponentNickname.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBOpponentNickname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cTBOpponentNickname.Location = new System.Drawing.Point(45, 3);
            this.cTBOpponentNickname.MaxLength = 20;
            this.cTBOpponentNickname.Name = "cTBOpponentNickname";
            this.cTBOpponentNickname.Size = new System.Drawing.Size(189, 22);
            this.cTBOpponentNickname.TabIndex = 16;
            // 
            // ViewOponenteServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDamas.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.pSeacrhOpponent);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.bSearchOppoent);
            this.Controls.Add(this.pOpponent);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.lGameOpponent);
            this.Controls.Add(this.pInfoVencedor);
            this.Controls.Add(this.pJogadorLocal);
            this.Controls.Add(this.pBarraTranparentePreta);
            this.Controls.Add(this.pLatencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(607, 425);
            this.Name = "ViewOponenteServidor";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.ViewOponenteServidor_Load);
            this.pBarraTranparentePreta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pJogadorLocal)).EndInit();
            this.pInfoVencedor.ResumeLayout(false);
            this.pInfoVencedor.PerformLayout();
            this.pLatencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pServerIP.ResumeLayout(false);
            this.pServerIP.PerformLayout();
            this.pServerIPImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBServerIPImage)).EndInit();
            this.pOpponent.ResumeLayout(false);
            this.pSeacrhOpponent.ResumeLayout(false);
            this.pSeacrhOpponent.PerformLayout();
            this.pOpponentNickname.ResumeLayout(false);
            this.pOpponentNickname.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBOpponentNicknameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBarraCinzenta;
        private System.Windows.Forms.Panel pBarraTranparentePreta;
        private System.Windows.Forms.PictureBox pJogadorLocal;
        private System.Windows.Forms.Panel pInfoVencedor;
        private System.Windows.Forms.Label lNomeVencedor;
        private System.Windows.Forms.Label lNomeVencedorN;
        private System.Windows.Forms.Label lCountryVencedor;
        private System.Windows.Forms.Label lCountryVencedorN;
        private System.Windows.Forms.Panel pBarraLatencia2;
        private System.Windows.Forms.Panel pLatencia;
        private System.Windows.Forms.Panel pBarraLatencia1;
        private System.Windows.Forms.Panel pBarraLatencia4;
        private System.Windows.Forms.Panel pBarraLatencia3;
        private System.Windows.Forms.Label lGameOpponent;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.PictureBox pBUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNomeOponente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCountryOponente;
        private System.Windows.Forms.ToolTip tTLantency;
        private System.Windows.Forms.ToolTip tTOpponentFound;
        private System.Windows.Forms.Button bSearchOppoent;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Panel pServerIP;
        private System.Windows.Forms.Panel pServerIPImage;
        private CueTextBox ctBServerIP;
        private System.Windows.Forms.Panel pOpponent;
        private System.Windows.Forms.Panel pSeacrhOpponent;
        private System.Windows.Forms.Panel pOpponentNickname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pBServerIPImage;
        private CueTextBox cTBOpponentNickname;
        private System.Windows.Forms.PictureBox pBOpponentNicknameImage;
        private System.Windows.Forms.CheckBox cBSearchInTheServer;
    }
}