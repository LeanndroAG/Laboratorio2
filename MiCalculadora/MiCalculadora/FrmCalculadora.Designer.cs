namespace MiCalculadora
{
    partial class FrmCalculadora
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
            btnCerrar = new Button();
            btnLimpiar = new Button();
            btnOperar = new Button();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperacion = new ComboBox();
            lblOperacion = new Label();
            lblPrimerOperando = new Label();
            lblResultado = new Label();
            lblSegundoOperando = new Label();
            grpSistema = new GroupBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            lblMostrar = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(382, 349);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(167, 89);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(200, 349);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(167, 89);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(12, 349);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(167, 89);
            btnOperar.TabIndex = 2;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(12, 298);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(167, 23);
            txtPrimerOperando.TabIndex = 3;
            txtPrimerOperando.TextChanged += txtPrimerOperando_TextChanged;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(382, 298);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(167, 23);
            txtSegundoOperando.TabIndex = 4;
            txtSegundoOperando.TextChanged += txtSegundoOperando_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DisplayMember = "(ninguno)";
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(200, 298);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(167, 23);
            cmbOperacion.TabIndex = 5;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(238, 256);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(94, 25);
            lblOperacion.TabIndex = 6;
            lblOperacion.Text = "Operacion";
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(32, 256);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(139, 23);
            lblPrimerOperando.TabIndex = 7;
            lblPrimerOperando.Text = "Primer operando";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(-2, 23);
            lblResultado.Name = "lblResultado";
            lblResultado.RightToLeft = RightToLeft.No;
            lblResultado.Size = new Size(181, 47);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado:";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(382, 254);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(167, 25);
            lblSegundoOperando.TabIndex = 9;
            lblSegundoOperando.Text = "Segundo operando";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(155, 135);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(230, 83);
            grpSistema.TabIndex = 11;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en";
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(6, 41);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(84, 25);
            rdbDecimal.TabIndex = 13;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(147, 41);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 25);
            rdbBinario.TabIndex = 12;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMostrar.Location = new Point(171, 35);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(0, 32);
            lblMostrar.TabIndex = 12;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(557, 450);
            Controls.Add(lblMostrar);
            Controls.Add(grpSistema);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblResultado);
            Controls.Add(lblPrimerOperando);
            Controls.Add(lblOperacion);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(btnOperar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Leandro Agüero";
            Load += FrmCalculadora_Load_1;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnCerrar;
        private Button btnLimpiar;
        private Button btnOperar;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperacion;
        private Label lblOperacion;
        private Label lblPrimerOperando;
        private Label lblResultado;
        private Label lblSegundoOperando;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblMostrar;
    }
}