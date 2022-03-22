namespace TrabalhoConversao
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.comboBoxBaseValor = new System.Windows.Forms.ComboBox();
            this.comboBoxBaseConvert = new System.Windows.Forms.ComboBox();
            this.textBoxValorConvert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxResultado = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConverter);
            this.panel1.Controls.Add(this.comboBoxBaseValor);
            this.panel1.Controls.Add(this.comboBoxBaseConvert);
            this.panel1.Controls.Add(this.textBoxValorConvert);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 138);
            this.panel1.TabIndex = 0;
            // 
            // buttonConverter
            // 
            this.buttonConverter.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConverter.Location = new System.Drawing.Point(393, 65);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(149, 29);
            this.buttonConverter.TabIndex = 6;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // comboBoxBaseValor
            // 
            this.comboBoxBaseValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaseValor.FormattingEnabled = true;
            this.comboBoxBaseValor.Items.AddRange(new object[] {
            "Binário",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.comboBoxBaseValor.Location = new System.Drawing.Point(624, 23);
            this.comboBoxBaseValor.Name = "comboBoxBaseValor";
            this.comboBoxBaseValor.Size = new System.Drawing.Size(153, 21);
            this.comboBoxBaseValor.TabIndex = 5;
            // 
            // comboBoxBaseConvert
            // 
            this.comboBoxBaseConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaseConvert.FormattingEnabled = true;
            this.comboBoxBaseConvert.Items.AddRange(new object[] {
            "Binário",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.comboBoxBaseConvert.Location = new System.Drawing.Point(177, 69);
            this.comboBoxBaseConvert.Name = "comboBoxBaseConvert";
            this.comboBoxBaseConvert.Size = new System.Drawing.Size(153, 21);
            this.comboBoxBaseConvert.TabIndex = 4;
            // 
            // textBoxValorConvert
            // 
            this.textBoxValorConvert.Location = new System.Drawing.Point(146, 23);
            this.textBoxValorConvert.Name = "textBoxValorConvert";
            this.textBoxValorConvert.Size = new System.Drawing.Size(263, 20);
            this.textBoxValorConvert.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informe a base do valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base para converter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a converter:";
            // 
            // richTextBoxResultado
            // 
            this.richTextBoxResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResultado.Location = new System.Drawing.Point(0, 138);
            this.richTextBoxResultado.Name = "richTextBoxResultado";
            this.richTextBoxResultado.Size = new System.Drawing.Size(800, 312);
            this.richTextBoxResultado.TabIndex = 1;
            this.richTextBoxResultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxResultado);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão entre bases númericas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxResultado;
        private System.Windows.Forms.TextBox textBoxValorConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBaseConvert;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.ComboBox comboBoxBaseValor;
    }
}

