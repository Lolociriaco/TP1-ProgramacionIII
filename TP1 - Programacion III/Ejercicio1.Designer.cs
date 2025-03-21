namespace TP1___Programacion_III
{
    partial class Ejercicio1
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
            this.lblEjercicio1 = new System.Windows.Forms.Label();
            this.txtEjercicio1 = new System.Windows.Forms.TextBox();
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.listEjercicio1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEjercicio1
            // 
            this.lblEjercicio1.AutoSize = true;
            this.lblEjercicio1.BackColor = System.Drawing.Color.DimGray;
            this.lblEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio1.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEjercicio1.Location = new System.Drawing.Point(40, 66);
            this.lblEjercicio1.Name = "lblEjercicio1";
            this.lblEjercicio1.Size = new System.Drawing.Size(169, 20);
            this.lblEjercicio1.TabIndex = 0;
            this.lblEjercicio1.Text = "Ingrese su nombre: ";
            // 
            // txtEjercicio1
            // 
            this.txtEjercicio1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicio1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEjercicio1.Location = new System.Drawing.Point(242, 64);
            this.txtEjercicio1.Name = "txtEjercicio1";
            this.txtEjercicio1.Size = new System.Drawing.Size(250, 24);
            this.txtEjercicio1.TabIndex = 1;
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.Location = new System.Drawing.Point(525, 61);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(107, 30);
            this.btnEjercicio1.TabIndex = 2;
            this.btnEjercicio1.Text = "Agregar";
            this.btnEjercicio1.UseVisualStyleBackColor = false;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // listEjercicio1
            // 
            this.listEjercicio1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEjercicio1.ForeColor = System.Drawing.SystemColors.Window;
            this.listEjercicio1.FormattingEnabled = true;
            this.listEjercicio1.ItemHeight = 18;
            this.listEjercicio1.Location = new System.Drawing.Point(245, 124);
            this.listEjercicio1.Name = "listEjercicio1";
            this.listEjercicio1.Size = new System.Drawing.Size(250, 130);
            this.listEjercicio1.TabIndex = 3;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listEjercicio1);
            this.Controls.Add(this.btnEjercicio1);
            this.Controls.Add(this.txtEjercicio1);
            this.Controls.Add(this.lblEjercicio1);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjercicio1;
        private System.Windows.Forms.TextBox txtEjercicio1;
        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.ListBox listEjercicio1;
    }
}