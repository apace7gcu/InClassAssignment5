namespace InClassAssignment5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTerms = new System.Windows.Forms.Label();
            this.bttnCalculate = new System.Windows.Forms.Button();
            this.lblTermDisplay = new System.Windows.Forms.Label();
            this.lblPiDisplay = new System.Windows.Forms.Label();
            this.txtEnterTerms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTerms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTerms.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTerms.Image = ((System.Drawing.Image)(resources.GetObject("lblTerms.Image")));
            this.lblTerms.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTerms.Location = new System.Drawing.Point(102, 9);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(184, 108);
            this.lblTerms.TabIndex = 0;
            this.lblTerms.Text = "Enter # of terms:";
            // 
            // bttnCalculate
            // 
            this.bttnCalculate.BackColor = System.Drawing.Color.LightBlue;
            this.bttnCalculate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCalculate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bttnCalculate.Location = new System.Drawing.Point(356, 173);
            this.bttnCalculate.Name = "bttnCalculate";
            this.bttnCalculate.Size = new System.Drawing.Size(157, 59);
            this.bttnCalculate.TabIndex = 2;
            this.bttnCalculate.Text = "CALCULATE";
            this.bttnCalculate.UseVisualStyleBackColor = false;
            this.bttnCalculate.Click += new System.EventHandler(this.bttnCalculate_Click);
            // 
            // lblTermDisplay
            // 
            this.lblTermDisplay.AutoSize = true;
            this.lblTermDisplay.Font = new System.Drawing.Font("Cambria Math", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermDisplay.ForeColor = System.Drawing.Color.Gray;
            this.lblTermDisplay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTermDisplay.Location = new System.Drawing.Point(12, 227);
            this.lblTermDisplay.Name = "lblTermDisplay";
            this.lblTermDisplay.Size = new System.Drawing.Size(0, 117);
            this.lblTermDisplay.TabIndex = 3;
            // 
            // lblPiDisplay
            // 
            this.lblPiDisplay.AutoSize = true;
            this.lblPiDisplay.Font = new System.Drawing.Font("Cambria Math", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiDisplay.ForeColor = System.Drawing.Color.Gray;
            this.lblPiDisplay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPiDisplay.Location = new System.Drawing.Point(174, 324);
            this.lblPiDisplay.Name = "lblPiDisplay";
            this.lblPiDisplay.Size = new System.Drawing.Size(0, 117);
            this.lblPiDisplay.TabIndex = 4;
            // 
            // txtEnterTerms
            // 
            this.txtEnterTerms.BackColor = System.Drawing.Color.LightCyan;
            this.txtEnterTerms.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterTerms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEnterTerms.Location = new System.Drawing.Point(330, 48);
            this.txtEnterTerms.Name = "txtEnterTerms";
            this.txtEnterTerms.Size = new System.Drawing.Size(100, 31);
            this.txtEnterTerms.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.txtEnterTerms);
            this.Controls.Add(this.lblPiDisplay);
            this.Controls.Add(this.lblTermDisplay);
            this.Controls.Add(this.bttnCalculate);
            this.Controls.Add(this.lblTerms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Button bttnCalculate;
        private System.Windows.Forms.Label lblTermDisplay;
        private System.Windows.Forms.Label lblPiDisplay;
        private System.Windows.Forms.TextBox txtEnterTerms;
    }
}

