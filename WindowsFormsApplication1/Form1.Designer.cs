namespace WindowsFormsApplication1
{
    partial class TicTacToe
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
            this.a11 = new System.Windows.Forms.TextBox();
            this.a12 = new System.Windows.Forms.TextBox();
            this.a13 = new System.Windows.Forms.TextBox();
            this.a21 = new System.Windows.Forms.TextBox();
            this.a22 = new System.Windows.Forms.TextBox();
            this.a23 = new System.Windows.Forms.TextBox();
            this.a31 = new System.Windows.Forms.TextBox();
            this.a32 = new System.Windows.Forms.TextBox();
            this.a33 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a11
            // 
            this.a11.Location = new System.Drawing.Point(86, 85);
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(25, 20);
            this.a11.TabIndex = 0;
            this.a11.TextChanged += new System.EventHandler(this.a11_TextChanged);
            // 
            // a12
            // 
            this.a12.Location = new System.Drawing.Point(117, 85);
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(25, 20);
            this.a12.TabIndex = 1;
            this.a12.TextChanged += new System.EventHandler(this.a12_TextChanged);
            // 
            // a13
            // 
            this.a13.Location = new System.Drawing.Point(148, 85);
            this.a13.Name = "a13";
            this.a13.Size = new System.Drawing.Size(25, 20);
            this.a13.TabIndex = 2;
            this.a13.TextChanged += new System.EventHandler(this.a13_TextChanged);
            // 
            // a21
            // 
            this.a21.Location = new System.Drawing.Point(86, 111);
            this.a21.Name = "a21";
            this.a21.Size = new System.Drawing.Size(25, 20);
            this.a21.TabIndex = 3;
            this.a21.TextChanged += new System.EventHandler(this.a21_TextChanged);
            // 
            // a22
            // 
            this.a22.Location = new System.Drawing.Point(117, 111);
            this.a22.Name = "a22";
            this.a22.Size = new System.Drawing.Size(25, 20);
            this.a22.TabIndex = 4;
            this.a22.TextChanged += new System.EventHandler(this.a22_TextChanged);
            // 
            // a23
            // 
            this.a23.Location = new System.Drawing.Point(148, 111);
            this.a23.Name = "a23";
            this.a23.Size = new System.Drawing.Size(25, 20);
            this.a23.TabIndex = 5;
            this.a23.TextChanged += new System.EventHandler(this.a23_TextChanged);
            // 
            // a31
            // 
            this.a31.Location = new System.Drawing.Point(86, 137);
            this.a31.Name = "a31";
            this.a31.Size = new System.Drawing.Size(25, 20);
            this.a31.TabIndex = 6;
            this.a31.TextChanged += new System.EventHandler(this.a31_TextChanged);
            // 
            // a32
            // 
            this.a32.Location = new System.Drawing.Point(117, 137);
            this.a32.Name = "a32";
            this.a32.Size = new System.Drawing.Size(25, 20);
            this.a32.TabIndex = 7;
            this.a32.TextChanged += new System.EventHandler(this.a32_TextChanged);
            // 
            // a33
            // 
            this.a33.Location = new System.Drawing.Point(148, 137);
            this.a33.Name = "a33";
            this.a33.Size = new System.Drawing.Size(25, 20);
            this.a33.TabIndex = 8;
            this.a33.TextChanged += new System.EventHandler(this.a33_TextChanged);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(114, 179);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter \'o\' or \'x\' to play";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.a33);
            this.Controls.Add(this.a32);
            this.Controls.Add(this.a31);
            this.Controls.Add(this.a23);
            this.Controls.Add(this.a22);
            this.Controls.Add(this.a21);
            this.Controls.Add(this.a13);
            this.Controls.Add(this.a12);
            this.Controls.Add(this.a11);
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a11;
        private System.Windows.Forms.TextBox a12;
        private System.Windows.Forms.TextBox a13;
        private System.Windows.Forms.TextBox a21;
        private System.Windows.Forms.TextBox a22;
        private System.Windows.Forms.TextBox a23;
        private System.Windows.Forms.TextBox a31;
        private System.Windows.Forms.TextBox a32;
        private System.Windows.Forms.TextBox a33;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label1;
    }
}

