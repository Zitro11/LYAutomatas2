
namespace Conversiones_Infijas
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbNotaciones = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.rdbPos = new System.Windows.Forms.RadioButton();
            this.rdbPre = new System.Windows.Forms.RadioButton();
            this.gpbNotaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConvertir.Location = new System.Drawing.Point(14, 39);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLimpiar.Location = new System.Drawing.Point(112, 39);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(210, 39);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpbNotaciones
            // 
            this.gpbNotaciones.Controls.Add(this.label2);
            this.gpbNotaciones.Controls.Add(this.label1);
            this.gpbNotaciones.Controls.Add(this.listBox2);
            this.gpbNotaciones.Controls.Add(this.listBox1);
            this.gpbNotaciones.Controls.Add(this.txtResultado);
            this.gpbNotaciones.Controls.Add(this.txtExp);
            this.gpbNotaciones.Controls.Add(this.lblRes2);
            this.gpbNotaciones.Controls.Add(this.lblExp);
            this.gpbNotaciones.Controls.Add(this.rdbPos);
            this.gpbNotaciones.Controls.Add(this.rdbPre);
            this.gpbNotaciones.Controls.Add(this.btnSalir);
            this.gpbNotaciones.Controls.Add(this.btnConvertir);
            this.gpbNotaciones.Controls.Add(this.btnLimpiar);
            this.gpbNotaciones.Location = new System.Drawing.Point(12, 12);
            this.gpbNotaciones.Name = "gpbNotaciones";
            this.gpbNotaciones.Size = new System.Drawing.Size(304, 313);
            this.gpbNotaciones.TabIndex = 3;
            this.gpbNotaciones.TabStop = false;
            this.gpbNotaciones.Text = "Notaciones";
            this.gpbNotaciones.Enter += new System.EventHandler(this.gpbNotaciones_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pila registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pila";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(240, 160);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(32, 134);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(173, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(32, 134);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(33, 274);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // txtExp
            // 
            this.txtExp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtExp.Location = new System.Drawing.Point(33, 194);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(100, 20);
            this.txtExp.TabIndex = 6;
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Location = new System.Drawing.Point(30, 244);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(58, 13);
            this.lblRes2.TabIndex = 4;
            this.lblRes2.Text = "Resultado:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(30, 167);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(56, 13);
            this.lblExp.TabIndex = 5;
            this.lblExp.Text = "Expresion:";
            // 
            // rdbPos
            // 
            this.rdbPos.AutoSize = true;
            this.rdbPos.Checked = true;
            this.rdbPos.Location = new System.Drawing.Point(50, 101);
            this.rdbPos.Name = "rdbPos";
            this.rdbPos.Size = new System.Drawing.Size(56, 17);
            this.rdbPos.TabIndex = 4;
            this.rdbPos.TabStop = true;
            this.rdbPos.Text = "Posfija";
            this.rdbPos.UseVisualStyleBackColor = true;
            // 
            // rdbPre
            // 
            this.rdbPre.AutoSize = true;
            this.rdbPre.Location = new System.Drawing.Point(164, 101);
            this.rdbPre.Name = "rdbPre";
            this.rdbPre.Size = new System.Drawing.Size(54, 17);
            this.rdbPre.TabIndex = 3;
            this.rdbPre.Text = "Prefija";
            this.rdbPre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 336);
            this.Controls.Add(this.gpbNotaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbNotaciones.ResumeLayout(false);
            this.gpbNotaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gpbNotaciones;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.RadioButton rdbPos;
        private System.Windows.Forms.RadioButton rdbPre;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

