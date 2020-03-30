namespace Pong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBallColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRacketColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScoreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAIColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pongHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMedia = new System.Windows.Forms.TabPage();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.progressBarMedia = new System.Windows.Forms.ProgressBar();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabGameOver = new System.Windows.Forms.TabPage();
            this.lblEnterNAme = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblPastPlayers = new System.Windows.Forms.Label();
            this.btnAddScores = new System.Windows.Forms.Button();
            this.lstBoxHistory = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtboxBody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tabPong = new System.Windows.Forms.TabPage();
            this.lblYou = new System.Windows.Forms.Label();
            this.lblAi = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblRock12 = new System.Windows.Forms.Label();
            this.lblRock9 = new System.Windows.Forms.Label();
            this.lblRock8 = new System.Windows.Forms.Label();
            this.lblRock7 = new System.Windows.Forms.Label();
            this.lblRock6 = new System.Windows.Forms.Label();
            this.lblRock5 = new System.Windows.Forms.Label();
            this.lblRock4 = new System.Windows.Forms.Label();
            this.lblRock3 = new System.Windows.Forms.Label();
            this.lblRock2 = new System.Windows.Forms.Label();
            this.lblRock1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBall = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.lblRule7 = new System.Windows.Forms.Label();
            this.lblRule6 = new System.Windows.Forms.Label();
            this.lblRule5 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBrowser = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabGameOver.SuspendLayout();
            this.tabPong.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click_1);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBallColorToolStripMenuItem,
            this.changeRacketColorToolStripMenuItem,
            this.changeScoreColorToolStripMenuItem,
            this.changeAIColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changeBallColorToolStripMenuItem
            // 
            this.changeBallColorToolStripMenuItem.Name = "changeBallColorToolStripMenuItem";
            this.changeBallColorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changeBallColorToolStripMenuItem.Text = "Change Ball Color";
            this.changeBallColorToolStripMenuItem.Click += new System.EventHandler(this.changeBallColorToolStripMenuItem_Click);
            // 
            // changeRacketColorToolStripMenuItem
            // 
            this.changeRacketColorToolStripMenuItem.Name = "changeRacketColorToolStripMenuItem";
            this.changeRacketColorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changeRacketColorToolStripMenuItem.Text = "Change Racket Color";
            this.changeRacketColorToolStripMenuItem.Click += new System.EventHandler(this.changeRacketColorToolStripMenuItem_Click);
            // 
            // changeScoreColorToolStripMenuItem
            // 
            this.changeScoreColorToolStripMenuItem.Name = "changeScoreColorToolStripMenuItem";
            this.changeScoreColorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changeScoreColorToolStripMenuItem.Text = "Change Score Color";
            this.changeScoreColorToolStripMenuItem.Click += new System.EventHandler(this.changeScoreColorToolStripMenuItem_Click);
            // 
            // changeAIColorToolStripMenuItem
            // 
            this.changeAIColorToolStripMenuItem.Name = "changeAIColorToolStripMenuItem";
            this.changeAIColorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changeAIColorToolStripMenuItem.Text = "Change AI Color";
            this.changeAIColorToolStripMenuItem.Click += new System.EventHandler(this.changeAIColorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSoftwareToolStripMenuItem,
            this.pongHistoryToolStripMenuItem,
            this.demoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSoftwareToolStripMenuItem
            // 
            this.aboutSoftwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem});
            this.aboutSoftwareToolStripMenuItem.Name = "aboutSoftwareToolStripMenuItem";
            this.aboutSoftwareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutSoftwareToolStripMenuItem.Text = "About Software";
            // 
            // madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem
            // 
            this.madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem.Name = "madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem";
            this.madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem.Text = "Made by Logan White University of Pittsburgh At Bradford";
            // 
            // pongHistoryToolStripMenuItem
            // 
            this.pongHistoryToolStripMenuItem.Name = "pongHistoryToolStripMenuItem";
            this.pongHistoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pongHistoryToolStripMenuItem.Text = "Pong History";
            this.pongHistoryToolStripMenuItem.Click += new System.EventHandler(this.pongHistoryToolStripMenuItem_Click);
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.demoToolStripMenuItem.Text = "Demo";
            this.demoToolStripMenuItem.Click += new System.EventHandler(this.demoToolStripMenuItem_Click);
            // 
            // tabMedia
            // 
            this.tabMedia.Controls.Add(this.btnBackToMenu);
            this.tabMedia.Controls.Add(this.btnOpen);
            this.tabMedia.Controls.Add(this.progressBarMedia);
            this.tabMedia.Controls.Add(this.btnFullScreen);
            this.tabMedia.Controls.Add(this.btnStop);
            this.tabMedia.Controls.Add(this.btnPause);
            this.tabMedia.Controls.Add(this.btnPlay);
            this.tabMedia.Controls.Add(this.pictureBox1);
            this.tabMedia.Location = new System.Drawing.Point(4, 22);
            this.tabMedia.Name = "tabMedia";
            this.tabMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedia.Size = new System.Drawing.Size(878, 635);
            this.tabMedia.TabIndex = 2;
            this.tabMedia.Text = "Media";
            this.tabMedia.UseVisualStyleBackColor = true;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(34, 521);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(119, 23);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(696, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(148, 72);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBarMedia
            // 
            this.progressBarMedia.Location = new System.Drawing.Point(34, 426);
            this.progressBarMedia.Name = "progressBarMedia";
            this.progressBarMedia.Size = new System.Drawing.Size(640, 23);
            this.progressBarMedia.TabIndex = 5;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(696, 343);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(148, 38);
            this.btnFullScreen.TabIndex = 4;
            this.btnFullScreen.Text = "Fullscreen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(696, 276);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(148, 38);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(696, 205);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(148, 38);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(696, 139);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(148, 38);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabGameOver
            // 
            this.tabGameOver.BackColor = System.Drawing.Color.Ivory;
            this.tabGameOver.Controls.Add(this.lblEnterNAme);
            this.tabGameOver.Controls.Add(this.txtboxName);
            this.tabGameOver.Controls.Add(this.lblPastPlayers);
            this.tabGameOver.Controls.Add(this.btnAddScores);
            this.tabGameOver.Controls.Add(this.lstBoxHistory);
            this.tabGameOver.Controls.Add(this.btnSend);
            this.tabGameOver.Controls.Add(this.lblBody);
            this.tabGameOver.Controls.Add(this.txtboxBody);
            this.tabGameOver.Controls.Add(this.label2);
            this.tabGameOver.Controls.Add(this.txtboxEmail);
            this.tabGameOver.Controls.Add(this.lblEmail);
            this.tabGameOver.Controls.Add(this.label1);
            this.tabGameOver.Controls.Add(this.lblGameOver);
            this.tabGameOver.Controls.Add(this.btnReturnToMenu);
            this.tabGameOver.Controls.Add(this.btnRestart);
            this.tabGameOver.Location = new System.Drawing.Point(4, 22);
            this.tabGameOver.Name = "tabGameOver";
            this.tabGameOver.Padding = new System.Windows.Forms.Padding(3);
            this.tabGameOver.Size = new System.Drawing.Size(878, 635);
            this.tabGameOver.TabIndex = 1;
            this.tabGameOver.Text = "Game Over";
            // 
            // lblEnterNAme
            // 
            this.lblEnterNAme.AutoSize = true;
            this.lblEnterNAme.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNAme.Location = new System.Drawing.Point(480, 176);
            this.lblEnterNAme.Name = "lblEnterNAme";
            this.lblEnterNAme.Size = new System.Drawing.Size(138, 19);
            this.lblEnterNAme.TabIndex = 14;
            this.lblEnterNAme.Text = "Enter Your Name:";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(624, 177);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(235, 20);
            this.txtboxName.TabIndex = 13;
            // 
            // lblPastPlayers
            // 
            this.lblPastPlayers.AutoSize = true;
            this.lblPastPlayers.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastPlayers.Location = new System.Drawing.Point(618, 103);
            this.lblPastPlayers.Name = "lblPastPlayers";
            this.lblPastPlayers.Size = new System.Drawing.Size(158, 32);
            this.lblPastPlayers.TabIndex = 12;
            this.lblPastPlayers.Text = "Past Players:";
            // 
            // btnAddScores
            // 
            this.btnAddScores.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddScores.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScores.Location = new System.Drawing.Point(624, 206);
            this.btnAddScores.Name = "btnAddScores";
            this.btnAddScores.Size = new System.Drawing.Size(235, 33);
            this.btnAddScores.TabIndex = 11;
            this.btnAddScores.Text = "Add Your Score";
            this.btnAddScores.UseVisualStyleBackColor = false;
            this.btnAddScores.Click += new System.EventHandler(this.btnAddScores_Click);
            // 
            // lstBoxHistory
            // 
            this.lstBoxHistory.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxHistory.FormattingEnabled = true;
            this.lstBoxHistory.ItemHeight = 14;
            this.lstBoxHistory.Location = new System.Drawing.Point(624, 262);
            this.lstBoxHistory.Name = "lstBoxHistory";
            this.lstBoxHistory.Size = new System.Drawing.Size(235, 326);
            this.lstBoxHistory.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Window;
            this.btnSend.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(93, 324);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(271, 33);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(24, 220);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(50, 19);
            this.lblBody.TabIndex = 8;
            this.lblBody.Text = "Body:";
            // 
            // txtboxBody
            // 
            this.txtboxBody.Location = new System.Drawing.Point(93, 220);
            this.txtboxBody.Multiline = true;
            this.txtboxBody.Name = "txtboxBody";
            this.txtboxBody.ReadOnly = true;
            this.txtboxBody.Size = new System.Drawing.Size(271, 83);
            this.txtboxBody.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(93, 177);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(271, 20);
            this.txtboxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(234, 32);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email Your Scores?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uh Oh! You May Have Lost, But You Can Avenge Your Demise!";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Ivory;
            this.lblGameOver.Font = new System.Drawing.Font("Maiandra GD", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(245, 28);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(374, 65);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "GAME OVER!!";
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.Color.Pink;
            this.btnReturnToMenu.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.Location = new System.Drawing.Point(8, 533);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(504, 55);
            this.btnReturnToMenu.TabIndex = 1;
            this.btnReturnToMenu.Text = "Return To Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRestart.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(6, 450);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(504, 55);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Another Round";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tabPong
            // 
            this.tabPong.Controls.Add(this.lblYou);
            this.tabPong.Controls.Add(this.lblAi);
            this.tabPong.Controls.Add(this.lblPause);
            this.tabPong.Controls.Add(this.lblRock12);
            this.tabPong.Controls.Add(this.lblRock9);
            this.tabPong.Controls.Add(this.lblRock8);
            this.tabPong.Controls.Add(this.lblRock7);
            this.tabPong.Controls.Add(this.lblRock6);
            this.tabPong.Controls.Add(this.lblRock5);
            this.tabPong.Controls.Add(this.lblRock4);
            this.tabPong.Controls.Add(this.lblRock3);
            this.tabPong.Controls.Add(this.lblRock2);
            this.tabPong.Controls.Add(this.lblRock1);
            this.tabPong.Controls.Add(this.lblScore);
            this.tabPong.Controls.Add(this.lblPlayer);
            this.tabPong.Controls.Add(this.lblBall);
            this.tabPong.Location = new System.Drawing.Point(4, 22);
            this.tabPong.Name = "tabPong";
            this.tabPong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPong.Size = new System.Drawing.Size(878, 635);
            this.tabPong.TabIndex = 0;
            this.tabPong.Text = "Pong Game";
            this.tabPong.UseVisualStyleBackColor = true;
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(162, 481);
            this.lblYou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(185, 32);
            this.lblYou.TabIndex = 18;
            this.lblYou.Text = "This is you -->";
            // 
            // lblAi
            // 
            this.lblAi.BackColor = System.Drawing.Color.Black;
            this.lblAi.Location = new System.Drawing.Point(400, 44);
            this.lblAi.Name = "lblAi";
            this.lblAi.Size = new System.Drawing.Size(100, 5);
            this.lblAi.TabIndex = 17;
            this.lblAi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Maiandra GD", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(139, 198);
            this.lblPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(579, 65);
            this.lblPause.TabIndex = 16;
            this.lblPause.Text = "Press \"P\" To Start Game";
            // 
            // lblRock12
            // 
            this.lblRock12.BackColor = System.Drawing.Color.Brown;
            this.lblRock12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock12.Location = new System.Drawing.Point(784, 273);
            this.lblRock12.Name = "lblRock12";
            this.lblRock12.Size = new System.Drawing.Size(10, 10);
            this.lblRock12.TabIndex = 15;
            this.lblRock12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock9
            // 
            this.lblRock9.BackColor = System.Drawing.Color.Brown;
            this.lblRock9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock9.Location = new System.Drawing.Point(796, 423);
            this.lblRock9.Name = "lblRock9";
            this.lblRock9.Size = new System.Drawing.Size(10, 10);
            this.lblRock9.TabIndex = 12;
            this.lblRock9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock8
            // 
            this.lblRock8.BackColor = System.Drawing.Color.Brown;
            this.lblRock8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock8.Location = new System.Drawing.Point(675, 361);
            this.lblRock8.Name = "lblRock8";
            this.lblRock8.Size = new System.Drawing.Size(10, 10);
            this.lblRock8.TabIndex = 11;
            this.lblRock8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock7
            // 
            this.lblRock7.BackColor = System.Drawing.Color.Brown;
            this.lblRock7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock7.Location = new System.Drawing.Point(267, 266);
            this.lblRock7.Name = "lblRock7";
            this.lblRock7.Size = new System.Drawing.Size(14, 17);
            this.lblRock7.TabIndex = 10;
            this.lblRock7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock6
            // 
            this.lblRock6.BackColor = System.Drawing.Color.Brown;
            this.lblRock6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock6.Location = new System.Drawing.Point(386, 284);
            this.lblRock6.Name = "lblRock6";
            this.lblRock6.Size = new System.Drawing.Size(125, 43);
            this.lblRock6.TabIndex = 9;
            this.lblRock6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock5
            // 
            this.lblRock5.BackColor = System.Drawing.Color.Brown;
            this.lblRock5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock5.Location = new System.Drawing.Point(80, 423);
            this.lblRock5.Name = "lblRock5";
            this.lblRock5.Size = new System.Drawing.Size(10, 10);
            this.lblRock5.TabIndex = 8;
            this.lblRock5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock4
            // 
            this.lblRock4.BackColor = System.Drawing.Color.Brown;
            this.lblRock4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock4.Location = new System.Drawing.Point(718, 149);
            this.lblRock4.Name = "lblRock4";
            this.lblRock4.Size = new System.Drawing.Size(10, 10);
            this.lblRock4.TabIndex = 7;
            this.lblRock4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock3
            // 
            this.lblRock3.BackColor = System.Drawing.Color.Brown;
            this.lblRock3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock3.Location = new System.Drawing.Point(147, 294);
            this.lblRock3.Name = "lblRock3";
            this.lblRock3.Size = new System.Drawing.Size(33, 22);
            this.lblRock3.TabIndex = 6;
            this.lblRock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock2
            // 
            this.lblRock2.BackColor = System.Drawing.Color.Brown;
            this.lblRock2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock2.Location = new System.Drawing.Point(32, 198);
            this.lblRock2.Name = "lblRock2";
            this.lblRock2.Size = new System.Drawing.Size(10, 10);
            this.lblRock2.TabIndex = 5;
            this.lblRock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRock1
            // 
            this.lblRock1.BackColor = System.Drawing.Color.Brown;
            this.lblRock1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRock1.Location = new System.Drawing.Point(215, 349);
            this.lblRock1.Name = "lblRock1";
            this.lblRock1.Size = new System.Drawing.Size(10, 10);
            this.lblRock1.TabIndex = 4;
            this.lblRock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(672, 25);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 32);
            this.lblScore.TabIndex = 3;
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Black;
            this.lblPlayer.Location = new System.Drawing.Point(400, 500);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(100, 5);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBall
            // 
            this.lblBall.BackColor = System.Drawing.Color.Black;
            this.lblBall.Location = new System.Drawing.Point(400, 160);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(15, 15);
            this.lblBall.TabIndex = 0;
            this.lblBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.Ivory;
            this.tabMenu.Controls.Add(this.lblRule7);
            this.tabMenu.Controls.Add(this.lblRule6);
            this.tabMenu.Controls.Add(this.lblRule5);
            this.tabMenu.Controls.Add(this.lblRule3);
            this.tabMenu.Controls.Add(this.lblRule2);
            this.tabMenu.Controls.Add(this.lblRule1);
            this.tabMenu.Controls.Add(this.lblRules);
            this.tabMenu.Controls.Add(this.btnStart);
            this.tabMenu.Controls.Add(this.lblTitle);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(878, 635);
            this.tabMenu.TabIndex = 3;
            this.tabMenu.Text = "Menu";
            // 
            // lblRule7
            // 
            this.lblRule7.AutoSize = true;
            this.lblRule7.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule7.ForeColor = System.Drawing.Color.Black;
            this.lblRule7.Location = new System.Drawing.Point(261, 435);
            this.lblRule7.Name = "lblRule7";
            this.lblRule7.Size = new System.Drawing.Size(271, 19);
            this.lblRule7.TabIndex = 8;
            this.lblRule7.Text = "* Use Options To Change Colors";
            // 
            // lblRule6
            // 
            this.lblRule6.AutoSize = true;
            this.lblRule6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule6.ForeColor = System.Drawing.Color.Black;
            this.lblRule6.Location = new System.Drawing.Point(261, 323);
            this.lblRule6.Name = "lblRule6";
            this.lblRule6.Size = new System.Drawing.Size(349, 19);
            this.lblRule6.TabIndex = 7;
            this.lblRule6.Text = "* Your Bar Will Get Smaller Each Bounce! ";
            // 
            // lblRule5
            // 
            this.lblRule5.AutoSize = true;
            this.lblRule5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule5.ForeColor = System.Drawing.Color.Black;
            this.lblRule5.Location = new System.Drawing.Point(261, 396);
            this.lblRule5.Name = "lblRule5";
            this.lblRule5.Size = new System.Drawing.Size(212, 19);
            this.lblRule5.TabIndex = 6;
            this.lblRule5.Text = "* \"P\" To Pause The Game";
            // 
            // lblRule3
            // 
            this.lblRule3.AutoSize = true;
            this.lblRule3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule3.ForeColor = System.Drawing.Color.Black;
            this.lblRule3.Location = new System.Drawing.Point(261, 359);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(327, 19);
            this.lblRule3.TabIndex = 5;
            this.lblRule3.Text = "* \"A\" To Move Left. \"D\" To Move Right";
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule2.ForeColor = System.Drawing.Color.Black;
            this.lblRule2.Location = new System.Drawing.Point(261, 286);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(277, 19);
            this.lblRule2.TabIndex = 4;
            this.lblRule2.Text = "* Don\'t Let The Ball Get Past You";
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule1.ForeColor = System.Drawing.Color.Black;
            this.lblRule1.Location = new System.Drawing.Point(261, 250);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(367, 19);
            this.lblRule1.TabIndex = 3;
            this.lblRule1.Text = "* Get The Ball Past Your Opponnent To Win";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Maiandra GD", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.Black;
            this.lblRules.Location = new System.Drawing.Point(279, 145);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(280, 65);
            this.lblRules.TabIndex = 2;
            this.lblRules.Text = "Directions:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.Font = new System.Drawing.Font("Maiandra GD", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(199, 486);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(456, 68);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Maiandra GD", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(188, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(467, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Pong!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Controls.Add(this.tabPong);
            this.tabControl1.Controls.Add(this.tabGameOver);
            this.tabControl1.Controls.Add(this.tabMedia);
            this.tabControl1.Controls.Add(this.tabBrowser);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 661);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabBrowser
            // 
            this.tabBrowser.Controls.Add(this.webBrowser1);
            this.tabBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.Size = new System.Drawing.Size(878, 635);
            this.tabBrowser.TabIndex = 4;
            this.tabBrowser.Text = "Web Browser";
            this.tabBrowser.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(878, 635);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(392, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(494, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 661);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabGameOver.ResumeLayout(false);
            this.tabGameOver.PerformLayout();
            this.tabPong.ResumeLayout(false);
            this.tabPong.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBallColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRacketColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pongHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScoreColorToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem madeByLoganWhiteUniversityOfPittsburghAtBradfordToolStripMenuItem;
        private System.Windows.Forms.TabPage tabMedia;
        private System.Windows.Forms.TabPage tabGameOver;
        private System.Windows.Forms.TabPage tabPong;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblAi;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblRock12;
        private System.Windows.Forms.Label lblRock9;
        private System.Windows.Forms.Label lblRock8;
        private System.Windows.Forms.Label lblRock7;
        private System.Windows.Forms.Label lblRock6;
        private System.Windows.Forms.Label lblRock5;
        private System.Windows.Forms.Label lblRock4;
        private System.Windows.Forms.Label lblRock3;
        private System.Windows.Forms.Label lblRock2;
        private System.Windows.Forms.Label lblRock1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBrowser;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRule6;
        private System.Windows.Forms.Label lblRule5;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem changeAIColorToolStripMenuItem;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label lblRule7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtboxBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstBoxHistory;
        private System.Windows.Forms.Label lblPastPlayers;
        private System.Windows.Forms.Button btnAddScores;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarMedia;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblEnterNAme;
        private System.Windows.Forms.TextBox txtboxName;
    }
}

