namespace Calculadora_Cientifica
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
            this.result_panel = new System.Windows.Forms.Panel();
            this.txt_values = new System.Windows.Forms.TextBox();
            this.buttom_panel = new System.Windows.Forms.Panel();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_operator4 = new System.Windows.Forms.Button();
            this.btn_operator3 = new System.Windows.Forms.Button();
            this.btn_operator2 = new System.Windows.Forms.Button();
            this.btn_operator1 = new System.Windows.Forms.Button();
            this.btn_number0 = new System.Windows.Forms.Button();
            this.btn_number9 = new System.Windows.Forms.Button();
            this.btn_number6 = new System.Windows.Forms.Button();
            this.btn_number8 = new System.Windows.Forms.Button();
            this.btn_number4 = new System.Windows.Forms.Button();
            this.btn_number2 = new System.Windows.Forms.Button();
            this.btn_number7 = new System.Windows.Forms.Button();
            this.btn_number5 = new System.Windows.Forms.Button();
            this.btn_number3 = new System.Windows.Forms.Button();
            this.btn_number1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esvaziar1ElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esvaziarAPilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.result_number = new System.Windows.Forms.Label();
            this.result_panel.SuspendLayout();
            this.buttom_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result_panel
            // 
            this.result_panel.Controls.Add(this.result_number);
            this.result_panel.Controls.Add(this.txt_values);
            this.result_panel.Controls.Add(this.label1);
            this.result_panel.Location = new System.Drawing.Point(12, 49);
            this.result_panel.Name = "result_panel";
            this.result_panel.Size = new System.Drawing.Size(284, 108);
            this.result_panel.TabIndex = 18;
            // 
            // txt_values
            // 
            this.txt_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_values.Location = new System.Drawing.Point(0, 3);
            this.txt_values.Name = "txt_values";
            this.txt_values.Size = new System.Drawing.Size(284, 50);
            this.txt_values.TabIndex = 0;
            this.txt_values.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttom_panel
            // 
            this.buttom_panel.Controls.Add(this.btn_enter);
            this.buttom_panel.Controls.Add(this.btn_operator4);
            this.buttom_panel.Controls.Add(this.btn_operator3);
            this.buttom_panel.Controls.Add(this.btn_operator2);
            this.buttom_panel.Controls.Add(this.btn_operator1);
            this.buttom_panel.Controls.Add(this.btn_number0);
            this.buttom_panel.Controls.Add(this.btn_number9);
            this.buttom_panel.Controls.Add(this.btn_number6);
            this.buttom_panel.Controls.Add(this.btn_number8);
            this.buttom_panel.Controls.Add(this.btn_number4);
            this.buttom_panel.Controls.Add(this.btn_number2);
            this.buttom_panel.Controls.Add(this.btn_number7);
            this.buttom_panel.Controls.Add(this.btn_number5);
            this.buttom_panel.Controls.Add(this.btn_number3);
            this.buttom_panel.Controls.Add(this.btn_number1);
            this.buttom_panel.Location = new System.Drawing.Point(12, 163);
            this.buttom_panel.Name = "buttom_panel";
            this.buttom_panel.Size = new System.Drawing.Size(284, 330);
            this.buttom_panel.TabIndex = 19;
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(175, 267);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(106, 60);
            this.btn_enter.TabIndex = 14;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            
            // 
            // btn_operator4
            // 
            this.btn_operator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operator4.Location = new System.Drawing.Point(175, 201);
            this.btn_operator4.Name = "btn_operator4";
            this.btn_operator4.Size = new System.Drawing.Size(106, 60);
            this.btn_operator4.TabIndex = 13;
            this.btn_operator4.Text = "/";
            this.btn_operator4.UseVisualStyleBackColor = true;
            this.btn_operator4.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_operator3
            // 
            this.btn_operator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operator3.Location = new System.Drawing.Point(175, 135);
            this.btn_operator3.Name = "btn_operator3";
            this.btn_operator3.Size = new System.Drawing.Size(106, 60);
            this.btn_operator3.TabIndex = 12;
            this.btn_operator3.Text = "*";
            this.btn_operator3.UseVisualStyleBackColor = true;
            this.btn_operator3.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_operator2
            // 
            this.btn_operator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operator2.Location = new System.Drawing.Point(175, 69);
            this.btn_operator2.Name = "btn_operator2";
            this.btn_operator2.Size = new System.Drawing.Size(106, 60);
            this.btn_operator2.TabIndex = 11;
            this.btn_operator2.Text = "-";
            this.btn_operator2.UseVisualStyleBackColor = true;
            this.btn_operator2.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_operator1
            // 
            this.btn_operator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operator1.Location = new System.Drawing.Point(175, 3);
            this.btn_operator1.Name = "btn_operator1";
            this.btn_operator1.Size = new System.Drawing.Size(106, 60);
            this.btn_operator1.TabIndex = 10;
            this.btn_operator1.Text = "+";
            this.btn_operator1.UseVisualStyleBackColor = true;
            this.btn_operator1.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_number0
            // 
            this.btn_number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number0.Location = new System.Drawing.Point(89, 267);
            this.btn_number0.Name = "btn_number0";
            this.btn_number0.Size = new System.Drawing.Size(80, 60);
            this.btn_number0.TabIndex = 9;
            this.btn_number0.Text = "0";
            this.btn_number0.UseVisualStyleBackColor = true;
            this.btn_number0.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number9
            // 
            this.btn_number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number9.Location = new System.Drawing.Point(3, 267);
            this.btn_number9.Name = "btn_number9";
            this.btn_number9.Size = new System.Drawing.Size(80, 60);
            this.btn_number9.TabIndex = 8;
            this.btn_number9.Text = "9";
            this.btn_number9.UseVisualStyleBackColor = true;
            this.btn_number9.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number6
            // 
            this.btn_number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number6.Location = new System.Drawing.Point(89, 135);
            this.btn_number6.Name = "btn_number6";
            this.btn_number6.Size = new System.Drawing.Size(80, 60);
            this.btn_number6.TabIndex = 7;
            this.btn_number6.Text = "6";
            this.btn_number6.UseVisualStyleBackColor = true;
            this.btn_number6.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number8
            // 
            this.btn_number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number8.Location = new System.Drawing.Point(89, 201);
            this.btn_number8.Name = "btn_number8";
            this.btn_number8.Size = new System.Drawing.Size(80, 60);
            this.btn_number8.TabIndex = 6;
            this.btn_number8.Text = "8";
            this.btn_number8.UseVisualStyleBackColor = true;
            this.btn_number8.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number4
            // 
            this.btn_number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number4.Location = new System.Drawing.Point(89, 69);
            this.btn_number4.Name = "btn_number4";
            this.btn_number4.Size = new System.Drawing.Size(80, 60);
            this.btn_number4.TabIndex = 5;
            this.btn_number4.Text = "4";
            this.btn_number4.UseVisualStyleBackColor = true;
            this.btn_number4.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number2
            // 
            this.btn_number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number2.Location = new System.Drawing.Point(89, 3);
            this.btn_number2.Name = "btn_number2";
            this.btn_number2.Size = new System.Drawing.Size(80, 60);
            this.btn_number2.TabIndex = 4;
            this.btn_number2.Text = "2";
            this.btn_number2.UseVisualStyleBackColor = true;
            this.btn_number2.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number7
            // 
            this.btn_number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number7.Location = new System.Drawing.Point(3, 201);
            this.btn_number7.Name = "btn_number7";
            this.btn_number7.Size = new System.Drawing.Size(80, 60);
            this.btn_number7.TabIndex = 3;
            this.btn_number7.Text = "7";
            this.btn_number7.UseVisualStyleBackColor = true;
            this.btn_number7.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number5
            // 
            this.btn_number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number5.Location = new System.Drawing.Point(3, 135);
            this.btn_number5.Name = "btn_number5";
            this.btn_number5.Size = new System.Drawing.Size(80, 60);
            this.btn_number5.TabIndex = 2;
            this.btn_number5.Text = "5";
            this.btn_number5.UseVisualStyleBackColor = true;
            this.btn_number5.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number3
            // 
            this.btn_number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number3.Location = new System.Drawing.Point(3, 69);
            this.btn_number3.Name = "btn_number3";
            this.btn_number3.Size = new System.Drawing.Size(80, 60);
            this.btn_number3.TabIndex = 1;
            this.btn_number3.Text = "3";
            this.btn_number3.UseVisualStyleBackColor = true;
            this.btn_number3.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_number1
            // 
            this.btn_number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_number1.Location = new System.Drawing.Point(3, 3);
            this.btn_number1.Name = "btn_number1";
            this.btn_number1.Size = new System.Drawing.Size(80, 60);
            this.btn_number1.TabIndex = 0;
            this.btn_number1.Text = "1";
            this.btn_number1.UseVisualStyleBackColor = true;
            this.btn_number1.Click += new System.EventHandler(this.number_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilhaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pilhaToolStripMenuItem
            // 
            this.pilhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esvaziar1ElementoToolStripMenuItem,
            this.esvaziarAPilhaToolStripMenuItem});
            this.pilhaToolStripMenuItem.Name = "pilhaToolStripMenuItem";
            this.pilhaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pilhaToolStripMenuItem.Text = "Opções";
            // 
            // esvaziar1ElementoToolStripMenuItem
            // 
            this.esvaziar1ElementoToolStripMenuItem.Name = "esvaziar1ElementoToolStripMenuItem";
            this.esvaziar1ElementoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.esvaziar1ElementoToolStripMenuItem.Text = "Limpar o último elemento";
            // 
            // esvaziarAPilhaToolStripMenuItem
            // 
            this.esvaziarAPilhaToolStripMenuItem.Name = "esvaziarAPilhaToolStripMenuItem";
            this.esvaziarAPilhaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.esvaziarAPilhaToolStripMenuItem.Text = "Esvaziar a pilha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultado:";
            // 
            // result_number
            // 
            this.result_number.AutoSize = true;
            this.result_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_number.Location = new System.Drawing.Point(91, 56);
            this.result_number.Name = "result_number";
            this.result_number.Size = new System.Drawing.Size(0, 20);
            this.result_number.TabIndex = 2;
            this.result_number.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 505);
            this.Controls.Add(this.buttom_panel);
            this.Controls.Add(this.result_panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculadora Ciêntifica";
            this.result_panel.ResumeLayout(false);
            this.result_panel.PerformLayout();
            this.buttom_panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel result_panel;
        private System.Windows.Forms.Panel buttom_panel;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_operator4;
        private System.Windows.Forms.Button btn_operator3;
        private System.Windows.Forms.Button btn_operator2;
        private System.Windows.Forms.Button btn_operator1;
        private System.Windows.Forms.Button btn_number0;
        private System.Windows.Forms.Button btn_number9;
        private System.Windows.Forms.Button btn_number6;
        private System.Windows.Forms.Button btn_number8;
        private System.Windows.Forms.Button btn_number4;
        private System.Windows.Forms.Button btn_number2;
        private System.Windows.Forms.Button btn_number7;
        private System.Windows.Forms.Button btn_number5;
        private System.Windows.Forms.Button btn_number3;
        private System.Windows.Forms.Button btn_number1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esvaziar1ElementoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esvaziarAPilhaToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_values;
        private System.Windows.Forms.Label result_number;
        private System.Windows.Forms.Label label1;
    }
}

