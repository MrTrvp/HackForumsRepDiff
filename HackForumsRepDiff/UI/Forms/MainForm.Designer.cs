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
            this.lvGiven = new System.Windows.Forms.ListView();
            this.chUsernameG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvReceived = new System.Windows.Forms.ListView();
            this.chUsernameR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsernameD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDifference = new System.Windows.Forms.ListView();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDocuments = new System.Windows.Forms.TabPage();
            this.lvLoadedDocuments = new System.Windows.Forms.ListView();
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpGiven = new System.Windows.Forms.TabPage();
            this.tpReceived = new System.Windows.Forms.TabPage();
            this.tpDifference = new System.Windows.Forms.TabPage();
            this.lbGiven = new System.Windows.Forms.Label();
            this.lbReceived = new System.Windows.Forms.Label();
            this.lbDifference = new System.Windows.Forms.Label();
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
            // lvGiven
            // 
            this.lvGiven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGiven.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsernameG,
            this.chNumberG,
            this.chCommentG,
            this.chTimeG});
            this.lvGiven.FullRowSelect = true;
            this.lvGiven.Location = new System.Drawing.Point(3, 3);
            this.lvGiven.Name = "lvGiven";
            this.lvGiven.Size = new System.Drawing.Size(556, 226);
            this.lvGiven.TabIndex = 3;
            this.lvGiven.UseCompatibleStateImageBehavior = false;
            this.lvGiven.View = System.Windows.Forms.View.Details;
            // 
            // chUsernameG
            // 
            this.chUsernameG.Text = "Username";
            this.chUsernameG.Width = 132;
            // 
            // chNumberG
            // 
            this.chNumberG.Text = "Number";
            this.chNumberG.Width = 78;
            // 
            // chCommentG
            // 
            this.chCommentG.Text = "Comment";
            this.chCommentG.Width = 236;
            // 
            // chTimeG
            // 
            this.chTimeG.Text = "Time";
            this.chTimeG.Width = 86;
            // 
            // lvReceived
            // 
            this.lvReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsernameR,
            this.chNumberR,
            this.chCommentR,
            this.chTimeR});
            this.lvReceived.FullRowSelect = true;
            this.lvReceived.Location = new System.Drawing.Point(3, 3);
            this.lvReceived.Name = "lvReceived";
            this.lvReceived.Size = new System.Drawing.Size(556, 226);
            this.lvReceived.TabIndex = 3;
            this.lvReceived.UseCompatibleStateImageBehavior = false;
            this.lvReceived.View = System.Windows.Forms.View.Details;
            // 
            // chUsernameR
            // 
            this.chUsernameR.Text = "Username";
            this.chUsernameR.Width = 132;
            // 
            // chNumberR
            // 
            this.chNumberR.Text = "Number";
            this.chNumberR.Width = 78;
            // 
            // chCommentR
            // 
            this.chCommentR.Text = "Comment";
            this.chCommentR.Width = 236;
            // 
            // chTimeR
            // 
            this.chTimeR.Text = "Time";
            this.chTimeR.Width = 86;
            // 
            // chUsernameD
            // 
            this.chUsernameD.Text = "Username";
            this.chUsernameD.Width = 132;
            // 
            // chNumberD
            // 
            this.chNumberD.Text = "Number";
            this.chNumberD.Width = 78;
            // 
            // chCommentD
            // 
            this.chCommentD.Text = "Comment";
            this.chCommentD.Width = 236;
            // 
            // chTimeD
            // 
            this.chTimeD.Text = "Time";
            this.chTimeD.Width = 86;
            // 
            // lvDifference
            // 
            this.lvDifference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDifference.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsernameD,
            this.chNumberD,
            this.chCommentD,
            this.chTimeD});
            this.lvDifference.FullRowSelect = true;
            this.lvDifference.Location = new System.Drawing.Point(3, 3);
            this.lvDifference.Name = "lvDifference";
            this.lvDifference.Size = new System.Drawing.Size(556, 226);
            this.lvDifference.TabIndex = 3;
            this.lvDifference.UseCompatibleStateImageBehavior = false;
            this.lvDifference.View = System.Windows.Forms.View.Details;
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
            this.tpDocuments.Controls.Add(this.lvLoadedDocuments);
            this.tpDocuments.Location = new System.Drawing.Point(4, 22);
            this.tpDocuments.Name = "tpDocuments";
            this.tpDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tpDocuments.Size = new System.Drawing.Size(562, 251);
            this.tpDocuments.TabIndex = 3;
            this.tpDocuments.Text = "Documents";
            this.tpDocuments.UseVisualStyleBackColor = true;
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
            this.lvLoadedDocuments.Size = new System.Drawing.Size(556, 245);
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
            this.tpGiven.Controls.Add(this.lbGiven);
            this.tpGiven.Controls.Add(this.lvGiven);
            this.tpGiven.Location = new System.Drawing.Point(4, 22);
            this.tpGiven.Name = "tpGiven";
            this.tpGiven.Padding = new System.Windows.Forms.Padding(3);
            this.tpGiven.Size = new System.Drawing.Size(562, 251);
            this.tpGiven.TabIndex = 0;
            this.tpGiven.Text = "Given";
            this.tpGiven.UseVisualStyleBackColor = true;
            // 
            // tpReceived
            // 
            this.tpReceived.Controls.Add(this.lbReceived);
            this.tpReceived.Controls.Add(this.lvReceived);
            this.tpReceived.Location = new System.Drawing.Point(4, 22);
            this.tpReceived.Name = "tpReceived";
            this.tpReceived.Padding = new System.Windows.Forms.Padding(3);
            this.tpReceived.Size = new System.Drawing.Size(562, 251);
            this.tpReceived.TabIndex = 1;
            this.tpReceived.Text = "Received";
            this.tpReceived.UseVisualStyleBackColor = true;
            // 
            // tpDifference
            // 
            this.tpDifference.Controls.Add(this.lbDifference);
            this.tpDifference.Controls.Add(this.lvDifference);
            this.tpDifference.Location = new System.Drawing.Point(4, 22);
            this.tpDifference.Name = "tpDifference";
            this.tpDifference.Padding = new System.Windows.Forms.Padding(3);
            this.tpDifference.Size = new System.Drawing.Size(562, 251);
            this.tpDifference.TabIndex = 2;
            this.tpDifference.Text = "Difference";
            this.tpDifference.UseVisualStyleBackColor = true;
            // 
            // lbGiven
            // 
            this.lbGiven.AutoSize = true;
            this.lbGiven.Location = new System.Drawing.Point(3, 233);
            this.lbGiven.Name = "lbGiven";
            this.lbGiven.Size = new System.Drawing.Size(218, 13);
            this.lbGiven.TabIndex = 4;
            this.lbGiven.Text = "Total Given Count: 0 - Total Given: 0";
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Location = new System.Drawing.Point(3, 233);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(256, 13);
            this.lbReceived.TabIndex = 5;
            this.lbReceived.Text = "Total Received Count: 0 - Total Received: 0";
            // 
            // lbDifference
            // 
            this.lbDifference.AutoSize = true;
            this.lbDifference.Location = new System.Drawing.Point(3, 233);
            this.lbDifference.Name = "lbDifference";
            this.lbDifference.Size = new System.Drawing.Size(270, 13);
            this.lbDifference.TabIndex = 6;
            this.lbDifference.Text = "Total Difference Count: 0 - Total Difference: 0";
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
            this.tpGiven.ResumeLayout(false);
            this.tpGiven.PerformLayout();
            this.tpReceived.ResumeLayout(false);
            this.tpReceived.PerformLayout();
            this.tpDifference.ResumeLayout(false);
            this.tpDifference.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsLoadedDocuments;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.ListView lvGiven;
        private System.Windows.Forms.ListView lvReceived;
        private System.Windows.Forms.ListView lvDifference;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDocuments;
        private System.Windows.Forms.TabPage tpGiven;
        private System.Windows.Forms.TabPage tpReceived;
        private System.Windows.Forms.TabPage tpDifference;
        private System.Windows.Forms.ColumnHeader chUsernameG;
        private System.Windows.Forms.ColumnHeader chNumberG;
        private System.Windows.Forms.ColumnHeader chCommentG;
        private System.Windows.Forms.ColumnHeader chTimeG;
        private System.Windows.Forms.ColumnHeader chUsernameR;
        private System.Windows.Forms.ColumnHeader chNumberR;
        private System.Windows.Forms.ColumnHeader chCommentR;
        private System.Windows.Forms.ColumnHeader chTimeR;
        private System.Windows.Forms.ColumnHeader chUsernameD;
        private System.Windows.Forms.ColumnHeader chNumberD;
        private System.Windows.Forms.ColumnHeader chCommentD;
        private System.Windows.Forms.ColumnHeader chTimeD;
        private System.Windows.Forms.ListView lvLoadedDocuments;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Label lbGiven;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.Label lbDifference;
    }
}