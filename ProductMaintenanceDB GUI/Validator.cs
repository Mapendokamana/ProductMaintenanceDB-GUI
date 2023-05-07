using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenanceDB_GUI
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if text box has text in it
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == "") // bad
            {
                MessageBox.Show(textBox.Tag + " input is required");
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if combo box has value selected
        /// </summary>
        /// <param name="comboBox">combo box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsSelected(ComboBox comboBox)
        {
            bool isValid = true;
            if (comboBox.SelectedIndex == -1) // bad
            {
                MessageBox.Show(comboBox.Tag + " must be selected");
                comboBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        public static bool IsPresentDate(DateTimePicker dateTimePicker) 
        {
            bool isValid = true;
            if (dateTimePicker.Text =="") // bad
            {
                MessageBox.Show(dateTimePicker.Tag + "is required");
                dateTimePicker.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative int value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            int result;
            if (!Int32.TryParse(textBox.Text, out result)) // not an int
            {
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < 0) // it is an int but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains an int value within given range
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <param name="minVal">minimum value for the range</param>
        /// <param name="maxVal">maximum value for the range</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsIntInRange(TextBox textBox, int minVal, int maxVal)
        {
            bool isValid = true;
            int result;
            if (!Int32.TryParse(textBox.Text, out result)) // not an int
            {
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < minVal || result > maxVal) // it is an int but out of range
            {
                MessageBox.Show(textBox.Tag + " has to be between " + minVal +
                                              " and " + maxVal);
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative double value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;
            double result;
            if (!Double.TryParse(textBox.Text, out result)) // not a double
            {
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < 0) // it is a double but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative decimal value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal result;
            if (!Decimal.TryParse(textBox.Text, out result)) // not a decimal
            {
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < 0) // it is a decimal but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a decimal value within given range
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <param name="minVal">minimum value for the range</param>
        /// <param name="maxVal">maximum value for the range</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsDecimalInRange(TextBox textBox,
                                            decimal minVal, decimal maxVal)
        {
            bool isValid = true;
            decimal result;
            if (!Decimal.TryParse(textBox.Text, out result)) // not a decimal
            {
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < minVal || result > maxVal) // it is a decimal but outside the range
            {
                MessageBox.Show(textBox.Tag + " has to be between " + minVal +
                                              " and " + maxVal);
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains correct date format
        /// </summary>
        /// <param name="textBox">text box to check (MMDDYY)</param>
        /// <returns>true if valid and false if not</returns>

        public static bool IsDate(TextBox textBox)
        {
            bool isValid = true;

            DateTime dateValue;
            if (!DateTime.TryParse(textBox.Text, out dateValue)) // check if the input string matches any of the allowed formats
            {
                isValid = true;
                string[] formats = { "MM/dd/yyyy", "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy" };
            }
            else 
            {
                MessageBox.Show(textBox.Tag +"Invalid date. Please enter a valid date in the format MM/dd/yyyy.");
                isValid = false;
            }
            return isValid;

        }

    }
}
