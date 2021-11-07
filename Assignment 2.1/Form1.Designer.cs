
namespace Assignment_2._1
{
    partial class MotgageCalculator
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
            this.lblInitPrincipal = new System.Windows.Forms.Label();
            this.lblMonPayment = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblAnnualIntRate = new System.Windows.Forms.Label();
            this.txtInitPrincipal = new System.Windows.Forms.TextBox();
            this.txtAnnualIntRate = new System.Windows.Forms.TextBox();
            this.txtMonPayment = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInitPrincipal
            // 
            this.lblInitPrincipal.AutoSize = true;
            this.lblInitPrincipal.Location = new System.Drawing.Point(21, 25);
            this.lblInitPrincipal.Name = "lblInitPrincipal";
            this.lblInitPrincipal.Size = new System.Drawing.Size(89, 13);
            this.lblInitPrincipal.TabIndex = 0;
            this.lblInitPrincipal.Text = "Initial Principal ($)";
            // 
            // lblMonPayment
            // 
            this.lblMonPayment.AutoSize = true;
            this.lblMonPayment.Location = new System.Drawing.Point(21, 166);
            this.lblMonPayment.Name = "lblMonPayment";
            this.lblMonPayment.Size = new System.Drawing.Size(103, 13);
            this.lblMonPayment.TabIndex = 1;
            this.lblMonPayment.Text = "Monthly Payment ($)";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(21, 77);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(67, 13);
            this.lblTerm.TabIndex = 2;
            this.lblTerm.Text = "Term (Years)";
            // 
            // lblAnnualIntRate
            // 
            this.lblAnnualIntRate.AutoSize = true;
            this.lblAnnualIntRate.Location = new System.Drawing.Point(21, 51);
            this.lblAnnualIntRate.Name = "lblAnnualIntRate";
            this.lblAnnualIntRate.Size = new System.Drawing.Size(121, 13);
            this.lblAnnualIntRate.TabIndex = 3;
            this.lblAnnualIntRate.Text = "Annual Interest Rate (%)";
            // 
            // txtInitPrincipal
            // 
            this.txtInitPrincipal.Location = new System.Drawing.Point(157, 22);
            this.txtInitPrincipal.Name = "txtInitPrincipal";
            this.txtInitPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtInitPrincipal.TabIndex = 4;
            this.txtInitPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnnualIntRate
            // 
            this.txtAnnualIntRate.Location = new System.Drawing.Point(157, 48);
            this.txtAnnualIntRate.Name = "txtAnnualIntRate";
            this.txtAnnualIntRate.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualIntRate.TabIndex = 5;
            this.txtAnnualIntRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonPayment
            // 
            this.txtMonPayment.Location = new System.Drawing.Point(157, 163);
            this.txtMonPayment.Name = "txtMonPayment";
            this.txtMonPayment.Size = new System.Drawing.Size(100, 20);
            this.txtMonPayment.TabIndex = 6;
            this.txtMonPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(157, 74);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 20);
            this.txtTerm.TabIndex = 7;
            this.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(106, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // MotgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 235);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtMonPayment);
            this.Controls.Add(this.txtAnnualIntRate);
            this.Controls.Add(this.txtInitPrincipal);
            this.Controls.Add(this.lblAnnualIntRate);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblMonPayment);
            this.Controls.Add(this.lblInitPrincipal);
            this.Name = "MotgageCalculator";
            this.Text = "Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitPrincipal;
        private System.Windows.Forms.Label lblMonPayment;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblAnnualIntRate;
        private System.Windows.Forms.TextBox txtInitPrincipal;
        private System.Windows.Forms.TextBox txtAnnualIntRate;
        private System.Windows.Forms.TextBox txtMonPayment;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Button btnCalculate;
    }
}

