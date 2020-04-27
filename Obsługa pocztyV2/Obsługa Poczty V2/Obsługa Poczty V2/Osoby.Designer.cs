namespace Obsługa_Poczty_V2
{
    partial class Osoby
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.osobyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wysłaneOdebraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.książkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHouseNumber12 = new System.Windows.Forms.TextBox();
            this.textBoxHouseNumber22 = new System.Windows.Forms.TextBox();
            this.textBoxPostCode2 = new System.Windows.Forms.TextBox();
            this.textBoxStreet2 = new System.Windows.Forms.TextBox();
            this.textBoxTown2 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelTown = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxHouseNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxHouseNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridViewOsoby3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsoby3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobyToolStripMenuItem,
            this.wysłaneOdebraneToolStripMenuItem,
            this.książkaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // osobyToolStripMenuItem
            // 
            this.osobyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.osobyToolStripMenuItem.Name = "osobyToolStripMenuItem";
            this.osobyToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.osobyToolStripMenuItem.Text = "Osoby";
            // 
            // wysłaneOdebraneToolStripMenuItem
            // 
            this.wysłaneOdebraneToolStripMenuItem.Name = "wysłaneOdebraneToolStripMenuItem";
            this.wysłaneOdebraneToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.wysłaneOdebraneToolStripMenuItem.Text = "Książka Nadawcza";
            this.wysłaneOdebraneToolStripMenuItem.Click += new System.EventHandler(this.wysłaneOdebraneToolStripMenuItem_Click);
            // 
            // książkaToolStripMenuItem
            // 
            this.książkaToolStripMenuItem.Name = "książkaToolStripMenuItem";
            this.książkaToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.książkaToolStripMenuItem.Text = "Książka Odbiorcza";
            this.książkaToolStripMenuItem.Click += new System.EventHandler(this.książkaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxHouseNumber12);
            this.panel1.Controls.Add(this.textBoxHouseNumber22);
            this.panel1.Controls.Add(this.textBoxPostCode2);
            this.panel1.Controls.Add(this.textBoxStreet2);
            this.panel1.Controls.Add(this.textBoxTown2);
            this.panel1.Controls.Add(this.textBoxName2);
            this.panel1.Controls.Add(this.buttonClean);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelPostCode);
            this.panel1.Controls.Add(this.labelStreet);
            this.panel1.Controls.Add(this.labelTown);
            this.panel1.Controls.Add(this.labelHouse);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxHouseNumber1);
            this.panel1.Controls.Add(this.textBoxHouseNumber2);
            this.panel1.Controls.Add(this.textBoxPostCode);
            this.panel1.Controls.Add(this.textBoxStreet);
            this.panel1.Controls.Add(this.textBoxTown);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 167);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(550, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Wyszukiwarka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kod Pocztowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Miasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dom | Lokal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nazwa";
            // 
            // textBoxHouseNumber12
            // 
            this.textBoxHouseNumber12.Location = new System.Drawing.Point(612, 130);
            this.textBoxHouseNumber12.Name = "textBoxHouseNumber12";
            this.textBoxHouseNumber12.Size = new System.Drawing.Size(32, 22);
            this.textBoxHouseNumber12.TabIndex = 19;
            this.textBoxHouseNumber12.TextChanged += new System.EventHandler(this.textBoxHouseNumber12_TextChanged);
            // 
            // textBoxHouseNumber22
            // 
            this.textBoxHouseNumber22.Location = new System.Drawing.Point(650, 130);
            this.textBoxHouseNumber22.Name = "textBoxHouseNumber22";
            this.textBoxHouseNumber22.Size = new System.Drawing.Size(39, 22);
            this.textBoxHouseNumber22.TabIndex = 20;
            this.textBoxHouseNumber22.TextChanged += new System.EventHandler(this.textBoxHouseNumber22_TextChanged);
            // 
            // textBoxPostCode2
            // 
            this.textBoxPostCode2.Location = new System.Drawing.Point(695, 130);
            this.textBoxPostCode2.Name = "textBoxPostCode2";
            this.textBoxPostCode2.Size = new System.Drawing.Size(103, 22);
            this.textBoxPostCode2.TabIndex = 21;
            this.textBoxPostCode2.TextChanged += new System.EventHandler(this.textBoxPostCode2_TextChanged);
            // 
            // textBoxStreet2
            // 
            this.textBoxStreet2.Location = new System.Drawing.Point(458, 130);
            this.textBoxStreet2.Name = "textBoxStreet2";
            this.textBoxStreet2.Size = new System.Drawing.Size(148, 22);
            this.textBoxStreet2.TabIndex = 18;
            this.textBoxStreet2.TextChanged += new System.EventHandler(this.textBoxStreet2_TextChanged);
            // 
            // textBoxTown2
            // 
            this.textBoxTown2.Location = new System.Drawing.Point(650, 75);
            this.textBoxTown2.Name = "textBoxTown2";
            this.textBoxTown2.Size = new System.Drawing.Size(148, 22);
            this.textBoxTown2.TabIndex = 17;
            this.textBoxTown2.TextChanged += new System.EventHandler(this.textBoxTown2_TextChanged);
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(458, 75);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(186, 22);
            this.textBoxName2.TabIndex = 16;
            this.textBoxName2.TextChanged += new System.EventHandler(this.textBoxName2_TextChanged);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(358, 21);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(82, 77);
            this.buttonClean.TabIndex = 15;
            this.buttonClean.Text = "Wyczyść";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(233, 112);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 40);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(119, 112);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 40);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 112);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 40);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Location = new System.Drawing.Point(247, 56);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(96, 17);
            this.labelPostCode.TabIndex = 11;
            this.labelPostCode.Text = "Kod Pocztowy";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(50, 56);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(39, 17);
            this.labelStreet.TabIndex = 9;
            this.labelStreet.Text = "Ulica";
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Location = new System.Drawing.Point(242, 1);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(49, 17);
            this.labelTown.TabIndex = 8;
            this.labelTown.Text = "Miasto";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new System.Drawing.Point(154, 56);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(82, 17);
            this.labelHouse.TabIndex = 7;
            this.labelHouse.Text = "Dom | Lokal";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(82, 1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 17);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Nazwa";
            // 
            // textBoxHouseNumber1
            // 
            this.textBoxHouseNumber1.Location = new System.Drawing.Point(157, 76);
            this.textBoxHouseNumber1.Name = "textBoxHouseNumber1";
            this.textBoxHouseNumber1.Size = new System.Drawing.Size(32, 22);
            this.textBoxHouseNumber1.TabIndex = 3;
            // 
            // textBoxHouseNumber2
            // 
            this.textBoxHouseNumber2.Location = new System.Drawing.Point(195, 76);
            this.textBoxHouseNumber2.Name = "textBoxHouseNumber2";
            this.textBoxHouseNumber2.Size = new System.Drawing.Size(39, 22);
            this.textBoxHouseNumber2.TabIndex = 4;
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Location = new System.Drawing.Point(240, 76);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(103, 22);
            this.textBoxPostCode.TabIndex = 5;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(3, 76);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(148, 22);
            this.textBoxStreet.TabIndex = 2;
            // 
            // textBoxTown
            // 
            this.textBoxTown.Location = new System.Drawing.Point(195, 21);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(148, 22);
            this.textBoxTown.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(3, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // dataGridViewOsoby3
            // 
            this.dataGridViewOsoby3.AllowUserToAddRows = false;
            this.dataGridViewOsoby3.AllowUserToDeleteRows = false;
            this.dataGridViewOsoby3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOsoby3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOsoby3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOsoby3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOsoby3.Location = new System.Drawing.Point(12, 204);
            this.dataGridViewOsoby3.MultiSelect = false;
            this.dataGridViewOsoby3.Name = "dataGridViewOsoby3";
            this.dataGridViewOsoby3.ReadOnly = true;
            this.dataGridViewOsoby3.RowHeadersWidth = 51;
            this.dataGridViewOsoby3.RowTemplate.Height = 24;
            this.dataGridViewOsoby3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOsoby3.Size = new System.Drawing.Size(821, 234);
            this.dataGridViewOsoby3.TabIndex = 6;
            this.dataGridViewOsoby3.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOsoby3_CellMouseClick);
            // 
            // Osoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.dataGridViewOsoby3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Osoby";
            this.Text = "Osoby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Osoby_FormClosed);
            this.Load += new System.EventHandler(this.Osoby_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsoby3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wysłaneOdebraneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem książkaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewOsoby3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxHouseNumber1;
        private System.Windows.Forms.TextBox textBoxHouseNumber2;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHouseNumber12;
        private System.Windows.Forms.TextBox textBoxHouseNumber22;
        private System.Windows.Forms.TextBox textBoxPostCode2;
        private System.Windows.Forms.TextBox textBoxStreet2;
        private System.Windows.Forms.TextBox textBoxTown2;
        private System.Windows.Forms.TextBox textBoxName2;
    }
}