namespace ADCN
{
    partial class frmJuegoMemoria3
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnRendirse = new System.Windows.Forms.Button();
            this.btnPista = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblFrase = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIngresarFrase = new System.Windows.Forms.TextBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.pnlFrases = new System.Windows.Forms.Panel();
            this.pbxCheck = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlFrases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(222, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(645, 35);
            this.lblTitulo.TabIndex = 68;
            this.lblTitulo.Text = "Memoriza la frase y haz click en Siguiente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(977, 49);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(84, 20);
            this.lblTiempo.TabIndex = 67;
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
            this.lblTime.TabIndex = 66;
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
            this.btnRendirse.TabIndex = 65;
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
            this.btnPista.TabIndex = 64;
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
            this.lblNivel.TabIndex = 63;
            this.lblNivel.Text = "label1";
            // 
            // lblFrase
            // 
            this.lblFrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(0, 0);
            this.lblFrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(379, 100);
            this.lblFrase.TabIndex = 69;
            this.lblFrase.Text = "lblFrase";
            this.lblFrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(468, 284);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(150, 40);
            this.btnSiguiente.TabIndex = 70;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIngresarFrase);
            this.panel1.Controls.Add(this.lblFrase);
            this.panel1.Location = new System.Drawing.Point(56, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 100);
            this.panel1.TabIndex = 72;
            // 
            // txtIngresarFrase
            // 
            this.txtIngresarFrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngresarFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarFrase.Location = new System.Drawing.Point(0, 0);
            this.txtIngresarFrase.Multiline = true;
            this.txtIngresarFrase.Name = "txtIngresarFrase";
            this.txtIngresarFrase.Size = new System.Drawing.Size(379, 100);
            this.txtIngresarFrase.TabIndex = 71;
            this.txtIngresarFrase.Visible = false;
            this.txtIngresarFrase.Click += new System.EventHandler(this.borrarPortapapeles);
            this.txtIngresarFrase.VisibleChanged += new System.EventHandler(this.borrarPortapapeles);
            // 
            // btnComprobar
            // 
            this.btnComprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprobar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnComprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobar.FlatAppearance.BorderSize = 0;
            this.btnComprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.ForeColor = System.Drawing.Color.White;
            this.btnComprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobar.Location = new System.Drawing.Point(468, 284);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(150, 40);
            this.btnComprobar.TabIndex = 73;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Visible = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // pnlFrases
            // 
            this.pnlFrases.BackColor = System.Drawing.Color.White;
            this.pnlFrases.Controls.Add(this.panel1);
            this.pnlFrases.Location = new System.Drawing.Point(297, 129);
            this.pnlFrases.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFrases.Name = "pnlFrases";
            this.pnlFrases.Size = new System.Drawing.Size(500, 223);
            this.pnlFrases.TabIndex = 74;
            // 
            // pbxCheck
            // 
            this.pbxCheck.Image = global::ADCN.Properties.Resources.lista;
            this.pbxCheck.Location = new System.Drawing.Point(468, 357);
            this.pbxCheck.Name = "pbxCheck";
            this.pbxCheck.Size = new System.Drawing.Size(150, 41);
            this.pbxCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCheck.TabIndex = 75;
            this.pbxCheck.TabStop = false;
            this.pbxCheck.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmJuegoMemoria3
            // 
            this.AcceptButton = this.btnSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 474);
            this.Controls.Add(this.pbxCheck);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnRendirse);
            this.Controls.Add(this.btnPista);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.pnlFrases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuegoMemoria3";
            this.Text = "frmJuegoMemoria2";
            this.Load += new System.EventHandler(this.frmJuegoMemoria2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFrases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRendirse;
        private System.Windows.Forms.Button btnPista;
        public System.Windows.Forms.Label lblNivel;
        public System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnComprobar;
        public System.Windows.Forms.TextBox txtIngresarFrase;
        private System.Windows.Forms.Panel pnlFrases;
        private System.Windows.Forms.PictureBox pbxCheck;
        private System.Windows.Forms.Timer timer2;
    }
}