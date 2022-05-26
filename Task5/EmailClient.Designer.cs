namespace Task5
{
    partial class EmailClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Compose = new System.Windows.Forms.Button();
            this.list_mail = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIL APP";
            // 
            // btn_Compose
            // 
            this.btn_Compose.Location = new System.Drawing.Point(30, 62);
            this.btn_Compose.Name = "btn_Compose";
            this.btn_Compose.Size = new System.Drawing.Size(107, 34);
            this.btn_Compose.TabIndex = 1;
            this.btn_Compose.Text = "Compose";
            this.btn_Compose.UseVisualStyleBackColor = true;
            this.btn_Compose.Click += new System.EventHandler(this.btn_Compose_Click);
            // 
            // list_mail
            // 
            this.list_mail.HideSelection = false;
            this.list_mail.Location = new System.Drawing.Point(172, 62);
            this.list_mail.Name = "list_mail";
            this.list_mail.Size = new System.Drawing.Size(567, 362);
            this.list_mail.TabIndex = 2;
            this.list_mail.UseCompatibleStateImageBehavior = false;
            // 
            // EmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_mail);
            this.Controls.Add(this.btn_Compose);
            this.Controls.Add(this.label1);
            this.Name = "EmailClient";
            this.Text = "EmailClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Compose;
        private System.Windows.Forms.ListView list_mail;
    }
}