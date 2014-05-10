namespace DCPU_16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.ToolStripContainer();
            this.WorkSpace = new System.Windows.Forms.SplitContainer();
            this.Program = new System.Windows.Forms.ListBox();
            this.Hide = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClearCell = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CellAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddData = new System.Windows.Forms.Button();
            this.DataValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataAdress = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.AddCommand = new System.Windows.Forms.Button();
            this.OperandAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandAddress = new System.Windows.Forms.TextBox();
            this.CommandBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripDropDownButton();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Run = new System.Windows.Forms.ToolStripButton();
            this.BeginDebug = new System.Windows.Forms.ToolStripDropDownButton();
            this.startDebuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.dfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperandAddress2 = new System.Windows.Forms.TextBox();
            this.Menu.ContentPanel.SuspendLayout();
            this.Menu.TopToolStripPanel.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSpace)).BeginInit();
            this.WorkSpace.Panel1.SuspendLayout();
            this.WorkSpace.Panel2.SuspendLayout();
            this.WorkSpace.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            // 
            // Menu.ContentPanel
            // 
            this.Menu.ContentPanel.Controls.Add(this.WorkSpace);
            this.Menu.ContentPanel.Size = new System.Drawing.Size(416, 301);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(416, 326);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStripContainer1";
            // 
            // Menu.TopToolStripPanel
            // 
            this.Menu.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // WorkSpace
            // 
            this.WorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkSpace.Location = new System.Drawing.Point(0, 0);
            this.WorkSpace.Name = "WorkSpace";
            // 
            // WorkSpace.Panel1
            // 
            this.WorkSpace.Panel1.Controls.Add(this.Program);
            // 
            // WorkSpace.Panel2
            // 
            this.WorkSpace.Panel2.Controls.Add(this.Hide);
            this.WorkSpace.Panel2.Controls.Add(this.groupBox3);
            this.WorkSpace.Panel2.Controls.Add(this.groupBox1);
            this.WorkSpace.Panel2.Controls.Add(this.GroupBox2);
            this.WorkSpace.Panel2MinSize = 0;
            this.WorkSpace.Size = new System.Drawing.Size(416, 301);
            this.WorkSpace.SplitterDistance = 233;
            this.WorkSpace.TabIndex = 1;
            // 
            // Program
            // 
            this.Program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Program.FormattingEnabled = true;
            this.Program.Location = new System.Drawing.Point(0, 0);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(233, 301);
            this.Program.TabIndex = 0;
            this.Program.SelectedIndexChanged += new System.EventHandler(this.Program_SelectedIndexChanged);
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(43, 263);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(99, 23);
            this.Hide.TabIndex = 3;
            this.Hide.Text = "Hide tool box";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClearCell);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CellAddress);
            this.groupBox3.Location = new System.Drawing.Point(6, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clear Cell";
            // 
            // ClearCell
            // 
            this.ClearCell.Location = new System.Drawing.Point(108, 17);
            this.ClearCell.Name = "ClearCell";
            this.ClearCell.Size = new System.Drawing.Size(47, 23);
            this.ClearCell.TabIndex = 1;
            this.ClearCell.Text = "Clear";
            this.ClearCell.UseVisualStyleBackColor = true;
            this.ClearCell.Click += new System.EventHandler(this.ClearCell_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // CellAddress
            // 
            this.CellAddress.Location = new System.Drawing.Point(57, 19);
            this.CellAddress.Name = "CellAddress";
            this.CellAddress.Size = new System.Drawing.Size(45, 20);
            this.CellAddress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddData);
            this.groupBox1.Controls.Add(this.DataValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DataAdress);
            this.groupBox1.Location = new System.Drawing.Point(6, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Data";
            // 
            // AddData
            // 
            this.AddData.Location = new System.Drawing.Point(107, 19);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(47, 23);
            this.AddData.TabIndex = 1;
            this.AddData.Text = "Add";
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // DataValue
            // 
            this.DataValue.Location = new System.Drawing.Point(57, 46);
            this.DataValue.Name = "DataValue";
            this.DataValue.Size = new System.Drawing.Size(97, 20);
            this.DataValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            // 
            // DataAdress
            // 
            this.DataAdress.Location = new System.Drawing.Point(57, 19);
            this.DataAdress.Name = "DataAdress";
            this.DataAdress.Size = new System.Drawing.Size(45, 20);
            this.DataAdress.TabIndex = 1;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.OperandAddress2);
            this.GroupBox2.Controls.Add(this.AddCommand);
            this.GroupBox2.Controls.Add(this.OperandAddress);
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.CommandAddress);
            this.GroupBox2.Controls.Add(this.CommandBox);
            this.GroupBox2.Location = new System.Drawing.Point(6, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(164, 114);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Add Command";
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(107, 67);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(47, 23);
            this.AddCommand.TabIndex = 1;
            this.AddCommand.Text = "Add";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // OperandAddress
            // 
            this.OperandAddress.Location = new System.Drawing.Point(57, 68);
            this.OperandAddress.Name = "OperandAddress";
            this.OperandAddress.Size = new System.Drawing.Size(45, 20);
            this.OperandAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // CommandAddress
            // 
            this.CommandAddress.Location = new System.Drawing.Point(57, 19);
            this.CommandAddress.Name = "CommandAddress";
            this.CommandAddress.Size = new System.Drawing.Size(97, 20);
            this.CommandAddress.TabIndex = 1;
            // 
            // CommandBox
            // 
            this.CommandBox.FormattingEnabled = true;
            this.CommandBox.Location = new System.Drawing.Point(11, 43);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(143, 21);
            this.CommandBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View,
            this.Help,
            this.Run,
            this.BeginDebug,
            this.Stop});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(262, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // File
            // 
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(38, 22);
            this.File.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // View
            // 
            this.View.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputToolStripMenuItem,
            this.toolBoxToolStripMenuItem});
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(45, 22);
            this.View.Text = "View";
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.outputToolStripMenuItem.Text = "Output/Dump";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.outputToolStripMenuItem_Click);
            // 
            // toolBoxToolStripMenuItem
            // 
            this.toolBoxToolStripMenuItem.Name = "toolBoxToolStripMenuItem";
            this.toolBoxToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toolBoxToolStripMenuItem.Text = "ToolBox";
            this.toolBoxToolStripMenuItem.Click += new System.EventHandler(this.toolBoxToolStripMenuItem_Click);
            // 
            // Help
            // 
            this.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(45, 22);
            this.Help.Text = "Help";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.commandsToolStripMenuItem.Text = "View Help";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.commandsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Run
            // 
            this.Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(32, 22);
            this.Run.Text = "Run";
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // BeginDebug
            // 
            this.BeginDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BeginDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDebuggingToolStripMenuItem,
            this.doStepToolStripMenuItem});
            this.BeginDebug.Image = ((System.Drawing.Image)(resources.GetObject("BeginDebug.Image")));
            this.BeginDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BeginDebug.Name = "BeginDebug";
            this.BeginDebug.Size = new System.Drawing.Size(55, 22);
            this.BeginDebug.Text = "Debug";
            // 
            // startDebuggingToolStripMenuItem
            // 
            this.startDebuggingToolStripMenuItem.Name = "startDebuggingToolStripMenuItem";
            this.startDebuggingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.startDebuggingToolStripMenuItem.Text = "Start Debugging";
            this.startDebuggingToolStripMenuItem.Click += new System.EventHandler(this.startDebuggingToolStripMenuItem_Click);
            // 
            // doStepToolStripMenuItem
            // 
            this.doStepToolStripMenuItem.Enabled = false;
            this.doStepToolStripMenuItem.Name = "doStepToolStripMenuItem";
            this.doStepToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.doStepToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.doStepToolStripMenuItem.Text = "Do Step";
            this.doStepToolStripMenuItem.Click += new System.EventHandler(this.doStepToolStripMenuItem_Click);
            // 
            // Stop
            // 
            this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Stop.Enabled = false;
            this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(35, 22);
            this.Stop.Text = "Stop";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // dfsdfToolStripMenuItem
            // 
            this.dfsdfToolStripMenuItem.Name = "dfsdfToolStripMenuItem";
            this.dfsdfToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // OperandAddress2
            // 
            this.OperandAddress2.Location = new System.Drawing.Point(57, 94);
            this.OperandAddress2.Name = "OperandAddress2";
            this.OperandAddress2.Size = new System.Drawing.Size(45, 20);
            this.OperandAddress2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 326);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "DCPU-16";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Menu.ContentPanel.ResumeLayout(false);
            this.Menu.TopToolStripPanel.ResumeLayout(false);
            this.Menu.TopToolStripPanel.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.WorkSpace.Panel1.ResumeLayout(false);
            this.WorkSpace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkSpace)).EndInit();
            this.WorkSpace.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer Menu;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Help;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Run;
        private System.Windows.Forms.ToolStripButton Stop;
        private System.Windows.Forms.ToolStripDropDownButton View;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.SplitContainer WorkSpace;
        private System.Windows.Forms.ListBox Program;
        private System.Windows.Forms.ToolStripMenuItem toolBoxToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ClearCell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CellAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.TextBox DataValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DataAdress;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button AddCommand;
        private System.Windows.Forms.TextBox OperandAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommandAddress;
        private System.Windows.Forms.ComboBox CommandBox;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem dfsdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton BeginDebug;
        private System.Windows.Forms.ToolStripMenuItem startDebuggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doStepToolStripMenuItem;
        private System.Windows.Forms.TextBox OperandAddress2;
    }
}

