namespace EjemploDepuracionCodigoCSharp
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lvnumeros = new System.Windows.Forms.ListView();
            this.btningresar = new System.Windows.Forms.Button();
            this.lbvalores = new System.Windows.Forms.ListBox();
            this.btnfibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo con uso de ciclo mientras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un valor:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(154, 113);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 2;
            // 
            // lvnumeros
            // 
            this.lvnumeros.Location = new System.Drawing.Point(432, 111);
            this.lvnumeros.Name = "lvnumeros";
            this.lvnumeros.Size = new System.Drawing.Size(121, 325);
            this.lvnumeros.TabIndex = 3;
            this.lvnumeros.UseCompatibleStateImageBehavior = false;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(260, 111);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // lbvalores
            // 
            this.lbvalores.FormattingEnabled = true;
            this.lbvalores.Location = new System.Drawing.Point(622, 111);
            this.lbvalores.Name = "lbvalores";
            this.lbvalores.Size = new System.Drawing.Size(120, 329);
            this.lbvalores.TabIndex = 5;
            // 
            // btnfibonacci
            // 
            this.btnfibonacci.Location = new System.Drawing.Point(260, 140);
            this.btnfibonacci.Name = "btnfibonacci";
            this.btnfibonacci.Size = new System.Drawing.Size(75, 23);
            this.btnfibonacci.TabIndex = 6;
            this.btnfibonacci.Text = "Fibonacci";
            this.btnfibonacci.UseVisualStyleBackColor = true;
            this.btnfibonacci.Click += new System.EventHandler(this.btnfibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfibonacci);
            this.Controls.Add(this.lbvalores);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lvnumeros);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ListView lvnumeros;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.ListBox lbvalores;
        private System.Windows.Forms.Button btnfibonacci;
    }
}

