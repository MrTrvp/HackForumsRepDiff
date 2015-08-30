namespace HackForumsRepDiff.UI.Forms
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
                components.Dispose();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmsLoadedDocuments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDocuments = new System.Windows.Forms.TabPage();
            this.lbTotalFiles = new System.Windows.Forms.Label();
            this.lvLoadedDocuments = new System.Windows.Forms.ListView();
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpGiven = new System.Windows.Forms.TabPage();
            this.rcGiven = new HackForumsRepDiff.UI.Controls.ReputationContainer();
            this.tpReceived = new System.Windows.Forms.TabPage();
            this.rcReceived = new HackForumsRepDiff.UI.Controls.ReputationContainer();
            this.tpDifference = new System.Windows.Forms.TabPage();
            this.rcDifference = new HackForumsRepDiff.UI.Controls.ReputationContainer();
            this.cmsLoadedDocuments.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDocuments.SuspendLayout();
            this.tpGiven.SuspendLayout();
            this.tpReceived.SuspendLayout();
            this.tpDifference.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsLoadedDocuments
            // 
            this.cmsLoadedDocuments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiRemove});
            this.cmsLoadedDocuments.Name = "cmsLoadedDocuments";
            this.cmsLoadedDocuments.Size = new System.Drawing.Size(118, 48);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = global::HackForumsRepDiff.Properties.Resources.page_add;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(117, 22);
            this.tsmiAdd.Text = "Add";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Image = global::HackForumsRepDiff.Properties.Resources.page_delete;
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(117, 22);
            this.tsmiRemove.Text = "Remove";
            this.tsmiRemove.Click += new System.EventHandler(this.tsmiRemove_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpDocuments);
            this.tcMain.Controls.Add(this.tpGiven);
            this.tcMain.Controls.Add(this.tpReceived);
            this.tcMain.Controls.Add(this.tpDifference);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(570, 277);
            this.tcMain.TabIndex = 7;
            // 
            // tpDocuments
            // 
            this.tpDocuments.Controls.Add(this.lbTotalFiles);
            this.tpDocuments.Controls.Add(this.lvLoadedDocuments);
            this.tpDocuments.Location = new System.Drawing.Point(4, 22);
            this.tpDocuments.Name = "tpDocuments";
            this.tpDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tpDocuments.Size = new System.Drawing.Size(562, 251);
            this.tpDocuments.TabIndex = 3;
            this.tpDocuments.Text = "Documents";
            this.tpDocuments.UseVisualStyleBackColor = true;
            // 
            // lbTotalFiles
            // 
            this.lbTotalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalFiles.AutoSize = true;
            this.lbTotalFiles.Location = new System.Drawing.Point(3, 233);
            this.lbTotalFiles.Name = "lbTotalFiles";
            this.lbTotalFiles.Size = new System.Drawing.Size(79, 13);
            this.lbTotalFiles.TabIndex = 9;
            this.lbTotalFiles.Text = "Total Files: 0";
            // 
            // lvLoadedDocuments
            // 
            this.lvLoadedDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLoadedDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPath,
            this.chType});
            this.lvLoadedDocuments.ContextMenuStrip = this.cmsLoadedDocuments;
            this.lvLoadedDocuments.FullRowSelect = true;
            this.lvLoadedDocuments.Location = new System.Drawing.Point(3, 3);
            this.lvLoadedDocuments.Name = "lvLoadedDocuments";
            this.lvLoadedDocuments.Size = new System.Drawing.Size(556, 226);
            this.lvLoadedDocuments.TabIndex = 8;
            this.lvLoadedDocuments.UseCompatibleStateImageBehavior = false;
            this.lvLoadedDocuments.View = System.Windows.Forms.View.Details;
            // 
            // chPath
            // 
            this.chPath.Text = "Path";
            this.chPath.Width = 431;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 101;
            // 
            // tpGiven
            // 
            this.tpGiven.Controls.Add(this.rcGiven);
            this.tpGiven.Location = new System.Drawing.Point(4, 22);
            this.tpGiven.Name = "tpGiven";
            this.tpGiven.Padding = new System.Windows.Forms.Padding(3);
            this.tpGiven.Size = new System.Drawing.Size(562, 251);
            this.tpGiven.TabIndex = 0;
            this.tpGiven.Text = "Given";
            this.tpGiven.UseVisualStyleBackColor = true;
            // 
            // rcGiven
            // 
            this.rcGiven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rcGiven.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rcGiven.Location = new System.Drawing.Point(0, 0);
            this.rcGiven.Name = "rcGiven";
            this.rcGiven.Reputations = new HackForumsRepDiff.Core.Models.Reputation[0];
            this.rcGiven.Size = new System.Drawing.Size(562, 251);
            this.rcGiven.TabIndex = 2;
            this.rcGiven.Type = HackForumsRepDiff.Core.Models.TransactionType.Given;
            // 
            // tpReceived
            // 
            this.tpReceived.Controls.Add(this.rcReceived);
            this.tpReceived.Location = new System.Drawing.Point(4, 22);
            this.tpReceived.Name = "tpReceived";
            this.tpReceived.Padding = new System.Windows.Forms.Padding(3);
            this.tpReceived.Size = new System.Drawing.Size(562, 251);
            this.tpReceived.TabIndex = 1;
            this.tpReceived.Text = "Received";
            this.tpReceived.UseVisualStyleBackColor = true;
            // 
            // rcReceived
            // 
            this.rcReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rcReceived.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rcReceived.Location = new System.Drawing.Point(0, 0);
            this.rcReceived.Name = "rcReceived";
            this.rcReceived.Reputations = new HackForumsRepDiff.Core.Models.Reputation[0];
            this.rcReceived.Size = new System.Drawing.Size(562, 251);
            this.rcReceived.TabIndex = 1;
            this.rcReceived.Type = HackForumsRepDiff.Core.Models.TransactionType.Received;
            // 
            // tpDifference
            // 
            this.tpDifference.Controls.Add(this.rcDifference);
            this.tpDifference.Location = new System.Drawing.Point(4, 22);
            this.tpDifference.Name = "tpDifference";
            this.tpDifference.Padding = new System.Windows.Forms.Padding(3);
            this.tpDifference.Size = new System.Drawing.Size(562, 251);
            this.tpDifference.TabIndex = 2;
            this.tpDifference.Text = "Difference";
            this.tpDifference.UseVisualStyleBackColor = true;
            // 
            // rcDifference
            // 
            this.rcDifference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rcDifference.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rcDifference.Location = new System.Drawing.Point(0, 0);
            this.rcDifference.Name = "rcDifference";
            this.rcDifference.Reputations = new HackForumsRepDiff.Core.Models.Reputation[0];
            this.rcDifference.Size = new System.Drawing.Size(562, 251);
            this.rcDifference.TabIndex = 0;
            this.rcDifference.Type = HackForumsRepDiff.Core.Models.TransactionType.Difference;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 301);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HackForums - RepDiff";
            this.cmsLoadedDocuments.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpDocuments.ResumeLayout(false);
            this.tpDocuments.PerformLayout();
            this.tpGiven.ResumeLayout(false);
            this.tpReceived.ResumeLayout(false);
            this.tpDifference.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsLoadedDocuments;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDocuments;
        private System.Windows.Forms.TabPage tpGiven;
        private System.Windows.Forms.TabPage tpReceived;
        private System.Windows.Forms.TabPage tpDifference;
        private System.Windows.Forms.ListView lvLoadedDocuments;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Label lbTotalFiles;
        private Controls.ReputationContainer rcDifference;
        private Controls.ReputationContainer rcReceived;
        private Controls.ReputationContainer rcGiven;
    }
}