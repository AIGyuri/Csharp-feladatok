namespace OrvosiNobeldijasokGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNobelEv = new System.Windows.Forms.TextBox();
            this.textBoxNobelNev = new System.Windows.Forms.TextBox();
            this.textBoxNobelSzulHal = new System.Windows.Forms.TextBox();
            this.textBoxNobelOrszag = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sz/H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország";
            // 
            // textBoxNobelEv
            // 
            this.textBoxNobelEv.Location = new System.Drawing.Point(138, 56);
            this.textBoxNobelEv.Name = "textBoxNobelEv";
            this.textBoxNobelEv.Size = new System.Drawing.Size(100, 20);
            this.textBoxNobelEv.TabIndex = 4;
            // 
            // textBoxNobelNev
            // 
            this.textBoxNobelNev.Location = new System.Drawing.Point(138, 102);
            this.textBoxNobelNev.Name = "textBoxNobelNev";
            this.textBoxNobelNev.Size = new System.Drawing.Size(212, 20);
            this.textBoxNobelNev.TabIndex = 5;
            // 
            // textBoxNobelSzulHal
            // 
            this.textBoxNobelSzulHal.Location = new System.Drawing.Point(138, 147);
            this.textBoxNobelSzulHal.Name = "textBoxNobelSzulHal";
            this.textBoxNobelSzulHal.Size = new System.Drawing.Size(144, 20);
            this.textBoxNobelSzulHal.TabIndex = 6;
            // 
            // textBoxNobelOrszag
            // 
            this.textBoxNobelOrszag.Location = new System.Drawing.Point(138, 188);
            this.textBoxNobelOrszag.Name = "textBoxNobelOrszag";
            this.textBoxNobelOrszag.Size = new System.Drawing.Size(100, 20);
            this.textBoxNobelOrszag.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(169, 268);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(148, 30);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Adatok mentése";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 329);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxNobelOrszag);
            this.Controls.Add(this.textBoxNobelSzulHal);
            this.Controls.Add(this.textBoxNobelNev);
            this.Controls.Add(this.textBoxNobelEv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNobelEv;
        private System.Windows.Forms.TextBox textBoxNobelNev;
        private System.Windows.Forms.TextBox textBoxNobelSzulHal;
        private System.Windows.Forms.TextBox textBoxNobelOrszag;
        private System.Windows.Forms.Button buttonSave;
    }
}

