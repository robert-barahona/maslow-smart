namespace ADCN
{
    partial class frmRendirse
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerVideo = new System.Windows.Forms.Button();
            this.btnVolverAJugar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbxTrophy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrophy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(89, 198);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 32);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "IR AL MENÚ";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerVideo
            // 
            this.btnVerVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerVideo.BackColor = System.Drawing.Color.DarkRed;
            this.btnVerVideo.FlatAppearance.BorderSize = 0;
            this.btnVerVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVerVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVideo.ForeColor = System.Drawing.Color.White;
            this.btnVerVideo.Location = new System.Drawing.Point(175, 158);
            this.btnVerVideo.Name = "btnVerVideo";
            this.btnVerVideo.Size = new System.Drawing.Size(155, 32);
            this.btnVerVideo.TabIndex = 12;
            this.btnVerVideo.Text = "VER UN VIDEO";
            this.btnVerVideo.UseVisualStyleBackColor = false;
            this.btnVerVideo.Click += new System.EventHandler(this.btnVerVideo_Click);
            // 
            // btnVolverAJugar
            // 
            this.btnVolverAJugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverAJugar.BackColor = System.Drawing.Color.DarkRed;
            this.btnVolverAJugar.FlatAppearance.BorderSize = 0;
            this.btnVolverAJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVolverAJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAJugar.ForeColor = System.Drawing.Color.White;
            this.btnVolverAJugar.Location = new System.Drawing.Point(9, 158);
            this.btnVolverAJugar.Name = "btnVolverAJugar";
            this.btnVolverAJugar.Size = new System.Drawing.Size(155, 32);
            this.btnVolverAJugar.TabIndex = 11;
            this.btnVolverAJugar.Text = "VOLVER A JUGAR";
            this.btnVolverAJugar.UseVisualStyleBackColor = false;
            this.btnVolverAJugar.Click += new System.EventHandler(this.btnVolverAJugar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(10, 86);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(318, 52);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxTrophy
            // 
            this.pbxTrophy.BackColor = System.Drawing.Color.Transparent;
            this.pbxTrophy.Image = global::ADCN.Properties.Resources.game_over_gif;
            this.pbxTrophy.Location = new System.Drawing.Point(9, 10);
            this.pbxTrophy.Margin = new System.Windows.Forms.Padding(2);
            this.pbxTrophy.Name = "pbxTrophy";
            this.pbxTrophy.Size = new System.Drawing.Size(321, 79);
            this.pbxTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTrophy.TabIndex = 9;
            this.pbxTrophy.TabStop = false;
            // 
            // frmRendirse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADCN.Properties.Resources.fondo_rendirse3;
            this.ClientSize = new System.Drawing.Size(339, 240);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerVideo);
            this.Controls.Add(this.btnVolverAJugar);
            this.Controls.Add(this.pbxTrophy);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRendirse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRendirse";
            this.Load += new System.EventHandler(this.frmRendirse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrophy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnVerVideo;
        public System.Windows.Forms.Button btnVolverAJugar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbxTrophy;
    }
}