namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            Button1 = new Button();
            Button2 = new Button();
            ButtonMultiply = new Button();
            Button3 = new Button();
            ButtonReset = new Button();
            Button4 = new Button();
            Button5 = new Button();
            Button6 = new Button();
            ButtonPlus = new Button();
            button7 = new Button();
            Button8 = new Button();
            Button9 = new Button();
            ButtonMinus = new Button();
            ButtonResult = new Button();
            Button0 = new Button();
            ButtonDivide = new Button();
            InputValuesTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Button1, 0, 0);
            tableLayoutPanel1.Controls.Add(Button2, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonMultiply, 3, 3);
            tableLayoutPanel1.Controls.Add(Button3, 2, 0);
            tableLayoutPanel1.Controls.Add(ButtonReset, 3, 0);
            tableLayoutPanel1.Controls.Add(Button4, 0, 1);
            tableLayoutPanel1.Controls.Add(Button5, 1, 1);
            tableLayoutPanel1.Controls.Add(Button6, 2, 1);
            tableLayoutPanel1.Controls.Add(ButtonPlus, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(Button8, 1, 2);
            tableLayoutPanel1.Controls.Add(Button9, 2, 2);
            tableLayoutPanel1.Controls.Add(ButtonMinus, 3, 2);
            tableLayoutPanel1.Controls.Add(ButtonResult, 0, 3);
            tableLayoutPanel1.Controls.Add(Button0, 1, 3);
            tableLayoutPanel1.Controls.Add(ButtonDivide, 2, 3);
            tableLayoutPanel1.Location = new Point(12, 64);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(329, 176);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Button1
            // 
            Button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button1.Location = new Point(3, 4);
            Button1.Margin = new Padding(3, 4, 3, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(76, 36);
            Button1.TabIndex = 0;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button2.Location = new Point(85, 4);
            Button2.Margin = new Padding(3, 4, 3, 4);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 36);
            Button2.TabIndex = 1;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonMultiply.Location = new Point(249, 136);
            ButtonMultiply.Margin = new Padding(3, 4, 3, 4);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(75, 36);
            ButtonMultiply.TabIndex = 14;
            ButtonMultiply.Text = "*";
            ButtonMultiply.UseVisualStyleBackColor = true;
            ButtonMultiply.Click += ButtonMultiply_Click;
            // 
            // Button3
            // 
            Button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button3.Location = new Point(167, 4);
            Button3.Margin = new Padding(3, 4, 3, 4);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 36);
            Button3.TabIndex = 2;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button3_Click;
            // 
            // ButtonReset
            // 
            ButtonReset.BackColor = Color.LightCoral;
            ButtonReset.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonReset.Location = new Point(249, 4);
            ButtonReset.Margin = new Padding(3, 4, 3, 4);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(75, 36);
            ButtonReset.TabIndex = 3;
            ButtonReset.Text = "C";
            ButtonReset.UseVisualStyleBackColor = false;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // Button4
            // 
            Button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button4.Location = new Point(3, 48);
            Button4.Margin = new Padding(3, 4, 3, 4);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 36);
            Button4.TabIndex = 4;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click;
            // 
            // Button5
            // 
            Button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button5.Location = new Point(85, 48);
            Button5.Margin = new Padding(3, 4, 3, 4);
            Button5.Name = "Button5";
            Button5.Size = new Size(75, 36);
            Button5.TabIndex = 5;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = true;
            Button5.Click += Button5_Click;
            // 
            // Button6
            // 
            Button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button6.Location = new Point(167, 48);
            Button6.Margin = new Padding(3, 4, 3, 4);
            Button6.Name = "Button6";
            Button6.Size = new Size(75, 36);
            Button6.TabIndex = 6;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = true;
            Button6.Click += Button6_Click;
            // 
            // ButtonPlus
            // 
            ButtonPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonPlus.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonPlus.Location = new Point(249, 48);
            ButtonPlus.Margin = new Padding(3, 4, 3, 4);
            ButtonPlus.Name = "ButtonPlus";
            ButtonPlus.Size = new Size(75, 36);
            ButtonPlus.TabIndex = 7;
            ButtonPlus.Text = "+";
            ButtonPlus.UseVisualStyleBackColor = true;
            ButtonPlus.Click += ButtonPlus_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button7.Location = new Point(3, 92);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(75, 36);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Button8
            // 
            Button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button8.Location = new Point(85, 92);
            Button8.Margin = new Padding(3, 4, 3, 4);
            Button8.Name = "Button8";
            Button8.Size = new Size(75, 36);
            Button8.TabIndex = 9;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = true;
            Button8.Click += Button8_Click;
            // 
            // Button9
            // 
            Button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button9.Location = new Point(167, 92);
            Button9.Margin = new Padding(3, 4, 3, 4);
            Button9.Name = "Button9";
            Button9.Size = new Size(75, 36);
            Button9.TabIndex = 10;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = true;
            Button9.Click += Button9_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonMinus.Location = new Point(249, 92);
            ButtonMinus.Margin = new Padding(3, 4, 3, 4);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(75, 36);
            ButtonMinus.TabIndex = 11;
            ButtonMinus.Text = "-";
            ButtonMinus.UseVisualStyleBackColor = true;
            ButtonMinus.Click += ButtonMinus_Click;
            // 
            // ButtonResult
            // 
            ButtonResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonResult.Location = new Point(3, 136);
            ButtonResult.Margin = new Padding(3, 4, 3, 4);
            ButtonResult.Name = "ButtonResult";
            ButtonResult.Size = new Size(75, 36);
            ButtonResult.TabIndex = 12;
            ButtonResult.Text = "=";
            ButtonResult.UseVisualStyleBackColor = true;
            ButtonResult.Click += ButtonResult_Click;
            // 
            // Button0
            // 
            Button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button0.Location = new Point(85, 136);
            Button0.Margin = new Padding(3, 4, 3, 4);
            Button0.Name = "Button0";
            Button0.Size = new Size(75, 36);
            Button0.TabIndex = 13;
            Button0.Text = "0";
            Button0.UseVisualStyleBackColor = true;
            Button0.Click += Button0_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonDivide.Location = new Point(167, 136);
            ButtonDivide.Margin = new Padding(3, 4, 3, 4);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(75, 36);
            ButtonDivide.TabIndex = 15;
            ButtonDivide.Text = "/";
            ButtonDivide.UseVisualStyleBackColor = true;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // InputValuesTextBox
            // 
            InputValuesTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            InputValuesTextBox.Location = new Point(15, 13);
            InputValuesTextBox.Margin = new Padding(3, 4, 3, 4);
            InputValuesTextBox.Name = "InputValuesTextBox";
            InputValuesTextBox.RightToLeft = RightToLeft.Yes;
            InputValuesTextBox.Size = new Size(321, 43);
            InputValuesTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(348, 252);
            Controls.Add(InputValuesTextBox);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Калькулятор";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button ButtonReset;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button ButtonPlus;
        private Button button7;
        private Button Button8;
        private Button Button9;
        private Button ButtonMinus;
        private Button ButtonResult;
        private Button Button0;
        private Button ButtonMultiply;
        private Button ButtonDivide;
        private TextBox InputValuesTextBox;
    }
}
