
namespace FoodLog
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.calPanel = new System.Windows.Forms.Panel();
            this.cal = new System.Windows.Forms.Label();
            this.dailyCal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statPanel = new System.Windows.Forms.Panel();
            this.statPercent = new CircularProgressBar.CircularProgressBar();
            this.dailyPercent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.protPanel = new System.Windows.Forms.Panel();
            this.protLabel = new System.Windows.Forms.Label();
            this.dailyProt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carbPanel = new System.Windows.Forms.Panel();
            this.carbLabel = new System.Windows.Forms.Label();
            this.dailyCarb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fatPanel = new System.Windows.Forms.Panel();
            this.fatLabel = new System.Windows.Forms.Label();
            this.dailyFat = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.calPanel.SuspendLayout();
            this.statPanel.SuspendLayout();
            this.protPanel.SuspendLayout();
            this.carbPanel.SuspendLayout();
            this.fatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.sum);
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 144);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 126);
            this.pnlNav.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(0, 535);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(186, 42);
            this.exit.TabIndex = 1;
            this.exit.Text = "Kilépés       ";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Info
            // 
            this.Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.Info.FlatAppearance.BorderSize = 0;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Info.Image = ((System.Drawing.Image)(resources.GetObject("Info.Image")));
            this.Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Info.Location = new System.Drawing.Point(0, 270);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(186, 42);
            this.Info.TabIndex = 1;
            this.Info.Text = "Info            ";
            this.Info.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // sum
            // 
            this.sum.Dock = System.Windows.Forms.DockStyle.Top;
            this.sum.FlatAppearance.BorderSize = 0;
            this.sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.sum.Image = ((System.Drawing.Image)(resources.GetObject("sum.Image")));
            this.sum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sum.Location = new System.Drawing.Point(0, 228);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(186, 42);
            this.sum.TabIndex = 1;
            this.sum.Text = "Összegzés ";
            this.sum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // btnCal
            // 
            this.btnCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCal.Image = ((System.Drawing.Image)(resources.GetObject("btnCal.Image")));
            this.btnCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCal.Location = new System.Drawing.Point(0, 186);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(186, 42);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Naptár      ";
            this.btnCal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Főoldal     ";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(149)))));
            this.userName.Location = new System.Drawing.Point(51, 101);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(85, 16);
            this.userName.TabIndex = 1;
            this.userName.Text = "Admin";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.statusLabel.Location = new System.Drawing.Point(210, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(116, 32);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Főoldal";
            // 
            // calPanel
            // 
            this.calPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.calPanel.Controls.Add(this.cal);
            this.calPanel.Controls.Add(this.dailyCal);
            this.calPanel.Controls.Add(this.label2);
            this.calPanel.Location = new System.Drawing.Point(233, 86);
            this.calPanel.Name = "calPanel";
            this.calPanel.Size = new System.Drawing.Size(258, 130);
            this.calPanel.TabIndex = 2;
            // 
            // cal
            // 
            this.cal.AutoSize = true;
            this.cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.cal.Location = new System.Drawing.Point(13, 53);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(159, 32);
            this.cal.TabIndex = 1;
            this.cal.Text = "1687/1800";
            // 
            // dailyCal
            // 
            this.dailyCal.AutoSize = true;
            this.dailyCal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.dailyCal.Location = new System.Drawing.Point(20, 85);
            this.dailyCal.Name = "dailyCal";
            this.dailyCal.Size = new System.Drawing.Size(185, 17);
            this.dailyCal.TabIndex = 0;
            this.dailyCal.Text = "Összesen elfogyasztott kalória";
            this.dailyCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bevitt kalória";
            // 
            // statPanel
            // 
            this.statPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.statPanel.Controls.Add(this.statPercent);
            this.statPanel.Controls.Add(this.dailyPercent);
            this.statPanel.Controls.Add(this.label5);
            this.statPanel.Location = new System.Drawing.Point(233, 228);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(258, 318);
            this.statPanel.TabIndex = 2;
            // 
            // statPercent
            // 
            this.statPercent.AnimationSpeed = 500;
            this.statPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.statPercent.Font = new System.Drawing.Font("Yu Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statPercent.ForeColor = System.Drawing.Color.White;
            this.statPercent.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.statPercent.InnerMargin = 2;
            this.statPercent.InnerWidth = -1;
            this.statPercent.Location = new System.Drawing.Point(52, 80);
            this.statPercent.MarqueeAnimationSpeed = 2000;
            this.statPercent.Name = "statPercent";
            this.statPercent.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.statPercent.OuterMargin = -25;
            this.statPercent.OuterWidth = 26;
            this.statPercent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.statPercent.ProgressWidth = 7;
            this.statPercent.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statPercent.Size = new System.Drawing.Size(150, 150);
            this.statPercent.StartAngle = 270;
            this.statPercent.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.statPercent.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.statPercent.SubscriptText = "";
            this.statPercent.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.statPercent.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.statPercent.SuperscriptText = "";
            this.statPercent.TabIndex = 1;
            this.statPercent.Text = "50%";
            this.statPercent.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.statPercent.Value = 70;
            // 
            // dailyPercent
            // 
            this.dailyPercent.AutoSize = true;
            this.dailyPercent.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.dailyPercent.Location = new System.Drawing.Point(29, 274);
            this.dailyPercent.Name = "dailyPercent";
            this.dailyPercent.Size = new System.Drawing.Size(200, 17);
            this.dailyPercent.TabIndex = 0;
            this.dailyPercent.Text = "Összesen elfogyasztott kalória %";
            this.dailyPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bevitt kalória";
            // 
            // protPanel
            // 
            this.protPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.protPanel.Controls.Add(this.protLabel);
            this.protPanel.Controls.Add(this.dailyProt);
            this.protPanel.Controls.Add(this.label8);
            this.protPanel.Location = new System.Drawing.Point(593, 86);
            this.protPanel.Name = "protPanel";
            this.protPanel.Size = new System.Drawing.Size(258, 130);
            this.protPanel.TabIndex = 2;
            // 
            // protLabel
            // 
            this.protLabel.AutoSize = true;
            this.protLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.protLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.protLabel.Location = new System.Drawing.Point(20, 53);
            this.protLabel.Name = "protLabel";
            this.protLabel.Size = new System.Drawing.Size(90, 32);
            this.protLabel.TabIndex = 1;
            this.protLabel.Text = "200 g";
            // 
            // dailyProt
            // 
            this.dailyProt.AutoSize = true;
            this.dailyProt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyProt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.dailyProt.Location = new System.Drawing.Point(20, 85);
            this.dailyProt.Name = "dailyProt";
            this.dailyProt.Size = new System.Drawing.Size(186, 17);
            this.dailyProt.TabIndex = 0;
            this.dailyProt.Text = "Összesen elfogyasztott fehérje";
            this.dailyProt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bevitt fehérje";
            // 
            // carbPanel
            // 
            this.carbPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.carbPanel.Controls.Add(this.carbLabel);
            this.carbPanel.Controls.Add(this.dailyCarb);
            this.carbPanel.Controls.Add(this.label11);
            this.carbPanel.Location = new System.Drawing.Point(593, 228);
            this.carbPanel.Name = "carbPanel";
            this.carbPanel.Size = new System.Drawing.Size(258, 130);
            this.carbPanel.TabIndex = 2;
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.carbLabel.Location = new System.Drawing.Point(20, 53);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(90, 32);
            this.carbLabel.TabIndex = 1;
            this.carbLabel.Text = "200 g";
            // 
            // dailyCarb
            // 
            this.dailyCarb.AutoSize = true;
            this.dailyCarb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyCarb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.dailyCarb.Location = new System.Drawing.Point(20, 85);
            this.dailyCarb.Name = "dailyCarb";
            this.dailyCarb.Size = new System.Drawing.Size(206, 17);
            this.dailyCarb.TabIndex = 0;
            this.dailyCarb.Text = "Összesen elfogyasztott szénhidrát";
            this.dailyCarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bevitt szénhidrát";
            // 
            // fatPanel
            // 
            this.fatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.fatPanel.Controls.Add(this.fatLabel);
            this.fatPanel.Controls.Add(this.dailyFat);
            this.fatPanel.Controls.Add(this.label14);
            this.fatPanel.Location = new System.Drawing.Point(593, 373);
            this.fatPanel.Name = "fatPanel";
            this.fatPanel.Size = new System.Drawing.Size(258, 130);
            this.fatPanel.TabIndex = 2;
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.fatLabel.Location = new System.Drawing.Point(20, 53);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(90, 32);
            this.fatLabel.TabIndex = 1;
            this.fatLabel.Text = "200 g";
            // 
            // dailyFat
            // 
            this.dailyFat.AutoSize = true;
            this.dailyFat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.dailyFat.Location = new System.Drawing.Point(20, 85);
            this.dailyFat.Name = "dailyFat";
            this.dailyFat.Size = new System.Drawing.Size(166, 17);
            this.dailyFat.TabIndex = 0;
            this.dailyFat.Text = "Összesen elfogyasztott zsír";
            this.dailyFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(20, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Bevitt zsír";
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(862, 515);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 50);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 3;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(914, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(883, 10);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.statPanel);
            this.Controls.Add(this.fatPanel);
            this.Controls.Add(this.carbPanel);
            this.Controls.Add(this.protPanel);
            this.Controls.Add(this.calPanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food logger";
            this.Activated += new System.EventHandler(this.Food_Activated);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.calPanel.ResumeLayout(false);
            this.calPanel.PerformLayout();
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            this.protPanel.ResumeLayout(false);
            this.protPanel.PerformLayout();
            this.carbPanel.ResumeLayout(false);
            this.carbPanel.PerformLayout();
            this.fatPanel.ResumeLayout(false);
            this.fatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel calPanel;
        private System.Windows.Forms.Label cal;
        private System.Windows.Forms.Label dailyCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel statPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel protPanel;
        private System.Windows.Forms.Label protLabel;
        private System.Windows.Forms.Label dailyProt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel carbPanel;
        private System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Label dailyCarb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel fatPanel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label dailyFat;
        private System.Windows.Forms.Label label14;
        private CircularProgressBar.CircularProgressBar statPercent;
        private System.Windows.Forms.Label dailyPercent;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button Info;
    }
}

