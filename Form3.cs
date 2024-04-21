using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form3_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");
            ToDoListView.DataSource = todoList;
            ToDoListView.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleTxtBox.Text = "";
            DescTxtBox.Text = "";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            TitleTxtBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescTxtBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTxtBox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescTxtBox.Text;
            }
            else
            {
                todoList.Rows.Add(TitleTxtBox.Text, DescTxtBox.Text);
            }

            TitleTxtBox.Text = "";
            DescTxtBox.Text = "";
            isEditing = false;
        }

        private void NewButton_MouseHover(object sender, EventArgs e)
        {
            NewButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void NewButton_MouseLeave(object sender, EventArgs e)
        {
            NewButton.ResetBackColor();
            NewButton.UseVisualStyleBackColor = true;
        }

        private void EditButton_MouseHover(object sender, EventArgs e)
        {
            EditButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.ResetBackColor();
            EditButton.UseVisualStyleBackColor = true;
        }

        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.ResetBackColor();
            DeleteButton.UseVisualStyleBackColor = true;
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            SaveButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SaveButton.ResetBackColor();
            SaveButton.UseVisualStyleBackColor = true;
        }
    }
}
