namespace PrOperadores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textnumero1 = new System.Windows.Forms.TextBox();
            this.textnumero2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textsuma = new System.Windows.Forms.Label();
            this.textresta = new System.Windows.Forms.Label();
            this.textmultiplicacion = new System.Windows.Forms.Label();
            this.textdivision = new System.Windows.Forms.Label();
            this.textpotencia = new System.Windows.Forms.Label();
            this.textraiz = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.textnumero2);
            this.groupBox1.Controls.Add(this.textnumero1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // textnumero1
            // 
            this.textnumero1.Location = new System.Drawing.Point(107, 43);
            this.textnumero1.Name = "textnumero1";
            this.textnumero1.Size = new System.Drawing.Size(100, 23);
            this.textnumero1.TabIndex = 2;
            // 
            // textnumero2
            // 
            this.textnumero2.Location = new System.Drawing.Point(107, 109);
            this.textnumero2.Name = "textnumero2";
            this.textnumero2.Size = new System.Drawing.Size(100, 23);
            this.textnumero2.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(246, 46);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(246, 109);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textraiz);
            this.groupBox2.Controls.Add(this.textpotencia);
            this.groupBox2.Controls.Add(this.textdivision);
            this.groupBox2.Controls.Add(this.textmultiplicacion);
            this.groupBox2.Controls.Add(this.textresta);
            this.groupBox2.Controls.Add(this.textsuma);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textsuma
            // 
            this.textsuma.AutoSize = true;
            this.textsuma.Location = new System.Drawing.Point(15, 28);
            this.textsuma.Name = "textsuma";
            this.textsuma.Size = new System.Drawing.Size(40, 15);
            this.textsuma.TabIndex = 0;
            this.textsuma.Text = "Suma:";
            // 
            // textresta
            // 
            this.textresta.AutoSize = true;
            this.textresta.Location = new System.Drawing.Point(15, 63);
            this.textresta.Name = "textresta";
            this.textresta.Size = new System.Drawing.Size(38, 15);
            this.textresta.TabIndex = 1;
            this.textresta.Text = "Resta:";
            // 
            // textmultiplicacion
            // 
            this.textmultiplicacion.AutoSize = true;
            this.textmultiplicacion.Location = new System.Drawing.Point(15, 105);
            this.textmultiplicacion.Name = "textmultiplicacion";
            this.textmultiplicacion.Size = new System.Drawing.Size(86, 15);
            this.textmultiplicacion.TabIndex = 2;
            this.textmultiplicacion.Text = "Multiplicacion:";
            // 
            // textdivision
            // 
            this.textdivision.AutoSize = true;
            this.textdivision.Location = new System.Drawing.Point(254, 29);
            this.textdivision.Name = "textdivision";
            this.textdivision.Size = new System.Drawing.Size(53, 15);
            this.textdivision.TabIndex = 3;
            this.textdivision.Text = "Divicion:";
            // 
            // textpotencia
            // 
            this.textpotencia.AutoSize = true;
            this.textpotencia.Location = new System.Drawing.Point(254, 63);
            this.textpotencia.Name = "textpotencia";
            this.textpotencia.Size = new System.Drawing.Size(56, 15);
            this.textpotencia.TabIndex = 4;
            this.textpotencia.Text = "Potencia:";
            // 
            // textraiz
            // 
            this.textraiz.AutoSize = true;
            this.textraiz.Location = new System.Drawing.Point(254, 105);
            this.textraiz.Name = "textraiz";
            this.textraiz.Size = new System.Drawing.Size(31, 15);
            this.textraiz.TabIndex = 5;
            this.textraiz.Text = "Raiz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ":. Estructura Secuenciales .:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnlimpiar;
        private Button btncalcular;
        private TextBox textnumero2;
        private TextBox textnumero1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label textraiz;
        private Label textpotencia;
        private Label textdivision;
        private Label textmultiplicacion;
        private Label textresta;
        private Label textsuma;
    }
}