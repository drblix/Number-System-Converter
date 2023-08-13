using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NumberSystemConverter
{
    public partial class Form1 : Form
    {
        private enum NumberSystem
        {
            Decimal,
            Binary,
            Hexadecimal
        }

        private static readonly Dictionary<ulong, char> DecimalToHexaDict = new Dictionary<ulong, char>()
        {
            { 0, '0' },
            { 1, '1' },
            { 2, '2' },
            { 3, '3' },
            { 4, '4' },
            { 5, '5' },
            { 6, '6' },
            { 7, '7' },
            { 8, '8' },
            { 9, '9' },
            { 10, 'A' },
            { 11, 'B' },
            { 12, 'C' },
            { 13, 'D' },
            { 14, 'E' },
            { 15, 'F' }
        };

        private static readonly Dictionary<char, ulong> HexaToDecimalDict = new Dictionary<char, ulong>()
        {
            { '0', 0 },
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { 'A', 10 },
            { 'B', 11 },
            { 'C', 12 },
            { 'D', 13 },
            { 'E', 14 },
            { 'F', 15 },
        };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object _, EventArgs __)
        {
            // Did the user enter anything?
            if (fromTextBox.Text.Trim() == string.Empty)
            {
                ShowErrorBox("No number to convert");
                return;
            }
            
            // Removing all spaces in the user's input
            string textToConvert = fromTextBox.Text.Trim().Replace(" ", string.Empty);
            
            // Are both number system dropdowns valid?
            if (fromComboBox.SelectedIndex == -1 || toComboBox.SelectedIndex == -1)
            {
                ShowErrorBox("Pick a number system");
                return;
            }

            NumberSystem fromSystem = (NumberSystem)fromComboBox.SelectedIndex;
            NumberSystem toSystem = (NumberSystem)toComboBox.SelectedIndex;
            
            if (fromSystem == NumberSystem.Decimal)
            {
                switch (toSystem)
                {
                    case NumberSystem.Binary when ulong.TryParse(textToConvert, out ulong parsedText):
                        toTextBox.Text = DecimalToBinary(parsedText);
                        break;
                    case NumberSystem.Binary:
                        ShowErrorBox("Failed to parse decimal number to binary. Check if number is negative");
                        break;
                    case NumberSystem.Hexadecimal when ulong.TryParse(textToConvert, out ulong parsedText):
                        toTextBox.Text = DecimalToHexadecimal(parsedText);
                        break;
                    case NumberSystem.Hexadecimal:
                        ShowErrorBox("Failed to parse decimal number to hexadecimal. Check if number is negative");
                        break;
                    default:
                        ShowErrorBox("Invalid number system to convert to");
                        break;
                }
            }
            else if (fromSystem == NumberSystem.Binary)
            {
                if (toSystem == NumberSystem.Decimal)
                    toTextBox.Text = BinaryToDecimal(fromTextBox.Text).ToString();
                else if (toSystem == NumberSystem.Hexadecimal)
                    toTextBox.Text = DecimalToHexadecimal( ulong.Parse(BinaryToDecimal(fromTextBox.Text).ToString()));
            }
            else
            {
                if (toSystem == NumberSystem.Decimal)
                    toTextBox.Text = HexadecimalToDecimal(fromTextBox.Text).ToString();
                else if (toSystem == NumberSystem.Binary)
                    toTextBox.Text = DecimalToBinary(ulong.Parse(HexadecimalToDecimal(fromTextBox.Text).ToString()));
            }
        }
        
        private void fromComboBox_SelectedIndexChanged(object _, EventArgs __)
        {
            if (fromComboBox.SelectedIndex == toComboBox.SelectedIndex)
            {
                if (fromComboBox.SelectedIndex - 1 < 0)
                    toComboBox.SelectedIndex = 2;
                else
                    toComboBox.SelectedIndex = fromComboBox.SelectedIndex - 1;
            }
        }

        private void toComboBox_SelectedIndexChanged(object _, EventArgs __)
        {
            if (toComboBox.SelectedIndex == fromComboBox.SelectedIndex)
            {
                if (toComboBox.SelectedIndex - 1 < 0)
                    fromComboBox.SelectedIndex = 2;
                else
                    fromComboBox.SelectedIndex = toComboBox.SelectedIndex - 1;
            }
        }

        private static string DecimalToBinary(ulong number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            // Main driver
            while (number > 0)
            {
                stringBuilder.Append(number % 2);
                number /= 2;
            }
            
            // Appending zeroes until a factor of 4 is reached
            // Creates groups of fours
            while (stringBuilder.Length % 4 != 0)
                stringBuilder.Append('0');
            
            // Reversing the built string
            char[] charArray = stringBuilder.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string DecimalToHexadecimal(ulong number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            // Main driver
            // '?' is appended when unknown value is encountered
            while (number > 0)
            {
                stringBuilder.Append(DecimalToHexaDict.TryGetValue(number % 16, out char hexChar) ? hexChar : '?');
                number /= 16;
            }
            
            // Reversing the built string
            char[] charArray = stringBuilder.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
        private static ulong BinaryToDecimal(string binary)
        {
            ulong num = 0;
            int pow = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                    num += (ulong)Math.Pow(2, pow);

                pow++;
            }

            return num;
        }

        private static ulong HexadecimalToDecimal(string hexa)
        {
            ulong num = 0;
            int pow = 0;
            for (int i = hexa.Length - 1; i >= 0; i--)
            {
                if (HexaToDecimalDict.TryGetValue(hexa[i], out ulong val))
                    num += (ulong)Math.Pow(16, pow) * val;
                else
                    ShowErrorBox("Failed to convert hexadecimal to decimal");

                pow++;
            }

            return num;
        }

        private void copyButton_Click(object _, EventArgs __) => Clipboard.SetText(toTextBox.Text);
        private static void ShowErrorBox(string message) => MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}