namespace UmDiaDeCorridas.WinApp
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.picPista = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlfredo = new System.Windows.Forms.Label();
            this.lblBeto = new System.Windows.Forms.Label();
            this.lblJoao = new System.Windows.Forms.Label();
            this.nudCao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.btnAposta = new System.Windows.Forms.Button();
            this.lblApostaNome = new System.Windows.Forms.Label();
            this.rbtAlfredo = new System.Windows.Forms.RadioButton();
            this.rbtBeto = new System.Windows.Forms.RadioButton();
            this.rbtJoao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // picPista
            // 
            this.picPista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPista.Image = ((System.Drawing.Image)(resources.GetObject("picPista.Image")));
            this.picPista.Location = new System.Drawing.Point(12, 12);
            this.picPista.Name = "picPista";
            this.picPista.Size = new System.Drawing.Size(717, 240);
            this.picPista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPista.TabIndex = 0;
            this.picPista.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCorrer);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.nudCao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudValor);
            this.groupBox1.Controls.Add(this.btnAposta);
            this.groupBox1.Controls.Add(this.lblApostaNome);
            this.groupBox1.Controls.Add(this.rbtAlfredo);
            this.groupBox1.Controls.Add(this.rbtBeto);
            this.groupBox1.Controls.Add(this.rbtJoao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balcão de Apostas";
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(604, 196);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(107, 37);
            this.btnCorrer.TabIndex = 11;
            this.btnCorrer.Text = "Corram!";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlfredo);
            this.groupBox2.Controls.Add(this.lblBeto);
            this.groupBox2.Controls.Add(this.lblJoao);
            this.groupBox2.Location = new System.Drawing.Point(407, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 171);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apostas";
            // 
            // lblAlfredo
            // 
            this.lblAlfredo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlfredo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlfredo.Location = new System.Drawing.Point(19, 125);
            this.lblAlfredo.Name = "lblAlfredo";
            this.lblAlfredo.Size = new System.Drawing.Size(266, 17);
            this.lblAlfredo.TabIndex = 14;
            this.lblAlfredo.Text = "Aposta do Alfredo";
            // 
            // lblBeto
            // 
            this.lblBeto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeto.Location = new System.Drawing.Point(21, 75);
            this.lblBeto.Name = "lblBeto";
            this.lblBeto.Size = new System.Drawing.Size(266, 17);
            this.lblBeto.TabIndex = 13;
            this.lblBeto.Text = "Aposta do Beto";
            // 
            // lblJoao
            // 
            this.lblJoao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJoao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoao.Location = new System.Drawing.Point(21, 33);
            this.lblJoao.Name = "lblJoao";
            this.lblJoao.Size = new System.Drawing.Size(266, 17);
            this.lblJoao.TabIndex = 12;
            this.lblJoao.Text = "Aposta do João";
            // 
            // nudCao
            // 
            this.nudCao.Location = new System.Drawing.Point(342, 206);
            this.nudCao.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCao.Name = "nudCao";
            this.nudCao.Size = new System.Drawing.Size(56, 20);
            this.nudCao.TabIndex = 9;
            this.nudCao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "No cão numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "R$:";
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(179, 206);
            this.nudValor.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudValor.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(56, 20);
            this.nudValor.TabIndex = 6;
            this.nudValor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAposta
            // 
            this.btnAposta.Location = new System.Drawing.Point(68, 203);
            this.btnAposta.Name = "btnAposta";
            this.btnAposta.Size = new System.Drawing.Size(75, 23);
            this.btnAposta.TabIndex = 5;
            this.btnAposta.Text = "Aposta";
            this.btnAposta.UseVisualStyleBackColor = true;
            this.btnAposta.Click += new System.EventHandler(this.btnAposta_Click);
            // 
            // lblApostaNome
            // 
            this.lblApostaNome.AutoSize = true;
            this.lblApostaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaNome.Location = new System.Drawing.Point(17, 208);
            this.lblApostaNome.Name = "lblApostaNome";
            this.lblApostaNome.Size = new System.Drawing.Size(39, 13);
            this.lblApostaNome.TabIndex = 4;
            this.lblApostaNome.Text = "[nome]";
            // 
            // rbtAlfredo
            // 
            this.rbtAlfredo.AutoSize = true;
            this.rbtAlfredo.Location = new System.Drawing.Point(9, 135);
            this.rbtAlfredo.Name = "rbtAlfredo";
            this.rbtAlfredo.Size = new System.Drawing.Size(58, 17);
            this.rbtAlfredo.TabIndex = 3;
            this.rbtAlfredo.TabStop = true;
            this.rbtAlfredo.Text = "Alfredo";
            this.rbtAlfredo.UseVisualStyleBackColor = true;
            this.rbtAlfredo.CheckedChanged += new System.EventHandler(this.rbtJoao_CheckedChanged);
            // 
            // rbtBeto
            // 
            this.rbtBeto.AutoSize = true;
            this.rbtBeto.Location = new System.Drawing.Point(9, 103);
            this.rbtBeto.Name = "rbtBeto";
            this.rbtBeto.Size = new System.Drawing.Size(47, 17);
            this.rbtBeto.TabIndex = 2;
            this.rbtBeto.TabStop = true;
            this.rbtBeto.Text = "Beto";
            this.rbtBeto.UseVisualStyleBackColor = true;
            this.rbtBeto.CheckedChanged += new System.EventHandler(this.rbtJoao_CheckedChanged);
            // 
            // rbtJoao
            // 
            this.rbtJoao.AutoSize = true;
            this.rbtJoao.Location = new System.Drawing.Point(9, 71);
            this.rbtJoao.Name = "rbtJoao";
            this.rbtJoao.Size = new System.Drawing.Size(48, 17);
            this.rbtJoao.TabIndex = 1;
            this.rbtJoao.TabStop = true;
            this.rbtJoao.Text = "João";
            this.rbtJoao.UseVisualStyleBackColor = true;
            this.rbtJoao.CheckedChanged += new System.EventHandler(this.rbtJoao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aposta Minima:  R$5";
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(41, 23);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(76, 37);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(41, 79);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(76, 37);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 3;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(41, 142);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(76, 37);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 4;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(41, 204);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(76, 37);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 5;
            this.pic4.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 509);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Um dia de Corridas!";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Button btnAposta;
        private System.Windows.Forms.Label lblApostaNome;
        private System.Windows.Forms.RadioButton rbtAlfredo;
        private System.Windows.Forms.RadioButton rbtBeto;
        private System.Windows.Forms.RadioButton rbtJoao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.Label lblAlfredo;
        private System.Windows.Forms.Label lblBeto;
        private System.Windows.Forms.Label lblJoao;
    }
}

