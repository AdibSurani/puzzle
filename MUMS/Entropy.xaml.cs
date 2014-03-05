using System;
using System.Linq;
using System.Windows.Controls;

namespace Puzzle.MUMS
{
    /// <summary>
    /// Interaction logic for Entropy.xaml
    /// </summary>
    public partial class Entropy : Page
    {
        public Entropy()
        {
            InitializeComponent();
            int[] input = {
                2, 13, 23, 37, 41, 7, 11, 79,
                11, 37, 47, 53, 11, 61, 47, 3,
                71, 2, 23, 43, 11, 7, 3, 97,
                19, 11, 2, 71, 23, 43, 17, 17,
                2, 37, 37, 23, 5, 2, 5, 23,
                7, 83, 23, 71, 19, 83, 2, 71,
                11, 61, 73, 43, 7, 11, 61, 53,
                61, 11, 67, 67, 73, 61, 11
            };
            MainTextBox.Text = Decode(input);
        }

        static string Decode(int[] input)
        {
            var dic = Enumerable.Range(0, 26).Zip(Utility.Primes, Tuple.Create)
                .ToDictionary(tuple => tuple.Item2, tuple => tuple.Item1);
            return String.Concat(from p in input select (char)('A' + dic[p]));
        }
    }
}
