namespace ProyectoParqueadero
{
    partial class RegistroForm
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
            this.nombreUsuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseniaTxt = new System.Windows.Forms.TextBox();
            this.registrobtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoUsuarioTxt = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "contraseña:";
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(423, 74);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(121, 22);
            this.nombreUsuarioTxt.TabIndex = 2;
            // 
            // contraseniaTxt
            // 
            this.contraseniaTxt.Location = new System.Drawing.Point(423, 130);
            this.contraseniaTxt.Name = "contraseniaTxt";
            this.contraseniaTxt.Size = new System.Drawing.Size(121, 22);
            this.contraseniaTxt.TabIndex = 3;
            // 
            // registrobtn
            // 
            this.registrobtn.Location = new System.Drawing.Point(293, 275);
            this.registrobtn.Name = "registrobtn";
            this.registrobtn.Size = new System.Drawing.Size(162, 23);
            this.registrobtn.TabIndex = 4;
            this.registrobtn.Text = "REGISTRAR";
            this.registrobtn.UseVisualStyleBackColor = true;
            this.registrobtn.Click += new System.EventHandler(this.registrobtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo usuario:";
            // 
            // tipoUsuarioTxt
            // 
            this.tipoUsuarioTxt.FormattingEnabled = true;
            this.tipoUsuarioTxt.Items.AddRange(new object[] {
            "Usuario usual",
            "Usuario ocasional"});
            this.tipoUsuarioTxt.Location = new System.Drawing.Point(423, 187);
            this.tipoUsuarioTxt.Name = "tipoUsuarioTxt";
            this.tipoUsuarioTxt.Size = new System.Drawing.Size(121, 24);
            this.tipoUsuarioTxt.TabIndex = 7;
            this.tipoUsuarioTxt.Text = "Usuario usual";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(362, 238);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 8;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tipoUsuarioTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registrobtn);
            this.Controls.Add(this.contraseniaTxt);
            this.Controls.Add(this.nombreUsuarioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroForm";
            this.Text = "RegistroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreUsuarioTxt;
        private System.Windows.Forms.TextBox contraseniaTxt;
        private System.Windows.Forms.Button registrobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoUsuarioTxt;
        private System.Windows.Forms.Label labelError;
    }
}