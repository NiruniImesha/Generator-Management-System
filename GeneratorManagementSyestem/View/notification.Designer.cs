namespace GeneratorManagementSyestem.View
{
    partial class notification
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
            this.notification_txt = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notification_txt
            // 
            this.notification_txt.AutoSize = true;
            this.notification_txt.Location = new System.Drawing.Point(117, 60);
            this.notification_txt.Name = "notification_txt";
            this.notification_txt.Size = new System.Drawing.Size(78, 17);
            this.notification_txt.TabIndex = 0;
            this.notification_txt.Text = "Notification";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(166, 166);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.notification_txt);
            this.Name = "notification";
            this.Text = "notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notification_txt;
        private System.Windows.Forms.Button btn_ok;
    }
}