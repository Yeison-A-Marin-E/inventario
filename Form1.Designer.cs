namespace inventario
{
    partial class INICIO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.USUARIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.INGRESAR = new System.Windows.Forms.Button();
            this.SALIR = new System.Windows.Forms.Button();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // USUARIO
            // 
            this.USUARIO.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.USUARIO.Location = new System.Drawing.Point(289, 140);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(223, 34);
            this.USUARIO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            // 
            // INGRESAR
            // 
            this.INGRESAR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INGRESAR.Location = new System.Drawing.Point(289, 290);
            this.INGRESAR.Name = "INGRESAR";
            this.INGRESAR.Size = new System.Drawing.Size(102, 36);
            this.INGRESAR.TabIndex = 2;
            this.INGRESAR.Text = "INGRESAR";
            this.INGRESAR.UseVisualStyleBackColor = true;
            // 
            // SALIR
            // 
            this.SALIR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SALIR.Location = new System.Drawing.Point(423, 290);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(102, 36);
            this.SALIR.TabIndex = 3;
            this.SALIR.Text = "SALIR";
            this.SALIR.UseVisualStyleBackColor = true;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LABEL2.Location = new System.Drawing.Point(322, 178);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(162, 27);
            this.LABEL2.TabIndex = 4;
            this.LABEL2.Text = "CONTRASEÑA";
            // 
            // CONTRASEÑA
            // 
            this.CONTRASEÑA.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CONTRASEÑA.Location = new System.Drawing.Point(289, 208);
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            this.CONTRASEÑA.Size = new System.Drawing.Size(223, 34);
            this.CONTRASEÑA.TabIndex = 5;
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CONTRASEÑA);
            this.Controls.Add(this.LABEL2);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.INGRESAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USUARIO);
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox USUARIO;
        private Label label1;
        private Button INGRESAR;
        private Button SALIR;
        private Label LABEL2;
        private TextBox CONTRASEÑA;
    }
}