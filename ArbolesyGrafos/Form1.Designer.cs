namespace ArbolesyGrafos
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
            this.btnArbol = new System.Windows.Forms.Button();
            this.btnGrafo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArbol
            // 
            this.btnArbol.Location = new System.Drawing.Point(153, 69);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(304, 134);
            this.btnArbol.TabIndex = 0;
            this.btnArbol.Text = "Árbol";
            this.btnArbol.UseVisualStyleBackColor = true;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click);
            // 
            // btnGrafo
            // 
            this.btnGrafo.Location = new System.Drawing.Point(153, 245);
            this.btnGrafo.Name = "btnGrafo";
            this.btnGrafo.Size = new System.Drawing.Size(304, 134);
            this.btnGrafo.TabIndex = 1;
            this.btnGrafo.Text = "Grafo";
            this.btnGrafo.UseVisualStyleBackColor = true;
            this.btnGrafo.Click += new System.EventHandler(this.btnGrafo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 495);
            this.Controls.Add(this.btnGrafo);
            this.Controls.Add(this.btnArbol);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArbol;
        private System.Windows.Forms.Button btnGrafo;
    }
}

