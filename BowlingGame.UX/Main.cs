using System;
using System.Windows.Forms;

namespace BowlingGame.UX
{
    public partial class Main : Form
    {
        private Game game;
        private bool gameEnded;

        public Main()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            if (gameEnded)
            {
                ResetUIComponents();
                InitializeGame();

                return;
            }

            int rolledPins = Convert.ToInt32(InpPins.Value);
            game.Roll(rolledPins);

            int currentScore = game.Score();
            UpdateScoreLabel(currentScore);
        }

        private void InitializeGame()
        {
            game = new Game();
            gameEnded = false;
            game.GameEvent += HandleGameEvent;
        }

        private void HandleGameEvent(object sender, Event e)
        {
            switch (e)
            {
                case Rolled re:
                    AddEventToList($"Rolled {re.Pins} pin(s)");
                    break;
                case FrameCompleted fc:
                    AddEventToList($"Frame {fc.FrameNumber + 1} ended");
                    break;
                case SpareBonusEarned _:
                    AddEventToList($"Got a spare!");
                    break;
                case StrikeBonusEarned _:
                    AddEventToList($"Got a strike!");
                    break;
                case GameCompleted _:
                    AddEventToList($"Game ended");

                    gameEnded = true;
                    UpdateUIForGameEnded();

                    break;
            }
        }

        private void ResetUIComponents()
        {
            UpdateScoreLabel(0);
            ClearEventsList();

            BtnRoll.Text = "Register Roll";
            BtnRoll.BackColor = GreenAccentColor;

            LblScoreTitle.Text = "Score:";
            LblScore.ForeColor = GreenAccentColor;
        }

        private void UpdateUIForGameEnded()
        {
            BtnRoll.Text = "Start new Game";
            BtnRoll.BackColor = YellowAccentColor;

            LblScoreTitle.Text = "Final Score:";
            LblScore.ForeColor = YellowAccentColor;
        }

        private void UpdateScoreLabel(int score) =>
            LblScore.Text = score.ToString();

        private void AddEventToList(string description)
        {
            LbxEvents.Items.Add(description);

            LbxEvents.SelectedIndex = LbxEvents.Items.Count - 1;
            LbxEvents.SelectedIndex = -1;
        }

        private void ClearEventsList() =>
            LbxEvents.Items.Clear();
    }
}
