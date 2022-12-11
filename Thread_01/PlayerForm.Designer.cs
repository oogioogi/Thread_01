namespace Thread_01
{
    partial class PlayerForm
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
            this.lableName = new System.Windows.Forms.Label();
            this.btnGiveup = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lableStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Location = new System.Drawing.Point(12, 9);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(41, 12);
            this.lableName.TabIndex = 0;
            this.lableName.Text = "아이린";
            // 
            // btnGiveup
            // 
            this.btnGiveup.Location = new System.Drawing.Point(145, 5);
            this.btnGiveup.Name = "btnGiveup";
            this.btnGiveup.Size = new System.Drawing.Size(46, 21);
            this.btnGiveup.TabIndex = 1;
            this.btnGiveup.Text = "포기";
            this.btnGiveup.UseVisualStyleBackColor = true;
            this.btnGiveup.Click += new System.EventHandler(this.btnGiveup_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 26);
            this.progressBar1.TabIndex = 2;
            // 
            // lableStatus
            // 
            this.lableStatus.AutoSize = true;
            this.lableStatus.Location = new System.Drawing.Point(197, 9);
            this.lableStatus.Name = "lableStatus";
            this.lableStatus.Size = new System.Drawing.Size(121, 12);
            this.lableStatus.TabIndex = 3;
            this.lableStatus.Text = "진행 상황 표시: 100%";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(330, 71);
            this.ControlBox = false;
            this.Controls.Add(this.lableStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGiveup);
            this.Controls.Add(this.lableName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Button btnGiveup;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lableStatus;
    }
}