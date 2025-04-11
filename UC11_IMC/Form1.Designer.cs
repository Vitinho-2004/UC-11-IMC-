namespace UC11_IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCLICK = new System.Windows.Forms.Button();
            this.labelALTURA = new System.Windows.Forms.Label();
            this.textBoxNUM1 = new System.Windows.Forms.TextBox();
            this.labelPESO = new System.Windows.Forms.Label();
            this.labelRESULTADO = new System.Windows.Forms.Label();
            this.textBoxNUM2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIMC = new System.Windows.Forms.Label();
            this.labelCATEGORIA = new System.Windows.Forms.Label();
            this.labelCategoria2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCLICK
            // 
            this.buttonCLICK.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCLICK.Location = new System.Drawing.Point(304, 276);
            this.buttonCLICK.Name = "buttonCLICK";
            this.buttonCLICK.Size = new System.Drawing.Size(151, 41);
            this.buttonCLICK.TabIndex = 0;
            this.buttonCLICK.Text = "CALCULAR";
            this.buttonCLICK.UseVisualStyleBackColor = false;
            this.buttonCLICK.Click += new System.EventHandler(this.buttonCLICK_Click);
            // 
            // labelALTURA
            // 
            this.labelALTURA.AutoSize = true;
            this.labelALTURA.Location = new System.Drawing.Point(290, 108);
            this.labelALTURA.Name = "labelALTURA";
            this.labelALTURA.Size = new System.Drawing.Size(59, 15);
            this.labelALTURA.TabIndex = 1;
            this.labelALTURA.Text = "ALTURA :";
            this.labelALTURA.Click += new System.EventHandler(this.labelALTURA_Click);
            // 
            // textBoxNUM1
            // 
            this.textBoxNUM1.Location = new System.Drawing.Point(355, 103);
            this.textBoxNUM1.Name = "textBoxNUM1";
            this.textBoxNUM1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNUM1.TabIndex = 2;
            this.textBoxNUM1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelPESO
            // 
            this.labelPESO.AutoSize = true;
            this.labelPESO.Location = new System.Drawing.Point(293, 148);
            this.labelPESO.Name = "labelPESO";
            this.labelPESO.Size = new System.Drawing.Size(46, 15);
            this.labelPESO.TabIndex = 3;
            this.labelPESO.Text = "PESO :";
            // 
            // labelRESULTADO
            // 
            this.labelRESULTADO.AutoSize = true;
            this.labelRESULTADO.Location = new System.Drawing.Point(279, 192);
            this.labelRESULTADO.Name = "labelRESULTADO";
            this.labelRESULTADO.Size = new System.Drawing.Size(86, 15);
            this.labelRESULTADO.TabIndex = 4;
            this.labelRESULTADO.Text = "RESULTADO :";
            // 
            // textBoxNUM2
            // 
            this.textBoxNUM2.Location = new System.Drawing.Point(355, 145);
            this.textBoxNUM2.Name = "textBoxNUM2";
            this.textBoxNUM2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNUM2.TabIndex = 5;
            this.textBoxNUM2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(351, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "IMC";
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMC.Location = new System.Drawing.Point(363, 187);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(51, 29);
            this.labelIMC.TabIndex = 8;
            this.labelIMC.Text = "imc";
            this.labelIMC.Click += new System.EventHandler(this.labelIMC_Click);
            // 
            // labelCATEGORIA
            // 
            this.labelCATEGORIA.AutoSize = true;
            this.labelCATEGORIA.Location = new System.Drawing.Point(282, 230);
            this.labelCATEGORIA.Name = "labelCATEGORIA";
            this.labelCATEGORIA.Size = new System.Drawing.Size(80, 15);
            this.labelCATEGORIA.TabIndex = 9;
            this.labelCATEGORIA.Text = "CATEGORIA :";
            this.labelCATEGORIA.Click += new System.EventHandler(this.labelCATEGORIA_Click);
            // 
            // labelCategoria2
            // 
            this.labelCategoria2.AutoSize = true;
            this.labelCategoria2.Location = new System.Drawing.Point(364, 230);
            this.labelCategoria2.Name = "labelCategoria2";
            this.labelCategoria2.Size = new System.Drawing.Size(0, 15);
            this.labelCategoria2.TabIndex = 10;
            this.labelCategoria2.Click += new System.EventHandler(this.labelCategoria2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCategoria2);
            this.Controls.Add(this.labelCATEGORIA);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNUM2);
            this.Controls.Add(this.labelRESULTADO);
            this.Controls.Add(this.labelPESO);
            this.Controls.Add(this.textBoxNUM1);
            this.Controls.Add(this.labelALTURA);
            this.Controls.Add(this.buttonCLICK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCLICK;
        private System.Windows.Forms.Label labelALTURA;
        private System.Windows.Forms.TextBox textBoxNUM1;
        private System.Windows.Forms.Label labelPESO;
        private System.Windows.Forms.Label labelRESULTADO;
        private System.Windows.Forms.TextBox textBoxNUM2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label labelCATEGORIA;
        private System.Windows.Forms.Label labelCategoria2;
    }
}

