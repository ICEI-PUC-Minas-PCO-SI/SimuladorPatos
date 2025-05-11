namespace SimuladorPatosWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBoxPatos = new ComboBox();
            btnSelecionar = new Button();
            btnNadar = new Button();
            label1 = new Label();
            btnVoar = new Button();
            btnGrasnar = new Button();
            btnChutar = new Button();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // comboBoxPatos
            // 
            comboBoxPatos.FormattingEnabled = true;
            comboBoxPatos.Items.AddRange(new object[] { "Pato Real", "Pato Cabeça Vermelha", "Pato de Borracha", "Pato Carolino", "Alexandre Pato", "Irerê", "Pato Mergulhão" });
            comboBoxPatos.Location = new Point(122, 11);
            comboBoxPatos.Name = "comboBoxPatos";
            comboBoxPatos.Size = new Size(142, 23);
            comboBoxPatos.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(54, 52);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(137, 23);
            btnSelecionar.TabIndex = 1;
            btnSelecionar.Text = "Selecionar Pato";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnNadar
            // 
            btnNadar.Location = new Point(270, 11);
            btnNadar.Name = "btnNadar";
            btnNadar.Size = new Size(77, 23);
            btnNadar.TabIndex = 2;
            btnNadar.Text = "Nadar";
            btnNadar.UseVisualStyleBackColor = true;
            btnNadar.Click += btnNadar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Selecione o Pato:";
            // 
            // btnVoar
            // 
            btnVoar.Location = new Point(270, 40);
            btnVoar.Name = "btnVoar";
            btnVoar.Size = new Size(77, 23);
            btnVoar.TabIndex = 4;
            btnVoar.Text = "Voar";
            btnVoar.UseVisualStyleBackColor = true;
            btnVoar.Click += btnVoar_Click;
            // 
            // btnGrasnar
            // 
            btnGrasnar.Location = new Point(270, 69);
            btnGrasnar.Name = "btnGrasnar";
            btnGrasnar.Size = new Size(77, 23);
            btnGrasnar.TabIndex = 5;
            btnGrasnar.Text = "Grasnar";
            btnGrasnar.UseVisualStyleBackColor = true;
            btnGrasnar.Click += btnGrasnar_Click;
            // 
            // btnChutar
            // 
            btnChutar.Location = new Point(270, 98);
            btnChutar.Name = "btnChutar";
            btnChutar.Size = new Size(77, 23);
            btnChutar.TabIndex = 6;
            btnChutar.Text = "Chutar";
            btnChutar.UseVisualStyleBackColor = true;
            btnChutar.Click += btnChutar_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(19, 140);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(328, 280);
            txtLog.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(txtLog);
            Controls.Add(btnChutar);
            Controls.Add(btnGrasnar);
            Controls.Add(btnVoar);
            Controls.Add(label1);
            Controls.Add(btnNadar);
            Controls.Add(btnSelecionar);
            Controls.Add(comboBoxPatos);
            Name = "Form1";
            Text = "Simulador de Patos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPatos;
        private Button btnSelecionar;
        private Button btnNadar;
        private Label label1;
        private Button btnVoar;
        private Button btnGrasnar;
        private Button btnChutar;
        private TextBox txtLog;
    }
}
