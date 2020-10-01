namespace Felhantering1
{
    partial class ErrorForm
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
            this.txtTal1 = new System.Windows.Forms.TextBox();
            this.txtTal2 = new System.Windows.Forms.TextBox();
            this.btnTestCode = new System.Windows.Forms.Button();
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTal1
            // 
            this.txtTal1.Location = new System.Drawing.Point(286, 43);
            this.txtTal1.Multiline = true;
            this.txtTal1.Name = "txtTal1";
            this.txtTal1.Size = new System.Drawing.Size(224, 34);
            this.txtTal1.TabIndex = 0;
            // 
            // txtTal2
            // 
            this.txtTal2.Location = new System.Drawing.Point(286, 110);
            this.txtTal2.Multiline = true;
            this.txtTal2.Name = "txtTal2";
            this.txtTal2.Size = new System.Drawing.Size(224, 37);
            this.txtTal2.TabIndex = 1;
            // 
            // btnTestCode
            // 
            this.btnTestCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestCode.Location = new System.Drawing.Point(323, 206);
            this.btnTestCode.Name = "btnTestCode";
            this.btnTestCode.Size = new System.Drawing.Size(120, 86);
            this.btnTestCode.TabIndex = 2;
            this.btnTestCode.Text = "Kör koden";
            this.btnTestCode.UseVisualStyleBackColor = true;
            this.btnTestCode.Click += new System.EventHandler(this.btnTestCode_Click);
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(146, 57);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(95, 20);
            this.lblTal1.TabIndex = 3;
            this.lblTal1.Text = "Mata in tal 1";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(146, 127);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(95, 20);
            this.lblTal2.TabIndex = 4;
            this.lblTal2.Text = "Mata in tal 2";
            this.lblTal2.Click += new System.EventHandler(this.lblTal2_Click);
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Location = new System.Drawing.Point(85, 359);
            this.lblErrorCode.Margin = new System.Windows.Forms.Padding(3);
            this.lblErrorCode.Name = "lblErrorCode";
            this.lblErrorCode.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Error:";
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorCode);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Controls.Add(this.btnTestCode);
            this.Controls.Add(this.txtTal2);
            this.Controls.Add(this.txtTal1);
            this.Name = "ErrorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTal1;
        private System.Windows.Forms.TextBox txtTal2;
        private System.Windows.Forms.Button btnTestCode;
        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.Label lblErrorCode;
        private System.Windows.Forms.Label label1;
    }
}

