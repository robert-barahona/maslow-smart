namespace ADCN
{
    partial class frmJuegoAtencion3
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
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnRendirse = new System.Windows.Forms.Button();
            this.btnPista = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.gbxSignificado = new System.Windows.Forms.GroupBox();
            this.lblSignificado = new System.Windows.Forms.Label();
            this.gbxColor = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxCheck = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gbxSignificado.SuspendLayout();
            this.gbxColor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(977, 49);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(84, 20);
            this.lblTiempo.TabIndex = 53;
            this.lblTiempo.Text = "00:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(977, 19);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(84, 20);
            this.lblTime.TabIndex = 52;
            this.lblTime.Text = "Tiempo:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRendirse
            // 
            this.btnRendirse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRendirse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRendirse.FlatAppearance.BorderSize = 0;
            this.btnRendirse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRendirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRendirse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendirse.ForeColor = System.Drawing.Color.White;
            this.btnRendirse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRendirse.Location = new System.Drawing.Point(977, 416);
            this.btnRendirse.Name = "btnRendirse";
            this.btnRendirse.Size = new System.Drawing.Size(84, 40);
            this.btnRendirse.TabIndex = 51;
            this.btnRendirse.Text = "Rendirse";
            this.btnRendirse.UseVisualStyleBackColor = false;
            this.btnRendirse.Click += new System.EventHandler(this.btnRendirse_Click);
            // 
            // btnPista
            // 
            this.btnPista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPista.FlatAppearance.BorderSize = 0;
            this.btnPista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnPista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPista.ForeColor = System.Drawing.Color.White;
            this.btnPista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPista.Location = new System.Drawing.Point(11, 416);
            this.btnPista.Name = "btnPista";
            this.btnPista.Size = new System.Drawing.Size(84, 40);
            this.btnPista.TabIndex = 50;
            this.btnPista.Text = "Comodín";
            this.btnPista.UseVisualStyleBackColor = false;
            this.btnPista.Click += new System.EventHandler(this.btnPista_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(10, 19);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(57, 20);
            this.lblNivel.TabIndex = 49;
            this.lblNivel.Text = "label1";
            // 
            // gbxSignificado
            // 
            this.gbxSignificado.Controls.Add(this.lblSignificado);
            this.gbxSignificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSignificado.Location = new System.Drawing.Point(362, 82);
            this.gbxSignificado.Name = "gbxSignificado";
            this.gbxSignificado.Size = new System.Drawing.Size(349, 111);
            this.gbxSignificado.TabIndex = 54;
            this.gbxSignificado.TabStop = false;
            this.gbxSignificado.Text = "Significado";
            // 
            // lblSignificado
            // 
            this.lblSignificado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSignificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignificado.Location = new System.Drawing.Point(3, 27);
            this.lblSignificado.Name = "lblSignificado";
            this.lblSignificado.Size = new System.Drawing.Size(343, 81);
            this.lblSignificado.TabIndex = 0;
            this.lblSignificado.Text = "label1";
            this.lblSignificado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxColor
            // 
            this.gbxColor.Controls.Add(this.lblColor);
            this.gbxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxColor.Location = new System.Drawing.Point(362, 226);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(349, 111);
            this.gbxColor.TabIndex = 55;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "Texto";
            // 
            // lblColor
            // 
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(3, 27);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(343, 81);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "label1";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSi, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(362, 387);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 62);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Crimson;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(177, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(169, 56);
            this.btnNo.TabIndex = 53;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.White;
            this.btnSi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSi.Location = new System.Drawing.Point(3, 3);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(168, 56);
            this.btnSi.TabIndex = 52;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(223, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(627, 20);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "¿Coincide el significado de arriba con el color de abajo?";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxCheck
            // 
            this.pbxCheck.Image = global::ADCN.Properties.Resources.lista;
            this.pbxCheck.Location = new System.Drawing.Point(481, 182);
            this.pbxCheck.Name = "pbxCheck";
            this.pbxCheck.Size = new System.Drawing.Size(111, 68);
            this.pbxCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCheck.TabIndex = 76;
            this.pbxCheck.TabStop = false;
            this.pbxCheck.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmJuegoAtencion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 474);
            this.Controls.Add(this.pbxCheck);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbxColor);
            this.Controls.Add(this.gbxSignificado);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnRendirse);
            this.Controls.Add(this.btnPista);
            this.Controls.Add(this.lblNivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuegoAtencion3";
            this.Text = "frmJuegoAtencion3";
            this.Load += new System.EventHandler(this.frmJuegoAtencion3_Load);
            this.gbxSignificado.ResumeLayout(false);
            this.gbxColor.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRendirse;
        private System.Windows.Forms.Button btnPista;
        public System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.GroupBox gbxSignificado;
        private System.Windows.Forms.GroupBox gbxColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSi;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblSignificado;
        public System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.PictureBox pbxCheck;
        private System.Windows.Forms.Timer timer2;
    }
}