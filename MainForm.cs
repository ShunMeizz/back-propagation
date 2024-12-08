using System;
using System.Windows.Forms;
using Backprop;

namespace back_propagation
{
    public partial class MainForm : Form
    {
        NeuralNet nn;
        int inputSize = 2;
        int outputSize = 1;
        int hiddenNeuron;
        int min_epoch = 10000;
        int curr_epoch;
        int[,] orDataSet = new int[4, 3]
        {
            { 0, 0, 0 },
            { 0, 1, 1 },
            { 1, 0, 1 },
            { 1, 1, 1 }
        };

        int[,] andDataSet = new int[16, 5]
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 1, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 1, 0, 1, 0 },
            { 0, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 1, 0 },
            { 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0 },
            { 1, 1, 0, 0, 0 },
            { 1, 1, 0, 1, 0 },
            { 1, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 1 }
        };

        int[,] dataSet;

        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "OR", "AND" });
            comboBox1.SelectedIndex = 1; 
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "OR")
            {
                dataSet = orDataSet;
                inputSize = 2;
                outputSize = 1;
                tbInput3.Enabled = false;
                tbInput4.Enabled = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "AND")
            {
                dataSet = andDataSet;
                inputSize = 4;
                outputSize = 1;
                tbInput3.Enabled = true;
                tbInput4.Enabled = true;
            }

            CreateNN();
        }

        private void CreateNN()
        {
            hiddenNeuron = (int)((2 / 3.0) * inputSize) + outputSize;
            nn = new NeuralNet(inputSize, hiddenNeuron, outputSize);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                CreateNN();
            }

            if (curr_epoch == 0)
            {
                for (int i = 1; i <= min_epoch; i++)
                {
                    trainNN();
                    double mad = testTrainNN();
                    if (mad <= 0.01)
                    {
                        min_epoch = i;
                        break;
                    }
                }

                curr_epoch = min_epoch;
            }
            else
            {
                int epoch = Convert.ToInt32(tbEpoch.Text);
                for (int i = 0; i < epoch; i++)
                {
                    trainNN();
                }

                curr_epoch += epoch;
            }

            MessageBox.Show($"Training complete! Epochs: {curr_epoch}", "Training", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trainNN()
        {
            for (int i = 0; i < Math.Pow(2, inputSize); i++)
            {
                for (int j = 0; j < inputSize; j++)
                {
                    nn.setInputs(j, dataSet[i, j]);
                }

                nn.setDesiredOutput(0, dataSet[i, inputSize]);
                nn.learn();
            }
        }

        private double testTrainNN()
        {
            double errorSum = 0;

            for (int i = 0; i < Math.Pow(2, inputSize); i++)
            {
                for (int j = 0; j < inputSize; j++)
                {
                    nn.setInputs(j, dataSet[i, j]);
                }

                nn.run();
                errorSum += Math.Abs((double)dataSet[i, inputSize] - nn.getOuputData(0));
            }

            return errorSum / Math.Pow(2, inputSize);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "OR")
            {
                nn.setInputs(0, Convert.ToDouble(tbInput1.Text));
                nn.setInputs(1, Convert.ToDouble(tbInput2.Text));
            }
            else if (comboBox1.SelectedItem.ToString() == "AND")
            {
                nn.setInputs(0, Convert.ToDouble(tbInput1.Text));
                nn.setInputs(1, Convert.ToDouble(tbInput2.Text));

                if (tbInput3.Enabled && tbInput4.Enabled)
                {
                    nn.setInputs(2, Convert.ToDouble(tbInput3.Text));
                    nn.setInputs(3, Convert.ToDouble(tbInput4.Text));
                }
                else
                {
                    MessageBox.Show("Please enable tbInput3 and tbInput4 for AND dataset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            nn.run();
            tbOutput.Text = "" + nn.getOuputData(0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateNN();
            curr_epoch = 0;
            MessageBox.Show("Neural Network Created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            min_epoch = 10000;
        }
    }
}
