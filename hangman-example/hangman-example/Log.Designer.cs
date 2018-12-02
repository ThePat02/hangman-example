namespace hangman_example
{
    partial class Log
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
            this.m_logbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // m_logbox
            // 
            this.m_logbox.BackColor = System.Drawing.Color.Black;
            this.m_logbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_logbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_logbox.Location = new System.Drawing.Point(12, 12);
            this.m_logbox.Name = "m_logbox";
            this.m_logbox.Size = new System.Drawing.Size(413, 329);
            this.m_logbox.TabIndex = 0;
            this.m_logbox.Text = "";
            this.m_logbox.TextChanged += new System.EventHandler(this.m_logbox_TextChanged);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(437, 353);
            this.Controls.Add(this.m_logbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_logbox;
    }
}