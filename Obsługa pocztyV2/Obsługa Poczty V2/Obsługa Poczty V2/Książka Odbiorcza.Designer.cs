namespace Obsługa_Poczty_V2
{
    partial class Odbiorcza
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
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
            this.osobyToolStripMenuItem.Name = "osobyToolStripMenuItem";
            this.osobyToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.osobyToolStripMenuItem.Text = "Osoby";
            this.osobyToolStripMenuItem.Click += new System.EventHandler(this.osobyToolStripMenuItem_Click);
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
            this.książkaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.książkaToolStripMenuItem.Name = "książkaToolStripMenuItem";
            this.książkaToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.książkaToolStripMenuItem.Text = "Książka Odbiorcza";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.labelTo);
            this.panel1.Controls.Add(this.labelFrom);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 167);
            this.panel1.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(74, 65);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 55);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj pozycje";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(699, 118);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(110, 40);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Drukuj";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(427, 141);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(58, 17);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "Data do";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(427, 97);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(58, 17);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "Data od";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(493, 136);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(493, 92);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dataGridViewOsoby3
            // 
            this.dataGridViewOsoby3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOsoby3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOsoby3.Location = new System.Drawing.Point(12, 204);
            this.dataGridViewOsoby3.Name = "dataGridViewOsoby3";
            this.dataGridViewOsoby3.RowHeadersWidth = 51;
            this.dataGridViewOsoby3.RowTemplate.Height = 24;
            this.dataGridViewOsoby3.Size = new System.Drawing.Size(821, 234);
            this.dataGridViewOsoby3.TabIndex = 7;
            // 
            // Odbiorcza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.dataGridViewOsoby3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Odbiorcza";
            this.Text = "Książka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Książka_FormClosed);
            this.Load += new System.EventHandler(this.Książka_Load);
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
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonAdd;
    }
}