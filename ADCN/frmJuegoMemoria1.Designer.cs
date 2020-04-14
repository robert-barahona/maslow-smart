namespace ADCN
{
    partial class frmJuegoMemoria1
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
            this.lblNivel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRespuesta4 = new System.Windows.Forms.Button();
            this.btnRespuesta3 = new System.Windows.Forms.Button();
            this.btnRespuesta2 = new System.Windows.Forms.Button();
            this.btnRespuesta1 = new System.Windows.Forms.Button();
            this.pnlOperacion = new System.Windows.Forms.Panel();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxCheck = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlOperacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(978, 49);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(80, 20);
            this.lblTiempo.TabIndex = 58;
            this.lblTiempo.Text = "00:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(974, 19);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(84, 20);
            this.lblTime.TabIndex = 57;
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
            this.btnRendirse.Location = new System.Drawing.Point(974, 422);
            this.btnRendirse.Name = "btnRendirse";
            this.btnRendirse.Size = new System.Drawing.Size(84, 40);
            this.btnRendirse.TabIndex = 56;
            this.btnRendirse.Text = "Rendirse";
            this.btnRendirse.UseVisualStyleBackColor = false;
            this.btnRendirse.Click += new System.EventHandler(this.btnRendirse_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(10, 19);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(57, 20);
            this.lblNivel.TabIndex = 54;
            this.lblNivel.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnRespuesta4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRespuesta3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRespuesta2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRespuesta1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(376, 275);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 72);
            this.tableLayoutPanel1.TabIndex = 61;
            // 
            // btnRespuesta4
            // 
            this.btnRespuesta4.BackColor = System.Drawing.Color.White;
            this.btnRespuesta4.FlatAppearance.BorderSize = 0;
            this.btnRespuesta4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRespuesta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta4.Location = new System.Drawing.Point(240, 3);
            this.btnRespuesta4.Name = "btnRespuesta4";
            this.btnRespuesta4.Size = new System.Drawing.Size(73, 66);
            this.btnRespuesta4.TabIndex = 3;
            this.btnRespuesta4.Text = "0";
            this.btnRespuesta4.UseVisualStyleBackColor = false;
            this.btnRespuesta4.Click += new System.EventHandler(this.btnRespuesta4_Click);
            // 
            // btnRespuesta3
            // 
            this.btnRespuesta3.BackColor = System.Drawing.Color.White;
            this.btnRespuesta3.FlatAppearance.BorderSize = 0;
            this.btnRespuesta3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRespuesta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta3.Location = new System.Drawing.Point(161, 3);
            this.btnRespuesta3.Name = "btnRespuesta3";
            this.btnRespuesta3.Size = new System.Drawing.Size(73, 66);
            this.btnRespuesta3.TabIndex = 2;
            this.btnRespuesta3.Text = "0";
            this.btnRespuesta3.UseVisualStyleBackColor = false;
            this.btnRespuesta3.Click += new System.EventHandler(this.btnRespuesta3_Click);
            // 
            // btnRespuesta2
            // 
            this.btnRespuesta2.BackColor = System.Drawing.Color.White;
            this.btnRespuesta2.FlatAppearance.BorderSize = 0;
            this.btnRespuesta2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRespuesta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta2.Location = new System.Drawing.Point(82, 3);
            this.btnRespuesta2.Name = "btnRespuesta2";
            this.btnRespuesta2.Size = new System.Drawing.Size(73, 66);
            this.btnRespuesta2.TabIndex = 1;
            this.btnRespuesta2.Text = "0";
            this.btnRespuesta2.UseVisualStyleBackColor = false;
            this.btnRespuesta2.Click += new System.EventHandler(this.btnRespuesta2_Click);
            // 
            // btnRespuesta1
            // 
            this.btnRespuesta1.BackColor = System.Drawing.Color.White;
            this.btnRespuesta1.FlatAppearance.BorderSize = 0;
            this.btnRespuesta1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRespuesta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta1.Location = new System.Drawing.Point(3, 3);
            this.btnRespuesta1.Name = "btnRespuesta1";
            this.btnRespuesta1.Size = new System.Drawing.Size(73, 66);
            this.btnRespuesta1.TabIndex = 0;
            this.btnRespuesta1.Text = "0";
            this.btnRespuesta1.UseVisualStyleBackColor = false;
            this.btnRespuesta1.Click += new System.EventHandler(this.btnRespuesta1_Click);
            // 
            // pnlOperacion
            // 
            this.pnlOperacion.BackColor = System.Drawing.Color.Silver;
            this.pnlOperacion.Controls.Add(this.lblOperacion);
            this.pnlOperacion.Location = new System.Drawing.Point(376, 119);
            this.pnlOperacion.Name = "pnlOperacion";
            this.pnlOperacion.Size = new System.Drawing.Size(318, 150);
            this.pnlOperacion.TabIndex = 60;
            // 
            // lblOperacion
            // 
            this.lblOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(0, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(318, 150);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "0x0";
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(346, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(378, 34);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "¿Cual es la respuesta correcta?";
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
            this.pbxCheck.Location = new System.Drawing.Point(458, 353);
            this.pbxCheck.Name = "pbxCheck";
            this.pbxCheck.Size = new System.Drawing.Size(152, 41);
            this.pbxCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCheck.TabIndex = 63;
            this.pbxCheck.TabStop = false;
            this.pbxCheck.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(14, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 40);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmJuegoMemoria1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 474);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbxCheck);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlOperacion);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnRendirse);
            this.Controls.Add(this.lblNivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuegoMemoria1";
            this.Text = "frmJuegoMemoria1";
            this.Load += new System.EventHandler(this.frmJuegoMemoria1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlOperacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRendirse;
        public System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlOperacion;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblOperacion;
        public System.Windows.Forms.Button btnRespuesta4;
        public System.Windows.Forms.Button btnRespuesta3;
        public System.Windows.Forms.Button btnRespuesta2;
        public System.Windows.Forms.Button btnRespuesta1;
        private System.Windows.Forms.PictureBox pbxCheck;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSalir;
    }
}