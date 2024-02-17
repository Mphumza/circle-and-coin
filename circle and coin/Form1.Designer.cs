namespace circle_and_coin
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            rbCircle = new RadioButton();
            rbCoin = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button = new Button();
            lblAns = new Label();
            txtWeight = new TextBox();
            txtRadius = new TextBox();
            ComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 22);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Circle vs Coin";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "choose either";
            // 
            // rbCircle
            // 
            rbCircle.AutoSize = true;
            rbCircle.Location = new Point(183, 64);
            rbCircle.Name = "rbCircle";
            rbCircle.Size = new Size(58, 19);
            rbCircle.TabIndex = 2;
            rbCircle.TabStop = true;
            rbCircle.Text = "Circle ";
            rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbCoin
            // 
            rbCoin.AutoSize = true;
            rbCoin.Location = new Point(325, 62);
            rbCoin.Name = "rbCoin";
            rbCoin.Size = new Size(50, 19);
            rbCoin.TabIndex = 3;
            rbCoin.TabStop = true;
            rbCoin.Text = "Coin";
            rbCoin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 64);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 4;
            label3.Text = "OR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 128);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 5;
            label4.Text = "Circle Radius";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 192);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 6;
            label5.Text = "Coin weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 244);
            label6.Name = "label6";
            label6.Size = new Size(249, 15);
            label6.TabIndex = 7;
            label6.Text = "Which Calculation would you like to perform?";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button.Location = new Point(252, 284);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 8;
            button.Text = "Calculate now";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // lblAns
            // 
            lblAns.AutoSize = true;
            lblAns.Location = new Point(73, 319);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(99, 15);
            lblAns.TabIndex = 9;
            lblAns.Text = "Output goes here";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(128, 184);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 10;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(128, 120);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 23);
            txtRadius.TabIndex = 12;
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Items.AddRange(new object[] { "Perimeter", "Area", "CoinValue" });
            ComboBox.Location = new Point(394, 241);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(121, 23);
            ComboBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ComboBox);
            Controls.Add(txtRadius);
            Controls.Add(txtWeight);
            Controls.Add(lblAns);
            Controls.Add(button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rbCoin);
            Controls.Add(rbCircle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rbCircle;
        private RadioButton rbCoin;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button;
        private Label lblAns;
        private TextBox txtWeight;
        private TextBox txtRadius;
        private ComboBox ComboBox;
    }
}