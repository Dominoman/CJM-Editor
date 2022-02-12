namespace CjmEditor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modelvic20 = new System.Windows.Forms.RadioButton();
            this.modelc64 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ntsc = new System.Windows.Forms.RadioButton();
            this.pal = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reu = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bank5 = new System.Windows.Forms.CheckBox();
            this.bank3 = new System.Windows.Forms.CheckBox();
            this.bank2 = new System.Windows.Forms.CheckBox();
            this.bank1 = new System.Windows.Forms.CheckBox();
            this.bank0 = new System.Windows.Forms.CheckBox();
            this.vic20memory = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.noaudioscale = new System.Windows.Forms.CheckBox();
            this.fullheight = new System.Windows.Forms.CheckBox();
            this.accuratedisk = new System.Windows.Forms.CheckBox();
            this._readonly = new System.Windows.Forms.CheckBox();
            this.driveicon = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.NumericUpDown();
            this.joy1 = new System.Windows.Forms.Button();
            this.joy2 = new System.Windows.Forms.Button();
            this.joy3 = new System.Windows.Forms.Button();
            this.joy4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "S&ave as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modelvic20);
            this.groupBox1.Controls.Add(this.modelc64);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(64, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // modelvic20
            // 
            this.modelvic20.AutoSize = true;
            this.modelvic20.Location = new System.Drawing.Point(6, 42);
            this.modelvic20.Name = "modelvic20";
            this.modelvic20.Size = new System.Drawing.Size(54, 17);
            this.modelvic20.TabIndex = 1;
            this.modelvic20.Text = "VIC20";
            this.modelvic20.UseVisualStyleBackColor = true;
            this.modelvic20.CheckedChanged += new System.EventHandler(this.Model_CheckedChanged);
            // 
            // modelc64
            // 
            this.modelc64.AutoSize = true;
            this.modelc64.Checked = true;
            this.modelc64.Location = new System.Drawing.Point(6, 19);
            this.modelc64.Name = "modelc64";
            this.modelc64.Size = new System.Drawing.Size(44, 17);
            this.modelc64.TabIndex = 0;
            this.modelc64.TabStop = true;
            this.modelc64.Text = "C64";
            this.modelc64.UseVisualStyleBackColor = true;
            this.modelc64.CheckedChanged += new System.EventHandler(this.Model_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ntsc);
            this.groupBox2.Controls.Add(this.pal);
            this.groupBox2.Location = new System.Drawing.Point(82, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(64, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            // 
            // ntsc
            // 
            this.ntsc.AutoSize = true;
            this.ntsc.Location = new System.Drawing.Point(6, 42);
            this.ntsc.Name = "ntsc";
            this.ntsc.Size = new System.Drawing.Size(54, 17);
            this.ntsc.TabIndex = 1;
            this.ntsc.Text = "NTSC";
            this.ntsc.UseVisualStyleBackColor = true;
            this.ntsc.CheckedChanged += new System.EventHandler(this.Model_CheckedChanged);
            // 
            // pal
            // 
            this.pal.AutoSize = true;
            this.pal.Checked = true;
            this.pal.Location = new System.Drawing.Point(6, 19);
            this.pal.Name = "pal";
            this.pal.Size = new System.Drawing.Size(45, 17);
            this.pal.TabIndex = 0;
            this.pal.TabStop = true;
            this.pal.Text = "PAL";
            this.pal.UseVisualStyleBackColor = true;
            this.pal.CheckedChanged += new System.EventHandler(this.Model_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reu);
            this.groupBox3.Location = new System.Drawing.Point(152, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 73);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "C64 REU";
            // 
            // reu
            // 
            this.reu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reu.FormattingEnabled = true;
            this.reu.Items.AddRange(new object[] {
            "",
            "Reu 512 Kb",
            "Reu 2 Mb",
            "Reu 16 Mb"});
            this.reu.Location = new System.Drawing.Point(6, 19);
            this.reu.Name = "reu";
            this.reu.Size = new System.Drawing.Size(81, 21);
            this.reu.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bank5);
            this.groupBox4.Controls.Add(this.bank3);
            this.groupBox4.Controls.Add(this.bank2);
            this.groupBox4.Controls.Add(this.bank1);
            this.groupBox4.Controls.Add(this.bank0);
            this.groupBox4.Controls.Add(this.vic20memory);
            this.groupBox4.Location = new System.Drawing.Point(254, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 165);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VIC 20 Memory";
            // 
            // bank5
            // 
            this.bank5.AutoSize = true;
            this.bank5.Location = new System.Drawing.Point(6, 138);
            this.bank5.Name = "bank5";
            this.bank5.Size = new System.Drawing.Size(59, 17);
            this.bank5.TabIndex = 5;
            this.bank5.Text = "bank 5";
            this.bank5.UseVisualStyleBackColor = true;
            this.bank5.CheckedChanged += new System.EventHandler(this.Bank_CheckedChanged);
            // 
            // bank3
            // 
            this.bank3.AutoSize = true;
            this.bank3.Location = new System.Drawing.Point(6, 115);
            this.bank3.Name = "bank3";
            this.bank3.Size = new System.Drawing.Size(59, 17);
            this.bank3.TabIndex = 4;
            this.bank3.Text = "bank 3";
            this.bank3.UseVisualStyleBackColor = true;
            this.bank3.CheckedChanged += new System.EventHandler(this.Bank_CheckedChanged);
            // 
            // bank2
            // 
            this.bank2.AutoSize = true;
            this.bank2.Location = new System.Drawing.Point(6, 92);
            this.bank2.Name = "bank2";
            this.bank2.Size = new System.Drawing.Size(59, 17);
            this.bank2.TabIndex = 3;
            this.bank2.Text = "bank 2";
            this.bank2.UseVisualStyleBackColor = true;
            this.bank2.CheckedChanged += new System.EventHandler(this.Bank_CheckedChanged);
            // 
            // bank1
            // 
            this.bank1.AutoSize = true;
            this.bank1.Location = new System.Drawing.Point(6, 69);
            this.bank1.Name = "bank1";
            this.bank1.Size = new System.Drawing.Size(59, 17);
            this.bank1.TabIndex = 2;
            this.bank1.Text = "bank 1";
            this.bank1.UseVisualStyleBackColor = true;
            this.bank1.CheckedChanged += new System.EventHandler(this.Bank_CheckedChanged);
            // 
            // bank0
            // 
            this.bank0.AutoSize = true;
            this.bank0.Location = new System.Drawing.Point(6, 46);
            this.bank0.Name = "bank0";
            this.bank0.Size = new System.Drawing.Size(59, 17);
            this.bank0.TabIndex = 1;
            this.bank0.Text = "bank 0";
            this.bank0.UseVisualStyleBackColor = true;
            this.bank0.CheckedChanged += new System.EventHandler(this.Bank_CheckedChanged);
            // 
            // vic20memory
            // 
            this.vic20memory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vic20memory.FormattingEnabled = true;
            this.vic20memory.Items.AddRange(new object[] {
            "",
            "3k",
            "4k",
            "8k",
            "16k",
            "24k",
            "32k",
            "35k"});
            this.vic20memory.Location = new System.Drawing.Point(6, 19);
            this.vic20memory.Name = "vic20memory";
            this.vic20memory.Size = new System.Drawing.Size(81, 21);
            this.vic20memory.TabIndex = 0;
            this.vic20memory.SelectedValueChanged += new System.EventHandler(this.Bank_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.noaudioscale);
            this.groupBox5.Controls.Add(this.fullheight);
            this.groupBox5.Controls.Add(this.accuratedisk);
            this.groupBox5.Controls.Add(this._readonly);
            this.groupBox5.Controls.Add(this.driveicon);
            this.groupBox5.Location = new System.Drawing.Point(356, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(106, 165);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Options";
            // 
            // noaudioscale
            // 
            this.noaudioscale.AutoSize = true;
            this.noaudioscale.Location = new System.Drawing.Point(6, 111);
            this.noaudioscale.Name = "noaudioscale";
            this.noaudioscale.Size = new System.Drawing.Size(97, 17);
            this.noaudioscale.TabIndex = 4;
            this.noaudioscale.Text = "No audio scale";
            this.noaudioscale.UseVisualStyleBackColor = true;
            // 
            // fullheight
            // 
            this.fullheight.AutoSize = true;
            this.fullheight.Location = new System.Drawing.Point(6, 88);
            this.fullheight.Name = "fullheight";
            this.fullheight.Size = new System.Drawing.Size(74, 17);
            this.fullheight.TabIndex = 3;
            this.fullheight.Text = "Full height";
            this.fullheight.UseVisualStyleBackColor = true;
            this.fullheight.CheckedChanged += new System.EventHandler(this.Fullheight_CheckedChanged);
            // 
            // accuratedisk
            // 
            this.accuratedisk.AutoSize = true;
            this.accuratedisk.Location = new System.Drawing.Point(6, 65);
            this.accuratedisk.Name = "accuratedisk";
            this.accuratedisk.Size = new System.Drawing.Size(91, 17);
            this.accuratedisk.TabIndex = 2;
            this.accuratedisk.Text = "Accurate disk";
            this.accuratedisk.UseVisualStyleBackColor = true;
            // 
            // _readonly
            // 
            this._readonly.AutoSize = true;
            this._readonly.Location = new System.Drawing.Point(6, 42);
            this._readonly.Name = "_readonly";
            this._readonly.Size = new System.Drawing.Size(74, 17);
            this._readonly.TabIndex = 1;
            this._readonly.Text = "Read only";
            this._readonly.UseVisualStyleBackColor = true;
            // 
            // driveicon
            // 
            this.driveicon.AutoSize = true;
            this.driveicon.Location = new System.Drawing.Point(6, 19);
            this.driveicon.Name = "driveicon";
            this.driveicon.Size = new System.Drawing.Size(74, 17);
            this.driveicon.TabIndex = 0;
            this.driveicon.Text = "Drive icon";
            this.driveicon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vertical display shift:";
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(123, 113);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(52, 20);
            this.v.TabIndex = 8;
            // 
            // joy1
            // 
            this.joy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.joy1.Location = new System.Drawing.Point(12, 204);
            this.joy1.Name = "joy1";
            this.joy1.Size = new System.Drawing.Size(75, 23);
            this.joy1.TabIndex = 9;
            this.joy1.Text = "Joy 1...";
            this.joy1.UseVisualStyleBackColor = true;
            this.joy1.Click += new System.EventHandler(this.Joy_Click);
            // 
            // joy2
            // 
            this.joy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.joy2.Location = new System.Drawing.Point(93, 204);
            this.joy2.Name = "joy2";
            this.joy2.Size = new System.Drawing.Size(75, 23);
            this.joy2.TabIndex = 10;
            this.joy2.Text = "Joy 2...";
            this.joy2.UseVisualStyleBackColor = true;
            this.joy2.Click += new System.EventHandler(this.Joy_Click);
            // 
            // joy3
            // 
            this.joy3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.joy3.Location = new System.Drawing.Point(174, 204);
            this.joy3.Name = "joy3";
            this.joy3.Size = new System.Drawing.Size(75, 23);
            this.joy3.TabIndex = 11;
            this.joy3.Text = "Joy 3...";
            this.joy3.UseVisualStyleBackColor = true;
            this.joy3.Click += new System.EventHandler(this.Joy_Click);
            // 
            // joy4
            // 
            this.joy4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.joy4.Location = new System.Drawing.Point(255, 204);
            this.joy4.Name = "joy4";
            this.joy4.Size = new System.Drawing.Size(75, 23);
            this.joy4.TabIndex = 12;
            this.joy4.Text = "Joy 4...";
            this.joy4.UseVisualStyleBackColor = true;
            this.joy4.Click += new System.EventHandler(this.Joy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CJM Files|*.cjm|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CJM Files|*.cjm|All files|*.*";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 235);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatus
            // 
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 257);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.joy4);
            this.Controls.Add(this.joy3);
            this.Controls.Add(this.joy2);
            this.Controls.Add(this.joy1);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton modelvic20;
        private System.Windows.Forms.RadioButton modelc64;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ntsc;
        private System.Windows.Forms.RadioButton pal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox reu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox bank5;
        private System.Windows.Forms.CheckBox bank3;
        private System.Windows.Forms.CheckBox bank2;
        private System.Windows.Forms.CheckBox bank1;
        private System.Windows.Forms.CheckBox bank0;
        private System.Windows.Forms.ComboBox vic20memory;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox noaudioscale;
        private System.Windows.Forms.CheckBox fullheight;
        private System.Windows.Forms.CheckBox accuratedisk;
        private System.Windows.Forms.CheckBox _readonly;
        private System.Windows.Forms.CheckBox driveicon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown v;
        private System.Windows.Forms.Button joy1;
        private System.Windows.Forms.Button joy2;
        private System.Windows.Forms.Button joy3;
        private System.Windows.Forms.Button joy4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

