using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable table; 

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FillGrid();

        }

        private void bttNew_Click(object sender, EventArgs e)
        {

            txtTitle.Clear();
            txtNotes.Clear();
        
        }
        private void SaveNote()
        {
            try
            {
                var note = new Note
                {
                    Label = txtTitle.Text,
                    Content = txtNotes.Text
                };

                using (var context = new NoteTakingDBEntities())
                {
                    context.Notes.Add(note);
                    context.SaveChanges();
                    MessageBox.Show("Note saved.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed to save note. {ex.Message}");
            }
        }

        private void FillGrid()
        {
            // CRUD
            var notes = new NoteTakingDBEntities().Notes.ToList();
            dataGridView1.DataSource = notes;  
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            SaveNote();
            FillGrid();
            txtTitle.Clear();
            txtNotes.Clear();
      
        }


        private void bttUpdate_Click(object sender, EventArgs e)
        {
            UpdateNote();
            FillGrid();
            txtTitle.Clear();
            txtNotes.Clear();
        }

        private void UpdateNote()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            try
            {
                int noteId = (int)dataGridView1.CurrentRow.Cells["NoteId"].Value;
                using (var context = new NoteTakingDBEntities())
                {
                    Note note = context.Notes.SingleOrDefault(n => n.NoteId == noteId);

                    if (note != null)
                    {
                        
                        note.Label = txtTitle.Text;
                        note.Content = txtNotes.Text;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Update. {ex.Message}");
            }
        }
        

        private void bttDelete_Click(object sender, EventArgs e)
        {
            DeleteNote();
            FillGrid();

        }

        private void DeleteNote()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            try
            {
                int noteId = (int)dataGridView1.CurrentRow.Cells["NoteId"].Value;

                using (var context = new NoteTakingDBEntities())
                {
                    Note note = context.Notes.SingleOrDefault(n => n.NoteId == noteId);
                    context.Notes.Remove(note);
                    context.SaveChanges();
                    MessageBox.Show($"Note #: {note.NoteId} deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Delete. {ex.Message}");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            int noteId = (int)dataGridView1.CurrentRow.Cells["NoteId"].Value;
            var context = new NoteTakingDBEntities();
            Note note = context.Notes.SingleOrDefault(n => n.NoteId == noteId);
            txtTitle.Text = note.Label;
            txtNotes.Text = note.Content;
        }
    }
}   
