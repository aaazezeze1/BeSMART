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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        bool sidebarExpand = false; //collapsed sidebar

        private void timer1SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) //expanding sidebar
            {
                if (fLP1Sidebar.Width < 190)
                {
                    fLP1Sidebar.Width += 10;
                    //fLP1CalendarContent.Width -= 10;
                    //fLP1CalendarContent.Left += 10;

                    //fLP2Days.Width -= 10;
                    //fLP2Days.Left += 10;
                }
                else
                {
                    //make sure sidebar does not go below min width
                    fLP1Sidebar.Width = 190;
                    sidebarExpand = false;
                    timer1SidebarTransition.Stop();
                }
            }
            else //collapse seidebar
            {
                if (fLP1Sidebar.Width > 72)
                {
                    fLP1Sidebar.Width -= 10;
                    //fLP1CalendarContent.Width += 10;
                    //fLP1CalendarContent.Left -= 10;

                    //fLP2Days.Width += 10;
                    //fLP2Days.Left -= 10;
                }
                else
                {
                    //make sure sidebar does not exceed the max width
                    fLP1Sidebar.Width = 72;
                    sidebarExpand = true;
                    timer1SidebarTransition.Stop();
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1SidebarTransition.Start();
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
            catch (Exception)
            {
                MessageBox.Show("Error: Unable to Delete");
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

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            var SchedForm3 = new Form3();
            SchedForm3.Show();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            //var ToDoListForm5 = new Form5();
            //ToDoListForm5.Show();
            //ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            var FormulaForm4 = new Form4();
            FormulaForm4.Show();
            FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new Form7();
            ConverterForm7.Show();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5Settings_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new Form6();
            MediaPlayerForm6.Show();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }
    }
}
