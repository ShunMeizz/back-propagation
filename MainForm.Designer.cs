namespace back_propagation
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tbInput1 = new TextBox();
            tbInput2 = new TextBox();
            tbInput3 = new TextBox();
            tbInput4 = new TextBox();
            btnCreate = new Button();
            btnTrain = new Button();
            btnTest = new Button();
            tbOutput = new TextBox();
            tbEpoch = new TextBox();
            tbThreshold = new TextBox();
            Threshold = new Label();
            Epoch = new Label();
            Output = new Label();
            Input = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();

            // 
            // tbInput1
            // 
            tbInput1.Location = new Point(52, 75);
            tbInput1.Name = "tbInput1";
            tbInput1.Size = new Size(142, 23);
            tbInput1.TabIndex = 0;

            // 
            // tbInput2
            // 
            tbInput2.Location = new Point(52, 110);
            tbInput2.Name = "tbInput2";
            tbInput2.Size = new Size(142, 23);
            tbInput2.TabIndex = 1;

            // 
            // tbInput3 (initially disabled for OR)
            // 
            tbInput3.Location = new Point(52, 145);
            tbInput3.Name = "tbInput3";
            tbInput3.Size = new Size(142, 23);
            tbInput3.TabIndex = 2;
            tbInput3.Enabled = false; // Disabled for OR

            // 
            // tbInput4 (initially disabled for OR)
            // 
            tbInput4.Location = new Point(52, 180);
            tbInput4.Name = "tbInput4";
            tbInput4.Size = new Size(142, 23);
            tbInput4.TabIndex = 3;
            tbInput4.Enabled = false; // Disabled for OR

            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(53, 231);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(142, 30);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;

            // 
            // btnTrain
            // 
            btnTrain.Location = new Point(240, 231);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(142, 30);
            btnTrain.TabIndex = 5;
            btnTrain.Text = "Train";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += btnTrain_Click;

            // 
            // btnTest
            // 
            btnTest.Location = new Point(426, 231);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(142, 30);
            btnTest.TabIndex = 6;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;

            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(426, 180);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(142, 23);
            tbOutput.TabIndex = 7;

            // 
            // tbEpoch
            // 
            tbEpoch.Location = new Point(240, 180);
            tbEpoch.Name = "tbEpoch";
            tbEpoch.Size = new Size(142, 23);
            tbEpoch.TabIndex = 8;

            // 
            // tbThreshold
            // 
            tbThreshold.Location = new Point(240, 130);
            tbThreshold.Name = "tbThreshold";
            tbThreshold.Size = new Size(142, 23);
            tbThreshold.TabIndex = 9;

            // 
            // Threshold
            // 
            Threshold.AutoSize = true;
            Threshold.Location = new Point(235, 108);
            Threshold.Name = "Threshold";
            Threshold.Size = new Size(59, 15);
            Threshold.TabIndex = 10;
            Threshold.Text = "Threshold";

            // 
            // Epoch
            // 
            Epoch.AutoSize = true;
            Epoch.Location = new Point(237, 162);
            Epoch.Name = "Epoch";
            Epoch.Size = new Size(40, 15);
            Epoch.TabIndex = 11;
            Epoch.Text = "Epoch";

            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(423, 161);
            Output.Name = "Output";
            Output.Size = new Size(45, 15);
            Output.TabIndex = 12;
            Output.Text = "Output";

            // 
            // Input
            // 
            Input.AutoSize = true;
            Input.Location = new Point(49, 52);
            Input.Name = "Input";
            Input.Size = new Size(35, 15);
            Input.TabIndex = 13;
            Input.Text = "Input";

            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(650, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 14;

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(Input);
            Controls.Add(Output);
            Controls.Add(Epoch);
            Controls.Add(Threshold);
            Controls.Add(tbThreshold);
            Controls.Add(tbEpoch);
            Controls.Add(tbOutput);
            Controls.Add(btnTest);
            Controls.Add(btnTrain);
            Controls.Add(btnCreate);
            Controls.Add(tbInput4);
            Controls.Add(tbInput3);
            Controls.Add(tbInput2);
            Controls.Add(tbInput1);
            Name = "MainForm";
            Text = "Backpropagation Neural Network";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInput1;
        private TextBox tbInput2;
        private TextBox tbInput3;
        private TextBox tbInput4;
        private Button btnCreate;
        private Button btnTrain;
        private Button btnTest;
        private TextBox tbOutput;
        private TextBox tbEpoch;
        private TextBox tbThreshold;
        private Label Threshold;
        private Label Epoch;
        private Label Output;
        private Label Input;
        private ComboBox comboBox1;
    }
}
