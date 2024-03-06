namespace OTS2023_ConventorApp
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
            this.btnTest = new System.Windows.Forms.Button();
            this.rdnMass = new System.Windows.Forms.RadioButton();
            this.rdnLength = new System.Windows.Forms.RadioButton();
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(366, 309);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Convert";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // rdnMass
            // 
            this.rdnMass.AutoSize = true;
            this.rdnMass.Location = new System.Drawing.Point(100, 65);
            this.rdnMass.Name = "rdnMass";
            this.rdnMass.Size = new System.Drawing.Size(50, 17);
            this.rdnMass.TabIndex = 1;
            this.rdnMass.TabStop = true;
            this.rdnMass.Text = "Mass";
            this.rdnMass.UseVisualStyleBackColor = true;
            this.rdnMass.CheckedChanged += new System.EventHandler(this.rdnMass_CheckedChanged);
            // 
            // rdnLength
            // 
            this.rdnLength.AutoSize = true;
            this.rdnLength.Location = new System.Drawing.Point(100, 89);
            this.rdnLength.Name = "rdnLength";
            this.rdnLength.Size = new System.Drawing.Size(58, 17);
            this.rdnLength.TabIndex = 2;
            this.rdnLength.TabStop = true;
            this.rdnLength.Text = "Length";
            this.rdnLength.UseVisualStyleBackColor = true;
            this.rdnLength.CheckedChanged += new System.EventHandler(this.rdnLength_CheckedChanged);
            // 
            // txtUnos
            // 
            this.txtUnos.Location = new System.Drawing.Point(341, 169);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(100, 20);
            this.txtUnos.TabIndex = 3;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(341, 204);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(100, 20);
            this.txtRezultat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtUnos);
            this.Controls.Add(this.rdnLength);
            this.Controls.Add(this.rdnMass);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RadioButton rdnMass;
        private System.Windows.Forms.RadioButton rdnLength;
        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

