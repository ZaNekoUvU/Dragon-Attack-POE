namespace $rootnamespace$
{
    partial class $safeitemname$
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerNametbx = new System.Windows.Forms.TextBox();
            this.DragonNametbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StatTextBox1 = new System.Windows.Forms.TextBox();
            this.FireDragonCheck = new System.Windows.Forms.CheckBox();
            this.WindDragonCheck = new System.Windows.Forms.CheckBox();
            this.EarthDragonCheck = new System.Windows.Forms.CheckBox();
            this.IceDragonCheck = new System.Windows.Forms.CheckBox();
            this.IceDragonCheck2 = new System.Windows.Forms.CheckBox();
            this.EarthDragonCheck2 = new System.Windows.Forms.CheckBox();
            this.WindDragonCheck2 = new System.Windows.Forms.CheckBox();
            this.FireDragonCheck2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DragonNametbx2 = new System.Windows.Forms.TextBox();
            this.PlayerNametbx2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveCharButton2 = new System.Windows.Forms.Button();
            this.SaveCharButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerNametbx
            // 
            this.PlayerNametbx.Location = new System.Drawing.Point(98, 44);
            this.PlayerNametbx.Name = "PlayerNametbx";
            this.PlayerNametbx.Size = new System.Drawing.Size(100, 20);
            this.PlayerNametbx.TabIndex = 1;
            this.PlayerNametbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerNametbx.TextChanged += new System.EventHandler(this.PlayerNametbx_TextChanged);
            // 
            // DragonNametbx
            // 
            this.DragonNametbx.Location = new System.Drawing.Point(98, 84);
            this.DragonNametbx.Name = "DragonNametbx";
            this.DragonNametbx.Size = new System.Drawing.Size(100, 20);
            this.DragonNametbx.TabIndex = 2;
            this.DragonNametbx.TextChanged += new System.EventHandler(this.DragonNametbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dragon Name:";
            // 
            // StatTextBox1
            // 
            this.StatTextBox1.Location = new System.Drawing.Point(98, 220);
            this.StatTextBox1.Multiline = true;
            this.StatTextBox1.Name = "StatTextBox1";
            this.StatTextBox1.Size = new System.Drawing.Size(130, 134);
            this.StatTextBox1.TabIndex = 8;
            this.StatTextBox1.TextChanged += new System.EventHandler(this.StatTextBox1_TextChanged);
            // 
            // FireDragonCheck
            // 
            this.FireDragonCheck.AutoSize = true;
            this.FireDragonCheck.Location = new System.Drawing.Point(98, 151);
            this.FireDragonCheck.Name = "FireDragonCheck";
            this.FireDragonCheck.Size = new System.Drawing.Size(81, 17);
            this.FireDragonCheck.TabIndex = 9;
            this.FireDragonCheck.Text = "Fire Dragon";
            this.FireDragonCheck.UseVisualStyleBackColor = true;
            this.FireDragonCheck.CheckedChanged += new System.EventHandler(this.FireDragonCheck_CheckedChanged);
            // 
            // WindDragonCheck
            // 
            this.WindDragonCheck.AutoSize = true;
            this.WindDragonCheck.Location = new System.Drawing.Point(98, 174);
            this.WindDragonCheck.Name = "WindDragonCheck";
            this.WindDragonCheck.Size = new System.Drawing.Size(89, 17);
            this.WindDragonCheck.TabIndex = 10;
            this.WindDragonCheck.Text = "Wind Dragon";
            this.WindDragonCheck.UseVisualStyleBackColor = true;
            this.WindDragonCheck.CheckedChanged += new System.EventHandler(this.WindDragonCheck_CheckedChanged);
            // 
            // EarthDragonCheck
            // 
            this.EarthDragonCheck.AutoSize = true;
            this.EarthDragonCheck.Location = new System.Drawing.Point(98, 197);
            this.EarthDragonCheck.Name = "EarthDragonCheck";
            this.EarthDragonCheck.Size = new System.Drawing.Size(89, 17);
            this.EarthDragonCheck.TabIndex = 11;
            this.EarthDragonCheck.Text = "Earth Dragon";
            this.EarthDragonCheck.UseVisualStyleBackColor = true;
            this.EarthDragonCheck.CheckedChanged += new System.EventHandler(this.EarthDragonCheck_CheckedChanged);
            // 
            // IceDragonCheck
            // 
            this.IceDragonCheck.AutoSize = true;
            this.IceDragonCheck.Location = new System.Drawing.Point(98, 128);
            this.IceDragonCheck.Name = "IceDragonCheck";
            this.IceDragonCheck.Size = new System.Drawing.Size(79, 17);
            this.IceDragonCheck.TabIndex = 12;
            this.IceDragonCheck.Text = "Ice Dragon";
            this.IceDragonCheck.UseVisualStyleBackColor = true;
            this.IceDragonCheck.CheckedChanged += new System.EventHandler(this.IceDragonCheck_CheckedChanged);
            // 
            // IceDragonCheck2
            // 
            this.IceDragonCheck2.AutoSize = true;
            this.IceDragonCheck2.Location = new System.Drawing.Point(348, 128);
            this.IceDragonCheck2.Name = "IceDragonCheck2";
            this.IceDragonCheck2.Size = new System.Drawing.Size(79, 17);
            this.IceDragonCheck2.TabIndex = 21;
            this.IceDragonCheck2.Text = "Ice Dragon";
            this.IceDragonCheck2.UseVisualStyleBackColor = true;
            this.IceDragonCheck2.CheckedChanged += new System.EventHandler(this.IceDragonCheck2_CheckedChanged);
            // 
            // EarthDragonCheck2
            // 
            this.EarthDragonCheck2.AutoSize = true;
            this.EarthDragonCheck2.Location = new System.Drawing.Point(348, 197);
            this.EarthDragonCheck2.Name = "EarthDragonCheck2";
            this.EarthDragonCheck2.Size = new System.Drawing.Size(89, 17);
            this.EarthDragonCheck2.TabIndex = 20;
            this.EarthDragonCheck2.Text = "Earth Dragon";
            this.EarthDragonCheck2.UseVisualStyleBackColor = true;
            this.EarthDragonCheck2.CheckedChanged += new System.EventHandler(this.EarthDragonCheck2_CheckedChanged);
            // 
            // WindDragonCheck2
            // 
            this.WindDragonCheck2.AutoSize = true;
            this.WindDragonCheck2.Location = new System.Drawing.Point(348, 174);
            this.WindDragonCheck2.Name = "WindDragonCheck2";
            this.WindDragonCheck2.Size = new System.Drawing.Size(89, 17);
            this.WindDragonCheck2.TabIndex = 19;
            this.WindDragonCheck2.Text = "Wind Dragon";
            this.WindDragonCheck2.UseVisualStyleBackColor = true;
            this.WindDragonCheck2.CheckedChanged += new System.EventHandler(this.WindDragonCheck2_CheckedChanged);
            // 
            // FireDragonCheck2
            // 
            this.FireDragonCheck2.AutoSize = true;
            this.FireDragonCheck2.Location = new System.Drawing.Point(348, 151);
            this.FireDragonCheck2.Name = "FireDragonCheck2";
            this.FireDragonCheck2.Size = new System.Drawing.Size(81, 17);
            this.FireDragonCheck2.TabIndex = 18;
            this.FireDragonCheck2.Text = "Fire Dragon";
            this.FireDragonCheck2.UseVisualStyleBackColor = true;
            this.FireDragonCheck2.CheckedChanged += new System.EventHandler(this.FireDragonCheck2_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 220);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 134);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.StatTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dragon Name:";
            // 
            // DragonNametbx2
            // 
            this.DragonNametbx2.Location = new System.Drawing.Point(348, 84);
            this.DragonNametbx2.Name = "DragonNametbx2";
            this.DragonNametbx2.Size = new System.Drawing.Size(100, 20);
            this.DragonNametbx2.TabIndex = 15;
            this.DragonNametbx2.TextChanged += new System.EventHandler(this.DragonNametbx2_TextChanged);
            // 
            // PlayerNametbx2
            // 
            this.PlayerNametbx2.Location = new System.Drawing.Point(348, 44);
            this.PlayerNametbx2.Name = "PlayerNametbx2";
            this.PlayerNametbx2.Size = new System.Drawing.Size(100, 20);
            this.PlayerNametbx2.TabIndex = 14;
            this.PlayerNametbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerNametbx2.TextChanged += new System.EventHandler(this.PlayerNametbx2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player Name:";
            // 
            // SaveCharButton2
            // 
            this.SaveCharButton2.Location = new System.Drawing.Point(348, 360);
            this.SaveCharButton2.Name = "SaveCharButton2";
            this.SaveCharButton2.Size = new System.Drawing.Size(196, 24);
            this.SaveCharButton2.TabIndex = 22;
            this.SaveCharButton2.Text = "Save";
            this.SaveCharButton2.UseVisualStyleBackColor = true;
            this.SaveCharButton2.Click += new System.EventHandler(this.SaveCharButton2_Click);
            // 
            // SaveCharButton
            // 
            this.SaveCharButton.Location = new System.Drawing.Point(98, 360);
            this.SaveCharButton.Name = "SaveCharButton";
            this.SaveCharButton.Size = new System.Drawing.Size(196, 24);
            this.SaveCharButton.TabIndex = 23;
            this.SaveCharButton.Text = "Save";
            this.SaveCharButton.UseVisualStyleBackColor = true;
            this.SaveCharButton.Click += new System.EventHandler(this.SaveCharButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(269, 408);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 24;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // $safeitemname$
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 435);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SaveCharButton);
            this.Controls.Add(this.SaveCharButton2);
            this.Controls.Add(this.IceDragonCheck2);
            this.Controls.Add(this.EarthDragonCheck2);
            this.Controls.Add(this.WindDragonCheck2);
            this.Controls.Add(this.FireDragonCheck2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DragonNametbx2);
            this.Controls.Add(this.PlayerNametbx2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IceDragonCheck);
            this.Controls.Add(this.EarthDragonCheck);
            this.Controls.Add(this.WindDragonCheck);
            this.Controls.Add(this.FireDragonCheck);
            this.Controls.Add(this.StatTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DragonNametbx);
            this.Controls.Add(this.PlayerNametbx);
            this.Controls.Add(this.label1);
            this.Name = "$safeitemname$";
            this.Text = "$safeitemname$";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlayerNametbx;
        private System.Windows.Forms.TextBox DragonNametbx;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox StatTextBox1;
        private System.Windows.Forms.CheckBox FireDragonCheck;
        private System.Windows.Forms.CheckBox WindDragonCheck;
        private System.Windows.Forms.CheckBox EarthDragonCheck;
        private System.Windows.Forms.CheckBox IceDragonCheck;
        private System.Windows.Forms.CheckBox IceDragonCheck2;
        private System.Windows.Forms.CheckBox EarthDragonCheck2;
        private System.Windows.Forms.CheckBox WindDragonCheck2;
        private System.Windows.Forms.CheckBox FireDragonCheck2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DragonNametbx2;
        private System.Windows.Forms.TextBox PlayerNametbx2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveCharButton2;
        private System.Windows.Forms.Button SaveCharButton;
        private System.Windows.Forms.Button StartButton;
    }
}

