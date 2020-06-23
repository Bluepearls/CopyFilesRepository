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
            this.SuspendLayout();
            // 
            // btnCopyAndPaste
            // 
            this.btnCopyAndPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopyAndPaste.Location = new System.Drawing.Point(965, 377);
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
            this.lblSourcePath.Size = new System.Drawing.Size(126, 25);
            this.lblSourcePath.TabIndex = 1;
            this.lblSourcePath.Text = "Source Path:";
            // 
            // lblTargetPath
            // 
            this.lblTargetPath.AutoSize = true;
            this.lblTargetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTargetPath.Location = new System.Drawing.Point(57, 185);
            this.lblTargetPath.Name = "lblTargetPath";
            this.lblTargetPath.Size = new System.Drawing.Size(120, 25);
            this.lblTargetPath.TabIndex = 2;
            this.lblTargetPath.Text = "Target Path:";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSourcePath.Location = new System.Drawing.Point(214, 118);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(819, 35);
            this.txtSourcePath.TabIndex = 3;
            this.txtSourcePath.Text = "              ";
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTargetPath.Location = new System.Drawing.Point(214, 180);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(819, 35);
            this.txtTargetPath.TabIndex = 4;
            this.txtTargetPath.Text = "    ";
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSourcePath.Location = new System.Drawing.Point(1045, 118);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(114, 38);
            this.btnSourcePath.TabIndex = 5;
            this.btnSourcePath.Text = "Browser";
            this.btnSourcePath.UseVisualStyleBackColor = true;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // btnTargetPath
            // 
            this.btnTargetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTargetPath.Location = new System.Drawing.Point(1045, 180);
            this.btnTargetPath.Name = "btnTargetPath";
            this.btnTargetPath.Size = new System.Drawing.Size(114, 38);
            this.btnTargetPath.TabIndex = 6;
            this.btnTargetPath.Text = "Browser";
            this.btnTargetPath.UseVisualStyleBackColor = true;
            this.btnTargetPath.Click += new System.EventHandler(this.btnTargetPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(57, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solution Name:";
            // 
            // txtSolutionName
            // 
            this.txtSolutionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSolutionName.Location = new System.Drawing.Point(214, 58);
            this.txtSolutionName.Name = "txtSolutionName";
            this.txtSolutionName.Size = new System.Drawing.Size(819, 35);
            this.txtSolutionName.TabIndex = 8;
            // 
            // cboCopyView
            // 
            this.cboCopyView.AutoSize = true;
            this.cboCopyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCopyView.Location = new System.Drawing.Point(61, 311);
            this.cboCopyView.Name = "cboCopyView";
            this.cboCopyView.Size = new System.Drawing.Size(133, 29);
            this.cboCopyView.TabIndex = 9;
            this.cboCopyView.Text = "Copy View";
            this.cboCopyView.UseVisualStyleBackColor = true;
            // 
            // cboCopyDll
            // 
            this.cboCopyDll.AutoSize = true;
            this.cboCopyDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCopyDll.Location = new System.Drawing.Point(291, 311);
            this.cboCopyDll.Name = "cboCopyDll";
            this.cboCopyDll.Size = new System.Drawing.Size(126, 29);
            this.cboCopyDll.TabIndex = 10;
            this.cboCopyDll.Text = "Copy DLL";
            this.cboCopyDll.UseVisualStyleBackColor = true;
            // 
            // cboRestart
            // 
            this.cboRestart.AutoSize = true;
            this.cboRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboRestart.Location = new System.Drawing.Point(502, 311);
            this.cboRestart.Name = "cboRestart";
            this.cboRestart.Size = new System.Drawing.Size(167, 29);
            this.cboRestart.TabIndex = 11;
            this.cboRestart.Text = "Restart Google";
            this.cboRestart.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.Location = new System.Drawing.Point(214, 243);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(819, 35);
            this.txtUrl.TabIndex = 12;
            this.txtUrl.Text = "     ";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUrl.Location = new System.Drawing.Point(57, 248);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(144, 25);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "Web Client Url:";
            // 
            // frmCopyFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cboRestart);
            this.Controls.Add(this.cboCopyDll);
            this.Controls.Add(this.cboCopyView);
            this.Controls.Add(this.txtSolutionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTargetPath);
            this.Controls.Add(this.btnSourcePath);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.lblTargetPath);
            this.Controls.Add(this.lblSourcePath);
            this.Controls.Add(this.btnCopyAndPaste);
            this.Name = "frmCopyFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy And Paste Files";
            this.Load += new System.EventHandler(this.frmCopyFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

