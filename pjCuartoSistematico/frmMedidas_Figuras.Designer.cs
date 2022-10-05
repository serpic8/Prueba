namespace pjCuartoSistematico
{
    partial class frmMedidas_Figuras
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
            this.pnlFiguras = new System.Windows.Forms.Panel();
            this.btn3D = new System.Windows.Forms.Button();
            this.btn2D = new System.Windows.Forms.Button();
            this.pnlFiguras.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiguras
            // 
            this.pnlFiguras.Controls.Add(this.btn3D);
            this.pnlFiguras.Controls.Add(this.btn2D);
            this.pnlFiguras.Location = new System.Drawing.Point(73, 55);
            this.pnlFiguras.Name = "pnlFiguras";
            this.pnlFiguras.Size = new System.Drawing.Size(334, 170);
            this.pnlFiguras.TabIndex = 0;
            // 
            // btn3D
            // 
            this.btn3D.Location = new System.Drawing.Point(217, 132);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(75, 23);
            this.btn3D.TabIndex = 1;
            this.btn3D.Text = "3D";
            this.btn3D.UseVisualStyleBackColor = true;
            this.btn3D.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // btn2D
            // 
            this.btn2D.Location = new System.Drawing.Point(51, 132);
            this.btn2D.Name = "btn2D";
            this.btn2D.Size = new System.Drawing.Size(75, 23);
            this.btn2D.TabIndex = 0;
            this.btn2D.Text = "2D";
            this.btn2D.UseVisualStyleBackColor = true;
            this.btn2D.Click += new System.EventHandler(this.btn2D_Click);
            // 
            // frmMedidas_Figuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 265);
            this.Controls.Add(this.pnlFiguras);
            this.Name = "frmMedidas_Figuras";
            this.Text = "Figuras";
            this.pnlFiguras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlFiguras;
        private Button btn3D;
        private Button btn2D;
    }
}