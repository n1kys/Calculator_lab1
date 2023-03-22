namespace WinFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            xPoweraHalf = new Button();
            Press8 = new Button();
            Press9 = new Button();
            Cos = new Button();
            textBox1 = new TextBox();
            Press6 = new Button();
            Press3 = new Button();
            Press4 = new Button();
            OneDivX = new Button();
            Press5 = new Button();
            Press7 = new Button();
            button11 = new Button();
            ChangeSign = new Button();
            Equal = new Button();
            Press2 = new Button();
            Press1 = new Button();
            ToDouble = new Button();
            Mult = new Button();
            Add = new Button();
            Minus = new Button();
            Backspace = new Button();
            Division = new Button();
            Sin = new Button();
            Square = new Button();
            Clear = new Button();
            MaxValue = new TextBox();
            MinValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SubmitValue = new Button();
            SuspendLayout();
            // 
            // xPoweraHalf
            // 
            xPoweraHalf.BackColor = Color.Gray;
            xPoweraHalf.FlatAppearance.BorderSize = 0;
            xPoweraHalf.FlatStyle = FlatStyle.Flat;
            xPoweraHalf.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            xPoweraHalf.Location = new Point(10, 106);
            xPoweraHalf.Margin = new Padding(3, 2, 3, 2);
            xPoweraHalf.Name = "xPoweraHalf";
            xPoweraHalf.Size = new Size(52, 31);
            xPoweraHalf.TabIndex = 0;
            xPoweraHalf.Text = "x½";
            xPoweraHalf.UseVisualStyleBackColor = false;
            xPoweraHalf.Click += xPoweraHalf_Click;
            // 
            // Press8
            // 
            Press8.Location = new Point(76, 149);
            Press8.Margin = new Padding(3, 2, 3, 2);
            Press8.Name = "Press8";
            Press8.Size = new Size(52, 31);
            Press8.TabIndex = 1;
            Press8.Text = "8";
            Press8.UseVisualStyleBackColor = true;
            Press8.Click += Press8_Click;
            // 
            // Press9
            // 
            Press9.Location = new Point(138, 149);
            Press9.Margin = new Padding(3, 2, 3, 2);
            Press9.Name = "Press9";
            Press9.Size = new Size(52, 31);
            Press9.TabIndex = 2;
            Press9.Text = "9";
            Press9.UseVisualStyleBackColor = true;
            Press9.Click += Press9_Click;
            // 
            // Cos
            // 
            Cos.BackColor = Color.Gray;
            Cos.FlatAppearance.BorderSize = 0;
            Cos.FlatStyle = FlatStyle.Flat;
            Cos.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cos.Location = new Point(76, 106);
            Cos.Margin = new Padding(3, 2, 3, 2);
            Cos.Name = "Cos";
            Cos.Size = new Size(52, 31);
            Cos.TabIndex = 3;
            Cos.Text = "cos";
            Cos.UseVisualStyleBackColor = false;
            Cos.Click += Cos_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(3, 9);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 51);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Press6
            // 
            Press6.Location = new Point(138, 191);
            Press6.Margin = new Padding(3, 2, 3, 2);
            Press6.Name = "Press6";
            Press6.Size = new Size(52, 31);
            Press6.TabIndex = 5;
            Press6.Text = "6";
            Press6.UseVisualStyleBackColor = true;
            Press6.Click += Press6_Click;
            // 
            // Press3
            // 
            Press3.Location = new Point(138, 233);
            Press3.Margin = new Padding(3, 2, 3, 2);
            Press3.Name = "Press3";
            Press3.Size = new Size(52, 31);
            Press3.TabIndex = 6;
            Press3.Text = "3";
            Press3.UseVisualStyleBackColor = true;
            Press3.Click += Press3_Click;
            // 
            // Press4
            // 
            Press4.Location = new Point(10, 191);
            Press4.Margin = new Padding(3, 2, 3, 2);
            Press4.Name = "Press4";
            Press4.Size = new Size(52, 31);
            Press4.TabIndex = 7;
            Press4.Text = "4";
            Press4.UseVisualStyleBackColor = true;
            Press4.Click += Press4_Click;
            // 
            // OneDivX
            // 
            OneDivX.BackColor = Color.Gray;
            OneDivX.FlatAppearance.BorderSize = 0;
            OneDivX.FlatStyle = FlatStyle.Flat;
            OneDivX.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OneDivX.Location = new Point(138, 106);
            OneDivX.Margin = new Padding(3, 2, 3, 2);
            OneDivX.Name = "OneDivX";
            OneDivX.Size = new Size(52, 31);
            OneDivX.TabIndex = 8;
            OneDivX.Text = "1/x";
            OneDivX.UseVisualStyleBackColor = false;
            OneDivX.Click += OneDivX_Click;
            // 
            // Press5
            // 
            Press5.Location = new Point(76, 191);
            Press5.Margin = new Padding(3, 2, 3, 2);
            Press5.Name = "Press5";
            Press5.Size = new Size(52, 31);
            Press5.TabIndex = 9;
            Press5.Text = "5";
            Press5.UseVisualStyleBackColor = true;
            Press5.Click += Press5_Click;
            // 
            // Press7
            // 
            Press7.Location = new Point(10, 149);
            Press7.Margin = new Padding(3, 2, 3, 2);
            Press7.Name = "Press7";
            Press7.Size = new Size(52, 31);
            Press7.TabIndex = 10;
            Press7.Text = "7";
            Press7.UseVisualStyleBackColor = true;
            Press7.Click += Press7_Click;
            // 
            // button11
            // 
            button11.Location = new Point(76, 275);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(52, 31);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Press0_Click;
            // 
            // ChangeSign
            // 
            ChangeSign.BackColor = Color.Gray;
            ChangeSign.FlatAppearance.BorderSize = 0;
            ChangeSign.FlatStyle = FlatStyle.Flat;
            ChangeSign.Location = new Point(10, 275);
            ChangeSign.Margin = new Padding(3, 2, 3, 2);
            ChangeSign.Name = "ChangeSign";
            ChangeSign.Size = new Size(52, 31);
            ChangeSign.TabIndex = 12;
            ChangeSign.Text = "±";
            ChangeSign.UseVisualStyleBackColor = false;
            ChangeSign.Click += ChangeSign_Click;
            // 
            // Equal
            // 
            Equal.BackColor = Color.DarkGreen;
            Equal.FlatAppearance.BorderSize = 0;
            Equal.FlatStyle = FlatStyle.Flat;
            Equal.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Equal.Location = new Point(214, 275);
            Equal.Margin = new Padding(3, 2, 3, 2);
            Equal.Name = "Equal";
            Equal.Size = new Size(82, 31);
            Equal.TabIndex = 13;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = false;
            Equal.Click += Equal_Click;
            // 
            // Press2
            // 
            Press2.Location = new Point(76, 233);
            Press2.Margin = new Padding(3, 2, 3, 2);
            Press2.Name = "Press2";
            Press2.Size = new Size(52, 31);
            Press2.TabIndex = 14;
            Press2.Text = "2";
            Press2.UseVisualStyleBackColor = true;
            Press2.Click += Press2_Click;
            // 
            // Press1
            // 
            Press1.Location = new Point(10, 233);
            Press1.Margin = new Padding(3, 2, 3, 2);
            Press1.Name = "Press1";
            Press1.Size = new Size(52, 31);
            Press1.TabIndex = 15;
            Press1.Text = "1";
            Press1.UseVisualStyleBackColor = true;
            Press1.Click += Press1_Click;
            // 
            // ToDouble
            // 
            ToDouble.BackColor = Color.Gray;
            ToDouble.FlatAppearance.BorderSize = 0;
            ToDouble.FlatStyle = FlatStyle.Flat;
            ToDouble.Location = new Point(138, 275);
            ToDouble.Margin = new Padding(3, 2, 3, 2);
            ToDouble.Name = "ToDouble";
            ToDouble.Size = new Size(52, 31);
            ToDouble.TabIndex = 16;
            ToDouble.Text = ",";
            ToDouble.UseVisualStyleBackColor = false;
            ToDouble.Click += ToDouble_Click;
            // 
            // Mult
            // 
            Mult.BackColor = Color.Gray;
            Mult.FlatAppearance.BorderSize = 0;
            Mult.FlatStyle = FlatStyle.Flat;
            Mult.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Mult.ForeColor = SystemColors.ActiveCaptionText;
            Mult.Location = new Point(214, 191);
            Mult.Margin = new Padding(3, 2, 3, 2);
            Mult.Name = "Mult";
            Mult.Size = new Size(82, 31);
            Mult.TabIndex = 17;
            Mult.Text = "×";
            Mult.UseVisualStyleBackColor = false;
            Mult.Click += Mult_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.Gray;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = SystemColors.ActiveCaptionText;
            Add.Location = new Point(214, 106);
            Add.Margin = new Padding(3, 2, 3, 2);
            Add.Name = "Add";
            Add.Size = new Size(82, 31);
            Add.TabIndex = 18;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Minus
            // 
            Minus.BackColor = Color.Gray;
            Minus.FlatAppearance.BorderSize = 0;
            Minus.FlatStyle = FlatStyle.Flat;
            Minus.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Minus.ForeColor = SystemColors.ActiveCaptionText;
            Minus.Location = new Point(214, 149);
            Minus.Margin = new Padding(3, 2, 3, 2);
            Minus.Name = "Minus";
            Minus.Size = new Size(82, 31);
            Minus.TabIndex = 19;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = false;
            Minus.Click += Minus_Click;
            // 
            // Backspace
            // 
            Backspace.BackColor = Color.Gray;
            Backspace.FlatAppearance.BorderSize = 0;
            Backspace.FlatStyle = FlatStyle.Flat;
            Backspace.Image = (Image)resources.GetObject("Backspace.Image");
            Backspace.Location = new Point(214, 64);
            Backspace.Margin = new Padding(3, 2, 3, 2);
            Backspace.Name = "Backspace";
            Backspace.Size = new Size(82, 31);
            Backspace.TabIndex = 20;
            Backspace.UseVisualStyleBackColor = false;
            Backspace.Click += Backspace_Click;
            // 
            // Division
            // 
            Division.BackColor = Color.Gray;
            Division.FlatAppearance.BorderSize = 0;
            Division.FlatStyle = FlatStyle.Flat;
            Division.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Division.ForeColor = SystemColors.ActiveCaptionText;
            Division.Location = new Point(214, 233);
            Division.Margin = new Padding(3, 2, 3, 2);
            Division.Name = "Division";
            Division.Size = new Size(82, 31);
            Division.TabIndex = 21;
            Division.Text = "÷";
            Division.UseVisualStyleBackColor = false;
            Division.Click += Div_Click;
            // 
            // Sin
            // 
            Sin.BackColor = Color.Gray;
            Sin.FlatAppearance.BorderSize = 0;
            Sin.FlatStyle = FlatStyle.Flat;
            Sin.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Sin.Location = new Point(76, 64);
            Sin.Margin = new Padding(3, 2, 3, 2);
            Sin.Name = "Sin";
            Sin.Size = new Size(52, 31);
            Sin.TabIndex = 22;
            Sin.Text = "sin";
            Sin.UseVisualStyleBackColor = false;
            Sin.Click += Sin_Click;
            // 
            // Square
            // 
            Square.BackColor = Color.Gray;
            Square.FlatAppearance.BorderSize = 0;
            Square.FlatStyle = FlatStyle.Flat;
            Square.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Square.Location = new Point(10, 64);
            Square.Margin = new Padding(3, 2, 3, 2);
            Square.Name = "Square";
            Square.Size = new Size(52, 31);
            Square.TabIndex = 23;
            Square.Text = "x²";
            Square.UseVisualStyleBackColor = false;
            Square.Click += Square_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Gray;
            Clear.FlatAppearance.BorderSize = 0;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(138, 64);
            Clear.Margin = new Padding(3, 2, 3, 2);
            Clear.Name = "Clear";
            Clear.Size = new Size(52, 31);
            Clear.TabIndex = 24;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // MaxValue
            // 
            MaxValue.BackColor = SystemColors.WindowFrame;
            MaxValue.ForeColor = SystemColors.Window;
            MaxValue.Location = new Point(103, 339);
            MaxValue.Name = "MaxValue";
            MaxValue.RightToLeft = RightToLeft.No;
            MaxValue.Size = new Size(87, 23);
            MaxValue.TabIndex = 25;
            MaxValue.TextAlign = HorizontalAlignment.Right;
            MaxValue.KeyPress += MaxValue_KeyPress;
            // 
            // MinValue
            // 
            MinValue.BackColor = SystemColors.WindowFrame;
            MinValue.ForeColor = SystemColors.Window;
            MinValue.Location = new Point(12, 339);
            MinValue.Name = "MinValue";
            MinValue.Size = new Size(85, 23);
            MinValue.TabIndex = 26;
            MinValue.TextAlign = HorizontalAlignment.Right;
            MinValue.KeyPress += MinValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(24, 321);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 27;
            label1.Text = "Min value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(115, 321);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 28;
            label2.Text = "Max value";
            // 
            // SubmitValue
            // 
            SubmitValue.Location = new Point(214, 339);
            SubmitValue.Name = "SubmitValue";
            SubmitValue.Size = new Size(82, 23);
            SubmitValue.TabIndex = 29;
            SubmitValue.Text = "Submit";
            SubmitValue.UseVisualStyleBackColor = true;
            SubmitValue.Click += SubmitValue_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(304, 375);
            Controls.Add(SubmitValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MinValue);
            Controls.Add(MaxValue);
            Controls.Add(Clear);
            Controls.Add(Square);
            Controls.Add(Sin);
            Controls.Add(Division);
            Controls.Add(Backspace);
            Controls.Add(Minus);
            Controls.Add(Add);
            Controls.Add(Mult);
            Controls.Add(ToDouble);
            Controls.Add(Press1);
            Controls.Add(Press2);
            Controls.Add(Equal);
            Controls.Add(ChangeSign);
            Controls.Add(button11);
            Controls.Add(Press7);
            Controls.Add(Press5);
            Controls.Add(OneDivX);
            Controls.Add(Press4);
            Controls.Add(Press3);
            Controls.Add(Press6);
            Controls.Add(textBox1);
            Controls.Add(Cos);
            Controls.Add(Press9);
            Controls.Add(Press8);
            Controls.Add(xPoweraHalf);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button xPoweraHalf;
        private Button Press8;
        private Button Press9;
        private Button Cos;
        private TextBox textBox1;
        private Button Press6;
        private Button Press3;
        private Button Press4;
        private Button OneDivX;
        private Button Press5;
        private Button Press7;
        private Button button11;
        private Button ChangeSign;
        private Button Equal;
        private Button Press2;
        private Button Press1;
        private Button ToDouble;
        private Button Mult;
        private Button Add;
        private Button Minus;
        private Button Backspace;
        private Button Division;
        private Button Sin;
        private Button Square;
        private Button Clear;
        private TextBox MaxValue;
        private TextBox MinValue;
        private Label label1;
        private Label label2;
        private Button SubmitValue;
    }
}