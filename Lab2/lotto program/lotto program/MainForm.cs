namespace lotto_program
{
    public partial class Lotto : Form
    {
        public Lotto()
        {
            InitializeComponent();
        }
        
        private void DrawRow(List<int> drawnNumbers)
        {
            for (int i = 0; i < 7; i++)
            {
                Random rand = new();
                int number = rand.Next(1, 35);
                drawnNumbers.Add(number);
            }
            //https://stackoverflow.com/questions/18303897/test-if-all-values-in-a-list-are-unique
            bool uniqueNumbers = drawnNumbers.Distinct().Count() == drawnNumbers.Count;
            if(!uniqueNumbers)
            {
                drawnNumbers.Clear();
                DrawRow(drawnNumbers);
            }

        }

        private void RunLotto()
        {
            int numberOfDraws;
            List<int> lottoNumbers = new List<int>{ int.Parse(numField1.Text), int.Parse(numField2.Text),
                int.Parse(numField3.Text), int.Parse(numField4.Text), int.Parse(numField5.Text),
                int.Parse(numField6.Text), int.Parse(numField7.Text) };

            //https://stackoverflow.com/questions/18303897/test-if-all-values-in-a-list-are-unique
            bool uniqueNumbers = lottoNumbers.Distinct().Count() == lottoNumbers.Count;

            if(!uniqueNumbers)
            {
                MessageBox.Show("Alla nummer är inte unika!, Skriv in nya.", "ERROR");
                lottoNumbers.Clear();
                return;
            }
            if(!(lottoNumbers.Max() < 36 && lottoNumbers.Min() > 0))
            {
                MessageBox.Show("Alla nummer är inte mellan 1-35, Skriv in nya.", "ERROR");
                lottoNumbers.Clear();
                return;
            }
            if(int.TryParse(numDraws.Text, out numberOfDraws) == false)
            {
                MessageBox.Show("Antalet dragningar måste vara en int", "ERROR");
                numDraws.Clear();
                return;
            }
            List<int> drawnNumbers = new();
            int numberOfCorrect;
            int five = 0;
            int six = 0;
            int seven = 0;
            for(int i = 0; i < int.Parse(numDraws.Text); i++)
            {
                numberOfCorrect = 0;
                DrawRow(drawnNumbers);
                for(int j = 0; j < 7; j++)
                {
                    if (lottoNumbers.Contains(drawnNumbers[j]))
                    {
                        numberOfCorrect++;
                    }
                }
                if (numberOfCorrect == 5)
                {
                    five++;
                    fiveCorrect.Text = five.ToString();
                    continue;
                }
                if (numberOfCorrect == 6)
                {
                    six++;
                    sixCorrect.Text = six.ToString();
                    continue;
                }
                if (numberOfCorrect == 7)
                {
                    seven++;
                    sevenCorrect.Text = seven.ToString();
                    continue;
                }


            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            RunLotto();
        }
    }
}