namespace WojciechWojtowiczLab2
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
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxNewVehicle = new System.Windows.Forms.GroupBox();
            this.radioButtonTram = new System.Windows.Forms.RadioButton();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.labelVehicleNumber = new System.Windows.Forms.Label();
            this.labelYearProduction = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxVehicleNumber = new System.Windows.Forms.TextBox();
            this.textBoxYearProduction = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.labelActualVehicle = new System.Windows.Forms.Label();
            this.labelActualNumberVehicle = new System.Windows.Forms.Label();
            this.labelActualYearOfProdution = new System.Windows.Forms.Label();
            this.labelActualModel = new System.Windows.Forms.Label();
            this.labelActualYearDescription = new System.Windows.Forms.Label();
            this.labelActualModelDesctription = new System.Windows.Forms.Label();
            this.labelActualVehicleDesctription = new System.Windows.Forms.Label();
            this.labelActualNumberDesctription = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonPantographDown = new System.Windows.Forms.Button();
            this.buttonStartVehicle = new System.Windows.Forms.Button();
            this.buttonBell = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonStopVehicle = new System.Windows.Forms.Button();
            this.buttonPantographUp = new System.Windows.Forms.Button();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.groupBoxNewVehicle.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(29, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(740, 91);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Wojciech Wojtowicz";
            // 
            // groupBoxNewVehicle
            // 
            this.groupBoxNewVehicle.Controls.Add(this.buttonAddVehicle);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxName);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxYearProduction);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxVehicleNumber);
            this.groupBoxNewVehicle.Controls.Add(this.labelModel);
            this.groupBoxNewVehicle.Controls.Add(this.labelYearProduction);
            this.groupBoxNewVehicle.Controls.Add(this.labelVehicleNumber);
            this.groupBoxNewVehicle.Controls.Add(this.radioButtonBus);
            this.groupBoxNewVehicle.Controls.Add(this.radioButtonTram);
            this.groupBoxNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxNewVehicle.Location = new System.Drawing.Point(24, 145);
            this.groupBoxNewVehicle.Name = "groupBoxNewVehicle";
            this.groupBoxNewVehicle.Size = new System.Drawing.Size(490, 345);
            this.groupBoxNewVehicle.TabIndex = 1;
            this.groupBoxNewVehicle.TabStop = false;
            this.groupBoxNewVehicle.Text = "Utworz Nowy pojazd";
            // 
            // radioButtonTram
            // 
            this.radioButtonTram.AutoSize = true;
            this.radioButtonTram.Checked = true;
            this.radioButtonTram.Location = new System.Drawing.Point(115, 53);
            this.radioButtonTram.Name = "radioButtonTram";
            this.radioButtonTram.Size = new System.Drawing.Size(108, 29);
            this.radioButtonTram.TabIndex = 0;
            this.radioButtonTram.TabStop = true;
            this.radioButtonTram.Text = "Tramwaj";
            this.radioButtonTram.UseVisualStyleBackColor = true;
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(345, 53);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(106, 29);
            this.radioButtonBus.TabIndex = 1;
            this.radioButtonBus.Text = "Autobus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // labelVehicleNumber
            // 
            this.labelVehicleNumber.AutoSize = true;
            this.labelVehicleNumber.Location = new System.Drawing.Point(97, 128);
            this.labelVehicleNumber.Name = "labelVehicleNumber";
            this.labelVehicleNumber.Size = new System.Drawing.Size(144, 25);
            this.labelVehicleNumber.TabIndex = 2;
            this.labelVehicleNumber.Text = "Numer pojazdu";
            // 
            // labelYearProduction
            // 
            this.labelYearProduction.AutoSize = true;
            this.labelYearProduction.Location = new System.Drawing.Point(112, 182);
            this.labelYearProduction.Name = "labelYearProduction";
            this.labelYearProduction.Size = new System.Drawing.Size(122, 25);
            this.labelYearProduction.TabIndex = 3;
            this.labelYearProduction.Text = "rok pordukcji";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(147, 226);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(72, 25);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Model:";
            // 
            // textBoxVehicleNumber
            // 
            this.textBoxVehicleNumber.Location = new System.Drawing.Point(251, 128);
            this.textBoxVehicleNumber.Name = "textBoxVehicleNumber";
            this.textBoxVehicleNumber.Size = new System.Drawing.Size(100, 30);
            this.textBoxVehicleNumber.TabIndex = 5;
            // 
            // textBoxYearProduction
            // 
            this.textBoxYearProduction.Location = new System.Drawing.Point(251, 176);
            this.textBoxYearProduction.Name = "textBoxYearProduction";
            this.textBoxYearProduction.Size = new System.Drawing.Size(100, 30);
            this.textBoxYearProduction.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(251, 220);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 30);
            this.textBoxName.TabIndex = 7;
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.AutoSize = true;
            this.buttonAddVehicle.Location = new System.Drawing.Point(226, 275);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(187, 35);
            this.buttonAddVehicle.TabIndex = 8;
            this.buttonAddVehicle.Text = "Dodaj nowy pojazd";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.buttonRefuel);
            this.groupBoxList.Controls.Add(this.buttonPantographUp);
            this.groupBoxList.Controls.Add(this.buttonStopVehicle);
            this.groupBoxList.Controls.Add(this.buttonNext);
            this.groupBoxList.Controls.Add(this.buttonBell);
            this.groupBoxList.Controls.Add(this.buttonStartVehicle);
            this.groupBoxList.Controls.Add(this.buttonPantographDown);
            this.groupBoxList.Controls.Add(this.buttonPrevious);
            this.groupBoxList.Controls.Add(this.labelActualNumberDesctription);
            this.groupBoxList.Controls.Add(this.labelActualVehicleDesctription);
            this.groupBoxList.Controls.Add(this.labelActualModelDesctription);
            this.groupBoxList.Controls.Add(this.labelActualYearDescription);
            this.groupBoxList.Controls.Add(this.labelActualModel);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProdution);
            this.groupBoxList.Controls.Add(this.labelActualNumberVehicle);
            this.groupBoxList.Controls.Add(this.labelActualVehicle);
            this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxList.Location = new System.Drawing.Point(539, 145);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(447, 455);
            this.groupBoxList.TabIndex = 9;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Lista pojazdów";
            // 
            // labelActualVehicle
            // 
            this.labelActualVehicle.AutoSize = true;
            this.labelActualVehicle.Location = new System.Drawing.Point(6, 35);
            this.labelActualVehicle.Name = "labelActualVehicle";
            this.labelActualVehicle.Size = new System.Drawing.Size(157, 25);
            this.labelActualVehicle.TabIndex = 0;
            this.labelActualVehicle.Text = "Aktualny pojazd:";
            // 
            // labelActualNumberVehicle
            // 
            this.labelActualNumberVehicle.AutoSize = true;
            this.labelActualNumberVehicle.Location = new System.Drawing.Point(11, 71);
            this.labelActualNumberVehicle.Name = "labelActualNumberVehicle";
            this.labelActualNumberVehicle.Size = new System.Drawing.Size(152, 25);
            this.labelActualNumberVehicle.TabIndex = 1;
            this.labelActualNumberVehicle.Text = "Numer Pojazdu:";
            // 
            // labelActualYearOfProdution
            // 
            this.labelActualYearOfProdution.AutoSize = true;
            this.labelActualYearOfProdution.Location = new System.Drawing.Point(26, 106);
            this.labelActualYearOfProdution.Name = "labelActualYearOfProdution";
            this.labelActualYearOfProdution.Size = new System.Drawing.Size(137, 25);
            this.labelActualYearOfProdution.TabIndex = 2;
            this.labelActualYearOfProdution.Text = "Rok Produkcji:";
            // 
            // labelActualModel
            // 
            this.labelActualModel.AutoSize = true;
            this.labelActualModel.Location = new System.Drawing.Point(15, 140);
            this.labelActualModel.Name = "labelActualModel";
            this.labelActualModel.Size = new System.Drawing.Size(148, 25);
            this.labelActualModel.TabIndex = 3;
            this.labelActualModel.Text = "Model Pojazdu:";
            // 
            // labelActualYearDescription
            // 
            this.labelActualYearDescription.AutoSize = true;
            this.labelActualYearDescription.Location = new System.Drawing.Point(226, 106);
            this.labelActualYearDescription.Name = "labelActualYearDescription";
            this.labelActualYearDescription.Size = new System.Drawing.Size(23, 25);
            this.labelActualYearDescription.TabIndex = 4;
            this.labelActualYearDescription.Text = "#";
            // 
            // labelActualModelDesctription
            // 
            this.labelActualModelDesctription.AutoSize = true;
            this.labelActualModelDesctription.Location = new System.Drawing.Point(226, 140);
            this.labelActualModelDesctription.Name = "labelActualModelDesctription";
            this.labelActualModelDesctription.Size = new System.Drawing.Size(23, 25);
            this.labelActualModelDesctription.TabIndex = 5;
            this.labelActualModelDesctription.Text = "#";
            // 
            // labelActualVehicleDesctription
            // 
            this.labelActualVehicleDesctription.AutoSize = true;
            this.labelActualVehicleDesctription.Location = new System.Drawing.Point(226, 35);
            this.labelActualVehicleDesctription.Name = "labelActualVehicleDesctription";
            this.labelActualVehicleDesctription.Size = new System.Drawing.Size(23, 25);
            this.labelActualVehicleDesctription.TabIndex = 6;
            this.labelActualVehicleDesctription.Text = "#";
            // 
            // labelActualNumberDesctription
            // 
            this.labelActualNumberDesctription.AutoSize = true;
            this.labelActualNumberDesctription.Location = new System.Drawing.Point(226, 71);
            this.labelActualNumberDesctription.Name = "labelActualNumberDesctription";
            this.labelActualNumberDesctription.Size = new System.Drawing.Size(23, 25);
            this.labelActualNumberDesctription.TabIndex = 7;
            this.labelActualNumberDesctription.Text = "#";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.AutoSize = true;
            this.buttonPrevious.Location = new System.Drawing.Point(20, 182);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(186, 35);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Poprzedni Element";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonPantographDown
            // 
            this.buttonPantographDown.AutoSize = true;
            this.buttonPantographDown.Location = new System.Drawing.Point(20, 378);
            this.buttonPantographDown.Name = "buttonPantographDown";
            this.buttonPantographDown.Size = new System.Drawing.Size(167, 35);
            this.buttonPantographDown.TabIndex = 9;
            this.buttonPantographDown.Text = "Opuść pantograf";
            this.buttonPantographDown.UseVisualStyleBackColor = true;
            this.buttonPantographDown.Click += new System.EventHandler(this.buttonPantographDown_Click);
            // 
            // buttonStartVehicle
            // 
            this.buttonStartVehicle.AutoSize = true;
            this.buttonStartVehicle.Location = new System.Drawing.Point(20, 246);
            this.buttonStartVehicle.Name = "buttonStartVehicle";
            this.buttonStartVehicle.Size = new System.Drawing.Size(156, 35);
            this.buttonStartVehicle.TabIndex = 10;
            this.buttonStartVehicle.Text = "Rusz pojazdem";
            this.buttonStartVehicle.UseVisualStyleBackColor = true;
            this.buttonStartVehicle.Click += new System.EventHandler(this.buttonStartVehicle_Click);
            // 
            // buttonBell
            // 
            this.buttonBell.AutoSize = true;
            this.buttonBell.Location = new System.Drawing.Point(20, 306);
            this.buttonBell.Name = "buttonBell";
            this.buttonBell.Size = new System.Drawing.Size(103, 35);
            this.buttonBell.TabIndex = 11;
            this.buttonBell.Text = "Dzwonek";
            this.buttonBell.UseVisualStyleBackColor = true;
            this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.AutoSize = true;
            this.buttonNext.Location = new System.Drawing.Point(231, 182);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(181, 35);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Następny Element";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonStopVehicle
            // 
            this.buttonStopVehicle.AutoSize = true;
            this.buttonStopVehicle.Location = new System.Drawing.Point(230, 246);
            this.buttonStopVehicle.Name = "buttonStopVehicle";
            this.buttonStopVehicle.Size = new System.Drawing.Size(182, 35);
            this.buttonStopVehicle.TabIndex = 13;
            this.buttonStopVehicle.Text = "Zatrzymaj pojazd";
            this.buttonStopVehicle.UseVisualStyleBackColor = true;
            this.buttonStopVehicle.Click += new System.EventHandler(this.buttonStopVehicle_Click);
            // 
            // buttonPantographUp
            // 
            this.buttonPantographUp.AutoSize = true;
            this.buttonPantographUp.Location = new System.Drawing.Point(250, 378);
            this.buttonPantographUp.Name = "buttonPantographUp";
            this.buttonPantographUp.Size = new System.Drawing.Size(180, 35);
            this.buttonPantographUp.TabIndex = 14;
            this.buttonPantographUp.Text = "Podnieś pantograf";
            this.buttonPantographUp.UseVisualStyleBackColor = true;
            this.buttonPantographUp.Click += new System.EventHandler(this.buttonPantographUp_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.AutoSize = true;
            this.buttonRefuel.Location = new System.Drawing.Point(250, 306);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(162, 35);
            this.buttonRefuel.TabIndex = 15;
            this.buttonRefuel.Text = "Zatankuj Pojazd";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 636);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxNewVehicle);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNewVehicle.ResumeLayout(false);
            this.groupBoxNewVehicle.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxNewVehicle;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYearProduction;
        private System.Windows.Forms.TextBox textBoxVehicleNumber;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYearProduction;
        private System.Windows.Forms.Label labelVehicleNumber;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.RadioButton radioButtonTram;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Label labelActualNumberDesctription;
        private System.Windows.Forms.Label labelActualVehicleDesctription;
        private System.Windows.Forms.Label labelActualModelDesctription;
        private System.Windows.Forms.Label labelActualYearDescription;
        private System.Windows.Forms.Label labelActualModel;
        private System.Windows.Forms.Label labelActualYearOfProdution;
        private System.Windows.Forms.Label labelActualNumberVehicle;
        private System.Windows.Forms.Label labelActualVehicle;
        private System.Windows.Forms.Button buttonRefuel;
        private System.Windows.Forms.Button buttonPantographUp;
        private System.Windows.Forms.Button buttonStopVehicle;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBell;
        private System.Windows.Forms.Button buttonStartVehicle;
        private System.Windows.Forms.Button buttonPantographDown;
        private System.Windows.Forms.Button buttonPrevious;
    }
}

