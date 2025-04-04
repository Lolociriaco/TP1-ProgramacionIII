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
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.femenino = new System.Windows.Forms.RadioButton();
            this.groupBoxEstCivil = new System.Windows.Forms.GroupBox();
            this.casado = new System.Windows.Forms.RadioButton();
            this.soltero = new System.Windows.Forms.RadioButton();
            this.checkedRoles = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarSeleccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMostrarSeleccionado = new System.Windows.Forms.Label();
            this.mostrarSexo = new System.Windows.Forms.Label();
            this.mostrarEstadoCivil = new System.Windows.Forms.Label();
            this.mostrarRoles = new System.Windows.Forms.Label();
            this.groupBoxSex.SuspendLayout();
            this.groupBoxEstCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSex.Controls.Add(this.masculino);
            this.groupBoxSex.Controls.Add(this.femenino);
            this.groupBoxSex.Location = new System.Drawing.Point(89, 65);
            this.groupBoxSex.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxSex.Size = new System.Drawing.Size(281, 113);
            this.groupBoxSex.TabIndex = 5;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Tag = "";
            this.groupBoxSex.Text = "Sexo";
            this.groupBoxSex.Enter += new System.EventHandler(this.groupBoxsexo_Enter);
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(15, 65);
            this.masculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(89, 20);
            this.masculino.TabIndex = 17;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.Location = new System.Drawing.Point(15, 32);
            this.femenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(88, 20);
            this.femenino.TabIndex = 16;
            this.femenino.TabStop = true;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // groupBoxEstCivil
            // 
            this.groupBoxEstCivil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEstCivil.Controls.Add(this.casado);
            this.groupBoxEstCivil.Controls.Add(this.soltero);
            this.groupBoxEstCivil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxEstCivil.Location = new System.Drawing.Point(663, 65);
            this.groupBoxEstCivil.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxEstCivil.Name = "groupBoxEstCivil";
            this.groupBoxEstCivil.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxEstCivil.Size = new System.Drawing.Size(297, 113);
            this.groupBoxEstCivil.TabIndex = 6;
            this.groupBoxEstCivil.TabStop = false;
            this.groupBoxEstCivil.Text = "Estado civil";
            this.groupBoxEstCivil.Enter += new System.EventHandler(this.groupBoxEstCivil_Enter);
            // 
            // casado
            // 
            this.casado.AutoSize = true;
            this.casado.Checked = true;
            this.casado.Location = new System.Drawing.Point(20, 37);
            this.casado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.casado.Name = "casado";
            this.casado.Size = new System.Drawing.Size(76, 20);
            this.casado.TabIndex = 5;
            this.casado.TabStop = true;
            this.casado.Text = "Casado";
            this.casado.UseVisualStyleBackColor = true;
            // 
            // soltero
            // 
            this.soltero.AutoSize = true;
            this.soltero.Location = new System.Drawing.Point(20, 65);
            this.soltero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soltero.Name = "soltero";
            this.soltero.Size = new System.Drawing.Size(71, 20);
            this.soltero.TabIndex = 4;
            this.soltero.Text = "Soltero";
            this.soltero.UseVisualStyleBackColor = true;
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
            this.checkedRoles.Location = new System.Drawing.Point(411, 73);
            this.checkedRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedRoles.Name = "checkedRoles";
            this.checkedRoles.Size = new System.Drawing.Size(212, 106);
            this.checkedRoles.TabIndex = 7;
            // 
            // btnMostrarSeleccion
            // 
            this.btnMostrarSeleccion.BackColor = System.Drawing.Color.DimGray;
            this.btnMostrarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSeleccion.Location = new System.Drawing.Point(368, 215);
            this.btnMostrarSeleccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarSeleccion.Name = "btnMostrarSeleccion";
            this.btnMostrarSeleccion.Size = new System.Drawing.Size(304, 28);
            this.btnMostrarSeleccion.TabIndex = 8;
            this.btnMostrarSeleccion.Text = "Mostrar lo que se seleccionó";
            this.btnMostrarSeleccion.UseVisualStyleBackColor = false;
            this.btnMostrarSeleccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // labelMostrarSeleccionado
            // 
            this.labelMostrarSeleccionado.AutoSize = true;
            this.labelMostrarSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrarSeleccionado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMostrarSeleccionado.Location = new System.Drawing.Point(295, 266);
            this.labelMostrarSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostrarSeleccionado.Name = "labelMostrarSeleccionado";
            this.labelMostrarSeleccionado.Size = new System.Drawing.Size(414, 24);
            this.labelMostrarSeleccionado.TabIndex = 14;
            this.labelMostrarSeleccionado.Text = "Usted selecciono los siguientes elementos:";
            // 
            // mostrarSexo
            // 
            this.mostrarSexo.AutoSize = true;
            this.mostrarSexo.BackColor = System.Drawing.Color.Black;
            this.mostrarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mostrarSexo.Location = new System.Drawing.Point(273, 320);
            this.mostrarSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostrarSexo.Name = "mostrarSexo";
            this.mostrarSexo.Size = new System.Drawing.Size(0, 24);
            this.mostrarSexo.TabIndex = 15;
            // 
            // mostrarEstadoCivil
            // 
            this.mostrarEstadoCivil.AutoSize = true;
            this.mostrarEstadoCivil.BackColor = System.Drawing.Color.Black;
            this.mostrarEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarEstadoCivil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mostrarEstadoCivil.Location = new System.Drawing.Point(273, 369);
            this.mostrarEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostrarEstadoCivil.Name = "mostrarEstadoCivil";
            this.mostrarEstadoCivil.Size = new System.Drawing.Size(0, 24);
            this.mostrarEstadoCivil.TabIndex = 16;
            // 
            // mostrarRoles
            // 
            this.mostrarRoles.AutoSize = true;
            this.mostrarRoles.BackColor = System.Drawing.Color.Black;
            this.mostrarRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarRoles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mostrarRoles.Location = new System.Drawing.Point(273, 387);
            this.mostrarRoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostrarRoles.Name = "mostrarRoles";
            this.mostrarRoles.Size = new System.Drawing.Size(0, 24);
            this.mostrarRoles.TabIndex = 17;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mostrarRoles);
            this.Controls.Add(this.mostrarEstadoCivil);
            this.Controls.Add(this.mostrarSexo);
            this.Controls.Add(this.labelMostrarSeleccionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarSeleccion);
            this.Controls.Add(this.checkedRoles);
            this.Controls.Add(this.groupBoxEstCivil);
            this.Controls.Add(this.groupBoxSex);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.groupBoxEstCivil.ResumeLayout(false);
            this.groupBoxEstCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxEstCivil;
        private System.Windows.Forms.CheckedListBox checkedRoles;
        private System.Windows.Forms.Button btnMostrarSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMostrarSeleccionado;
        private System.Windows.Forms.Label mostrarSexo;
        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.RadioButton casado;
        private System.Windows.Forms.RadioButton soltero;
        private System.Windows.Forms.Label mostrarEstadoCivil;
        private System.Windows.Forms.Label mostrarRoles;
    }
}