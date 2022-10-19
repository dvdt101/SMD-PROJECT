namespace SMD_PROJECT.view
{
    partial class YouTubeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTubeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.search_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.donwload_btn = new System.Windows.Forms.Button();
            this.logs_box = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link do video :";
            // 
            // search_input
            // 
            this.search_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.search_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_input.ForeColor = System.Drawing.Color.White;
            this.search_input.Location = new System.Drawing.Point(150, 254);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(578, 24);
            this.search_input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "YouTube videos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // donwload_btn
            // 
            this.donwload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.donwload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donwload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.donwload_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.donwload_btn.ForeColor = System.Drawing.Color.White;
            this.donwload_btn.Location = new System.Drawing.Point(347, 296);
            this.donwload_btn.Name = "donwload_btn";
            this.donwload_btn.Size = new System.Drawing.Size(140, 38);
            this.donwload_btn.TabIndex = 6;
            this.donwload_btn.Text = "Baixar video";
            this.donwload_btn.UseVisualStyleBackColor = false;
            this.donwload_btn.Click += new System.EventHandler(this.donwload_btn_Click);
            // 
            // logs_box
            // 
            this.logs_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.logs_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logs_box.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_box.ForeColor = System.Drawing.Color.White;
            this.logs_box.Location = new System.Drawing.Point(7, 366);
            this.logs_box.Name = "logs_box";
            this.logs_box.ReadOnly = true;
            this.logs_box.Size = new System.Drawing.Size(858, 131);
            this.logs_box.TabIndex = 7;
            this.logs_box.Text = "Project SMD Beta v0.25";
            // 
            // YouTubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(877, 509);
            this.Controls.Add(this.logs_box);
            this.Controls.Add(this.donwload_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YouTubeForm";
            this.Text = "YouTubeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button donwload_btn;
        private System.Windows.Forms.RichTextBox logs_box;
    }
}