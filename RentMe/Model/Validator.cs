using System;
using System.Windows.Forms;

namespace RentMe.Model
{
    /// <summary>
    /// Provides validation functionality for forms in the RentMe application
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Check if a TextBox is filled out
        /// </summary>
        /// <param name="theTextBox"></param>
        /// <returns>True if yes, false if no</returns>
        public static bool IsFieldFilled(TextBox theTextBox)
        {
            if (theTextBox.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                if (theTextBox.Text == "") 
                {
                    theTextBox.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Check if a text box value is an int32
        /// </summary>
        /// <param name="theTextBox"></param>
        /// <returns>True if yes, false if no</returns>
        public static bool IsInt32(TextBox theTextBox)
        {
            try
            {
                Convert.ToInt32(theTextBox);
                return true;
            }
            catch (FormatException)
            {
                theTextBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Check if the text box value is a valid zip code
        /// </summary>
        /// <param name="theTextBox"></param>
        /// <returns>True if yes, false if no</returns>
        public static bool IsZipCode(TextBox theTextBox)
        {
            try
            {
                int zipCode = Convert.ToInt32(theTextBox.Text);
                if (zipCode < 00001 || zipCode > 99950 || theTextBox.Text.Length != 5)
                {
                    theTextBox.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                theTextBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks if the text box value is a valid phone number
        /// </summary>
        /// <param name="theTextBox"></param>
        /// <returns>True if yes, false if no</returns>
        public static bool IsPhoneNumber(TextBox theTextBox)
        {
            string phoneNumberWithoutDashes = theTextBox.Text.Replace("-", "");
            if (phoneNumberWithoutDashes.Length != 10) 
            { 
                return false;
            }
            try
            {
                Convert.ToInt64(phoneNumberWithoutDashes);
                return true;
            }
            catch (FormatException)
            {
                theTextBox.Focus();
                return false;
            }
        }
    }
}
