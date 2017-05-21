namespace ProjectFrstTry
{
    partial class UcEditVisitor
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
            this.gbVisitorInfo = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.gbVisitorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVisitorInfo
            // 
            this.gbVisitorInfo.Controls.Add(this.cbDestination);
            this.gbVisitorInfo.Controls.Add(this.tbName);
            this.gbVisitorInfo.Controls.Add(this.lbDestination);
            this.gbVisitorInfo.Controls.Add(this.lbName);
            this.gbVisitorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisitorInfo.Location = new System.Drawing.Point(0, 0);
            this.gbVisitorInfo.Name = "gbVisitorInfo";
            this.gbVisitorInfo.Size = new System.Drawing.Size(233, 81);
            this.gbVisitorInfo.TabIndex = 0;
            this.gbVisitorInfo.TabStop = false;
            this.gbVisitorInfo.Text = "Visitor Info";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(27, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(27, 43);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(60, 13);
            this.lbDestination.TabIndex = 1;
            this.lbDestination.Text = "Destination";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 2;
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(100, 40);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(121, 21);
            this.cbDestination.TabIndex = 3;
            // 
            // UcEditVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbVisitorInfo);
            this.Name = "UcEditVisitor";
            this.Size = new System.Drawing.Size(233, 81);
            this.gbVisitorInfo.ResumeLayout(false);
            this.gbVisitorInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVisitorInfo;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbName;
    }
}
