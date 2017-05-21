namespace ProjectFrstTry
{
    partial class UcCreateVisitor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvVisitorTypes = new System.Windows.Forms.TreeView();
            this.gbVisitorType = new System.Windows.Forms.GroupBox();
            this.gbVisitorInfo = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbCreated = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbVisitorType.SuspendLayout();
            this.gbVisitorInfo.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbVisitorType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbVisitorInfo);
            this.splitContainer1.Size = new System.Drawing.Size(383, 231);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvVisitorTypes
            // 
            this.tvVisitorTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvVisitorTypes.Location = new System.Drawing.Point(3, 16);
            this.tvVisitorTypes.Name = "tvVisitorTypes";
            this.tvVisitorTypes.Size = new System.Drawing.Size(121, 212);
            this.tvVisitorTypes.TabIndex = 0;
            // 
            // gbVisitorType
            // 
            this.gbVisitorType.Controls.Add(this.tvVisitorTypes);
            this.gbVisitorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisitorType.Location = new System.Drawing.Point(0, 0);
            this.gbVisitorType.Name = "gbVisitorType";
            this.gbVisitorType.Size = new System.Drawing.Size(127, 231);
            this.gbVisitorType.TabIndex = 0;
            this.gbVisitorType.TabStop = false;
            this.gbVisitorType.Text = "Visitor Type";
            // 
            // gbVisitorInfo
            // 
            this.gbVisitorInfo.Controls.Add(this.dtpCreateDate);
            this.gbVisitorInfo.Controls.Add(this.cbDestination);
            this.gbVisitorInfo.Controls.Add(this.tbName);
            this.gbVisitorInfo.Controls.Add(this.lbCreated);
            this.gbVisitorInfo.Controls.Add(this.lbDestination);
            this.gbVisitorInfo.Controls.Add(this.lbName);
            this.gbVisitorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisitorInfo.Location = new System.Drawing.Point(0, 0);
            this.gbVisitorInfo.Name = "gbVisitorInfo";
            this.gbVisitorInfo.Size = new System.Drawing.Size(252, 231);
            this.gbVisitorInfo.TabIndex = 0;
            this.gbVisitorInfo.TabStop = false;
            this.gbVisitorInfo.Text = "Visitor Info";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(17, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(17, 62);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(60, 13);
            this.lbDestination.TabIndex = 1;
            this.lbDestination.Text = "Destination";
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Location = new System.Drawing.Point(17, 86);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(44, 13);
            this.lbCreated.TabIndex = 2;
            this.lbCreated.Text = "Created";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(116, 20);
            this.tbName.TabIndex = 3;
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(84, 64);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(116, 21);
            this.cbDestination.TabIndex = 4;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Location = new System.Drawing.Point(84, 86);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(116, 20);
            this.dtpCreateDate.TabIndex = 5;
            // 
            // UcCreateVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcCreateVisitor";
            this.Size = new System.Drawing.Size(383, 231);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbVisitorType.ResumeLayout(false);
            this.gbVisitorInfo.ResumeLayout(false);
            this.gbVisitorInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbVisitorType;
        private System.Windows.Forms.TreeView tvVisitorTypes;
        private System.Windows.Forms.GroupBox gbVisitorInfo;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbName;
    }
}
