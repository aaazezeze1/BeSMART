using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class FormulaForm : Form
    {
        private Dictionary<string, List<string>> categoryImages;
        private string currentCategory;
        private int currentImageIndex;

        public FormulaForm()
        {
            InitializeComponent();
            InitializeCategoryImages();
            ShowDefaultImage();
        }
        private void InitializeCategoryImages()
        {
            categoryImages = new Dictionary<string, List<string>>()
            {
                { "FunctionsEquations", new List<string> { "Images\\Functions and equations\\1.png", "Images\\Functions and equations\\2.png" } },
                { "Exponents", new List<string> { "Images\\Exponents.png" } },
                { "Radicals", new List<string> { "Images\\Radicals.png" } },
                { "Logic", new List<string> { "Images\\Logic\\1.png", "Images\\Logic\\2.png", "Images\\Logic\\3.png" } },
                { "Statistics", new List<string> { "Images\\Stats\\1.png", "Images\\Stats\\2.png", "Images\\Stats\\3.png" } },
                { "Sequences", new List<string> { "Images\\Sequences.png" } },
                { "ProbabilitySets", new List<string> { "Images\\Prob&Sets\\1.png", "Images\\Prob&Sets\\2.png" } },
                { "Trigonometry", new List<string> { "Images\\Trigonometry\\1.png", "Images\\Trigonometry\\2.png", "Images\\Trigonometry\\3.png", "Images\\Trigonometry\\4.png" } }
            };

            currentCategory = string.Empty;
            currentImageIndex = -1;
        }
        private void ShowDefaultImage()
        {
            pictureBoxFormula.ImageLocation = "Images\\NoSelectedCategory.png";
            btnprevious.Visible = false;
            btnnext.Visible = false;
        }
        private void ShowImage()
        {
            if (string.IsNullOrEmpty(currentCategory) || !categoryImages.ContainsKey(currentCategory) || categoryImages[currentCategory].Count == 0)
            {
                // Show default image or clear the picture box
                pictureBoxFormula.Image = null; // Clear the picture box
                btnprevious.Visible = false;
                btnnext.Visible = false;
                return;
            }

            // Show the current image of the current category
            pictureBoxFormula.ImageLocation = categoryImages[currentCategory][currentImageIndex];

            // Show or hide previous and next buttons based on the number of images in the category
            btnprevious.Visible = categoryImages[currentCategory].Count > 1;
            btnnext.Visible = categoryImages[currentCategory].Count > 1;
        }
        private Button previouslyClickedButton = null;
        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                if (control == label1)
                {
                    currentCategory = null;
                    ShowDefaultImage();
                }
                else
                {
                    currentCategory = control.Tag?.ToString();
                    currentImageIndex = 0;

                    if (previouslyClickedButton != null && previouslyClickedButton != control)
                    {
                        previouslyClickedButton.BackColor = Color.DimGray;
                        previouslyClickedButton.ForeColor = Color.White;
                    }
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;

                    previouslyClickedButton = control as Button;
                }
                ShowImage();
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                ShowImage();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < categoryImages[currentCategory].Count - 1)
            {
                currentImageIndex++;
                ShowImage();
            }
        }

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            var SchedForm3 = new ScheduleForm();
            SchedForm3.Show();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            var ToDoListForm5 = new ToDoForm();
            ToDoListForm5.Show();
            ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            //var FormulaForm4 = new Form4();
            //FormulaForm4.Show();
            //FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new ConverterForm();
            ConverterForm7.Show();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5Settings_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new MediaPlayerForm();
            MediaPlayerForm6.Show();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }

        private void btn1Schedule_Click_1(object sender, EventArgs e)
        {
            var SchedForm3 = new ScheduleForm();
            SchedForm3.Show();
            this.Hide();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click_1(object sender, EventArgs e)
        {
            var ToDolistForm5 = new ToDoForm();
            ToDolistForm5.Show();
            this.Hide();
            ToDolistForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click_1(object sender, EventArgs e)
        {
            //var FormulaForm4 = new FormulaForm();
            //FormulaForm4.Show();
            //this.Hide();
            //FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click_1(object sender, EventArgs e)
        {
            var ConverterForm7 = new ConverterForm();
            ConverterForm7.Show();
            this.Hide();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5MediaPlayer_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new MediaPlayerForm();
            MediaPlayerForm6.Show();
            this.Hide();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }

        private void btnprevious_MouseHover(object sender, EventArgs e)
        {
            btnprevious.BackColor = Color.DarkSlateGray;
        }

        private void btnprevious_MouseLeave(object sender, EventArgs e)
        {
            btnprevious.ResetBackColor();
            btnprevious.BackColor = Color.DimGray;
        }

        private void btnnext_MouseHover(object sender, EventArgs e)
        {
            btnnext.BackColor = Color.DarkSlateGray;
        }

        private void btnnext_MouseLeave(object sender, EventArgs e)
        {
            btnnext.ResetBackColor();
            btnnext.BackColor = Color.DimGray;
        }

        private void labl1BeSMART_Click(object sender, EventArgs e)
        {
            var NotesApp = new NotesApp();
            NotesApp.Show();
            this.Hide();
            NotesApp.FormClosed += (s, args) => this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var NotesApp = new NotesApp();
            NotesApp.Show();
            this.Hide();
            NotesApp.FormClosed += (s, args) => this.Show();
        }
    }
}
