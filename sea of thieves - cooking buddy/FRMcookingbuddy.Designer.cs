namespace sea_of_thieves___cooking_buddy
{
    partial class FRMcookingbuddy
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMcookingbuddy));
            this.TIMERbasicFish = new System.Windows.Forms.Timer(this.components);
            this.TIMERbasicMeat = new System.Windows.Forms.Timer(this.components);
            this.TIMERtrophyFish = new System.Windows.Forms.Timer(this.components);
            this.TIMERmonsterMeat = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLbasicFishStatus = new System.Windows.Forms.Label();
            this.LBLbMeatStatus = new System.Windows.Forms.Label();
            this.LBLtFischStatus = new System.Windows.Forms.Label();
            this.LBLmMeatStatus = new System.Windows.Forms.Label();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.PayPal = new System.Windows.Forms.ToolStripMenuItem();
            this.Reddit = new System.Windows.Forms.ToolStripMenuItem();
            this.Wiki = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.CMDcookMMeatAbort = new System.Windows.Forms.Button();
            this.CMDcookTFishAbort = new System.Windows.Forms.Button();
            this.CMDcookMeatAbort = new System.Windows.Forms.Button();
            this.CMDcookFishAbort = new System.Windows.Forms.Button();
            this.CMDcookMMeat = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CMDcookTFish = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CMDcookMeat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMDcookFish = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TIMERbasicFish
            // 
            this.TIMERbasicFish.Interval = 45000;
            this.TIMERbasicFish.Tick += new System.EventHandler(this.TIMERbasicFish_Tick);
            // 
            // TIMERbasicMeat
            // 
            this.TIMERbasicMeat.Interval = 65000;
            this.TIMERbasicMeat.Tick += new System.EventHandler(this.TIMERbasicMeat_Tick);
            // 
            // TIMERtrophyFish
            // 
            this.TIMERtrophyFish.Interval = 95000;
            this.TIMERtrophyFish.Tick += new System.EventHandler(this.TIMERtrophyFish_Tick);
            // 
            // TIMERmonsterMeat
            // 
            this.TIMERmonsterMeat.Interval = 125000;
            this.TIMERmonsterMeat.Tick += new System.EventHandler(this.TIMERmonsterMeat_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "basic fish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "basic meat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "trophy fish";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "monster meat";
            // 
            // LBLbasicFishStatus
            // 
            this.LBLbasicFishStatus.AutoSize = true;
            this.LBLbasicFishStatus.ForeColor = System.Drawing.Color.Red;
            this.LBLbasicFishStatus.Location = new System.Drawing.Point(69, 60);
            this.LBLbasicFishStatus.Name = "LBLbasicFishStatus";
            this.LBLbasicFishStatus.Size = new System.Drawing.Size(73, 18);
            this.LBLbasicFishStatus.TabIndex = 31;
            this.LBLbasicFishStatus.Text = "Cooking";
            // 
            // LBLbMeatStatus
            // 
            this.LBLbMeatStatus.AutoSize = true;
            this.LBLbMeatStatus.ForeColor = System.Drawing.Color.Red;
            this.LBLbMeatStatus.Location = new System.Drawing.Point(204, 58);
            this.LBLbMeatStatus.Name = "LBLbMeatStatus";
            this.LBLbMeatStatus.Size = new System.Drawing.Size(73, 18);
            this.LBLbMeatStatus.TabIndex = 32;
            this.LBLbMeatStatus.Text = "Cooking";
            // 
            // LBLtFischStatus
            // 
            this.LBLtFischStatus.AutoSize = true;
            this.LBLtFischStatus.ForeColor = System.Drawing.Color.Red;
            this.LBLtFischStatus.Location = new System.Drawing.Point(339, 58);
            this.LBLtFischStatus.Name = "LBLtFischStatus";
            this.LBLtFischStatus.Size = new System.Drawing.Size(73, 18);
            this.LBLtFischStatus.TabIndex = 33;
            this.LBLtFischStatus.Text = "Cooking";
            // 
            // LBLmMeatStatus
            // 
            this.LBLmMeatStatus.AutoSize = true;
            this.LBLmMeatStatus.ForeColor = System.Drawing.Color.Red;
            this.LBLmMeatStatus.Location = new System.Drawing.Point(474, 58);
            this.LBLmMeatStatus.Name = "LBLmMeatStatus";
            this.LBLmMeatStatus.Size = new System.Drawing.Size(73, 18);
            this.LBLmMeatStatus.TabIndex = 34;
            this.LBLmMeatStatus.Text = "Cooking";
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitHub,
            this.PayPal,
            this.Reddit,
            this.Wiki});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(190, 92);
            // 
            // GitHub
            // 
            this.GitHub.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.GitHub1;
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(189, 22);
            this.GitHub.Text = "open github";
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // PayPal
            // 
            this.PayPal.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.Donation;
            this.PayPal.Name = "PayPal";
            this.PayPal.Size = new System.Drawing.Size(189, 22);
            this.PayPal.Text = "donate via paypal";
            this.PayPal.Click += new System.EventHandler(this.PayPal_Click);
            // 
            // Reddit
            // 
            this.Reddit.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.Reddit;
            this.Reddit.Name = "Reddit";
            this.Reddit.Size = new System.Drawing.Size(189, 22);
            this.Reddit.Text = "open /r/Seaofthieves/";
            this.Reddit.Click += new System.EventHandler(this.Reddit_Click);
            // 
            // Wiki
            // 
            this.Wiki.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.Help;
            this.Wiki.Name = "Wiki";
            this.Wiki.Size = new System.Drawing.Size(189, 22);
            this.Wiki.Text = "open wiki";
            this.Wiki.Click += new System.EventHandler(this.Wiki_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Help;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(544, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 35;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CMDcookMMeatAbort
            // 
            this.CMDcookMMeatAbort.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat_Abort;
            this.CMDcookMMeatAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookMMeatAbort.Enabled = false;
            this.CMDcookMMeatAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookMMeatAbort.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookMMeatAbort.Location = new System.Drawing.Point(508, 26);
            this.CMDcookMMeatAbort.Name = "CMDcookMMeatAbort";
            this.CMDcookMMeatAbort.Size = new System.Drawing.Size(25, 25);
            this.CMDcookMMeatAbort.TabIndex = 30;
            this.CMDcookMMeatAbort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookMMeatAbort.UseVisualStyleBackColor = true;
            this.CMDcookMMeatAbort.Click += new System.EventHandler(this.CMDcookMMeatAbort_Click);
            // 
            // CMDcookTFishAbort
            // 
            this.CMDcookTFishAbort.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat_Abort;
            this.CMDcookTFishAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookTFishAbort.Enabled = false;
            this.CMDcookTFishAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookTFishAbort.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookTFishAbort.Location = new System.Drawing.Point(373, 26);
            this.CMDcookTFishAbort.Name = "CMDcookTFishAbort";
            this.CMDcookTFishAbort.Size = new System.Drawing.Size(25, 25);
            this.CMDcookTFishAbort.TabIndex = 29;
            this.CMDcookTFishAbort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookTFishAbort.UseVisualStyleBackColor = true;
            this.CMDcookTFishAbort.Click += new System.EventHandler(this.CMDcookTFishAbort_Click);
            // 
            // CMDcookMeatAbort
            // 
            this.CMDcookMeatAbort.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat_Abort;
            this.CMDcookMeatAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookMeatAbort.Enabled = false;
            this.CMDcookMeatAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookMeatAbort.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookMeatAbort.Location = new System.Drawing.Point(238, 26);
            this.CMDcookMeatAbort.Name = "CMDcookMeatAbort";
            this.CMDcookMeatAbort.Size = new System.Drawing.Size(25, 25);
            this.CMDcookMeatAbort.TabIndex = 28;
            this.CMDcookMeatAbort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookMeatAbort.UseVisualStyleBackColor = true;
            this.CMDcookMeatAbort.Click += new System.EventHandler(this.CMDcookMeatAbort_Click);
            // 
            // CMDcookFishAbort
            // 
            this.CMDcookFishAbort.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat_Abort;
            this.CMDcookFishAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookFishAbort.Enabled = false;
            this.CMDcookFishAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookFishAbort.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookFishAbort.Location = new System.Drawing.Point(102, 28);
            this.CMDcookFishAbort.Name = "CMDcookFishAbort";
            this.CMDcookFishAbort.Size = new System.Drawing.Size(25, 25);
            this.CMDcookFishAbort.TabIndex = 27;
            this.CMDcookFishAbort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookFishAbort.UseVisualStyleBackColor = true;
            this.CMDcookFishAbort.Click += new System.EventHandler(this.CMDcookFishAbort_Click);
            // 
            // CMDcookMMeat
            // 
            this.CMDcookMMeat.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat;
            this.CMDcookMMeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookMMeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookMMeat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookMMeat.Location = new System.Drawing.Point(477, 26);
            this.CMDcookMMeat.Name = "CMDcookMMeat";
            this.CMDcookMMeat.Size = new System.Drawing.Size(25, 25);
            this.CMDcookMMeat.TabIndex = 26;
            this.CMDcookMMeat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookMMeat.UseVisualStyleBackColor = true;
            this.CMDcookMMeat.Click += new System.EventHandler(this.CMDcookMMeat_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.Kraken;
            this.pictureBox4.Location = new System.Drawing.Point(418, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // CMDcookTFish
            // 
            this.CMDcookTFish.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat;
            this.CMDcookTFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookTFish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookTFish.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookTFish.Location = new System.Drawing.Point(342, 26);
            this.CMDcookTFish.Name = "CMDcookTFish";
            this.CMDcookTFish.Size = new System.Drawing.Size(25, 25);
            this.CMDcookTFish.TabIndex = 22;
            this.CMDcookTFish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookTFish.UseVisualStyleBackColor = true;
            this.CMDcookTFish.Click += new System.EventHandler(this.CMDcookTFish_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.Trophy_Fish;
            this.pictureBox3.Location = new System.Drawing.Point(283, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // CMDcookMeat
            // 
            this.CMDcookMeat.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat;
            this.CMDcookMeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookMeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookMeat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookMeat.Location = new System.Drawing.Point(207, 26);
            this.CMDcookMeat.Name = "CMDcookMeat";
            this.CMDcookMeat.Size = new System.Drawing.Size(25, 25);
            this.CMDcookMeat.TabIndex = 18;
            this.CMDcookMeat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookMeat.UseVisualStyleBackColor = true;
            this.CMDcookMeat.Click += new System.EventHandler(this.CMDcookMeat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.Meat;
            this.pictureBox1.Location = new System.Drawing.Point(148, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CMDcookFish
            // 
            this.CMDcookFish.BackgroundImage = global::sea_of_thieves___cooking_buddy.Properties.Resources.Chef_Hat;
            this.CMDcookFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDcookFish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMDcookFish.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDcookFish.Location = new System.Drawing.Point(71, 28);
            this.CMDcookFish.Name = "CMDcookFish";
            this.CMDcookFish.Size = new System.Drawing.Size(25, 25);
            this.CMDcookFish.TabIndex = 14;
            this.CMDcookFish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CMDcookFish.UseVisualStyleBackColor = true;
            this.CMDcookFish.Click += new System.EventHandler(this.CMDcookFish_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sea_of_thieves___cooking_buddy.Properties.Resources.Normal_Fish;
            this.pictureBox2.Location = new System.Drawing.Point(12, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FRMcookingbuddy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 88);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBLmMeatStatus);
            this.Controls.Add(this.LBLtFischStatus);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LBLbMeatStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLbasicFishStatus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CMDcookMMeatAbort);
            this.Controls.Add(this.CMDcookFish);
            this.Controls.Add(this.CMDcookTFishAbort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMDcookMeatAbort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CMDcookFishAbort);
            this.Controls.Add(this.CMDcookMeat);
            this.Controls.Add(this.CMDcookMMeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CMDcookTFish);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FRMcookingbuddy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sea of thieves - cooking buddy";
            this.Load += new System.EventHandler(this.FRMcookingbuddy_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRMcookingbuddy_KeyPress);
            this.CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TIMERbasicFish;
        private System.Windows.Forms.Timer TIMERbasicMeat;
        private System.Windows.Forms.Timer TIMERtrophyFish;
        private System.Windows.Forms.Timer TIMERmonsterMeat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CMDcookFish;
        private System.Windows.Forms.Button CMDcookMMeat;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CMDcookTFish;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CMDcookMeat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CMDcookFishAbort;
        private System.Windows.Forms.Button CMDcookMMeatAbort;
        private System.Windows.Forms.Button CMDcookTFishAbort;
        private System.Windows.Forms.Button CMDcookMeatAbort;
        private System.Windows.Forms.Label LBLmMeatStatus;
        private System.Windows.Forms.Label LBLtFischStatus;
        private System.Windows.Forms.Label LBLbMeatStatus;
        private System.Windows.Forms.Label LBLbasicFishStatus;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem GitHub;
        private System.Windows.Forms.ToolStripMenuItem PayPal;
        private System.Windows.Forms.ToolStripMenuItem Reddit;
        private System.Windows.Forms.ToolStripMenuItem Wiki;
        private System.Windows.Forms.Button button1;
    }
}

