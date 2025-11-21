namespace Bank_account
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
            Accountname = new TextBox();
            Amount = new NumericUpDown();
            backaccgrid = new DataGridView();
            Depositebtn = new Button();
            withdrawbtn = new Button();
            createbtn = new Button();
            label4 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backaccgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "New Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            label2.Click += label2_Click;
            // 
            // Accountname
            // 
            Accountname.Location = new Point(136, 35);
            Accountname.Name = "Accountname";
            Accountname.Size = new Size(142, 27);
            Accountname.TabIndex = 2;
            // 
            // Amount
            // 
            Amount.Location = new Point(128, 214);
            Amount.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            Amount.Minimum = new decimal(new int[] { -1530494977, 232830, 0, int.MinValue });
            Amount.Name = "Amount";
            Amount.Size = new Size(150, 27);
            Amount.TabIndex = 3;
            Amount.ValueChanged += Amount_ValueChanged;
            // 
            // backaccgrid
            // 
            backaccgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            backaccgrid.Location = new Point(297, 35);
            backaccgrid.Name = "backaccgrid";
            backaccgrid.RowHeadersWidth = 51;
            backaccgrid.Size = new Size(390, 157);
            backaccgrid.TabIndex = 4;
            // 
            // Depositebtn
            // 
            Depositebtn.Location = new Point(392, 210);
            Depositebtn.Name = "Depositebtn";
            Depositebtn.Size = new Size(118, 31);
            Depositebtn.TabIndex = 5;
            Depositebtn.Text = "Deposite";
            Depositebtn.UseVisualStyleBackColor = true;
            Depositebtn.Click += Deposite_Click;
            // 
            // withdrawbtn
            // 
            withdrawbtn.Location = new Point(532, 210);
            withdrawbtn.Name = "withdrawbtn";
            withdrawbtn.Size = new Size(112, 29);
            withdrawbtn.TabIndex = 6;
            withdrawbtn.Text = "Withdraw";
            withdrawbtn.UseVisualStyleBackColor = true;
            withdrawbtn.Click += withdrawbtn_Click;
            // 
            // createbtn
            // 
            createbtn.Location = new Point(136, 118);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(118, 38);
            createbtn.TabIndex = 7;
            createbtn.Text = "Create Account";
            createbtn.UseVisualStyleBackColor = true;
            createbtn.Click += createBTN;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 82);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 9;
            label4.Text = "Interest Rate (%)";
            label4.Click += label4_Click;
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(136, 75);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(89, 27);
            InterestRateNum.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 263);
            Controls.Add(InterestRateNum);
            Controls.Add(label4);
            Controls.Add(createbtn);
            Controls.Add(withdrawbtn);
            Controls.Add(Depositebtn);
            Controls.Add(backaccgrid);
            Controls.Add(Amount);
            Controls.Add(Accountname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)backaccgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Accountname;
        private NumericUpDown Amount;
        private DataGridView backaccgrid;
        private Button Depositebtn;
        private Button withdrawbtn;
        private Button createbtn;
        private Label label4;
        private NumericUpDown InterestRateNum;
    }
}
