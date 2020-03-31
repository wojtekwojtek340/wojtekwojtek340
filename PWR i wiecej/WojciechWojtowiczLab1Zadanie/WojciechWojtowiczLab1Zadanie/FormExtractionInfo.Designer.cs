namespace WojciechWojtowiczLab1Zadanie
{
    partial class FormExtractionInfo
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
            this.labelGoldMineLevel = new System.Windows.Forms.Label();
            this.labelGoldMineExtraction = new System.Windows.Forms.Label();
            this.labelGoldMineExtractionNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGoldMineLevel
            // 
            this.labelGoldMineLevel.AutoSize = true;
            this.labelGoldMineLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldMineLevel.Location = new System.Drawing.Point(105, 55);
            this.labelGoldMineLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoldMineLevel.Name = "labelGoldMineLevel";
            this.labelGoldMineLevel.Size = new System.Drawing.Size(104, 31);
            this.labelGoldMineLevel.TabIndex = 0;
            this.labelGoldMineLevel.Text = "Poziom";
            // 
            // labelGoldMineExtraction
            // 
            this.labelGoldMineExtraction.AutoSize = true;
            this.labelGoldMineExtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldMineExtraction.Location = new System.Drawing.Point(39, 105);
            this.labelGoldMineExtraction.Name = "labelGoldMineExtraction";
            this.labelGoldMineExtraction.Size = new System.Drawing.Size(267, 32);
            this.labelGoldMineExtraction.TabIndex = 1;
            this.labelGoldMineExtraction.Text = "Aktualne wydobycie";
            // 
            // labelGoldMineExtractionNext
            // 
            this.labelGoldMineExtractionNext.AutoSize = true;
            this.labelGoldMineExtractionNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldMineExtractionNext.Location = new System.Drawing.Point(39, 153);
            this.labelGoldMineExtractionNext.Name = "labelGoldMineExtractionNext";
            this.labelGoldMineExtractionNext.Size = new System.Drawing.Size(252, 32);
            this.labelGoldMineExtractionNext.TabIndex = 2;
            this.labelGoldMineExtractionNext.Text = "Kolejne wydobycie";
            // 
            // FormExtractionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.labelGoldMineExtractionNext);
            this.Controls.Add(this.labelGoldMineExtraction);
            this.Controls.Add(this.labelGoldMineLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExtractionInfo";
            this.Text = "FormGoldMine";
            this.Load += new System.EventHandler(this.FormGoldMine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGoldMineLevel;
        private System.Windows.Forms.Label labelGoldMineExtraction;
        private System.Windows.Forms.Label labelGoldMineExtractionNext;
    }
}