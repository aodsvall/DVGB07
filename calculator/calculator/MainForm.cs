namespace calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Button Button1;
        private int LeftHandSide;
        private int RightHandSide;


        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.OperationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 33);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(53, 49);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(71, 33);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(53, 49);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(130, 33);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(53, 49);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(12, 88);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(53, 49);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(71, 88);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(53, 49);
            this.Button5.TabIndex = 4;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(130, 88);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(53, 49);
            this.Button6.TabIndex = 3;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(12, 143);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(53, 49);
            this.Button7.TabIndex = 11;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(71, 143);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(53, 49);
            this.Button8.TabIndex = 10;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(130, 143);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(53, 49);
            this.Button9.TabIndex = 9;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 198);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(53, 49);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(71, 198);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(53, 49);
            this.Button0.TabIndex = 7;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(130, 198);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(53, 49);
            this.EqualButton.TabIndex = 6;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            // 
            // DivisionButton
            // 
            this.DivisionButton.Location = new System.Drawing.Point(189, 198);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(53, 49);
            this.DivisionButton.TabIndex = 15;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Location = new System.Drawing.Point(189, 143);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(53, 49);
            this.MultiplicationButton.TabIndex = 14;
            this.MultiplicationButton.Text = "X";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Location = new System.Drawing.Point(189, 88);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(53, 49);
            this.SubtractionButton.TabIndex = 13;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            // 
            // AdditionButton
            // 
            this.AdditionButton.Location = new System.Drawing.Point(189, 33);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(53, 49);
            this.AdditionButton.TabIndex = 12;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(12, 4);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(171, 27);
            this.ResultBox.TabIndex = 16;
            // 
            // OperationTextBox
            // 
            this.OperationTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.OperationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OperationTextBox.Location = new System.Drawing.Point(189, 4);
            this.OperationTextBox.Name = "OperationTextBox";
            this.OperationTextBox.Size = new System.Drawing.Size(53, 20);
            this.OperationTextBox.TabIndex = 17;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(249, 261);
            this.Controls.Add(this.OperationTextBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button Button7;
        private Button Button8;
        private Button Button9;
        private Button ClearButton;
        private Button Button0;
        private Button EqualButton;
        private Button DivisionButton;
        private Button MultiplicationButton;
        private Button SubtractionButton;
        private Button AdditionButton;
        private TextBox ResultBox;
        private TextBox OperationTextBox;

        //Generic method to add to left text box
        private void AddToResultBox(Button button)
        {
            ResultBox.Text += button.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button9);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            AddToResultBox(Button0);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
            OperationTextBox.Clear();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            LeftHandSide = int.Parse(ResultBox.Text);
        }
    }
}