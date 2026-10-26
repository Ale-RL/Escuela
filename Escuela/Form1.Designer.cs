namespace Escuela
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            nudSemestre = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            txtGrupo = new TextBox();
            txtEspecialidad = new TextBox();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            dgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "Matricula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(18, 64);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(400, 16);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 2;
            label3.Text = "Semestre:";
            label3.Click += label3_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(90, 16);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(143, 23);
            txtMatricula.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 4;
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(489, 14);
            nudSemestre.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(143, 23);
            nudSemestre.TabIndex = 5;
            nudSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(400, 64);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 6;
            label4.Text = "Grupo:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(400, 109);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 7;
            label5.Text = "Especialidad:";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(489, 58);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(143, 23);
            txtGrupo.TabIndex = 8;
            txtGrupo.TextChanged += txtGrupo_TextChanged;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(489, 108);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(143, 23);
            txtEspecialidad.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(683, 16);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(683, 64);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(683, 109);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Dock = DockStyle.Bottom;
            dgvAlumnos.Location = new Point(0, 193);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(800, 257);
            dgvAlumnos.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtGrupo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nudSemestre);
            Controls.Add(txtNombre);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMatricula;
        private TextBox txtNombre;
        private NumericUpDown nudSemestre;
        private Label label4;
        private Label label5;
        private TextBox txtGrupo;
        private TextBox txtEspecialidad;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnLimpiar;
        private DataGridView dgvAlumnos;
    }
}
