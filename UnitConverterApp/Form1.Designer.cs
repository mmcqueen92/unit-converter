namespace UnitConverterApp
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
            ConvertButton = new Button();
            FromUnitSelect = new ComboBox();
            ConvertLabel = new Label();
            ToLabel = new Label();
            InitialValue = new TextBox();
            ToUnitSelect = new ComboBox();
            ResultLabel = new Label();
            ResultBox = new TextBox();
            SuspendLayout();
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(53, 154);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(75, 23);
            ConvertButton.TabIndex = 0;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // FromUnitSelect
            // 
            FromUnitSelect.DisplayMember = "Miles";
            FromUnitSelect.FormattingEnabled = true;
            FromUnitSelect.Items.AddRange(new object[] { "Miles", "Kilometres" });
            FromUnitSelect.Location = new Point(231, 74);
            FromUnitSelect.Name = "FromUnitSelect";
            FromUnitSelect.Size = new Size(121, 23);
            FromUnitSelect.TabIndex = 1;
            // 
            // ConvertLabel
            // 
            ConvertLabel.AutoSize = true;
            ConvertLabel.Location = new Point(53, 74);
            ConvertLabel.Name = "ConvertLabel";
            ConvertLabel.Size = new Size(52, 15);
            ConvertLabel.TabIndex = 2;
            ConvertLabel.Text = "Convert:";
            ConvertLabel.Click += label1_Click;
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(53, 116);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(22, 15);
            ToLabel.TabIndex = 3;
            ToLabel.Text = "To:";
            // 
            // InitialValue
            // 
            InitialValue.Location = new Point(108, 74);
            InitialValue.Name = "InitialValue";
            InitialValue.Size = new Size(100, 23);
            InitialValue.TabIndex = 4;
            InitialValue.TextChanged += initialValue_TextChanged;
            InitialValue.KeyPress += initialValue_KeyPress;
            // 
            // ToUnitSelect
            // 
            ToUnitSelect.FormattingEnabled = true;
            ToUnitSelect.Items.AddRange(new object[] { "Miles", "Kilometres" });
            ToUnitSelect.Location = new Point(231, 116);
            ToUnitSelect.Name = "ToUnitSelect";
            ToUnitSelect.Size = new Size(121, 23);
            ToUnitSelect.TabIndex = 5;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(53, 204);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(42, 15);
            ResultLabel.TabIndex = 6;
            ResultLabel.Text = "Result:";
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(108, 204);
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(100, 23);
            ResultBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 324);
            Controls.Add(ResultBox);
            Controls.Add(ResultLabel);
            Controls.Add(ToUnitSelect);
            Controls.Add(InitialValue);
            Controls.Add(ToLabel);
            Controls.Add(ConvertLabel);
            Controls.Add(FromUnitSelect);
            Controls.Add(ConvertButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConvertButton;
        private ComboBox FromUnitSelect;
        private Label ConvertLabel;
        private Label ToLabel;
        private TextBox InitialValue;
        private ComboBox ToUnitSelect;
        private Label ResultLabel;
        private TextBox ResultBox;
    }
}
