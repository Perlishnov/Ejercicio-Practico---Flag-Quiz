using System.Net;
using System;

namespace Ejercicio_Practico___Flag_Quiz
{
    public partial class Form1 : Form
    {
        private CountryQuestion[] countries;
        private Random random = new Random();
        private int currentIndex = -1;
        private int tries = 0;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeCountries();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCurrentFlag();
            UpdateComboBox();

        }
        private void InitializeCountries()
        {
            // Crear con un arreglo con todos los paises
            countries = new CountryQuestion[]
            {
                new CountryQuestion("Aruba", "ua"),
            new CountryQuestion("Uruguay", "uy"),
            new CountryQuestion("Belize", "bz"),
            new CountryQuestion("Dominica", "dm"),
            new CountryQuestion("United States", "us"),
            new CountryQuestion("Cayman Islands", "ky"),
            new CountryQuestion("Guadeloupe", "gp"),
            new CountryQuestion("Canada", "ca"),
            new CountryQuestion("Barbados", "bb"),
            new CountryQuestion("Venezuela", "ve"),
            new CountryQuestion("Paraguay", "py"),
            new CountryQuestion("Colombia", "co"),
            new CountryQuestion("Peru", "pe"),
            new CountryQuestion("Greenland", "gl"),
            new CountryQuestion("Guatemala", "gt"),
            new CountryQuestion("Puerto Rico", "pr"),
            new CountryQuestion("Montserrat", "ms"),
            new CountryQuestion("Bermuda", "bm"),
            new CountryQuestion("Ecuador", "ec"),
            new CountryQuestion("Guiana", "gf"),
            new CountryQuestion("Bolivia", "bo"),
            new CountryQuestion("Anguilla", "ai"),
            new CountryQuestion("Honduras", "hn"),
            new CountryQuestion("Jamaica", "jm"),
            new CountryQuestion("Haiti", "ht"),
            new CountryQuestion("Dominican Republic", "do"),
            new CountryQuestion("Saint Martin", "mf"),
            new CountryQuestion("Brazil", "br"),
            new CountryQuestion("Grenada", "gd"),
            new CountryQuestion("Argentina", "ar"),
            new CountryQuestion("Suriname", "sr"),
            new CountryQuestion("Mexico", "mx"),
            new CountryQuestion("Panama", "pa"),
            new CountryQuestion("Guyana", "gy"),
            new CountryQuestion("Martinique", "mq"),
            new CountryQuestion("Costa Rica", "cr")
            };

            currentIndex = -1;
        }
        private void DisplayCurrentFlag()
        {
            if (currentIndex < countries.Length && tries<36)
            {
                // Buscar una pregunta que no ha sido respondida
                do
                {
                    currentIndex = random.Next(0, countries.Length);
                } while (countries[currentIndex].HasBennAnswered);

                CountryQuestion currentQuestion = countries[currentIndex];
                string flagUrl = currentQuestion.ImageRoute;

                // Cargar imagen al picturebox
                using (WebClient wc = new WebClient())
                {
                    Image flagImage = Image.FromStream(wc.OpenRead(flagUrl));
                    PBCountryImage.Image = flagImage;
                }
            }
            else
            {
                DisableControls();
                DisplayFinalEvaluation();
            }
            tries++;
        }
        private void UpdateComboBox()
        {
            if (currentIndex < countries.Length)
            {
                CountryQuestion currentQuestion = countries[currentIndex];
                // Limpiar el combobox y poner el nombre del pais
                cmbCountries.Items.Clear();
                cmbCountries.Items.Add(currentQuestion.CountryName);

                // Agregar el resto de paises
                foreach (CountryQuestion question in countries)
                {
                    if (question != currentQuestion && !question.HasBennAnswered)
                    {
                        cmbCountries.Items.Add(question.CountryName);
                    }
                }
            }
        }
        private void CheckAnswer()
        {
            if (currentIndex < countries.Length)
            {
                CountryQuestion currentQuestion = countries[currentIndex];
                string selectedAnswer = cmbCountries.SelectedItem as string;

                if (selectedAnswer == currentQuestion.CountryName)
                {
                    score++;
                    lblDisplayAnsweredMessage.Text = "Correct!";
                }
                else
                {
                    lblDisplayAnsweredMessage.Text = "Incorrect!";
                }

          
                lblFinalGrade.Text = $"Score: {score}";

                currentQuestion.HasBennAnswered = true;

                cmbCountries.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }
        private void NextFlag()
        {
            cmbCountries.Enabled = true;
            btnSubmit.Enabled = true;
            lblDisplayAnsweredMessage.Text = "";

            DisplayCurrentFlag();
            UpdateComboBox();
        }
        private void DisableControls()
        {
            cmbCountries.Enabled = false;
            btnSubmit.Enabled = false;
        }
        private void DisplayFinalEvaluation()
        {
            string evaluation = "";

            if (score <= 5)
            {
                evaluation = "Fail";
            }
            else if (score <= 15)
            {
                evaluation = "Poor";
            }
            else if (score <= 20)
            {
                evaluation = "Good";
            }
            else if (score <= 34)
            {
                evaluation = "Very Good!";
            }
            else if (score == 35)
            {
                evaluation = "Excelent!";
            }
            lblDisplayAnsweredMessage.Text = evaluation;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            btnNextFlag.Enabled = true;
        }

        private void btnNextFlag_Click(object sender, EventArgs e)
        {
            NextFlag();
            btnNextFlag.Enabled = false;
        }
    }
}