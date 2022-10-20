
namespace Clicker
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
            this.btn = new System.Windows.Forms.Button();
            this.labelInst = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.numGameLength = new System.Windows.Forms.NumericUpDown();
            this.labelKerdes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGameLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(300, 276);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(50, 50);
            this.btn.TabIndex = 0;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // labelInst
            // 
            this.labelInst.AutoSize = true;
            this.labelInst.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInst.Location = new System.Drawing.Point(187, 64);
            this.labelInst.Name = "labelInst";
            this.labelInst.Size = new System.Drawing.Size(292, 20);
            this.labelInst.TabIndex = 1;
            this.labelInst.Text = "Kattintson a gombra a játék elkezdéséhez";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.Location = new System.Drawing.Point(12, 9);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(17, 20);
            this.labelSeconds.TabIndex = 2;
            this.labelSeconds.Text = "0";
            // 
            // numGameLength
            // 
            this.numGameLength.Location = new System.Drawing.Point(624, 12);
            this.numGameLength.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numGameLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGameLength.Name = "numGameLength";
            this.numGameLength.Size = new System.Drawing.Size(48, 20);
            this.numGameLength.TabIndex = 3;
            this.numGameLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelKerdes
            // 
            this.labelKerdes.AutoSize = true;
            this.labelKerdes.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKerdes.Location = new System.Drawing.Point(355, 12);
            this.labelKerdes.Name = "labelKerdes";
            this.labelKerdes.Size = new System.Drawing.Size(263, 20);
            this.labelKerdes.TabIndex = 4;
            this.labelKerdes.Text = "Hány másodpercig szeretne játszani?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.labelKerdes);
            this.Controls.Add(this.numGameLength);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelInst);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numGameLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label labelInst;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.NumericUpDown numGameLength;
        private System.Windows.Forms.Label labelKerdes;
    }
}

