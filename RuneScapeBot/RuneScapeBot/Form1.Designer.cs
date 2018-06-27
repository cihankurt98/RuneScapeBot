namespace RuneScapeBot
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
            this.btn_launch = new System.Windows.Forms.Button();
            this.opd_selectFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_launch
            // 
            this.btn_launch.Location = new System.Drawing.Point(278, 209);
            this.btn_launch.Name = "btn_launch";
            this.btn_launch.Size = new System.Drawing.Size(183, 30);
            this.btn_launch.TabIndex = 0;
            this.btn_launch.Text = "Launch RuneScape";
            this.btn_launch.UseVisualStyleBackColor = true;
            this.btn_launch.Click += new System.EventHandler(this.btn_launch_Click);
            // 
            // opd_selectFile
            // 
            this.opd_selectFile.FileName = "selectedFile";
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.Location = new System.Drawing.Point(278, 158);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(183, 30);
            this.btn_selectFile.TabIndex = 1;
            this.btn_selectFile.Text = "Select RuneScape exe";
            this.btn_selectFile.UseVisualStyleBackColor = true;
            this.btn_selectFile.Click += new System.EventHandler(this.btn_selectFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_selectFile);
            this.Controls.Add(this.btn_launch);
            this.Name = "Form1";
            this.Text = "RunescapeBot V1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_launch;
        private System.Windows.Forms.OpenFileDialog opd_selectFile;
        private System.Windows.Forms.Button btn_selectFile;
    }
}

