namespace Dragon_attack
{
    partial class BattlePhase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattlePhase));
            this.hpLbl = new System.Windows.Forms.Label();
            this.playerTurnLbl = new System.Windows.Forms.Label();
            this.opponentLbl = new System.Windows.Forms.Label();
            this.opponentTxtBox = new System.Windows.Forms.TextBox();
            this.battleLogTxt = new System.Windows.Forms.TextBox();
            this.BattleLogLbl = new System.Windows.Forms.Label();
            this.opponentDragLbl = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.rollBtn = new System.Windows.Forms.Button();
            this.rollLbl = new System.Windows.Forms.Label();
            this.rollBtn2 = new System.Windows.Forms.Button();
            this.rollLbl2 = new System.Windows.Forms.Label();
            this.blockBtn = new System.Windows.Forms.Button();
            this.spAttackBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.RestBtn = new System.Windows.Forms.Button();
            this.Background2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).BeginInit();
            this.SuspendLayout();
            // 
            // hpLbl
            // 
            this.hpLbl.AutoSize = true;
            this.hpLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLbl.Location = new System.Drawing.Point(51, 64);
            this.hpLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hpLbl.Name = "hpLbl";
            this.hpLbl.Size = new System.Drawing.Size(73, 37);
            this.hpLbl.TabIndex = 3;
            this.hpLbl.Text = "HP:";
            this.hpLbl.Visible = false;
            this.hpLbl.Click += new System.EventHandler(this.playerOneHp);
            // 
            // playerTurnLbl
            // 
            this.playerTurnLbl.AutoSize = true;
            this.playerTurnLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playerTurnLbl.Location = new System.Drawing.Point(26, 51);
            this.playerTurnLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerTurnLbl.Name = "playerTurnLbl";
            this.playerTurnLbl.Size = new System.Drawing.Size(25, 13);
            this.playerTurnLbl.TabIndex = 4;
            this.playerTurnLbl.Text = "turn";
            this.playerTurnLbl.Visible = false;
            this.playerTurnLbl.Click += new System.EventHandler(this.playersTurnLbl);
            // 
            // opponentLbl
            // 
            this.opponentLbl.AutoSize = true;
            this.opponentLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opponentLbl.Location = new System.Drawing.Point(362, 89);
            this.opponentLbl.Name = "opponentLbl";
            this.opponentLbl.Size = new System.Drawing.Size(90, 13);
            this.opponentLbl.TabIndex = 5;
            this.opponentLbl.Text = "Opponent details:";
            this.opponentLbl.Visible = false;
            this.opponentLbl.Click += new System.EventHandler(this.opponentName);
            // 
            // opponentTxtBox
            // 
            this.opponentTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opponentTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.opponentTxtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.opponentTxtBox.Location = new System.Drawing.Point(361, 104);
            this.opponentTxtBox.Multiline = true;
            this.opponentTxtBox.Name = "opponentTxtBox";
            this.opponentTxtBox.Size = new System.Drawing.Size(250, 166);
            this.opponentTxtBox.TabIndex = 6;
            this.opponentTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.opponentTxtBox.Visible = false;
            this.opponentTxtBox.TextChanged += new System.EventHandler(this.opponentDetailsArea);
            // 
            // battleLogTxt
            // 
            this.battleLogTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.battleLogTxt.Location = new System.Drawing.Point(26, 300);
            this.battleLogTxt.Multiline = true;
            this.battleLogTxt.Name = "battleLogTxt";
            this.battleLogTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battleLogTxt.Size = new System.Drawing.Size(584, 131);
            this.battleLogTxt.TabIndex = 7;
            this.battleLogTxt.TextChanged += new System.EventHandler(this.battleLogArea);
            // 
            // BattleLogLbl
            // 
            this.BattleLogLbl.AutoSize = true;
            this.BattleLogLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BattleLogLbl.Location = new System.Drawing.Point(26, 284);
            this.BattleLogLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BattleLogLbl.Name = "BattleLogLbl";
            this.BattleLogLbl.Size = new System.Drawing.Size(55, 13);
            this.BattleLogLbl.TabIndex = 8;
            this.BattleLogLbl.Text = "Battle Log";
            this.BattleLogLbl.Click += new System.EventHandler(this.BattleLogLbl_Click);
            // 
            // opponentDragLbl
            // 
            this.opponentDragLbl.AutoSize = true;
            this.opponentDragLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opponentDragLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentDragLbl.Location = new System.Drawing.Point(478, 139);
            this.opponentDragLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opponentDragLbl.Name = "opponentDragLbl";
            this.opponentDragLbl.Size = new System.Drawing.Size(0, 31);
            this.opponentDragLbl.TabIndex = 9;
            this.opponentDragLbl.Click += new System.EventHandler(this.opponentDragonDetails);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SeaGreen;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BackButton.FlatAppearance.BorderSize = 3;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(638, 387);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 44);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // rollBtn
            // 
            this.rollBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollBtn.FlatAppearance.BorderSize = 3;
            this.rollBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.rollBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.rollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollBtn.Location = new System.Drawing.Point(113, 161);
            this.rollBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(134, 53);
            this.rollBtn.TabIndex = 12;
            this.rollBtn.Text = "Click To Roll";
            this.rollBtn.UseVisualStyleBackColor = false;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // rollLbl
            // 
            this.rollLbl.AutoSize = true;
            this.rollLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rollLbl.Location = new System.Drawing.Point(113, 146);
            this.rollLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rollLbl.Name = "rollLbl";
            this.rollLbl.Size = new System.Drawing.Size(45, 13);
            this.rollLbl.TabIndex = 13;
            this.rollLbl.Text = "Player 1";
            this.rollLbl.Click += new System.EventHandler(this.rollLbl_Click);
            // 
            // rollBtn2
            // 
            this.rollBtn2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rollBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollBtn2.FlatAppearance.BorderSize = 3;
            this.rollBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.rollBtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.rollBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollBtn2.Location = new System.Drawing.Point(477, 161);
            this.rollBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.rollBtn2.Name = "rollBtn2";
            this.rollBtn2.Size = new System.Drawing.Size(134, 53);
            this.rollBtn2.TabIndex = 14;
            this.rollBtn2.Text = "Click To Roll";
            this.rollBtn2.UseVisualStyleBackColor = false;
            this.rollBtn2.Click += new System.EventHandler(this.rollBtn2_Click);
            // 
            // rollLbl2
            // 
            this.rollLbl2.AutoSize = true;
            this.rollLbl2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rollLbl2.Location = new System.Drawing.Point(477, 147);
            this.rollLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rollLbl2.Name = "rollLbl2";
            this.rollLbl2.Size = new System.Drawing.Size(45, 13);
            this.rollLbl2.TabIndex = 15;
            this.rollLbl2.Text = "Player 2";
            this.rollLbl2.Click += new System.EventHandler(this.rollLbl2_Click);
            // 
            // blockBtn
            // 
            this.blockBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blockBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blockBtn.BackgroundImage")));
            this.blockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockBtn.Enabled = false;
            this.blockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blockBtn.Image = ((System.Drawing.Image)(resources.GetObject("blockBtn.Image")));
            this.blockBtn.Location = new System.Drawing.Point(27, 218);
            this.blockBtn.Margin = new System.Windows.Forms.Padding(2);
            this.blockBtn.Name = "blockBtn";
            this.blockBtn.Size = new System.Drawing.Size(149, 53);
            this.blockBtn.TabIndex = 2;
            this.blockBtn.Text = "Defend";
            this.blockBtn.UseVisualStyleBackColor = false;
            this.blockBtn.Visible = false;
            this.blockBtn.Click += new System.EventHandler(this.defendBtn_Click);
            // 
            // spAttackBtn
            // 
            this.spAttackBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spAttackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spAttackBtn.BackgroundImage")));
            this.spAttackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spAttackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spAttackBtn.Enabled = false;
            this.spAttackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spAttackBtn.Image = ((System.Drawing.Image)(resources.GetObject("spAttackBtn.Image")));
            this.spAttackBtn.Location = new System.Drawing.Point(27, 161);
            this.spAttackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.spAttackBtn.Name = "spAttackBtn";
            this.spAttackBtn.Size = new System.Drawing.Size(149, 53);
            this.spAttackBtn.TabIndex = 1;
            this.spAttackBtn.Text = "Special Attack";
            this.spAttackBtn.UseVisualStyleBackColor = false;
            this.spAttackBtn.Visible = false;
            this.spAttackBtn.Click += new System.EventHandler(this.specialAttackBtn_Click);
            // 
            // attackBtn
            // 
            this.attackBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attackBtn.BackgroundImage")));
            this.attackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attackBtn.Enabled = false;
            this.attackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attackBtn.Image = global::Dragon_attack.Properties.Resources.Buttons;
            this.attackBtn.Location = new System.Drawing.Point(27, 104);
            this.attackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(149, 53);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack ";
            this.attackBtn.UseVisualStyleBackColor = false;
            this.attackBtn.Visible = false;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // RestBtn
            // 
            this.RestBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RestBtn.BackgroundImage = global::Dragon_attack.Properties.Resources.Buttons;
            this.RestBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestBtn.Location = new System.Drawing.Point(26, 103);
            this.RestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RestBtn.Name = "RestBtn";
            this.RestBtn.Size = new System.Drawing.Size(150, 168);
            this.RestBtn.TabIndex = 17;
            this.RestBtn.Text = "Rest";
            this.RestBtn.UseVisualStyleBackColor = false;
            this.RestBtn.Visible = false;
            this.RestBtn.Click += new System.EventHandler(this.RestBtn_Click);
            // 
            // Background2
            // 
            this.Background2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Background2.Image = global::Dragon_attack.Properties.Resources.DragonAttackBackground;
            this.Background2.Location = new System.Drawing.Point(-1, 3);
            this.Background2.Name = "Background2";
            this.Background2.Size = new System.Drawing.Size(730, 486);
            this.Background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background2.TabIndex = 11;
            this.Background2.TabStop = false;
            this.Background2.Click += new System.EventHandler(this.Background2_Click);
            // 
            // BattlePhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 483);
            this.Controls.Add(this.rollLbl2);
            this.Controls.Add(this.rollBtn2);
            this.Controls.Add(this.rollLbl);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.opponentDragLbl);
            this.Controls.Add(this.BattleLogLbl);
            this.Controls.Add(this.battleLogTxt);
            this.Controls.Add(this.opponentTxtBox);
            this.Controls.Add(this.opponentLbl);
            this.Controls.Add(this.playerTurnLbl);
            this.Controls.Add(this.hpLbl);
            this.Controls.Add(this.blockBtn);
            this.Controls.Add(this.spAttackBtn);
            this.Controls.Add(this.attackBtn);
            this.Controls.Add(this.RestBtn);
            this.Controls.Add(this.Background2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BattlePhase";
            this.Text = "battlePhase";
            this.Load += new System.EventHandler(this.battlePhase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button spAttackBtn;
        private System.Windows.Forms.Button blockBtn;
        private System.Windows.Forms.Label hpLbl;
        private System.Windows.Forms.Label playerTurnLbl;
        private System.Windows.Forms.Label opponentLbl;
        private System.Windows.Forms.TextBox opponentTxtBox;
        private System.Windows.Forms.TextBox battleLogTxt;
        private System.Windows.Forms.Label BattleLogLbl;
        private System.Windows.Forms.Label opponentDragLbl;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox Background2;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Label rollLbl;
        private System.Windows.Forms.Button rollBtn2;
        private System.Windows.Forms.Label rollLbl2;
        private System.Windows.Forms.Button RestBtn;
    }
}

