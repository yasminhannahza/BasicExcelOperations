namespace BasicExcelOperations
{
    partial class frmBasicExcelOps
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
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnOps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 412);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(776, 33);
            this.pbProgress.TabIndex = 4;
            this.pbProgress.Visible = false;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 120);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(776, 271);
            this.txtConsole.TabIndex = 3;
            // 
            // btnOps
            // 
            this.btnOps.Location = new System.Drawing.Point(586, 12);
            this.btnOps.Name = "btnOps";
            this.btnOps.Size = new System.Drawing.Size(151, 52);
            this.btnOps.TabIndex = 5;
            this.btnOps.Text = "Ops??";
            this.btnOps.UseVisualStyleBackColor = true;
            this.btnOps.Click += new System.EventHandler(this.btnOps_Click);
            // 
            // frmBasicExcelOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOps);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.txtConsole);
            this.Name = "frmBasicExcelOps";
            this.Text = "Basic Excel Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnOps;
    }
}

