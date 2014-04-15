namespace PapelSelector
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfig2 = new System.Windows.Forms.Button();
            this.btnConfig1 = new System.Windows.Forms.Button();
            this.lblPrinter1 = new System.Windows.Forms.Label();
            this.lblPrinter2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(108, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConfig2
            // 
            this.btnConfig2.Location = new System.Drawing.Point(189, 48);
            this.btnConfig2.Name = "btnConfig2";
            this.btnConfig2.Size = new System.Drawing.Size(28, 19);
            this.btnConfig2.TabIndex = 2;
            this.btnConfig2.Text = "...";
            this.btnConfig2.UseVisualStyleBackColor = true;
            this.btnConfig2.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnConfig1
            // 
            this.btnConfig1.Location = new System.Drawing.Point(6, 48);
            this.btnConfig1.Name = "btnConfig1";
            this.btnConfig1.Size = new System.Drawing.Size(28, 19);
            this.btnConfig1.TabIndex = 3;
            this.btnConfig1.Text = "...";
            this.btnConfig1.UseVisualStyleBackColor = true;
            this.btnConfig1.Click += new System.EventHandler(this.btnConfig1_Click);
            // 
            // lblPrinter1
            // 
            this.lblPrinter1.AutoSize = true;
            this.lblPrinter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter1.Location = new System.Drawing.Point(3, 37);
            this.lblPrinter1.Name = "lblPrinter1";
            this.lblPrinter1.Size = new System.Drawing.Size(25, 9);
            this.lblPrinter1.TabIndex = 4;
            this.lblPrinter1.Text = "label3";
            this.lblPrinter1.Click += new System.EventHandler(this.lblPrinter1_Click);
            // 
            // lblPrinter2
            // 
            this.lblPrinter2.AutoSize = true;
            this.lblPrinter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter2.Location = new System.Drawing.Point(108, 37);
            this.lblPrinter2.Name = "lblPrinter2";
            this.lblPrinter2.Size = new System.Drawing.Size(25, 9);
            this.lblPrinter2.TabIndex = 5;
            this.lblPrinter2.Text = "label4";
            this.lblPrinter2.Click += new System.EventHandler(this.lblPrinter2_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(213, -1);
            this.lblClose.Margin = new System.Windows.Forms.Padding(0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(11, 11);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 69);
            this.ControlBox = false;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblPrinter2);
            this.Controls.Add(this.lblPrinter1);
            this.Controls.Add(this.btnConfig1);
            this.Controls.Add(this.btnConfig2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfig2;
        private System.Windows.Forms.Button btnConfig1;
        private System.Windows.Forms.Label lblPrinter1;
        private System.Windows.Forms.Label lblPrinter2;
        private System.Windows.Forms.Label lblClose;
    }
}

