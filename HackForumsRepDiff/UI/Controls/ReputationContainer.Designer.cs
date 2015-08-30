namespace HackForumsRepDiff.UI.Controls
{
    partial class ReputationContainer
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
            this.components = new System.ComponentModel.Container();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lvReputations = new System.Windows.Forms.ListView();
            this.chUsernameD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsReputations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReputations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(3, 233);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(256, 13);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total Unknown Count: 0 - Total Unknown: 0";
            // 
            // lvReputations
            // 
            this.lvReputations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvReputations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsernameD,
            this.chNumberD,
            this.chCommentD,
            this.chTimeD});
            this.lvReputations.ContextMenuStrip = this.cmsReputations;
            this.lvReputations.FullRowSelect = true;
            this.lvReputations.Location = new System.Drawing.Point(3, 3);
            this.lvReputations.Name = "lvReputations";
            this.lvReputations.Size = new System.Drawing.Size(556, 226);
            this.lvReputations.TabIndex = 9;
            this.lvReputations.UseCompatibleStateImageBehavior = false;
            this.lvReputations.View = System.Windows.Forms.View.Details;
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
            // cmsReputations
            // 
            this.cmsReputations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy});
            this.cmsReputations.Name = "cmsReputations";
            this.cmsReputations.Size = new System.Drawing.Size(153, 48);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::HackForumsRepDiff.Properties.Resources.cell_copy;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(152, 22);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // ReputationContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvReputations);
            this.Controls.Add(this.lbTotal);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "ReputationContainer";
            this.Size = new System.Drawing.Size(562, 251);
            this.cmsReputations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ListView lvReputations;
        private System.Windows.Forms.ColumnHeader chUsernameD;
        private System.Windows.Forms.ColumnHeader chNumberD;
        private System.Windows.Forms.ColumnHeader chCommentD;
        private System.Windows.Forms.ColumnHeader chTimeD;
        private System.Windows.Forms.ContextMenuStrip cmsReputations;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
    }
}