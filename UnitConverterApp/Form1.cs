namespace UnitConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // Step 1: Validate the InitialValue input
            if (string.IsNullOrWhiteSpace(InitialValue.Text))
            {
                MessageBox.Show("Please enter a value to convert.");
                return;
            }

            // Try to parse the InitialValue as a number
            if (!double.TryParse(InitialValue.Text, out double initialValue))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            // Step 2: Validate the dropdown selections
            if (FromUnitSelect.SelectedItem == null || ToUnitSelect.SelectedItem == null)
            {
                MessageBox.Show("Please select both units for conversion.");
                return;
            }

            string fromUnit = FromUnitSelect.SelectedItem?.ToString() ?? string.Empty;
            string toUnit = ToUnitSelect.SelectedItem?.ToString() ?? string.Empty;

            // Step 3: Perform the conversion (example conversion logic)
            double convertedValue = ConvertUnits(initialValue, fromUnit, toUnit);

            // Step 4: Display the result in the result TextBox (or Label if using that instead)
            ResultBox.Text = convertedValue.ToString("F2");  // Display with two decimal places
        }

        private static double ConvertUnits(double value, string fromUnit, string toUnit)
        {
            // Example conversion rates (using British spelling)
            if (fromUnit == "Metres" && toUnit == "Kilometres")
                return value / 1000;
            else if (fromUnit == "Kilometres" && toUnit == "Metres")
                return value * 1000;
            else if (fromUnit == "Inches" && toUnit == "Centimetres")
                return value * 2.54;
            else if (fromUnit == "Centimetres" && toUnit == "Inches")
                return value / 2.54;
            else if (fromUnit == "Miles" && toUnit == "Kilometres")
                return value * 1.60934;
            else if (fromUnit == "Kilometres" && toUnit == "Miles")
                return value / 1.60934;

            // Default case if no conversion is needed or if units are the same
            return value;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void initialValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void initialValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
