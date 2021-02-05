
namespace Dan
{
    partial class editExercises
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
            this.lblename = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExersiceNameTxt = new System.Windows.Forms.TextBox();
            this.TipTxt = new System.Windows.Forms.TextBox();
            this.MuscleGroupCbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddExercise = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblename
            // 
            this.lblename.AutoSize = true;
            this.lblename.Location = new System.Drawing.Point(12, 9);
            this.lblename.Name = "lblename";
            this.lblename.Size = new System.Drawing.Size(81, 15);
            this.lblename.TabIndex = 0;
            this.lblename.Text = "Exersise name";
            this.lblename.Click += new System.EventHandler(this.Lblename_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(619, 429);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ExersiceNameTxt
            // 
            this.ExersiceNameTxt.Location = new System.Drawing.Point(14, 27);
            this.ExersiceNameTxt.Name = "ExersiceNameTxt";
            this.ExersiceNameTxt.Size = new System.Drawing.Size(121, 23);
            this.ExersiceNameTxt.TabIndex = 2;
            // 
            // TipTxt
            // 
            this.TipTxt.Location = new System.Drawing.Point(14, 142);
            this.TipTxt.Name = "TipTxt";
            this.TipTxt.Size = new System.Drawing.Size(122, 23);
            this.TipTxt.TabIndex = 3;
            // 
            // MuscleGroupCbb
            // 
            this.MuscleGroupCbb.FormattingEnabled = true;
            this.MuscleGroupCbb.Location = new System.Drawing.Point(14, 83);
            this.MuscleGroupCbb.Name = "MuscleGroupCbb";
            this.MuscleGroupCbb.Size = new System.Drawing.Size(121, 23);
            this.MuscleGroupCbb.TabIndex = 4;
            this.MuscleGroupCbb.SelectedIndexChanged += new System.EventHandler(this.MuscleGroupCbb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "muscle Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "tip";
            // 
            // BtnAddExercise
            // 
            this.BtnAddExercise.Location = new System.Drawing.Point(14, 190);
            this.BtnAddExercise.Name = "BtnAddExercise";
            this.BtnAddExercise.Size = new System.Drawing.Size(123, 23);
            this.BtnAddExercise.TabIndex = 7;
            this.BtnAddExercise.Text = "add exercise";
            this.BtnAddExercise.UseVisualStyleBackColor = true;
            this.BtnAddExercise.Click += new System.EventHandler(this.BtnAddExercise_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // editExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddExercise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MuscleGroupCbb);
            this.Controls.Add(this.TipTxt);
            this.Controls.Add(this.ExersiceNameTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblename);
            this.Name = "editExercises";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblename;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ExersiceNameTxt;
        private System.Windows.Forms.TextBox TipTxt;
        private System.Windows.Forms.ComboBox MuscleGroupCbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddExercise;
        private System.Windows.Forms.Label label3;
    }
}