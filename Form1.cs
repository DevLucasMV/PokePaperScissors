namespace PokePaperScissors
{
    public partial class Form1 : Form
    {

        string playerChoice;
        string CPUChoice;
        string[] Options = { "V", "C", "B"};
        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerResult_Click(object sender, EventArgs e)
        {

        }

        private void ChooseEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;

            int i = random.Next(0, Options.Length);
            CPUChoice = Options[i];

            lblPlayerChoice.Text = "A sua escolha foi: " + UpdateTextAndImage(playerChoice, PLAYER_PIC);
            lblCPUChoice.Text = "A escolha do computador foi: " + UpdateTextAndImage(CPUChoice, CPU_PIC);
            CheckGame();

        }

        private string UpdateTextAndImage(string text, PictureBox pic)
        {
            string word = null;

            switch (text)
            {
                case "V":
                    word = "Venosaur";
                    pic.Image = Properties.Resources.venosaur;
                    break;
                case "C":
                    word = "Charizard";
                    pic.Image = Properties.Resources.Charizard;
                    break;
                case "B":
                    word = "Blastoise";
                    pic.Image = Properties.Resources.Blastoise;
                    break;
            }

            return word;
        }


        private void CheckGame()
        {
            if (CPUChoice == playerChoice)
            {
                lblFinalResult.Text = "Empatou!";
            }
            else if(playerChoice == "V" && CPUChoice == "C"  || playerChoice == "B" && CPUChoice == "V" || playerChoice == "C" && CPUChoice == "B")
            {
                computerScore++;
                lblFinalResult.Text = "Você perdeu!";
                draw = null;
            }
            else
            {
                playerScore++;
                lblFinalResult.Text = "Você venceu!";
                draw = null;
            }

            lblCPUresult.Text = "Computer Score: " + computerScore + Environment.NewLine + draw;
            lblPlayerResult.Text = "Player Score: " + playerScore + Environment.NewLine + draw;
        }

        private void PLAYER_PIC_Click(object sender, EventArgs e)
        {

        }

        private void CPU_PIC_Click(object sender, EventArgs e)
        {

        }
    }
}