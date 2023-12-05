namespace NoteTakingApp
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
            this.bttNew = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(30, 263);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(64, 66);
            this.bttNew.TabIndex = 0;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(67, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(59, 100);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(35, 13);
            this.Notes.TabIndex = 2;
            this.Notes.Text = "Notes";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(266, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(100, 50);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(266, 184);
            this.txtNotes.TabIndex = 4;
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(148, 263);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(64, 66);
            this.bttSave.TabIndex = 5;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.Location = new System.Drawing.Point(262, 263);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(64, 66);
            this.bttUpdate.TabIndex = 6;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = true;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(368, 263);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(64, 66);
            this.bttDelete.TabIndex = 7;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 282);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(474, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.bttNew);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

