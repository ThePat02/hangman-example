namespace hangman_example
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_picturebox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_btn_start = new System.Windows.Forms.Button();
            this.m_text_hangman = new System.Windows.Forms.Label();
            this.m_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_picturebox
            // 
            this.m_picturebox.Location = new System.Drawing.Point(12, 42);
            this.m_picturebox.Name = "m_picturebox";
            this.m_picturebox.Size = new System.Drawing.Size(398, 318);
            this.m_picturebox.TabIndex = 0;
            this.m_picturebox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // m_btn_start
            // 
            this.m_btn_start.Location = new System.Drawing.Point(416, 274);
            this.m_btn_start.Name = "m_btn_start";
            this.m_btn_start.Size = new System.Drawing.Size(395, 86);
            this.m_btn_start.TabIndex = 3;
            this.m_btn_start.Text = "Start game";
            this.m_btn_start.UseVisualStyleBackColor = true;
            this.m_btn_start.Click += new System.EventHandler(this.m_btn_start_Click);
            // 
            // m_text_hangman
            // 
            this.m_text_hangman.AutoSize = true;
            this.m_text_hangman.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_text_hangman.Location = new System.Drawing.Point(12, 363);
            this.m_text_hangman.Name = "m_text_hangman";
            this.m_text_hangman.Size = new System.Drawing.Size(311, 73);
            this.m_text_hangman.TabIndex = 4;
            this.m_text_hangman.Text = "Hangman";
            // 
            // m_box
            // 
            this.m_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_box.Enabled = false;
            this.m_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_box.Location = new System.Drawing.Point(673, 188);
            this.m_box.Name = "m_box";
            this.m_box.Size = new System.Drawing.Size(138, 80);
            this.m_box.TabIndex = 6;
            this.m_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_box.TextChanged += new System.EventHandler(this.m_box_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 556);
            this.Controls.Add(this.m_box);
            this.Controls.Add(this.m_text_hangman);
            this.Controls.Add(this.m_btn_start);
            this.Controls.Add(this.m_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_picturebox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button m_btn_start;
        private System.Windows.Forms.Label m_text_hangman;
        private System.Windows.Forms.TextBox m_box;
    }
}

