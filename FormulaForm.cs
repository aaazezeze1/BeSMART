using Newtonsoft.Json.Linq;
using ReaLTaiizor.Controls;
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

            btnFunctionsEquations.Click += btnCategory_Click;
            btnExponents.Click += btnCategory_Click;
            btnRadicals.Click += btnCategory_Click;
            btnLogic.Click += btnCategory_Click;
            btnStats.Click += btnCategory_Click;
            btnSequences.Click += btnCategory_Click;
            btnProbability.Click += btnCategory_Click;
            btnTrigo.Click += btnCategory_Click;

            label1.Click += btnCategory_Click;


            btnFunctionsEquations.Tag = "FunctionsEquations";
            btnExponents.Tag = "Exponents";
            btnRadicals.Tag = "Radicals";
            btnLogic.Tag = "Logic";
            btnStats.Tag = "Statistics";
            btnSequences.Tag = "Sequences";
            btnProbability.Tag = "ProbabilitySets";
            btnTrigo.Tag = "Trigonometry";

            label1.Tag = "label1";
        }
        private void InitializeCategoryImages()
        {
            categoryImages = new Dictionary<string, List<string>>()
            {
                { "FunctionsEquations", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Functions and equations\\1.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Functions and equations\\2.png" } },
                { "Exponents", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Exponents.png" } },
                { "Radicals", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Radicals.png" } },
                { "Logic", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Logic\\1.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Logic\\2.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Logic\\3.png" } },
                { "Statistics", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Stats\\1.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Stats\\2.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Stats\\3.png" } },
                { "Sequences", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Sequences.png" } },
                { "ProbabilitySets", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Prob&Sets\\1.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Prob&Sets\\2.png" } },
                { "Trigonometry", new List<string> { "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Trigonometry\\1.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Trigonometry\\2.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Trigonometry\\3.png", "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\Trigonometry\\4.png" } }
            };

            currentCategory = string.Empty;
            currentImageIndex = -1;
        }
        private void ShowDefaultImage()
        {
            pictureBoxFormula.ImageLocation = "C:\\Users\\acer\\source\\repos\\Be_SMART\\Images\\NoSelectedCategory.png";
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
        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                // Check if the clicked control is the label, if yes, reset the current category
                if (control == label1)
                {
                    currentCategory = null;
                    ShowDefaultImage();
                }
                else
                {
                    // Get the category from the clicked button's Tag property
                    currentCategory = control.Tag?.ToString();
                    currentImageIndex = 0;
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
    }
}
