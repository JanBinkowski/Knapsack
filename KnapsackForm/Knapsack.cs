using System;
using System.Windows.Forms;
using Engine;


namespace KnapsackForm
{
    public partial class Knapsack : Form
    {
        public Knapsack()
        {
            InitializeComponent();
        }

        public void Console()
        {
            string input_n;
            string input_c;
            string input_rng;
            input_n = tbN.Text;
            input_c = tbC.Text;
            input_rng = tbSeed.Text;

            //check if user inputs numbers
            if ((!IsNumber(input_n)) || (!IsNumber(input_c)) || (!IsNumber(input_rng)))
            {
                System.Environment.Exit(0);
            }

            int amountOfItems = Convert.ToInt32(input_n);
            int capacity_is = Convert.ToInt32(input_c);
            int rngSeed = Convert.ToInt32(input_rng);

            ItemGenerator generator = new ItemGenerator(amountOfItems, rngSeed);

            generator.showItems();
            
                    int[] values = generator.getValues();
            int[] weights = generator.getWeights();

            Algorithm algo = new Algorithm();

            rtbTotalValue.Text = algo.KnapSack(capacity_is, weights, values, amountOfItems).ToString();

        }

        public static bool IsNumber(string input)
        {
            int value;
            if (int.TryParse(input, out value))
                return true;
            else
                return false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
