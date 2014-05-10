namespace DCPU_16.Forms
{
    partial class HelpForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SET");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ADD");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SUB");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("MUL");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("MLI");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DIV");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("DVI");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("MOD");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Commands", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.HelpTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.HelpTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(463, 298);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Set";
            treeNode1.Text = "SET";
            treeNode2.Name = "Add";
            treeNode2.Text = "ADD";
            treeNode3.Name = "Sub";
            treeNode3.Text = "SUB";
            treeNode4.Name = "Mul";
            treeNode4.Text = "MUL";
            treeNode5.Name = "Mli";
            treeNode5.Text = "MLI";
            treeNode6.Name = "Div";
            treeNode6.Text = "DIV";
            treeNode7.Name = "Dvi";
            treeNode7.Text = "DVI";
            treeNode8.Name = "Mod";
            treeNode8.Text = "MOD";
            treeNode9.Name = "Commands";
            treeNode9.Text = "Commands";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(154, 298);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // HelpTextBox
            // 
            this.HelpTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpTextBox.Location = new System.Drawing.Point(0, 0);
            this.HelpTextBox.Name = "HelpTextBox";
            this.HelpTextBox.ReadOnly = true;
            this.HelpTextBox.Size = new System.Drawing.Size(305, 298);
            this.HelpTextBox.TabIndex = 0;
            this.HelpTextBox.Text = "";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 298);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox HelpTextBox;
        

        
    }
}