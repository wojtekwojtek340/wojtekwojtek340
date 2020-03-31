namespace WojciechWojtowiczLabb1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonColour = new System.Windows.Forms.Button();
            this.buttonLabelInvert = new System.Windows.Forms.Button();
            this.buttonLabelColour = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.Blue;
            this.labelName.Location = new System.Drawing.Point(120, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(575, 69);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Wojciech Wojtowicz";
            // 
            // buttonColour
            // 
            this.buttonColour.Location = new System.Drawing.Point(303, 345);
            this.buttonColour.Name = "buttonColour";
            this.buttonColour.Size = new System.Drawing.Size(200, 50);
            this.buttonColour.TabIndex = 1;
            this.buttonColour.Text = "Zmiana koloru tła";
            this.buttonColour.UseVisualStyleBackColor = true;
            this.buttonColour.Click += new System.EventHandler(this.buttonColour_Click);
            // 
            // buttonLabelInvert
            // 
            this.buttonLabelInvert.Location = new System.Drawing.Point(32, 345);
            this.buttonLabelInvert.Name = "buttonLabelInvert";
            this.buttonLabelInvert.Size = new System.Drawing.Size(200, 50);
            this.buttonLabelInvert.TabIndex = 2;
            this.buttonLabelInvert.Text = "Zmiana kolejnosci napisu";
            this.buttonLabelInvert.UseVisualStyleBackColor = true;
            this.buttonLabelInvert.Click += new System.EventHandler(this.buttonLabelInvert_Click);
            // 
            // buttonLabelColour
            // 
            this.buttonLabelColour.Location = new System.Drawing.Point(573, 345);
            this.buttonLabelColour.Name = "buttonLabelColour";
            this.buttonLabelColour.Size = new System.Drawing.Size(200, 50);
            this.buttonLabelColour.TabIndex = 3;
            this.buttonLabelColour.Text = "Zmiana koloru napisu";
            this.buttonLabelColour.UseVisualStyleBackColor = true;
            this.buttonLabelColour.Click += new System.EventHandler(this.buttonLabelColour_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(210, 171);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCount.TabIndex = 4;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(316, 163);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(100, 30);
            this.buttonCount.TabIndex = 5;
            this.buttonCount.Text = "policz";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(210, 199);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(316, 199);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(200, 30);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "dodaj dwie wartosci ";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(642, 163);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 58);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(12, 12);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(100, 50);
            this.buttonNewWindow.TabIndex = 9;
            this.buttonNewWindow.Text = "Nowe okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonLabelColour);
            this.Controls.Add(this.buttonLabelInvert);
            this.Controls.Add(this.buttonColour);
            this.Controls.Add(this.labelName);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonColour;
        private System.Windows.Forms.Button buttonLabelInvert;
        private System.Windows.Forms.Button buttonLabelColour;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

