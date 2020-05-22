namespace ConsoleApp9.Formulario
{
    partial class EditarSala
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdAsiento = new System.Windows.Forms.TextBox();
            this.btnOcupar = new System.Windows.Forms.Button();
            this.liberar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(43, 100);
            this.txtAsientos.Multiline = true;
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(593, 323);
            this.txtAsientos.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtIdAsiento
            // 
            this.txtIdAsiento.Location = new System.Drawing.Point(354, 30);
            this.txtIdAsiento.Name = "txtIdAsiento";
            this.txtIdAsiento.Size = new System.Drawing.Size(100, 23);
            this.txtIdAsiento.TabIndex = 5;
            this.txtIdAsiento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOcupar
            // 
            this.btnOcupar.Location = new System.Drawing.Point(475, 30);
            this.btnOcupar.Name = "btnOcupar";
            this.btnOcupar.Size = new System.Drawing.Size(75, 23);
            this.btnOcupar.TabIndex = 6;
            this.btnOcupar.Text = "ocupar";
            this.btnOcupar.UseVisualStyleBackColor = true;
            this.btnOcupar.Click += new System.EventHandler(this.btnOcupar_Click);
            // 
            // liberar
            // 
            this.liberar.Location = new System.Drawing.Point(561, 30);
            this.liberar.Name = "liberar";
            this.liberar.Size = new System.Drawing.Size(75, 23);
            this.liberar.TabIndex = 7;
            this.liberar.Text = "liberar";
            this.liberar.UseVisualStyleBackColor = true;
            this.liberar.Click += new System.EventHandler(this.liberar_Click);
            // 
            // EditarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.liberar);
            this.Controls.Add(this.btnOcupar);
            this.Controls.Add(this.txtIdAsiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAsientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarSala";
            this.Text = "EditarSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdAsiento;
        private System.Windows.Forms.Button btnOcupar;
        private System.Windows.Forms.Button liberar;
    }
}