namespace EstructurasDinamicas.Formularios
{
    partial class FrmPila
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lblPila = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnMostrarU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(273, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(122, 29);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 2;
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPila.Location = new System.Drawing.Point(31, 111);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(78, 20);
            this.lblPila.TabIndex = 3;
            this.lblPila.Text = "Pila vacio:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuitar.Location = new System.Drawing.Point(365, 29);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 33);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnMostrarU
            // 
            this.btnMostrarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMostrarU.Location = new System.Drawing.Point(457, 26);
            this.btnMostrarU.Name = "btnMostrarU";
            this.btnMostrarU.Size = new System.Drawing.Size(75, 52);
            this.btnMostrarU.TabIndex = 5;
            this.btnMostrarU.Text = "Mostrar ultimo";
            this.btnMostrarU.UseVisualStyleBackColor = true;
            this.btnMostrarU.Click += new System.EventHandler(this.btnMostrarU_Click);
            // 
            // FrmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarU);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnMostrarU;
    }
}