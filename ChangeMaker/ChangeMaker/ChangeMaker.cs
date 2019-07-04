using System;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChangeMaker
{
  public partial class ChangeMaker : Form
  {
    public ChangeMaker()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Button Click event that cleans up and starts the processing
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnMakeChange_Click(object sender, EventArgs e)
    {
      tbxResult.Clear();
      errError.Clear();
      decimal finput = 0.0M;
      string sinput = tbxAmount.Text;
      
      if (ValidateInput(sinput, out finput))
      {
        //tbxResult.AppendText("Amount: " + finput.ToString() + Environment.NewLine);
        ShowBills(finput);
      }
      else
      {
        errError.SetError(tbxAmount, "Enter a positive amount greater than 0.00");
      }
    }

    /// <summary>
    /// Write to the text box how the bills are broken down
    /// </summary>
    /// <param name="finput"></param>
    private void ShowBills(decimal finput)
    {
      UInt64 iAmount = (UInt64)(Math.Round(finput, 2) * 100);
      
      // There are 11 US demoniations
      // 100, 50, 20, 10, 5, 1, .50, .25, .10, .05, .01
      UInt64[] iDemoniations = {10000, 5000, 2000, 1000, 500, 100,
                                50, 25, 10, 5, 1};
      string[] sDemoniations ={"$100", "$50", "$20", "$10", "$5", "$1",
                               "$0.50", "$0.25", "$0.10", "$0.05", "$0.01"};

      // We start at the top and work our way down
      // Bills that are not needed are not shown
      try
      {
        for (int i = 0; i <= 10 || iAmount != 0; i++)
        {
          if (iAmount >= iDemoniations[i])
          {
            tbxResult.AppendText("(" + CalcChange(ref iAmount, iDemoniations[i]) +
                                 ") " + sDemoniations[i] + Environment.NewLine);
          }
        }
        // Double Check
        if (iAmount > 0)
        {throw new Exception("Something went wrong.");}
      }
      catch(Exception ex)
      {
        tbxResult.AppendText(ex.Message + Environment.NewLine);
      }
    }

    /// <summary>
    /// Calculates the amount of change given the current value and change demoniation
    /// </summary>
    /// <param name="uiCoin"></param>
    /// <param name="iCoinValue"></param>
    /// <returns>The Amount of Change</returns>
    string CalcChange(ref UInt64 uiCoin, UInt64 iCoinValue)
    {
      if (uiCoin <= 0)
      {
        throw new Exception("Something Went Wrong");
      }
      UInt64 coinage = uiCoin / iCoinValue;
      uiCoin -= iCoinValue * coinage;
      return coinage.ToString();
    }

    /// <summary>
    /// Validate the input from the text box
    /// </summary>
    /// <param name="input"></param>
    /// <param name="output">This is parsed from the input</param>
    /// <returns>If the input is valid or not as a bool</returns>
    private bool ValidateInput(string input, out decimal output)
    {
      bool retValue = true;
      output = 0.0M;
      char[] arrayInput;
      int countRightDec = 0;

      // To keep the user happy, lets remove "valid" currency symbols
      input = input.Trim();
      input = input.Replace("$", "").Replace(",", "");

      // This block will stop checking once it finds an error
      // Can't pass in an empty string
      if(string.IsNullOrEmpty(input))
      {
        retValue = false;
      }
      
      if (true == retValue)
      {
        // TryParse is doing most of the work
        // NumberStyles makes sure that there is only one decimal, no alpha or other characters
        if (decimal.TryParse(input, NumberStyles.Currency, null, out output))
        {
          // We are making change so positive non-zero amounts are required
          if (output < 0.0M)
          {
            retValue = false;
          }
          else
          {
            // So if you go past UInt32.MaxValue we will catch it here
            try
            {
              if ((UInt32)(Math.Round(output, 2)) * 100 > UInt32.MaxValue)
              {
                tbxResult.AppendText("Sorry, we don't have change for that amount of money.");
                retValue = false;
              }
            }
            catch
            {
              tbxResult.AppendText("Sorry, we don't have change for that amount of money.");
              retValue = false;
            }

            // If there isn't a decimal, then we need to add one
            if (-1 == input.IndexOf('.'))
            {
              input = input.Insert(input.Length, ".");
            }
            // So we have to make sure there are at most two numbers to the right of the
            // decimal place, otherwise we may end up with a phantom penny
            arrayInput = input.ToCharArray();
            for (int i = input.IndexOf('.') + 1; i < input.Length; i++)
            {
              countRightDec++;
            }
            if (countRightDec > 2)
            {
              retValue = false;
            }
          }
        }
        else 
        {
          retValue = false;
        }
      }

      return retValue;
    }
  }
}