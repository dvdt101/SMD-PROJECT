namespace SMD_PROJECT
{
    partial class MainPanel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.youtube_btn = new System.Windows.Forms.Button();
            this.music_btn = new System.Windows.Forms.Button();
            this.spotify_btn = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.menu_panel.Controls.Add(this.youtube_btn);
            this.menu_panel.Controls.Add(this.music_btn);
            this.menu_panel.Controls.Add(this.spotify_btn);
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1732, 32);
            this.menu_panel.TabIndex = 0;
            // 
            // youtube_btn
            // 
            this.youtube_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.youtube_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtube_btn.FlatAppearance.BorderSize = 0;
            this.youtube_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.youtube_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youtube_btn.ForeColor = System.Drawing.Color.White;
            this.youtube_btn.Location = new System.Drawing.Point(159, 1);
            this.youtube_btn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.youtube_btn.Name = "youtube_btn";
            this.youtube_btn.Size = new System.Drawing.Size(162, 28);
            this.youtube_btn.TabIndex = 2;
            this.youtube_btn.Text = "Youtube";
            this.youtube_btn.UseVisualStyleBackColor = false;
            this.youtube_btn.Click += new System.EventHandler(this.youtube_btn_Click);
            // 
            // music_btn
            // 
            this.music_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.music_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.music_btn.FlatAppearance.BorderSize = 0;
            this.music_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.music_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_btn.ForeColor = System.Drawing.Color.White;
            this.music_btn.Location = new System.Drawing.Point(0, 1);
            this.music_btn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.music_btn.Name = "music_btn";
            this.music_btn.Size = new System.Drawing.Size(162, 28);
            this.music_btn.TabIndex = 1;
            this.music_btn.Text = "Musicas";
            this.music_btn.UseVisualStyleBackColor = false;
            this.music_btn.Click += new System.EventHandler(this.music_btn_Click);
            // 
            // spotify_btn
            // 
            this.spotify_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.spotify_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spotify_btn.FlatAppearance.BorderSize = 0;
            this.spotify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spotify_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spotify_btn.ForeColor = System.Drawing.Color.White;
            this.spotify_btn.Location = new System.Drawing.Point(314, 0);
            this.spotify_btn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.spotify_btn.Name = "spotify_btn";
            this.spotify_btn.Size = new System.Drawing.Size(162, 29);
            this.spotify_btn.TabIndex = 1;
            this.spotify_btn.Text = "Spotify";
            this.spotify_btn.UseVisualStyleBackColor = false;
            this.spotify_btn.Click += new System.EventHandler(this.spotify_btn_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Black;
            this.main_panel.Controls.Add(this.pictureBox1);
            this.main_panel.Location = new System.Drawing.Point(0, 29);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(877, 509);
            this.main_panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 536);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.menu_panel);
            this.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "MainPanel";
            this.Text = "SMD-PROJECT";
            this.menu_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button spotify_btn;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button music_btn;
        private System.Windows.Forms.Button youtube_btn;
    }
}

