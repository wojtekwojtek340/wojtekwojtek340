namespace Obsługa_Poczty_V2
{
    partial class Nadawcza
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.osobyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wysłaneOdebraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.książkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewOsoby = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsoby)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
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
            this.wysłaneOdebraneToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.wysłaneOdebraneToolStripMenuItem.Name = "wysłaneOdebraneToolStripMenuItem";
            this.wysłaneOdebraneToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.wysłaneOdebraneToolStripMenuItem.Text = "Książka Nadawcza";
            // 
            // książkaToolStripMenuItem
            // 
            this.książkaToolStripMenuItem.Name = "książkaToolStripMenuItem";
            this.książkaToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.książkaToolStripMenuItem.Text = "Książka Odbiorcza";
            this.książkaToolStripMenuItem.Click += new System.EventHandler(this.książkaToolStripMenuItem_Click);
            // 
            // dataGridViewOsoby
            // 
            this.dataGridViewOsoby.AllowUserToAddRows = false;
            this.dataGridViewOsoby.AllowUserToDeleteRows = false;
            this.dataGridViewOsoby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOsoby.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOsoby.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOsoby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOsoby.Location = new System.Drawing.Point(12, 204);
            this.dataGridViewOsoby.MultiSelect = false;
            this.dataGridViewOsoby.Name = "dataGridViewOsoby";
            this.dataGridViewOsoby.ReadOnly = true;
            this.dataGridViewOsoby.RowHeadersWidth = 51;
            this.dataGridViewOsoby.RowTemplate.Height = 24;
            this.dataGridViewOsoby.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOsoby.Size = new System.Drawing.Size(821, 235);
            this.dataGridViewOsoby.TabIndex = 0;
            this.dataGridViewOsoby.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOsoby_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 167);
            this.panel1.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(281, 61);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(137, 56);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(116, 61);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 56);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodaj pozycje";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Nadawcza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 451);
            this.Controls.Add(this.dataGridViewOsoby);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Nadawcza";
            this.Text = "Książka Nadawcza";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsoby)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wysłaneOdebraneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem książkaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.DataGridView dataGridViewOsoby;
    }
}

