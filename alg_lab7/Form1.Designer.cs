namespace alg_lab7
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
            this.dirPath = new System.Windows.Forms.TextBox();
            this.btn_goto = new System.Windows.Forms.Button();
            this.itemslistBox = new System.Windows.Forms.ListBox();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dirPath
            // 
            this.dirPath.Location = new System.Drawing.Point(0, 0);
            this.dirPath.Name = "dirPath";
            this.dirPath.Size = new System.Drawing.Size(360, 22);
            this.dirPath.TabIndex = 0;
            // 
            // btn_goto
            // 
            this.btn_goto.Location = new System.Drawing.Point(407, 0);
            this.btn_goto.Name = "btn_goto";
            this.btn_goto.Size = new System.Drawing.Size(75, 23);
            this.btn_goto.TabIndex = 1;
            this.btn_goto.Text = "go to";
            this.btn_goto.UseVisualStyleBackColor = true;
            this.btn_goto.Click += new System.EventHandler(this.btn_goto_Click);
            // 
            // itemslistBox
            // 
            this.itemslistBox.FormattingEnabled = true;
            this.itemslistBox.ItemHeight = 16;
            this.itemslistBox.Location = new System.Drawing.Point(0, 51);
            this.itemslistBox.Name = "itemslistBox";
            this.itemslistBox.Size = new System.Drawing.Size(482, 372);
            this.itemslistBox.TabIndex = 2;
            this.itemslistBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.images_listBox_MouseDoubleClick);
            // 
            // btn_goBack
            // 
            this.btn_goBack.Location = new System.Drawing.Point(407, 29);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(75, 23);
            this.btn_goBack.TabIndex = 3;
            this.btn_goBack.Text = "go back";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.itemslistBox);
            this.Controls.Add(this.btn_goto);
            this.Controls.Add(this.dirPath);
            this.Name = "Form1";
            this.Text = "image view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirPath;
        private System.Windows.Forms.Button btn_goto;
        private System.Windows.Forms.ListBox itemslistBox;
        private System.Windows.Forms.Button btn_goBack;
    }
}

