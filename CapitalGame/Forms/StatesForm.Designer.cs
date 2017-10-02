namespace CapitalGame
{
    partial class StateGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateGameForm));
            this.CapitalListBox = new System.Windows.Forms.ListBox();
            this.StateLbl = new System.Windows.Forms.Label();
            this.TimeLeftLbl = new System.Windows.Forms.Label();
            this.CorrectLbl = new System.Windows.Forms.Label();
            this.AttemptsLbl = new System.Windows.Forms.Label();
            this.CapitalLbl = new System.Windows.Forms.Label();
            this.StateTxtBox = new System.Windows.Forms.TextBox();
            this.TimeLeftTxtBox = new System.Windows.Forms.TextBox();
            this.CorrectBox = new System.Windows.Forms.TextBox();
            this.AttemptsBox = new System.Windows.Forms.TextBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.TimeLeftTmr = new System.Windows.Forms.Timer(this.components);
            this.StateCapitalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Options_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.RegionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Regions_Europe = new System.Windows.Forms.ToolStripMenuItem();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.AnswerPicBox = new System.Windows.Forms.PictureBox();
            this.StateCapitalMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CapitalListBox
            // 
            this.CapitalListBox.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitalListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CapitalListBox.FormattingEnabled = true;
            this.CapitalListBox.ItemHeight = 12;
            this.CapitalListBox.Location = new System.Drawing.Point(416, 54);
            this.CapitalListBox.Name = "CapitalListBox";
            this.CapitalListBox.Size = new System.Drawing.Size(135, 208);
            this.CapitalListBox.TabIndex = 0;
            this.CapitalListBox.SelectedIndexChanged += new System.EventHandler(this.CapitalListBox_SelectedIndexChanged);
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLbl.ForeColor = System.Drawing.Color.Red;
            this.StateLbl.Location = new System.Drawing.Point(12, 42);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(160, 15);
            this.StateLbl.TabIndex = 1;
            this.StateLbl.Text = "What is the capital of:";
            // 
            // TimeLeftLbl
            // 
            this.TimeLeftLbl.AutoSize = true;
            this.TimeLeftLbl.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftLbl.ForeColor = System.Drawing.Color.Red;
            this.TimeLeftLbl.Location = new System.Drawing.Point(49, 121);
            this.TimeLeftLbl.Name = "TimeLeftLbl";
            this.TimeLeftLbl.Size = new System.Drawing.Size(152, 15);
            this.TimeLeftLbl.TabIndex = 2;
            this.TimeLeftLbl.Text = "Time Left to Answer:";
            this.TimeLeftLbl.Click += new System.EventHandler(this.TimeLeftLbl_Click);
            // 
            // CorrectLbl
            // 
            this.CorrectLbl.AutoSize = true;
            this.CorrectLbl.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLbl.ForeColor = System.Drawing.Color.Red;
            this.CorrectLbl.Location = new System.Drawing.Point(258, 192);
            this.CorrectLbl.Name = "CorrectLbl";
            this.CorrectLbl.Size = new System.Drawing.Size(59, 15);
            this.CorrectLbl.TabIndex = 3;
            this.CorrectLbl.Text = "Correct";
            this.CorrectLbl.Click += new System.EventHandler(this.CorrectLbl_Click);
            // 
            // AttemptsLbl
            // 
            this.AttemptsLbl.AutoSize = true;
            this.AttemptsLbl.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsLbl.ForeColor = System.Drawing.Color.Red;
            this.AttemptsLbl.Location = new System.Drawing.Point(68, 192);
            this.AttemptsLbl.Name = "AttemptsLbl";
            this.AttemptsLbl.Size = new System.Drawing.Size(73, 15);
            this.AttemptsLbl.TabIndex = 4;
            this.AttemptsLbl.Text = "Attempts";
            this.AttemptsLbl.Click += new System.EventHandler(this.AttemptsLbl_Click);
            // 
            // CapitalLbl
            // 
            this.CapitalLbl.AutoSize = true;
            this.CapitalLbl.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitalLbl.ForeColor = System.Drawing.Color.Red;
            this.CapitalLbl.Location = new System.Drawing.Point(413, 36);
            this.CapitalLbl.Name = "CapitalLbl";
            this.CapitalLbl.Size = new System.Drawing.Size(134, 15);
            this.CapitalLbl.TabIndex = 5;
            this.CapitalLbl.Text = "Select The Capital";
            // 
            // StateTxtBox
            // 
            this.StateTxtBox.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateTxtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StateTxtBox.Location = new System.Drawing.Point(178, 41);
            this.StateTxtBox.Name = "StateTxtBox";
            this.StateTxtBox.ReadOnly = true;
            this.StateTxtBox.Size = new System.Drawing.Size(177, 20);
            this.StateTxtBox.TabIndex = 6;
            this.StateTxtBox.TextChanged += new System.EventHandler(this.StateTxtBox_TextChanged);
            // 
            // TimeLeftTxtBox
            // 
            this.TimeLeftTxtBox.Font = new System.Drawing.Font("Broadway", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftTxtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeLeftTxtBox.Location = new System.Drawing.Point(204, 105);
            this.TimeLeftTxtBox.Multiline = true;
            this.TimeLeftTxtBox.Name = "TimeLeftTxtBox";
            this.TimeLeftTxtBox.ReadOnly = true;
            this.TimeLeftTxtBox.Size = new System.Drawing.Size(55, 40);
            this.TimeLeftTxtBox.TabIndex = 7;
            // 
            // CorrectBox
            // 
            this.CorrectBox.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CorrectBox.Location = new System.Drawing.Point(235, 219);
            this.CorrectBox.Name = "CorrectBox";
            this.CorrectBox.ReadOnly = true;
            this.CorrectBox.Size = new System.Drawing.Size(100, 20);
            this.CorrectBox.TabIndex = 8;
            this.CorrectBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AttemptsBox
            // 
            this.AttemptsBox.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AttemptsBox.Location = new System.Drawing.Point(52, 219);
            this.AttemptsBox.Name = "AttemptsBox";
            this.AttemptsBox.ReadOnly = true;
            this.AttemptsBox.Size = new System.Drawing.Size(100, 20);
            this.AttemptsBox.TabIndex = 9;
            this.AttemptsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.Color.Red;
            this.NextBtn.Location = new System.Drawing.Point(52, 256);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(100, 23);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = "Next Question";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndBtn.ForeColor = System.Drawing.Color.Red;
            this.EndBtn.Location = new System.Drawing.Point(235, 256);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(100, 23);
            this.EndBtn.TabIndex = 11;
            this.EndBtn.Text = "End Game";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // TimeLeftTmr
            // 
            this.TimeLeftTmr.Enabled = true;
            this.TimeLeftTmr.Interval = 1000;
            this.TimeLeftTmr.Tick += new System.EventHandler(this.TimeLeftTmr_Tick);
            // 
            // StateCapitalMenuStrip
            // 
            this.StateCapitalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsMenu,
            this.RegionsMenu});
            this.StateCapitalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StateCapitalMenuStrip.Name = "StateCapitalMenuStrip";
            this.StateCapitalMenuStrip.Size = new System.Drawing.Size(559, 24);
            this.StateCapitalMenuStrip.TabIndex = 12;
            this.StateCapitalMenuStrip.Text = "menuStrip1";
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Options_NewGame});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu.Text = "Options";
            // 
            // Options_NewGame
            // 
            this.Options_NewGame.Name = "Options_NewGame";
            this.Options_NewGame.Size = new System.Drawing.Size(152, 22);
            this.Options_NewGame.Text = "New Game";
            this.Options_NewGame.Click += new System.EventHandler(this.Options_NewGame_Click);
            // 
            // RegionsMenu
            // 
            this.RegionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Regions_Europe});
            this.RegionsMenu.Name = "RegionsMenu";
            this.RegionsMenu.Size = new System.Drawing.Size(61, 20);
            this.RegionsMenu.Text = "Regions";
            // 
            // Regions_Europe
            // 
            this.Regions_Europe.Name = "Regions_Europe";
            this.Regions_Europe.Size = new System.Drawing.Size(111, 22);
            this.Regions_Europe.Text = "Europe";
            this.Regions_Europe.Click += new System.EventHandler(this.Regions_Europe_Click);
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.AutoSize = true;
            this.AnswerLbl.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLbl.ForeColor = System.Drawing.Color.Red;
            this.AnswerLbl.Location = new System.Drawing.Point(307, 158);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(98, 15);
            this.AnswerLbl.TabIndex = 13;
            this.AnswerLbl.Text = "Click to Start";
            this.AnswerLbl.Click += new System.EventHandler(this.AnswerLbl_Click);
            // 
            // AnswerPicBox
            // 
            this.AnswerPicBox.Image = global::CapitalGame.Properties.Resources.start;
            this.AnswerPicBox.InitialImage = global::CapitalGame.Properties.Resources.start;
            this.AnswerPicBox.Location = new System.Drawing.Point(328, 97);
            this.AnswerPicBox.Name = "AnswerPicBox";
            this.AnswerPicBox.Size = new System.Drawing.Size(48, 48);
            this.AnswerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnswerPicBox.TabIndex = 14;
            this.AnswerPicBox.TabStop = false;
            this.AnswerPicBox.Click += new System.EventHandler(this.AnswerPicBox_Click);
            // 
            // StateGameForm
            // 
            this.AcceptButton = this.NextBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(559, 302);
            this.Controls.Add(this.AnswerPicBox);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.AttemptsBox);
            this.Controls.Add(this.CorrectBox);
            this.Controls.Add(this.TimeLeftTxtBox);
            this.Controls.Add(this.StateTxtBox);
            this.Controls.Add(this.CapitalLbl);
            this.Controls.Add(this.AttemptsLbl);
            this.Controls.Add(this.CorrectLbl);
            this.Controls.Add(this.TimeLeftLbl);
            this.Controls.Add(this.StateLbl);
            this.Controls.Add(this.CapitalListBox);
            this.Controls.Add(this.StateCapitalMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.StateCapitalMenuStrip;
            this.Name = "StateGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Capital Matching Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.StateCapitalMenuStrip.ResumeLayout(false);
            this.StateCapitalMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CapitalListBox;
        private System.Windows.Forms.Label StateLbl;
        private System.Windows.Forms.Label TimeLeftLbl;
        private System.Windows.Forms.Label CorrectLbl;
        private System.Windows.Forms.Label AttemptsLbl;
        private System.Windows.Forms.Label CapitalLbl;
        private System.Windows.Forms.TextBox StateTxtBox;
        private System.Windows.Forms.TextBox TimeLeftTxtBox;
        private System.Windows.Forms.TextBox CorrectBox;
        private System.Windows.Forms.TextBox AttemptsBox;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Timer TimeLeftTmr;
        private System.Windows.Forms.MenuStrip StateCapitalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem Options_NewGame;
        private System.Windows.Forms.ToolStripMenuItem RegionsMenu;
        private System.Windows.Forms.ToolStripMenuItem Regions_Europe;
        private System.Windows.Forms.Label AnswerLbl;
        private System.Windows.Forms.PictureBox AnswerPicBox;
    }
}

