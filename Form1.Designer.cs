namespace Sistema_de_Gestión_de_Citas_Médicas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRegistro = new System.Windows.Forms.TabPage();
            this.tabPageReporte = new System.Windows.Forms.TabPage();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaCita = new System.Windows.Forms.DateTimePicker();
            this.comboBoxHoraCita = new System.Windows.Forms.ComboBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRegistro);
            this.tabControl1.Controls.Add(this.tabPageReporte);
            this.tabControl1.Location = new System.Drawing.Point(11, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRegistro
            // 
            this.tabPageRegistro.Controls.Add(this.buttonRegistro);
            this.tabPageRegistro.Controls.Add(this.label2);
            this.tabPageRegistro.Controls.Add(this.label1);
            this.tabPageRegistro.Controls.Add(this.labelPaciente);
            this.tabPageRegistro.Controls.Add(this.labelDoctor);
            this.tabPageRegistro.Controls.Add(this.comboBoxHoraCita);
            this.tabPageRegistro.Controls.Add(this.dateTimePickerFechaCita);
            this.tabPageRegistro.Controls.Add(this.comboBoxPaciente);
            this.tabPageRegistro.Controls.Add(this.comboBoxDoctor);
            this.tabPageRegistro.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegistro.Name = "tabPageRegistro";
            this.tabPageRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistro.Size = new System.Drawing.Size(768, 372);
            this.tabPageRegistro.TabIndex = 0;
            this.tabPageRegistro.Text = "Registro de citas";
            this.tabPageRegistro.UseVisualStyleBackColor = true;
            // 
            // tabPageReporte
            // 
            this.tabPageReporte.Location = new System.Drawing.Point(4, 25);
            this.tabPageReporte.Name = "tabPageReporte";
            this.tabPageReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReporte.Size = new System.Drawing.Size(768, 372);
            this.tabPageReporte.TabIndex = 1;
            this.tabPageReporte.Text = "Reporte";
            this.tabPageReporte.UseVisualStyleBackColor = true;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(245, 61);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(365, 24);
            this.comboBoxDoctor.TabIndex = 0;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(244, 134);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(366, 24);
            this.comboBoxPaciente.TabIndex = 1;
            // 
            // dateTimePickerFechaCita
            // 
            this.dateTimePickerFechaCita.Location = new System.Drawing.Point(245, 204);
            this.dateTimePickerFechaCita.Name = "dateTimePickerFechaCita";
            this.dateTimePickerFechaCita.Size = new System.Drawing.Size(371, 22);
            this.dateTimePickerFechaCita.TabIndex = 2;
            // 
            // comboBoxHoraCita
            // 
            this.comboBoxHoraCita.FormattingEnabled = true;
            this.comboBoxHoraCita.Location = new System.Drawing.Point(245, 263);
            this.comboBoxHoraCita.Name = "comboBoxHoraCita";
            this.comboBoxHoraCita.Size = new System.Drawing.Size(371, 24);
            this.comboBoxHoraCita.TabIndex = 3;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(156, 69);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(47, 16);
            this.labelDoctor.TabIndex = 4;
            this.labelDoctor.Text = "Doctor";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(143, 137);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(60, 16);
            this.labelPaciente.TabIndex = 5;
            this.labelPaciente.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de la cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora de la cita";
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(324, 313);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(192, 28);
            this.buttonRegistro.TabIndex = 8;
            this.buttonRegistro.Text = "Guardar";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRegistro.ResumeLayout(false);
            this.tabPageRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRegistro;
        private System.Windows.Forms.TabPage tabPageReporte;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboBoxHoraCita;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCita;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistro;
    }
}

