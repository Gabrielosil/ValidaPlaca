namespace ValidaPlaca
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
            txtPlaca = new TextBox();
            btnValidar = new Button();
            lvPlacas = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(94, 67);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(128, 23);
            txtPlaca.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(120, 111);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lvPlacas
            // 
            lvPlacas.Location = new Point(94, 175);
            lvPlacas.Name = "lvPlacas";
            lvPlacas.Size = new Size(121, 97);
            lvPlacas.TabIndex = 2;
            lvPlacas.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 157);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Placas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 284);
            Controls.Add(label1);
            Controls.Add(lvPlacas);
            Controls.Add(btnValidar);
            Controls.Add(txtPlaca);
            Name = "Form1";
            Text = "Valida Placa de Carro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaca;
        private Button btnValidar;
        private ListView lvPlacas;
        private Label label1;
    }
}
