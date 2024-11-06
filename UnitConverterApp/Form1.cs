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
            // Conversion rates to meters for each unit
            var conversionToMeters = new Dictionary<string, double>
            {
                { "Metres", 1 },
                { "Kilometres", 1000 },
                { "Centimetres", 0.01 },
                { "Millimetres", 0.001 },
                { "Inches", 0.0254 },
                { "Feet", 0.3048 },
                { "Yards", 0.9144 },
                { "Miles", 1609.34 }
            };

            // Validate that both units are defined
            if (!conversionToMeters.ContainsKey(fromUnit) || !conversionToMeters.ContainsKey(toUnit))
            {
                throw new ArgumentException("Unsupported unit for conversion.");
            }

            // Convert from the initial unit to meters, then from meters to the target unit
            double valueInMeters = value * conversionToMeters[fromUnit];
            double convertedValue = valueInMeters / conversionToMeters[toUnit];

            return convertedValue;
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

        private void FromUnitSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
