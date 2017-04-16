namespace natacao.cs
{
    partial class matricula
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUltimoAniversario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(58, 13);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(313, 20);
            this.textNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano Nascimento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(106, 42);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(59, 20);
            this.txtNascimento.TabIndex = 3;
            this.txtNascimento.Enter += new System.EventHandler(this.txtNascimento_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano último aniversário:";
            // 
            // txtUltimoAniversario
            // 
            this.txtUltimoAniversario.Location = new System.Drawing.Point(291, 42);
            this.txtUltimoAniversario.Name = "txtUltimoAniversario";
            this.txtUltimoAniversario.Size = new System.Drawing.Size(80, 20);
            this.txtUltimoAniversario.TabIndex = 5;
            this.txtUltimoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUltimoAniversario_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Identificar Categoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Gold;
            this.txtCategoria.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCategoria.Location = new System.Drawing.Point(258, 78);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(113, 20);
            this.txtCategoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria:";
            // 
            // matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 110);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUltimoAniversario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.Name = "matricula";
            this.Text = "Matrícula de aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUltimoAniversario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label4;
    }
}

