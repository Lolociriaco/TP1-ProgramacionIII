namespace TP1___Programacion_III
{
    partial class Ejercicio2
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
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.groupBoxFullName = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarEj2 = new System.Windows.Forms.Button();
            this.listBoxEj2 = new System.Windows.Forms.ListBox();
            this.groupBoxFullName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Black;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(18, 145);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(87, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Nombre:";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.BackColor = System.Drawing.Color.Black;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(18, 218);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(88, 25);
            this.surname.TabIndex = 2;
            this.surname.Text = "Apellido:";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textName.Location = new System.Drawing.Point(112, 143);
            this.textName.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(220, 26);
            this.textName.TabIndex = 3;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(112, 216);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(220, 26);
            this.textSurname.TabIndex = 4;
            this.textSurname.Tag = "";
            // 
            // groupBoxFullName
            // 
            this.groupBoxFullName.BackColor = System.Drawing.Color.Black;
            this.groupBoxFullName.Controls.Add(this.btnAgregarEj2);
            this.groupBoxFullName.Controls.Add(this.textSurname);
            this.groupBoxFullName.Controls.Add(this.name);
            this.groupBoxFullName.Controls.Add(this.textName);
            this.groupBoxFullName.Controls.Add(this.surname);
            this.groupBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFullName.ForeColor = System.Drawing.Color.White;
            this.groupBoxFullName.Location = new System.Drawing.Point(20, 25);
            this.groupBoxFullName.Name = "groupBoxFullName";
            this.groupBoxFullName.Size = new System.Drawing.Size(372, 389);
            this.groupBoxFullName.TabIndex = 5;
            this.groupBoxFullName.TabStop = false;
            this.groupBoxFullName.Text = "Ingreso de datos";
            this.groupBoxFullName.Enter += new System.EventHandler(this.groupBoxFullName_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.listBoxEj2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(408, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 389);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elementos";
            // 
            // btnAgregarEj2
            // 
            this.btnAgregarEj2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEj2.Location = new System.Drawing.Point(153, 288);
            this.btnAgregarEj2.Name = "btnAgregarEj2";
            this.btnAgregarEj2.Size = new System.Drawing.Size(131, 38);
            this.btnAgregarEj2.TabIndex = 5;
            this.btnAgregarEj2.Text = "Agregar";
            this.btnAgregarEj2.UseVisualStyleBackColor = false;
            this.btnAgregarEj2.Click += new System.EventHandler(this.btnAgregarEj2_Click);
            // 
            // listBoxEj2
            // 
            this.listBoxEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEj2.FormattingEnabled = true;
            this.listBoxEj2.ItemHeight = 20;
            this.listBoxEj2.Location = new System.Drawing.Point(37, 42);
            this.listBoxEj2.Name = "listBoxEj2";
            this.listBoxEj2.Size = new System.Drawing.Size(291, 284);
            this.listBoxEj2.TabIndex = 0;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFullName);
            this.Controls.Add(this.groupBox2);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio2_FormClosed);
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.groupBoxFullName.ResumeLayout(false);
            this.groupBoxFullName.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.GroupBox groupBoxFullName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarEj2;
        private System.Windows.Forms.ListBox listBoxEj2;
    }
}