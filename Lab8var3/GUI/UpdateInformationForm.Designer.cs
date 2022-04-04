using System.ComponentModel;

namespace Lab8var3.GUI
{
    partial class UpdateInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(98, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Внести изменения";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(76, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Новая фамилия";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(76, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Новое имя";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(76, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 23);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По id студента";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(52, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 19);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По номеру записи";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(233, 118);
            this.numericUpDown3.Maximum = new decimal(new int[] {3, 0, 0, 0});
            this.numericUpDown3.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown3.TabIndex = 28;
            this.numericUpDown3.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(76, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Номер новой группы";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(231, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "в группе";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(293, 12);
            this.numericUpDown2.Maximum = new decimal(new int[] {3, 0, 0, 0});
            this.numericUpDown2.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(184, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {2048, 0, 0, 0});
            this.numericUpDown1.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 20);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(171, 12);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown4.TabIndex = 33;
            // 
            // UpdateInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 190);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "UpdateInformationForm";
            this.Text = "Обновление информации о студенте";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numericUpDown4;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;

        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;

        #endregion
    }
}