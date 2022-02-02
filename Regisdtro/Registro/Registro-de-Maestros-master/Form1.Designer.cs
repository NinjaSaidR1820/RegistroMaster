namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupSex = new System.Windows.Forms.GroupBox();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnResultados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "EDAD";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // groupSex
            // 
            this.groupSex.BackColor = System.Drawing.SystemColors.Info;
            this.groupSex.Controls.Add(this.optMasculino);
            this.groupSex.Controls.Add(this.optFemenino);
            this.groupSex.Location = new System.Drawing.Point(386, 48);
            this.groupSex.Name = "groupSex";
            this.groupSex.Size = new System.Drawing.Size(174, 119);
            this.groupSex.TabIndex = 4;
            this.groupSex.TabStop = false;
            this.groupSex.Text = "SEXO";
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(19, 74);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(129, 24);
            this.optMasculino.TabIndex = 1;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "MASCULINO";
            this.optMasculino.UseVisualStyleBackColor = true;
            this.optMasculino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optMasculino_KeyPress);
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Location = new System.Drawing.Point(19, 35);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(118, 24);
            this.optFemenino.TabIndex = 0;
            this.optFemenino.TabStop = true;
            this.optFemenino.Text = "FEMENINO";
            this.optFemenino.UseVisualStyleBackColor = true;
            this.optFemenino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optFemenino_KeyPress);
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(258, 79);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(95, 26);
            this.nudEdad.TabIndex = 5;
            this.nudEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudEdad_KeyPress);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(602, 48);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(334, 328);
            this.txtResultados.TabIndex = 6;
            this.txtResultados.TextChanged += new System.EventHandler(this.txtResultados_TextChanged);
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(659, 382);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(223, 37);
            this.btnResultados.TabIndex = 7;
            this.btnResultados.Text = "RESULTADOS";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total personas";
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(39, 78);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(195, 26);
            this.txtPersonas.TabIndex = 10;
            this.txtPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonas_KeyPress);
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDatos.HideSelection = false;
            this.lvDatos.Location = new System.Drawing.Point(35, 190);
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(561, 229);
            this.lvDatos.TabIndex = 11;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOMBRE";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EDAD";
            this.columnHeader2.Width = 151;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SEXO";
            this.columnHeader3.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.txtPersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.groupSex);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupSex.ResumeLayout(false);
            this.groupSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupSex;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.ListView lvDatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

