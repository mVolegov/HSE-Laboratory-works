using System.ComponentModel;

namespace Lab8var3.GUI
{
    partial class DeleteForm
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(55, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По номеру записи";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(55, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По id";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(175, 34);
            this.numericUpDown1.Maximum = new decimal(new int[] {2048, 0, 0, 0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(55, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер группы:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(174, 7);
            this.numericUpDown2.Maximum = new decimal(new int[] {3, 0, 0, 0});
            this.numericUpDown2.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(175, 66);
            this.numericUpDown3.Maximum = new decimal(new int[] {2048, 0, 0, 0});
            this.numericUpDown3.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "DeleteForm";
            this.Text = "Удаление студента";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown numericUpDown3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.RadioButton radioButton1;

        #endregion
    }
}