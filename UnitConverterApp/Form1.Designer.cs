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
            convertButton = new Button();
            fromUnitSelect = new ComboBox();
            convertLabel = new Label();
            toLabel = new Label();
            initialValue = new TextBox();
            toUnitSelect = new ComboBox();
            resultLabel = new Label();
            result = new TextBox();
            SuspendLayout();
            // 
            // convertButton
            // 
            convertButton.Location = new Point(53, 154);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 0;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += button1_Click;
            // 
            // fromUnitSelect
            // 
            fromUnitSelect.DisplayMember = "Miles";
            fromUnitSelect.FormattingEnabled = true;
            fromUnitSelect.Items.AddRange(new object[] { "Miles", "Kilometres", "Metres", "Yards" });
            fromUnitSelect.Location = new Point(231, 74);
            fromUnitSelect.Name = "fromUnitSelect";
            fromUnitSelect.Size = new Size(121, 23);
            fromUnitSelect.TabIndex = 1;
            // 
            // convertLabel
            // 
            convertLabel.AutoSize = true;
            convertLabel.Location = new Point(53, 74);
            convertLabel.Name = "convertLabel";
            convertLabel.Size = new Size(52, 15);
            convertLabel.TabIndex = 2;
            convertLabel.Text = "Convert:";
            convertLabel.Click += label1_Click;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(53, 116);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(22, 15);
            toLabel.TabIndex = 3;
            toLabel.Text = "To:";
            // 
            // initialValue
            // 
            initialValue.Location = new Point(108, 74);
            initialValue.Name = "initialValue";
            initialValue.Size = new Size(100, 23);
            initialValue.TabIndex = 4;
            initialValue.TextChanged += initialValue_TextChanged;
            // 
            // toUnitSelect
            // 
            toUnitSelect.FormattingEnabled = true;
            toUnitSelect.Location = new Point(231, 116);
            toUnitSelect.Name = "toUnitSelect";
            toUnitSelect.Size = new Size(121, 23);
            toUnitSelect.TabIndex = 5;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(53, 204);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(42, 15);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Result:";
            // 
            // result
            // 
            result.Location = new Point(108, 204);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 324);
            Controls.Add(result);
            Controls.Add(resultLabel);
            Controls.Add(toUnitSelect);
            Controls.Add(initialValue);
            Controls.Add(toLabel);
            Controls.Add(convertLabel);
            Controls.Add(fromUnitSelect);
            Controls.Add(convertButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertButton;
        private ComboBox fromUnitSelect;
        private Label convertLabel;
        private Label toLabel;
        private TextBox initialValue;
        private ComboBox toUnitSelect;
        private Label resultLabel;
        private TextBox result;
    }
}
