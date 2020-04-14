namespace ADCN
{
    partial class frmConfiguracion
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
            this.gbxTema = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbxRosa = new System.Windows.Forms.PictureBox();
            this.pbxVerde = new System.Windows.Forms.PictureBox();
            this.pbxAzul = new System.Windows.Forms.PictureBox();
            this.pbxNaranja = new System.Windows.Forms.PictureBox();
            this.gbxSonido = new System.Windows.Forms.GroupBox();
            this.pbxDesactivarSonido = new System.Windows.Forms.PictureBox();
            this.pbxActivarSonido = new System.Windows.Forms.PictureBox();
            this.gbxTema.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNaranja)).BeginInit();
            this.gbxSonido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDesactivarSonido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxActivarSonido)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTema
            // 
            this.gbxTema.Controls.Add(this.tableLayoutPanel1);
            this.gbxTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTema.Location = new System.Drawing.Point(52, 39);
            this.gbxTema.Name = "gbxTema";
            this.gbxTema.Size = new System.Drawing.Size(640, 386);
            this.gbxTema.TabIndex = 28;
            this.gbxTema.TabStop = false;
            this.gbxTema.Text = "Tema";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbxRosa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbxVerde, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbxAzul, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbxNaranja, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 333);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbxRosa
            // 
            this.pbxRosa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxRosa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRosa.Image = global::ADCN.Properties.Resources.theme_rosa1;
            this.pbxRosa.Location = new System.Drawing.Point(312, 169);
            this.pbxRosa.Name = "pbxRosa";
            this.pbxRosa.Size = new System.Drawing.Size(288, 154);
            this.pbxRosa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRosa.TabIndex = 3;
            this.pbxRosa.TabStop = false;
            this.pbxRosa.Click += new System.EventHandler(this.cambiarColores);
            this.pbxRosa.MouseEnter += new System.EventHandler(this.agrandarPbx);
            this.pbxRosa.MouseLeave += new System.EventHandler(this.minimizarPbx);
            // 
            // pbxVerde
            // 
            this.pbxVerde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxVerde.Image = global::ADCN.Properties.Resources.theme_verde1;
            this.pbxVerde.Location = new System.Drawing.Point(8, 169);
            this.pbxVerde.Name = "pbxVerde";
            this.pbxVerde.Size = new System.Drawing.Size(288, 154);
            this.pbxVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVerde.TabIndex = 2;
            this.pbxVerde.TabStop = false;
            this.pbxVerde.Click += new System.EventHandler(this.cambiarColores);
            this.pbxVerde.MouseEnter += new System.EventHandler(this.agrandarPbx);
            this.pbxVerde.MouseLeave += new System.EventHandler(this.minimizarPbx);
            // 
            // pbxAzul
            // 
            this.pbxAzul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAzul.Image = global::ADCN.Properties.Resources.theme_azul1;
            this.pbxAzul.Location = new System.Drawing.Point(312, 3);
            this.pbxAzul.Name = "pbxAzul";
            this.pbxAzul.Size = new System.Drawing.Size(288, 153);
            this.pbxAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAzul.TabIndex = 1;
            this.pbxAzul.TabStop = false;
            this.pbxAzul.Click += new System.EventHandler(this.cambiarColores);
            this.pbxAzul.MouseEnter += new System.EventHandler(this.agrandarPbx);
            this.pbxAzul.MouseLeave += new System.EventHandler(this.minimizarPbx);
            // 
            // pbxNaranja
            // 
            this.pbxNaranja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxNaranja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxNaranja.Image = global::ADCN.Properties.Resources.theme_naranja1;
            this.pbxNaranja.Location = new System.Drawing.Point(8, 3);
            this.pbxNaranja.Name = "pbxNaranja";
            this.pbxNaranja.Size = new System.Drawing.Size(288, 153);
            this.pbxNaranja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNaranja.TabIndex = 0;
            this.pbxNaranja.TabStop = false;
            this.pbxNaranja.Click += new System.EventHandler(this.cambiarColores);
            this.pbxNaranja.MouseEnter += new System.EventHandler(this.agrandarPbx);
            this.pbxNaranja.MouseLeave += new System.EventHandler(this.minimizarPbx);
            // 
            // gbxSonido
            // 
            this.gbxSonido.Controls.Add(this.pbxDesactivarSonido);
            this.gbxSonido.Controls.Add(this.pbxActivarSonido);
            this.gbxSonido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSonido.Location = new System.Drawing.Point(768, 39);
            this.gbxSonido.Name = "gbxSonido";
            this.gbxSonido.Size = new System.Drawing.Size(246, 386);
            this.gbxSonido.TabIndex = 29;
            this.gbxSonido.TabStop = false;
            this.gbxSonido.Text = "Sonido";
            // 
            // pbxDesactivarSonido
            // 
            this.pbxDesactivarSonido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDesactivarSonido.Image = global::ADCN.Properties.Resources.sound_off_disable;
            this.pbxDesactivarSonido.Location = new System.Drawing.Point(30, 237);
            this.pbxDesactivarSonido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxDesactivarSonido.Name = "pbxDesactivarSonido";
            this.pbxDesactivarSonido.Size = new System.Drawing.Size(191, 103);
            this.pbxDesactivarSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDesactivarSonido.TabIndex = 29;
            this.pbxDesactivarSonido.TabStop = false;
            this.pbxDesactivarSonido.Click += new System.EventHandler(this.pbxDesactivarSonido_Click);
            this.pbxDesactivarSonido.MouseEnter += new System.EventHandler(this.pbxDesactivarSonido_MouseEnter);
            this.pbxDesactivarSonido.MouseLeave += new System.EventHandler(this.pbxDesactivarSonido_MouseLeave);
            // 
            // pbxActivarSonido
            // 
            this.pbxActivarSonido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxActivarSonido.Image = global::ADCN.Properties.Resources.sound_on;
            this.pbxActivarSonido.Location = new System.Drawing.Point(30, 57);
            this.pbxActivarSonido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxActivarSonido.Name = "pbxActivarSonido";
            this.pbxActivarSonido.Size = new System.Drawing.Size(191, 103);
            this.pbxActivarSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxActivarSonido.TabIndex = 28;
            this.pbxActivarSonido.TabStop = false;
            this.pbxActivarSonido.Click += new System.EventHandler(this.pbxActivarSonido_Click);
            this.pbxActivarSonido.MouseEnter += new System.EventHandler(this.pbxActivarSonido_MouseEnter);
            this.pbxActivarSonido.MouseLeave += new System.EventHandler(this.pbxActivarSonido_MouseLeave);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 474);
            this.Controls.Add(this.gbxSonido);
            this.Controls.Add(this.gbxTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.gbxTema.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNaranja)).EndInit();
            this.gbxSonido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDesactivarSonido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxActivarSonido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxTema;
        private System.Windows.Forms.GroupBox gbxSonido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbxRosa;
        private System.Windows.Forms.PictureBox pbxVerde;
        private System.Windows.Forms.PictureBox pbxAzul;
        private System.Windows.Forms.PictureBox pbxNaranja;
        private System.Windows.Forms.PictureBox pbxActivarSonido;
        private System.Windows.Forms.PictureBox pbxDesactivarSonido;
    }
}