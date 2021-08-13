
namespace pessoaanimal
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
            this.labeltitulo = new System.Windows.Forms.Label();
            this.btmVerificar = new System.Windows.Forms.Button();
            this.labelPessoa = new System.Windows.Forms.Label();
            this.labelAnimal = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEnd = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.textSexy = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltitulo.Location = new System.Drawing.Point(347, 25);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(87, 25);
            this.labeltitulo.TabIndex = 0;
            this.labeltitulo.Text = "Cadastro";
            this.labeltitulo.Click += new System.EventHandler(this.labeltitulo_Click);
            // 
            // btmVerificar
            // 
            this.btmVerificar.Location = new System.Drawing.Point(347, 388);
            this.btmVerificar.Name = "btmVerificar";
            this.btmVerificar.Size = new System.Drawing.Size(106, 23);
            this.btmVerificar.TabIndex = 2;
            this.btmVerificar.Text = "Verificar Animal";
            this.btmVerificar.UseVisualStyleBackColor = true;
            this.btmVerificar.Click += new System.EventHandler(this.btmVerificar_Click);
            // 
            // labelPessoa
            // 
            this.labelPessoa.AutoSize = true;
            this.labelPessoa.Location = new System.Drawing.Point(101, 61);
            this.labelPessoa.Name = "labelPessoa";
            this.labelPessoa.Size = new System.Drawing.Size(43, 15);
            this.labelPessoa.TabIndex = 3;
            this.labelPessoa.Text = "Pessoa";
            // 
            // labelAnimal
            // 
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Location = new System.Drawing.Point(672, 61);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(45, 15);
            this.labelAnimal.TabIndex = 4;
            this.labelAnimal.Text = "Animal";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(24, 140);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(24, 204);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(56, 15);
            this.labelEnd.TabIndex = 6;
            this.labelEnd.Text = "Endereço";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(24, 281);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(51, 15);
            this.labelTel.TabIndex = 7;
            this.labelTel.Text = "Telefone";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(138, 132);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 23);
            this.textNome.TabIndex = 8;
            // 
            // textEnd
            // 
            this.textEnd.Location = new System.Drawing.Point(138, 204);
            this.textEnd.Name = "textEnd";
            this.textEnd.Size = new System.Drawing.Size(100, 23);
            this.textEnd.TabIndex = 9;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(138, 273);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(100, 23);
            this.textTel.TabIndex = 10;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(553, 140);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(30, 15);
            this.labelTipo.TabIndex = 11;
            this.labelTipo.Text = "Tipo";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(553, 204);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(32, 15);
            this.labelSex.TabIndex = 12;
            this.labelSex.Text = "Sexo";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(553, 265);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(36, 15);
            this.labelIdade.TabIndex = 13;
            this.labelIdade.Text = "Idade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nome";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(704, 132);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 23);
            this.textType.TabIndex = 15;
            // 
            // textSexy
            // 
            this.textSexy.Location = new System.Drawing.Point(704, 196);
            this.textSexy.Name = "textSexy";
            this.textSexy.Size = new System.Drawing.Size(100, 23);
            this.textSexy.TabIndex = 16;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(704, 257);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 23);
            this.textAge.TabIndex = 17;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(704, 324);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textSexy);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textEnd);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelAnimal);
            this.Controls.Add(this.labelPessoa);
            this.Controls.Add(this.btmVerificar);
            this.Controls.Add(this.labeltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Button btmVerificar;
        private System.Windows.Forms.Label labelPessoa;
        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEnd;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textSexy;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textName;
    }
}

