using DartsScorer;
using DartsScorer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsScorerWinForms
{
    public partial class MatchForm : Form
    {
        private Match _match;

        public MatchForm(string player1Name, string player2Name, int bestOfLegs, int startScore)
        {
            _match = new Match(bestOfLegs, startScore);

            _match.AddPlayer(new Player(player1Name));
            _match.AddPlayer(new Player(player2Name));

            InitializeComponent();
        }
    }
}
