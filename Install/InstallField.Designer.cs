namespace Install
{
    partial class InstallField
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
            this.components = new System.ComponentModel.Container();
            this.l_title = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.l_path = new System.Windows.Forms.Label();
            this.btn_read = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.l_text = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_title.Location = new System.Drawing.Point(12, 9);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(200, 30);
            this.l_title.TabIndex = 0;
            this.l_title.Text = "Установщик ПО";
            // 
            // btn_next
            // 
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.Location = new System.Drawing.Point(622, 424);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 35);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Далее";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // l_path
            // 
            this.l_path.BackColor = System.Drawing.Color.White;
            this.l_path.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.l_path.Location = new System.Drawing.Point(15, 104);
            this.l_path.Name = "l_path";
            this.l_path.Size = new System.Drawing.Size(430, 25);
            this.l_path.TabIndex = 2;
            this.l_path.Text = "C://";
            // 
            // btn_read
            // 
            this.btn_read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_read.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_read.Location = new System.Drawing.Point(451, 102);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(80, 30);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "Обзор";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // l_text
            // 
            this.l_text.AutoSize = true;
            this.l_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_text.Location = new System.Drawing.Point(13, 75);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(289, 20);
            this.l_text.TabIndex = 4;
            this.l_text.Text = "Выберите путь для установки программы.";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.Location = new System.Drawing.Point(516, 424);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 35);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // InstallField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(734, 471);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.l_text);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.l_path);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.l_title);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(750, 510);
            this.MinimumSize = new System.Drawing.Size(750, 510);
            this.Name = "InstallField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstallShield";
            this.Load += new System.EventHandler(this.InstallField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label l_path;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label l_text;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Timer Progress;
    }
}