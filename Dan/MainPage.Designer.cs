
namespace Dan
{
    partial class MainPage
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
            this.btnAddBg = new System.Windows.Forms.Button();
            this.btnClearSegments = new System.Windows.Forms.Button();
            this.btnPrintSegment = new System.Windows.Forms.Button();
            this.lbSegments = new System.Windows.Forms.ListBox();
            this.btnAddSegment = new System.Windows.Forms.Button();
            this.txtMainName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddBg
            // 
            this.btnAddBg.Location = new System.Drawing.Point(295, 104);
            this.btnAddBg.Name = "btnAddBg";
            this.btnAddBg.Size = new System.Drawing.Size(99, 23);
            this.btnAddBg.TabIndex = 0;
            this.btnAddBg.Text = "add bg";
            this.btnAddBg.UseVisualStyleBackColor = true;
            // 
            // btnClearSegments
            // 
            this.btnClearSegments.Location = new System.Drawing.Point(295, 133);
            this.btnClearSegments.Name = "btnClearSegments";
            this.btnClearSegments.Size = new System.Drawing.Size(99, 23);
            this.btnClearSegments.TabIndex = 1;
            this.btnClearSegments.Text = "clear segments";
            this.btnClearSegments.UseVisualStyleBackColor = true;
            this.btnClearSegments.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrintSegment
            // 
            this.btnPrintSegment.Location = new System.Drawing.Point(295, 162);
            this.btnPrintSegment.Name = "btnPrintSegment";
            this.btnPrintSegment.Size = new System.Drawing.Size(99, 23);
            this.btnPrintSegment.TabIndex = 2;
            this.btnPrintSegment.Text = "print/save";
            this.btnPrintSegment.UseVisualStyleBackColor = true;
            // 
            // lbSegments
            // 
            this.lbSegments.FormattingEnabled = true;
            this.lbSegments.ItemHeight = 15;
            this.lbSegments.Location = new System.Drawing.Point(12, 61);
            this.lbSegments.Name = "lbSegments";
            this.lbSegments.Size = new System.Drawing.Size(277, 124);
            this.lbSegments.TabIndex = 3;
            // 
            // btnAddSegment
            // 
            this.btnAddSegment.Location = new System.Drawing.Point(295, 61);
            this.btnAddSegment.Name = "btnAddSegment";
            this.btnAddSegment.Size = new System.Drawing.Size(99, 23);
            this.btnAddSegment.TabIndex = 4;
            this.btnAddSegment.Text = "Add segment";
            this.btnAddSegment.UseVisualStyleBackColor = true;
            this.btnAddSegment.Click += new System.EventHandler(this.btnAddSegment_Click);
            // 
            // txtMainName
            // 
            this.txtMainName.Location = new System.Drawing.Point(87, 12);
            this.txtMainName.Name = "txtMainName";
            this.txtMainName.Size = new System.Drawing.Size(167, 23);
            this.txtMainName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name ";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMainName);
            this.Controls.Add(this.btnAddSegment);
            this.Controls.Add(this.lbSegments);
            this.Controls.Add(this.btnPrintSegment);
            this.Controls.Add(this.btnClearSegments);
            this.Controls.Add(this.btnAddBg);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBg;
        private System.Windows.Forms.Button btnClearSegments;
        private System.Windows.Forms.Button btnPrintSegment;
        private System.Windows.Forms.ListBox lbSegments;
        private System.Windows.Forms.Button btnAddSegment;
        private System.Windows.Forms.TextBox txtMainName;
        private System.Windows.Forms.Label label1;
    }
}