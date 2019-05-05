namespace Conversor
{
    partial class conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conversor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxGraus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbK = new System.Windows.Forms.RadioButton();
            this.resC = new System.Windows.Forms.Label();
            this.resF = new System.Windows.Forms.Label();
            this.resK = new System.Windows.Forms.Label();
            this.btConvert1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textboxMedida = new System.Windows.Forms.TextBox();
            this.btM = new System.Windows.Forms.Button();
            this.btCm = new System.Windows.Forms.Button();
            this.btKm = new System.Windows.Forms.Button();
            this.resMedida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbKm = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbCm = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConvert1);
            this.groupBox1.Controls.Add(this.resK);
            this.groupBox1.Controls.Add(this.resF);
            this.groupBox1.Controls.Add(this.resC);
            this.groupBox1.Controls.Add(this.rbK);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textboxGraus);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperaturas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textboxGraus
            // 
            this.textboxGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxGraus.Location = new System.Drawing.Point(24, 280);
            this.textboxGraus.Margin = new System.Windows.Forms.Padding(5);
            this.textboxGraus.Multiline = true;
            this.textboxGraus.Name = "textboxGraus";
            this.textboxGraus.Size = new System.Drawing.Size(232, 33);
            this.textboxGraus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graus:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(150, 342);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(75, 17);
            this.rbF.TabIndex = 3;
            this.rbF.TabStop = true;
            this.rbF.Text = "Fahrenheit";
            this.rbF.UseVisualStyleBackColor = true;
            this.rbF.CheckedChanged += new System.EventHandler(this.rbF_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(40, 342);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(58, 17);
            this.rbC.TabIndex = 4;
            this.rbC.TabStop = true;
            this.rbC.Text = "Celsius";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbK
            // 
            this.rbK.AutoSize = true;
            this.rbK.Location = new System.Drawing.Point(273, 342);
            this.rbK.Name = "rbK";
            this.rbK.Size = new System.Drawing.Size(54, 17);
            this.rbK.TabIndex = 5;
            this.rbK.TabStop = true;
            this.rbK.Text = "Kelvin";
            this.rbK.UseVisualStyleBackColor = true;
            // 
            // resC
            // 
            this.resC.AutoSize = true;
            this.resC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resC.Location = new System.Drawing.Point(204, 63);
            this.resC.Name = "resC";
            this.resC.Size = new System.Drawing.Size(66, 31);
            this.resC.TabIndex = 6;
            this.resC.Text = "0 ºC";
            this.resC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resC.Click += new System.EventHandler(this.resGraus_Click);
            // 
            // resF
            // 
            this.resF.AutoSize = true;
            this.resF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resF.Location = new System.Drawing.Point(204, 106);
            this.resF.Name = "resF";
            this.resF.Size = new System.Drawing.Size(63, 31);
            this.resF.TabIndex = 7;
            this.resF.Text = "0 ºF";
            this.resF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resK
            // 
            this.resK.AutoSize = true;
            this.resK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resK.Location = new System.Drawing.Point(204, 152);
            this.resK.Name = "resK";
            this.resK.Size = new System.Drawing.Size(54, 31);
            this.resK.TabIndex = 8;
            this.resK.Text = "0 K";
            this.resK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resK.Click += new System.EventHandler(this.label3_Click);
            // 
            // btConvert1
            // 
            this.btConvert1.Location = new System.Drawing.Point(255, 279);
            this.btConvert1.Name = "btConvert1";
            this.btConvert1.Size = new System.Drawing.Size(90, 35);
            this.btConvert1.TabIndex = 9;
            this.btConvert1.Text = "Converter";
            this.btConvert1.UseVisualStyleBackColor = true;
            this.btConvert1.Click += new System.EventHandler(this.btConvert1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbM);
            this.groupBox2.Controls.Add(this.rbCm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.resMedida);
            this.groupBox2.Controls.Add(this.btKm);
            this.groupBox2.Controls.Add(this.btCm);
            this.groupBox2.Controls.Add(this.btM);
            this.groupBox2.Controls.Add(this.textboxMedida);
            this.groupBox2.Location = new System.Drawing.Point(425, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medidas";
            // 
            // textboxMedida
            // 
            this.textboxMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMedida.Location = new System.Drawing.Point(35, 167);
            this.textboxMedida.Margin = new System.Windows.Forms.Padding(5);
            this.textboxMedida.Multiline = true;
            this.textboxMedida.Name = "textboxMedida";
            this.textboxMedida.Size = new System.Drawing.Size(260, 33);
            this.textboxMedida.TabIndex = 0;
            // 
            // btM
            // 
            this.btM.BackColor = System.Drawing.Color.Gainsboro;
            this.btM.Location = new System.Drawing.Point(34, 271);
            this.btM.Name = "btM";
            this.btM.Size = new System.Drawing.Size(80, 34);
            this.btM.TabIndex = 1;
            this.btM.Text = "M";
            this.btM.UseVisualStyleBackColor = false;
            this.btM.Click += new System.EventHandler(this.btM_Click);
            // 
            // btCm
            // 
            this.btCm.Location = new System.Drawing.Point(124, 271);
            this.btCm.Name = "btCm";
            this.btCm.Size = new System.Drawing.Size(80, 34);
            this.btCm.TabIndex = 2;
            this.btCm.Text = "Cm";
            this.btCm.UseVisualStyleBackColor = true;
            this.btCm.Click += new System.EventHandler(this.btCm_Click);
            // 
            // btKm
            // 
            this.btKm.Location = new System.Drawing.Point(215, 271);
            this.btKm.Name = "btKm";
            this.btKm.Size = new System.Drawing.Size(80, 34);
            this.btKm.TabIndex = 4;
            this.btKm.Text = "Km";
            this.btKm.UseVisualStyleBackColor = true;
            this.btKm.Click += new System.EventHandler(this.btKm_Click);
            // 
            // resMedida
            // 
            this.resMedida.AutoSize = true;
            this.resMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMedida.Location = new System.Drawing.Point(38, 53);
            this.resMedida.Name = "resMedida";
            this.resMedida.Size = new System.Drawing.Size(51, 55);
            this.resMedida.TabIndex = 5;
            this.resMedida.Text = "0";
            this.resMedida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resMedida.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Converter para:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Etec Adolpho Berezin - João Araya, fev 2019";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(425, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbKm
            // 
            this.rbKm.AutoSize = true;
            this.rbKm.Location = new System.Drawing.Point(219, 208);
            this.rbKm.Name = "rbKm";
            this.rbKm.Size = new System.Drawing.Size(73, 17);
            this.rbKm.TabIndex = 12;
            this.rbKm.TabStop = true;
            this.rbKm.Text = "Kilometros";
            this.rbKm.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(38, 208);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(57, 17);
            this.rbM.TabIndex = 11;
            this.rbM.TabStop = true;
            this.rbM.Text = "Metros";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbCm
            // 
            this.rbCm.AutoSize = true;
            this.rbCm.Location = new System.Drawing.Point(119, 208);
            this.rbCm.Name = "rbCm";
            this.rbCm.Size = new System.Drawing.Size(80, 17);
            this.rbCm.TabIndex = 10;
            this.rbCm.TabStop = true;
            this.rbCm.Text = "Centimetros";
            this.rbCm.UseVisualStyleBackColor = true;
            // 
            // conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "conversor";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxGraus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.Label resC;
        private System.Windows.Forms.RadioButton rbK;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Label resK;
        private System.Windows.Forms.Label resF;
        private System.Windows.Forms.Button btConvert1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resMedida;
        private System.Windows.Forms.Button btKm;
        private System.Windows.Forms.Button btCm;
        private System.Windows.Forms.Button btM;
        private System.Windows.Forms.TextBox textboxMedida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbKm;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbCm;
    }
}

