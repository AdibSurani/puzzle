using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Puzzle.MUMS
{
    /// <summary>
    /// Interaction logic for Breakthrough.xaml
    /// </summary>
    public partial class Breakthrough : Page
    {
        public Breakthrough()
        {
            InitializeComponent();
            const string input =
                "tlg wVBtslAidcq oGrLDygoDok chzusR ONBpI nDoa jDk xsfdiAh bqI zfy kfDj " +
                "wrmGxjc rd Hzu lhcv ga nmEBt sM skf oHvuIE pj ydv oGBAg snmidv ga nCjD " +
                "iAtoadC ta gpbam Cqpbpgun hwe yql kFmGonbkjx hzkafcw rfadxoDp gtgpbgua " +
                "tSEBtbqKsdr cqenBw";
            MainTextBox.Text = Decode(input);
        }

        static string Decode(string input)
        {
            var result = new StringBuilder();
            int prevValue = 0;
            foreach (var c in input)
            {
                if (c == ' ')
                {
                    result.Append(c);
                }
                else
                {
                    int nextValue = char.IsLower(c) ? c - 'a' + 1 : c - 'A' + 1 + 26;
                    result.Append((char)(Math.Abs(prevValue - nextValue) + 'A' - 1));
                    prevValue = nextValue;
                }
            }
            return result.ToString();
        }
    }
}
