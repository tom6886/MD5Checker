namespace MD5Reader
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
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.btn_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(540, 302);
            this.memoEdit1.TabIndex = 0;
            // 
            // btn_file
            // 
            this.btn_file.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_file.Location = new System.Drawing.Point(0, 302);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(540, 37);
            this.btn_file.TabIndex = 1;
            this.btn_file.Text = "选择文件";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 339);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.btn_file);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "读取文件MD5值";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Button btn_file;
    }
}

