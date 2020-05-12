using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia
{
    public partial class Form1 : Form
    {
        struct Question
        {
            public string questionString;
            public List<PictureBox> answers;
            public string correctAnswer;
        }


        public Form1()
        {
            InitializeComponent();
        }

        List<Question> questions = new List<Question>();

        private Question InitQuestion(string questionstring, List<string> answers)
        {
            Question question = new Question();
            question.answers = new List<PictureBox>();

            question.questionString = questionstring;

            for (int iterator = 0; iterator < answers.Count; iterator++)
            {
                PictureBox auxPictureBox = new PictureBox();
                if (answers[iterator].Contains("Freddie"))
                    auxPictureBox.Image = Properties.Resources.p1;
                else if (answers[iterator].Contains("Bon Jovi"))
                    auxPictureBox.Image = Properties.Resources.p2;

                auxPictureBox.Width = 400;
                auxPictureBox.Height = 400;
                auxPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                auxPictureBox.Location = new Point(iterator * 500, 200);
                auxPictureBox.Name = answers[iterator];

                auxPictureBox.Click += new EventHandler(ImageClick);
                question.answers.Add(auxPictureBox);

                this.Controls.Add(question.answers[iterator]);

            }

                Label questionLabel = new Label();
                questionLabel.Text = question.questionString;
                questionLabel.Location = new Point(10, 10);
                questionLabel.AutoSize = true;
                questionLabel.Font = new Font("Times New Roman", 24);
                this.Controls.Add(questionLabel);
                question.correctAnswer = "Freddie Mercury";

            return question;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> answers = new List<string>();
            answers.Add("Freddie Mercury");
            answers.Add("John Bon Jovi");
            questions.Add(InitQuestion("Who was the singer of Queen?", answers));
            answers.Add("Spongebob");
            answers.Add("Plankton");
            questions.Add(InitQuestion2("Who was the villain of the show?", answers));
        }

        private void ImageClick(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;

            if (pictureBox.Name == questions[0].correctAnswer)
                MessageBox.Show("Bine");
            else MessageBox.Show("Nu esti roacer adevarat, bro");

            this.Controls.Clear();
        }

        struct Question2
        {
            public string questionString;
            public List<PictureBox> answers;
            public string correctAnswer;
        }


        
        List<Question> questions2 = new List<Question>();

        private Question InitQuestion2(string questionstring, List<string> answers)
        {
            Question question = new Question();
            question.answers = new List<PictureBox>();

            question.questionString = questionstring;

            for (int iterator = 0; iterator < answers.Count; iterator++)
            {
                PictureBox auxPictureBox = new PictureBox();
                if (answers[iterator].Contains("Spongebob"))
                    auxPictureBox.Image = Properties.Resources.p4;
                else if (answers[iterator].Contains("Squidward"))
                    auxPictureBox.Image = Properties.Resources.p5;

                auxPictureBox.Width = 400;
                auxPictureBox.Height = 400;
                auxPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                auxPictureBox.Location = new Point(iterator * 500, 200);
                auxPictureBox.Name = answers[iterator];

                auxPictureBox.Click += new EventHandler(Image2Click);
                question.answers.Add(auxPictureBox);

                this.Controls.Add(question.answers[iterator]);

            }

            Label questionLabel = new Label();
            questionLabel.Text = question.questionString;
            questionLabel.Location = new Point(10, 10);
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Times New Roman", 24);
            this.Controls.Add(questionLabel);
            question.correctAnswer = "Plankton";

            return question;

        }

        private void Image2Click(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;

            if (pictureBox.Name == questions[1].correctAnswer)
                MessageBox.Show("Bine");
            else MessageBox.Show("Nu ai copilarie, bro");
        }
    }
}

