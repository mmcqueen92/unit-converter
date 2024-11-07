namespace UnitConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly Dictionary<string, double> LengthUnits = new()
        {
            { "Inches", 0.0254 },
            { "Feet", 0.3048 },
            { "Yards", 0.9144 },
            { "Miles", 1609.34 },
            { "Centimetres", 0.01 },
            { "Metres", 1 },
            { "Kilometres", 1000 }
        };

        private static readonly Dictionary<string, double> WeightUnits = new()
        {
            { "Grams", 1 },
            { "Kilograms", 1000 },
            { "Pounds", 453.592 },
            { "Ounces", 28.3495 }
        };

        private static readonly Dictionary<string, double> VolumeUnits = new()
        {
            { "Millilitres", 1 },
            { "Litres", 1000 },
            { "Gallons", 3785.41 }
        };

                // Map all units to their categories for easy reference
        private static readonly Dictionary<string, Dictionary<string, double>> UnitCategories = new()
        {
            { "Length", LengthUnits },
            { "Weight", WeightUnits },
            { "Volume", VolumeUnits }
        };

                // Map each unit to its category
        private static readonly Dictionary<string, string> UnitToCategoryMap = new()
        {
            { "Inches", "Length" }, { "Feet", "Length" }, { "Yards", "Length" },
            { "Miles", "Length" }, { "Centimetres", "Length" }, { "Metres", "Length" },
            { "Kilometres", "Length" },

            { "Grams", "Weight" }, { "Kilograms", "Weight" }, { "Pounds", "Weight" },
            { "Ounces", "Weight" },

            { "Millilitres", "Volume" }, { "Litres", "Volume" }, { "Gallons", "Volume" }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the first dropdown with all available units
            FromUnitSelect.Items.AddRange(UnitToCategoryMap.Keys.ToArray());
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
            if (!UnitToCategoryMap.ContainsKey(fromUnit) || !UnitToCategoryMap.ContainsKey(toUnit))
            {
                throw new ArgumentException("Invalid units for conversion.");
            }

            // Ensure units are from the same category
            string fromCategory = UnitToCategoryMap[fromUnit];
            string toCategory = UnitToCategoryMap[toUnit];

            if (fromCategory != toCategory)
            {
                throw new InvalidOperationException("Cannot convert between different unit types.");
            }

            // Convert the value to the base unit within the selected category
            double valueInBaseUnit = value * UnitCategories[fromCategory][fromUnit];
            double convertedValue = valueInBaseUnit / UnitCategories[toCategory][toUnit];

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
            // Get the selected unit and its category
            string selectedFromUnit = FromUnitSelect.SelectedItem.ToString();

            if (selectedFromUnit != null && UnitToCategoryMap.TryGetValue(selectedFromUnit, out string selectedCategory))
            {
                // Clear and populate the second dropdown with units from the same category
                ToUnitSelect.Items.Clear();
                ToUnitSelect.Items.AddRange(UnitCategories[selectedCategory].Keys.ToArray());
            }
        }
    }
}
