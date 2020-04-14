namespace ADCN
{
    partial class frmInicio
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
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.gbxObjetivo = new System.Windows.Forms.GroupBox();
            this.gbxInstrucciones = new System.Windows.Forms.GroupBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.gbxObjetivo.SuspendLayout();
            this.gbxInstrucciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivo.Location = new System.Drawing.Point(35, 46);
            this.lblObjetivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(581, 58);
            this.lblObjetivo.TabIndex = 2;
            this.lblObjetivo.Text = "label1";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpezar.FlatAppearance.BorderSize = 0;
            this.btnEmpezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.White;
            this.btnEmpezar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpezar.Location = new System.Drawing.Point(434, 394);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(198, 40);
            this.btnEmpezar.TabIndex = 33;
            this.btnEmpezar.Text = "EMPEZAR";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // gbxObjetivo
            // 
            this.gbxObjetivo.Controls.Add(this.lblObjetivo);
            this.gbxObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxObjetivo.Location = new System.Drawing.Point(208, 37);
            this.gbxObjetivo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxObjetivo.Name = "gbxObjetivo";
            this.gbxObjetivo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxObjetivo.Size = new System.Drawing.Size(649, 128);
            this.gbxObjetivo.TabIndex = 34;
            this.gbxObjetivo.TabStop = false;
            this.gbxObjetivo.Text = "Objetivo";
            // 
            // gbxInstrucciones
            // 
            this.gbxInstrucciones.Controls.Add(this.lblInstrucciones);
            this.gbxInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInstrucciones.Location = new System.Drawing.Point(208, 188);
            this.gbxInstrucciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInstrucciones.Name = "gbxInstrucciones";
            this.gbxInstrucciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInstrucciones.Size = new System.Drawing.Size(649, 180);
            this.gbxInstrucciones.TabIndex = 35;
            this.gbxInstrucciones.TabStop = false;
            this.gbxInstrucciones.Text = "Instrucciones";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(35, 24);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(581, 139);
            this.lblInstrucciones.TabIndex = 2;
            this.lblInstrucciones.Text = "label1";
            this.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 474);
            this.Controls.Add(this.gbxInstrucciones);
            this.Controls.Add(this.gbxObjetivo);
            this.Controls.Add(this.btnEmpezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.gbxObjetivo.ResumeLayout(false);
            this.gbxInstrucciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.GroupBox gbxObjetivo;
        private System.Windows.Forms.GroupBox gbxInstrucciones;
        public System.Windows.Forms.Label lblObjetivo;
        public System.Windows.Forms.Label lblInstrucciones;
    }
}