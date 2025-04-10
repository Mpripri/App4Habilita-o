namespace App4Habilitação
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblIdade = new Label();
            txtIdade = new TextBox();
            lblTipo = new Label();
            txtTipo = new TextBox();
            bntVerificar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(351, 59);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(319, 91);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(351, 144);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(39, 15);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "Idade:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(319, 182);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(293, 226);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(162, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de carteira(A,B,C,D ou E)";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(319, 267);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 5;
            // 
            // bntVerificar
            // 
            bntVerificar.Location = new Point(330, 327);
            bntVerificar.Name = "bntVerificar";
            bntVerificar.Size = new Size(75, 23);
            bntVerificar.TabIndex = 6;
            bntVerificar.Text = "Verificar";
            bntVerificar.UseVisualStyleBackColor = true;
            bntVerificar.Click += bntVerificar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(351, 376);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "label1";
            lblResultado.Visible = false;
            lblResultado.Click += lblResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(bntVerificar);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtIdade);
            Controls.Add(lblIdade);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblIdade;
        private TextBox txtIdade;
        private Label lblTipo;
        private TextBox txtTipo;
        private Button bntVerificar;
        private Label lblResultado;
    }
}
