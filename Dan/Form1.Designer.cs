
namespace Dan
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numParts = new System.Windows.Forms.NumericUpDown();
            this.btnCont = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // edtName
            // 
            this.edtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtName.Location = new System.Drawing.Point(117, 6);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(162, 24);
            this.edtName.TabIndex = 1;
            // 
            // edtSurname
            // 
            this.edtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtSurname.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtSurname.Location = new System.Drawing.Point(117, 35);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(162, 24);
            this.edtSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Program Parts:";
            // 
            // numParts
            // 
            this.numParts.BackColor = System.Drawing.Color.White;
            this.numParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numParts.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numParts.Location = new System.Drawing.Point(117, 65);
            this.numParts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numParts.Name = "numParts";
            this.numParts.Size = new System.Drawing.Size(162, 24);
            this.numParts.TabIndex = 6;
            this.numParts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.White;
            this.btnCont.CausesValidation = false;
            this.btnCont.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btnCont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCont.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCont.Location = new System.Drawing.Point(189, 98);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(90, 30);
            this.btnCont.TabIndex = 7;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.BtnCont_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(290, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.numParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Cray Man Builder - Start";
            ((System.ComponentModel.ISupportInitialize)(this.numParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numParts;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button button1;
    }
}

