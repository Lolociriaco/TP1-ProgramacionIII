namespace TP1___Programacion_III
{
    partial class Ejercicio3
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
            this.checkBoxCasado = new System.Windows.Forms.CheckBox();
            this.groupBoxsexo = new System.Windows.Forms.GroupBox();
            this.checkBoxmujer = new System.Windows.Forms.CheckBox();
            this.checkBoxMasculino = new System.Windows.Forms.CheckBox();
            this.checkBoxsoltero = new System.Windows.Forms.CheckBox();
            this.groupBoxEstCivil = new System.Windows.Forms.GroupBox();
            this.checkedRoles = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarSeleccion = new System.Windows.Forms.Button();
            this.groupBoxsexo.SuspendLayout();
            this.groupBoxEstCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxCasado
            // 
            this.checkBoxCasado.AutoSize = true;
            this.checkBoxCasado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxCasado.Location = new System.Drawing.Point(13, 27);
            this.checkBoxCasado.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxCasado.Name = "checkBoxCasado";
            this.checkBoxCasado.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCasado.TabIndex = 3;
            this.checkBoxCasado.Text = "Casado";
            this.checkBoxCasado.UseVisualStyleBackColor = false;
            this.checkBoxCasado.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBoxsexo
            // 
            this.groupBoxsexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxsexo.Controls.Add(this.checkBoxmujer);
            this.groupBoxsexo.Controls.Add(this.checkBoxMasculino);
            this.groupBoxsexo.Location = new System.Drawing.Point(67, 53);
            this.groupBoxsexo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBoxsexo.Name = "groupBoxsexo";
            this.groupBoxsexo.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBoxsexo.Size = new System.Drawing.Size(211, 92);
            this.groupBoxsexo.TabIndex = 5;
            this.groupBoxsexo.TabStop = false;
            this.groupBoxsexo.Text = "Sexo";
            this.groupBoxsexo.Enter += new System.EventHandler(this.groupBoxsexo_Enter);
            // 
            // checkBoxmujer
            // 
            this.checkBoxmujer.AutoSize = true;
            this.checkBoxmujer.BackColor = System.Drawing.Color.White;
            this.checkBoxmujer.Location = new System.Drawing.Point(11, 27);
            this.checkBoxmujer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxmujer.Name = "checkBoxmujer";
            this.checkBoxmujer.Size = new System.Drawing.Size(72, 17);
            this.checkBoxmujer.TabIndex = 1;
            this.checkBoxmujer.Text = "Femenino";
            this.checkBoxmujer.UseVisualStyleBackColor = false;
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.AutoSize = true;
            this.checkBoxMasculino.BackColor = System.Drawing.Color.White;
            this.checkBoxMasculino.Location = new System.Drawing.Point(11, 60);
            this.checkBoxMasculino.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxMasculino.Name = "checkBoxMasculino";
            this.checkBoxMasculino.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMasculino.TabIndex = 0;
            this.checkBoxMasculino.Text = "Masculino";
            this.checkBoxMasculino.UseVisualStyleBackColor = false;
            this.checkBoxMasculino.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxsoltero
            // 
            this.checkBoxsoltero.AutoSize = true;
            this.checkBoxsoltero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxsoltero.Location = new System.Drawing.Point(13, 53);
            this.checkBoxsoltero.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxsoltero.Name = "checkBoxsoltero";
            this.checkBoxsoltero.Size = new System.Drawing.Size(59, 17);
            this.checkBoxsoltero.TabIndex = 2;
            this.checkBoxsoltero.Text = "Soltero";
            this.checkBoxsoltero.UseVisualStyleBackColor = false;
            this.checkBoxsoltero.CheckedChanged += new System.EventHandler(this.checkBoxsoltero_CheckedChanged);
            // 
            // groupBoxEstCivil
            // 
            this.groupBoxEstCivil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEstCivil.Controls.Add(this.checkBoxsoltero);
            this.groupBoxEstCivil.Controls.Add(this.checkBoxCasado);
            this.groupBoxEstCivil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxEstCivil.Location = new System.Drawing.Point(497, 53);
            this.groupBoxEstCivil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBoxEstCivil.Name = "groupBoxEstCivil";
            this.groupBoxEstCivil.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBoxEstCivil.Size = new System.Drawing.Size(223, 92);
            this.groupBoxEstCivil.TabIndex = 6;
            this.groupBoxEstCivil.TabStop = false;
            this.groupBoxEstCivil.Text = "Estado civil";
            this.groupBoxEstCivil.Enter += new System.EventHandler(this.groupBoxEstCivil_Enter);
            // 
            // checkedRoles
            // 
            this.checkedRoles.FormattingEnabled = true;
            this.checkedRoles.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.checkedRoles.Location = new System.Drawing.Point(306, 172);
            this.checkedRoles.Name = "checkedRoles";
            this.checkedRoles.Size = new System.Drawing.Size(160, 79);
            this.checkedRoles.TabIndex = 7;
            // 
            // btnMostrarSeleccion
            // 
            this.btnMostrarSeleccion.BackColor = System.Drawing.Color.DimGray;
            this.btnMostrarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSeleccion.Location = new System.Drawing.Point(271, 282);
            this.btnMostrarSeleccion.Name = "btnMostrarSeleccion";
            this.btnMostrarSeleccion.Size = new System.Drawing.Size(228, 23);
            this.btnMostrarSeleccion.TabIndex = 8;
            this.btnMostrarSeleccion.Text = "Mostrar lo que se seleccionó";
            this.btnMostrarSeleccion.UseVisualStyleBackColor = false;
            this.btnMostrarSeleccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarSeleccion);
            this.Controls.Add(this.checkedRoles);
            this.Controls.Add(this.groupBoxEstCivil);
            this.Controls.Add(this.groupBoxsexo);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.groupBoxsexo.ResumeLayout(false);
            this.groupBoxsexo.PerformLayout();
            this.groupBoxEstCivil.ResumeLayout(false);
            this.groupBoxEstCivil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxCasado;
        private System.Windows.Forms.GroupBox groupBoxsexo;
        private System.Windows.Forms.CheckBox checkBoxmujer;
        private System.Windows.Forms.CheckBox checkBoxMasculino;
        private System.Windows.Forms.CheckBox checkBoxsoltero;
        private System.Windows.Forms.GroupBox groupBoxEstCivil;
        private System.Windows.Forms.CheckedListBox checkedRoles;
        private System.Windows.Forms.Button btnMostrarSeleccion;
    }
}