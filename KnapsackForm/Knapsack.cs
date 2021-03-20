using System;
using System.Windows.Forms;
using Engine;


namespace KnapsackForm
{
    public partial class Knapsack : Form
    {
        private string input_n;
        private string input_c;
        private string input_rng;

        private int totalValue = 0;
        private string[] sequence;

        public Knapsack()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            input_n = tbN.Text;
            input_c = tbC.Text;
            input_rng = tbSeed.Text;

            //check if user inputs numbers
            if ((!IsNumber(input_n)) || (!IsNumber(input_c)) || (!IsNumber(input_rng)))
            {
                System.Windows.Forms.MessageBox.Show("Wrong input values!");
            }
            else
            {
                int amountOfItems = Convert.ToInt32(input_n);
                int capacity_is = Convert.ToInt32(input_c);
                int rngSeed = Convert.ToInt32(input_rng);

                ItemGenerator generator = new ItemGenerator(amountOfItems, rngSeed);

                int[] values = generator.getValues();
                int[] weights = generator.getWeights();

                AddMoreToList(values, weights);

                Algorithm algo = new Algorithm();

                totalValue = algo.KnapSack(capacity_is, weights, values, amountOfItems);
                SetTotalValue(totalValue.ToString());
            }
        }

        public static bool IsNumber(string input)
        {
            int value;
            if (int.TryParse(input, out value))
                return true;
            else
                return false;
        }

        private void SetTotalValue(string s)
        {
            rtbTotalValue.Text = s;
        }

        private void AddItemToList(string s)
        {
            lbItems.Items.Add(s);
        }

        private void AddMoreToList(int[] v, int[] w)
        {
            string row;
            for(int i = 0; i<v.Length; i++)
            {
                row = (i+1).ToString() + "\t" + w[i].ToString() + "\t" + v[i].ToString();
                AddItemToList(row);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
