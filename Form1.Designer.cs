
namespace WinFormGrades_If
{
    partial class GradeCalculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbxGrade = new System.Windows.Forms.ListBox();
            this.lblDataError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Orange;
            this.btnCalculate.Location = new System.Drawing.Point(46, 42);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(169, 65);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate This!";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtGrade.Location = new System.Drawing.Point(300, 42);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(115, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtName.Location = new System.Drawing.Point(300, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 2;
            // 
            // lbxGrade
            // 
            this.lbxGrade.BackColor = System.Drawing.Color.DarkSalmon;
            this.lbxGrade.FormattingEnabled = true;
            this.lbxGrade.Location = new System.Drawing.Point(46, 140);
            this.lbxGrade.Name = "lbxGrade";
            this.lbxGrade.Size = new System.Drawing.Size(169, 95);
            this.lbxGrade.TabIndex = 3;
            // 
            // lblDataError
            // 
            this.lblDataError.BackColor = System.Drawing.Color.Yellow;
            this.lblDataError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDataError.ForeColor = System.Drawing.Color.Red;
            this.lblDataError.Location = new System.Drawing.Point(300, 157);
            this.lblDataError.Name = "lblDataError";
            this.lblDataError.Size = new System.Drawing.Size(115, 78);
            this.lblDataError.TabIndex = 4;
            this.lblDataError.Text = "Error";
            // 
            // GradeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(471, 269);
            this.Controls.Add(this.lblDataError);
            this.Controls.Add(this.lbxGrade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnCalculate);
            this.Name = "GradeCalculator";
            this.Text = "Calculate Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lbxGrade;
        private System.Windows.Forms.Label lblDataError;
    }
}

