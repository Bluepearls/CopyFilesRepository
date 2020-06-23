namespace CopyFiles
{
    partial class frmCopyFiles
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
            this.btnCopyAndPaste = new System.Windows.Forms.Button();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.lblTargetPath = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.btnTargetPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSolutionName = new System.Windows.Forms.TextBox();
            this.cboCopyView = new System.Windows.Forms.CheckBox();
            this.cboCopyDll = new System.Windows.Forms.CheckBox();
            this.cboRestart = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pnlCopy = new System.Windows.Forms.Panel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlCopy.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.SuspendLayout();
            //
            // btnCopyAndPaste
            //
            this.btnCopyAndPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyAndPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopyAndPaste.Location = new System.Drawing.Point(965, 352);
            this.btnCopyAndPaste.Name = "btnCopyAndPaste";
            this.btnCopyAndPaste.Size = new System.Drawing.Size(194, 38);
            this.btnCopyAndPaste.TabIndex = 0;
            this.btnCopyAndPaste.Text = "Copy And Paste";
            this.btnCopyAndPaste.UseVisualStyleBackColor = true;
            this.btnCopyAndPaste.Click += new System.EventHandler(this.btnCopyAndPaste_Click);
            //
            // lblSourcePath
            //
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSourcePath.Location = new System.Drawing.Point(56, 123);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(120, 25);
            this.lblSourcePath.TabIndex = 20;
            this.lblSourcePath.Text = "Source Path";
            //
            // lblTargetPath
            //
            this.lblTargetPath.AutoSize = true;
            this.lblTargetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTargetPath.Location = new System.Drawing.Point(57, 185);
            this.lblTargetPath.Name = "lblTargetPath";
            this.lblTargetPath.Size = new System.Drawing.Size(114, 25);
            this.lblTargetPath.TabIndex = 21;
            this.lblTargetPath.Text = "Target Path";
            //
            // txtSourcePath
            //
            this.txtSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSourcePath.Location = new System.Drawing.Point(214, 118);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(819, 35);
            this.txtSourcePath.TabIndex = 2;
            //
            // txtTargetPath
            //
            this.txtTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTargetPath.Location = new System.Drawing.Point(214, 180);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(819, 35);
            this.txtTargetPath.TabIndex = 4;
            //
            // btnSourcePath
            //
            this.btnSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSourcePath.Location = new System.Drawing.Point(1045, 118);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(114, 38);
            this.btnSourcePath.TabIndex = 3;
            this.btnSourcePath.Text = "Browser";
            this.btnSourcePath.UseVisualStyleBackColor = true;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            //
            // btnTargetPath
            //
            this.btnTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTargetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTargetPath.Location = new System.Drawing.Point(1045, 180);
            this.btnTargetPath.Name = "btnTargetPath";
            this.btnTargetPath.Size = new System.Drawing.Size(114, 38);
            this.btnTargetPath.TabIndex = 5;
            this.btnTargetPath.Text = "Browser";
            this.btnTargetPath.UseVisualStyleBackColor = true;
            this.btnTargetPath.Click += new System.EventHandler(this.btnTargetPath_Click);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(57, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Solution Name";
            //
            // txtSolutionName
            //
            this.txtSolutionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolutionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSolutionName.Location = new System.Drawing.Point(214, 58);
            this.txtSolutionName.Name = "txtSolutionName";
            this.txtSolutionName.Size = new System.Drawing.Size(819, 35);
            this.txtSolutionName.TabIndex = 1;
            //
            // cboCopyView
            //
            this.cboCopyView.AutoSize = true;
            this.cboCopyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCopyView.Location = new System.Drawing.Point(62, 312);
            this.cboCopyView.Name = "cboCopyView";
            this.cboCopyView.Size = new System.Drawing.Size(133, 29);
            this.cboCopyView.TabIndex = 8;
            this.cboCopyView.Text = "Copy View";
            this.cboCopyView.UseVisualStyleBackColor = true;
            //
            // cboCopyDll
            //
            this.cboCopyDll.AutoSize = true;
            this.cboCopyDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCopyDll.Location = new System.Drawing.Point(336, 312);
            this.cboCopyDll.Name = "cboCopyDll";
            this.cboCopyDll.Size = new System.Drawing.Size(126, 29);
            this.cboCopyDll.TabIndex = 9;
            this.cboCopyDll.Text = "Copy DLL";
            this.cboCopyDll.UseVisualStyleBackColor = true;
            //
            // cboRestart
            //
            this.cboRestart.AutoSize = true;
            this.cboRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboRestart.Location = new System.Drawing.Point(623, 312);
            this.cboRestart.Name = "cboRestart";
            this.cboRestart.Size = new System.Drawing.Size(167, 29);
            this.cboRestart.TabIndex = 10;
            this.cboRestart.Text = "Restart Google";
            this.cboRestart.UseVisualStyleBackColor = true;
            //
            // txtUrl
            //
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.Location = new System.Drawing.Point(214, 243);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(819, 35);
            this.txtUrl.TabIndex = 6;
            //
            // lblUrl
            //
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUrl.Location = new System.Drawing.Point(57, 248);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(138, 25);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "Web Client Url";
            //
            // pnlCopy
            //
            this.pnlCopy.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCopy.Controls.Add(this.pnlMessage);
            this.pnlCopy.Controls.Add(this.lblUrl);
            this.pnlCopy.Controls.Add(this.txtUrl);
            this.pnlCopy.Controls.Add(this.cboRestart);
            this.pnlCopy.Controls.Add(this.cboCopyDll);
            this.pnlCopy.Controls.Add(this.cboCopyView);
            this.pnlCopy.Controls.Add(this.txtSolutionName);
            this.pnlCopy.Controls.Add(this.label3);
            this.pnlCopy.Controls.Add(this.btnTargetPath);
            this.pnlCopy.Controls.Add(this.btnSourcePath);
            this.pnlCopy.Controls.Add(this.txtTargetPath);
            this.pnlCopy.Controls.Add(this.txtSourcePath);
            this.pnlCopy.Controls.Add(this.lblTargetPath);
            this.pnlCopy.Controls.Add(this.lblSourcePath);
            this.pnlCopy.Controls.Add(this.btnCopyAndPaste);
            this.pnlCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCopy.Location = new System.Drawing.Point(0, 0);
            this.pnlCopy.Margin = new System.Windows.Forms.Padding(30);
            this.pnlCopy.Name = "pnlCopy";
            this.pnlCopy.Size = new System.Drawing.Size(1206, 453);
            this.pnlCopy.TabIndex = 14;
            //
            // pnlMessage
            //
            this.pnlMessage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMessage.Location = new System.Drawing.Point(0, 410);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(1206, 43);
            this.pnlMessage.TabIndex = 24;
            this.pnlMessage.Visible = false;
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.Location = new System.Drawing.Point(12, 8);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 25);
            this.lblMessage.TabIndex = 24;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // frmCopyFiles
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1206, 453);
            this.Controls.Add(this.pnlCopy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmCopyFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy And Paste Files (version : 1.0.0.1)";
            this.Load += new System.EventHandler(this.frmCopyFiles_Load);
            this.pnlCopy.ResumeLayout(false);
            this.pnlCopy.PerformLayout();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopyAndPaste;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Label lblTargetPath;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.Button btnTargetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSolutionName;
        private System.Windows.Forms.CheckBox cboCopyView;
        private System.Windows.Forms.CheckBox cboCopyDll;
        private System.Windows.Forms.CheckBox cboRestart;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Panel pnlCopy;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label lblMessage;
    }
}