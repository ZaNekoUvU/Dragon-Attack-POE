﻿namespace Dragon_attack
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
            this.spAttackBtn = new System.Windows.Forms.Button();
            this.blockBtn = new System.Windows.Forms.Button();
            this.hpLbl = new System.Windows.Forms.Label();
            this.playerTurnLbl = new System.Windows.Forms.Label();
            this.opponentLbl = new System.Windows.Forms.Label();
            this.opponentTxtBox = new System.Windows.Forms.TextBox();
            this.battleLogTxt = new System.Windows.Forms.TextBox();
            this.BattleLogLbl = new System.Windows.Forms.Label();
            this.opponentDragLbl = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.Background2 = new System.Windows.Forms.PictureBox();
            this.rollBtn = new System.Windows.Forms.Button();
            this.rollLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).BeginInit();
            this.SuspendLayout();
            // 
            // spAttackBtn
            // 
            this.spAttackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spAttackBtn.Enabled = false;
            this.spAttackBtn.Image = ((System.Drawing.Image)(resources.GetObject("spAttackBtn.Image")));
            this.spAttackBtn.Location = new System.Drawing.Point(83, 169);
            this.spAttackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spAttackBtn.Name = "spAttackBtn";
            this.spAttackBtn.Size = new System.Drawing.Size(199, 65);
            this.spAttackBtn.TabIndex = 1;
            this.spAttackBtn.Text = "Special Attack";
            this.spAttackBtn.UseVisualStyleBackColor = true;
            this.spAttackBtn.Click += new System.EventHandler(this.specialAttackBtn_Click);
            // 
            // blockBtn
            // 
            this.blockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blockBtn.Enabled = false;
            this.blockBtn.Image = ((System.Drawing.Image)(resources.GetObject("blockBtn.Image")));
            this.blockBtn.Location = new System.Drawing.Point(83, 239);
            this.blockBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockBtn.Name = "blockBtn";
            this.blockBtn.Size = new System.Drawing.Size(199, 65);
            this.blockBtn.TabIndex = 2;
            this.blockBtn.Text = "Defend";
            this.blockBtn.UseVisualStyleBackColor = true;
            this.blockBtn.Click += new System.EventHandler(this.defendBtn_Click);
            // 
            // hpLbl
            // 
            this.hpLbl.AutoSize = true;
            this.hpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLbl.Location = new System.Drawing.Point(115, 49);
            this.hpLbl.Name = "hpLbl";
            this.hpLbl.Size = new System.Drawing.Size(90, 46);
            this.hpLbl.TabIndex = 3;
            this.hpLbl.Text = "HP:";
            this.hpLbl.Click += new System.EventHandler(this.playerOneHp);
            // 
            // playerTurnLbl
            // 
            this.playerTurnLbl.AutoSize = true;
            this.playerTurnLbl.Location = new System.Drawing.Point(80, 33);
            this.playerTurnLbl.Name = "playerTurnLbl";
            this.playerTurnLbl.Size = new System.Drawing.Size(28, 16);
            this.playerTurnLbl.TabIndex = 4;
            this.playerTurnLbl.Text = "turn";
            this.playerTurnLbl.Click += new System.EventHandler(this.playersTurnLbl);
            // 
            // opponentLbl
            // 
            this.opponentLbl.AutoSize = true;
            this.opponentLbl.Location = new System.Drawing.Point(585, 79);
            this.opponentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opponentLbl.Name = "opponentLbl";
            this.opponentLbl.Size = new System.Drawing.Size(112, 16);
            this.opponentLbl.TabIndex = 5;
            this.opponentLbl.Text = "Opponent details:";
            this.opponentLbl.Click += new System.EventHandler(this.opponentName);
            // 
            // opponentTxtBox
            // 
            this.opponentTxtBox.BackColor = System.Drawing.Color.AliceBlue;
            this.opponentTxtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.opponentTxtBox.Location = new System.Drawing.Point(561, 98);
            this.opponentTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.opponentTxtBox.Multiline = true;
            this.opponentTxtBox.Name = "opponentTxtBox";
            this.opponentTxtBox.Size = new System.Drawing.Size(332, 205);
            this.opponentTxtBox.TabIndex = 6;
            this.opponentTxtBox.TextChanged += new System.EventHandler(this.opponentDetailsArea);
            // 
            // battleLogTxt
            // 
            this.battleLogTxt.BackColor = System.Drawing.Color.FloralWhite;
            this.battleLogTxt.Location = new System.Drawing.Point(83, 359);
            this.battleLogTxt.Margin = new System.Windows.Forms.Padding(4);
            this.battleLogTxt.Multiline = true;
            this.battleLogTxt.Name = "battleLogTxt";
            this.battleLogTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battleLogTxt.Size = new System.Drawing.Size(811, 160);
            this.battleLogTxt.TabIndex = 7;
            this.battleLogTxt.TextChanged += new System.EventHandler(this.battleLogArea);
            // 
            // BattleLogLbl
            // 
            this.BattleLogLbl.AutoSize = true;
            this.BattleLogLbl.Location = new System.Drawing.Point(80, 340);
            this.BattleLogLbl.Name = "BattleLogLbl";
            this.BattleLogLbl.Size = new System.Drawing.Size(67, 16);
            this.BattleLogLbl.TabIndex = 8;
            this.BattleLogLbl.Text = "Battle Log";
            this.BattleLogLbl.Click += new System.EventHandler(this.BattleLogLbl_Click);
            // 
            // opponentDragLbl
            // 
            this.opponentDragLbl.AutoSize = true;
            this.opponentDragLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentDragLbl.Location = new System.Drawing.Point(669, 169);
            this.opponentDragLbl.Name = "opponentDragLbl";
            this.opponentDragLbl.Size = new System.Drawing.Size(109, 38);
            this.opponentDragLbl.TabIndex = 9;
            this.opponentDragLbl.Text = "label5";
            this.opponentDragLbl.Click += new System.EventHandler(this.opponentDragonDetails);
            // 
            // BackButton
            // 
            this.BackButton.Image = global::Dragon_attack.Properties.Resources.Buttons;
            this.BackButton.Location = new System.Drawing.Point(832, 542);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 38);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // attackBtn
            // 
            this.attackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.attackBtn.Enabled = false;
            this.attackBtn.Image = global::Dragon_attack.Properties.Resources.Buttons;
            this.attackBtn.Location = new System.Drawing.Point(83, 98);
            this.attackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(199, 65);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack ";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // Background2
            // 
            this.Background2.Image = global::Dragon_attack.Properties.Resources.DragonAttackBackground;
            this.Background2.Location = new System.Drawing.Point(4, -26);
            this.Background2.Margin = new System.Windows.Forms.Padding(4);
            this.Background2.Name = "Background2";
            this.Background2.Size = new System.Drawing.Size(968, 606);
            this.Background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background2.TabIndex = 11;
            this.Background2.TabStop = false;
            this.Background2.Click += new System.EventHandler(this.Background2_Click);
            // 
            // rollBtn
            // 
            this.rollBtn.Location = new System.Drawing.Point(332, 169);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(178, 65);
            this.rollBtn.TabIndex = 12;
            this.rollBtn.Text = "Click To Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // rollLbl
            // 
            this.rollLbl.AutoSize = true;
            this.rollLbl.Location = new System.Drawing.Point(393, 122);
            this.rollLbl.Name = "rollLbl";
            this.rollLbl.Size = new System.Drawing.Size(56, 16);
            this.rollLbl.TabIndex = 13;
            this.rollLbl.Text = "Player 1";
            this.rollLbl.Click += new System.EventHandler(this.rollLbl_Click);
            // 
            // BattlePhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 594);
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
            this.Controls.Add(this.Background2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

