using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataInsert
{
    public partial class DataInsert : Form
    {

        #region Public Members

        public DataTable InputData;
        public bool wrapItems;
        public int wrapCount;
        public int spaceCount;
        public bool paraOwnLine;
        public bool trimSpaces;
        public bool firstLineHeader;

        #endregion

        #region Constructor

        public DataInsert()
        {
            InitializeComponent();

            if (InputData == null)
            {
                InputData = new DataTable("Input");
                InputData.Columns.CollectionChanged += new CollectionChangeEventHandler(Columns_CollectionChanged);
            }

            dgvDataToFormat.DataSource = InputData;
            clbQuoteElements.CheckOnClick = true;

            if (udSpaceCount.SelectedItem == null)
            {
                udSpaceCount.SelectedIndex = 10;
            }

            trimSpaces = true;
            firstLineHeader = false;
        }

        #endregion

        #region ToolStripButton Click Events

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newData();
        }

        private void allToolStripButton_Click(object sender, EventArgs e)
        {
            pasteFromClipboard();
            formatData();
            copyData();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyData();
        }

        private void formatToolStripButton_Click(object sender, EventArgs e)
        {
            formatData();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteFromClipboard();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Ben Williams", "DataInsert", MessageBoxButtons.OK);
        }

        #endregion

        #region UpDown Events

        private void udSpaceCount_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                spaceCount = (int)udSpaceCount.SelectedItem;
            }
            catch
            {
                spaceCount = 0;
                udSpaceCount.SelectedIndex = 10;
            }
        }

        #endregion

        #region Checkbox Events
        private void cbxFirstLineHeader_CheckedChanged(object sender, EventArgs e)
        {
            firstLineHeader = cbxFirstLineHeader.Checked;

            MakeFirstLineHeader();
        }
        #endregion

        #region DataColumn Events
        void Columns_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            try
            {
                switch (e.Action)
                {
                    case CollectionChangeAction.Add:
                        clbQuoteElements.Items.Add(e.Element.ToString());
                        break;
                    case CollectionChangeAction.Remove:
                        clbQuoteElements.Items.Remove(e.Element.ToString());
                        break;
                }
            }
            catch
            {
                // do nothing
            }
        }
        #endregion

        #region Private Methods

        #region Simple
        private void newData()
        {
            InputData.Clear();
            int columnCount = InputData.Columns.Count;
            for (int i = columnCount-1; i >= 0; i--)
            {
                InputData.Columns.Remove(InputData.Columns[i]);
            }
            txtOutputData.Clear();
        }

        private void pasteFromClipboard()
        {
            pasteData(Clipboard.GetDataObject());
        }

        private void copyData()
        {
            if (txtOutputData.TextLength > 0)
            {
                Clipboard.SetText(txtOutputData.Text, TextDataFormat.UnicodeText);
            }
        }
        #endregion

        #region Business Logic

        private void pasteData(IDataObject clipboardData)
        {
            #region Row Population

            object dataObject = clipboardData.GetData(DataFormats.StringFormat);
            List<string> rowlist;
            List<string> fieldlist;
            int columnNeededCount;
            int columnCurrentCount;

            if (dataObject != null)
            {
                // First process the rows
                rowlist = ((string)dataObject).Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None).ToList();

                #region Column Population
                foreach (string r in rowlist)
                {
                    fieldlist = r.Split(new string[] { "\t" }, StringSplitOptions.None).ToList();

                    #region Column Setup
                    columnCurrentCount = InputData.Columns.Count;
                    /********************************
                     * \t is the marker for a column
                     * Zero \t = one column
                     * One \t = two columns
                     * Ten \t = eleven columns
                     ********************************/
                    columnNeededCount = Math.Abs(columnCurrentCount - fieldlist.Count);

                    if ((columnNeededCount != 0) && (columnCurrentCount < columnNeededCount))
                    {
                        for (int i = 0; i < columnNeededCount; i++)
                        {
                            InputData.Columns.Add(new DataColumn());
                        }
                    }
                    #endregion

                    try
                    {
                        DataRow d = InputData.NewRow();
                        InputData.Rows.Add(d);
                        d.BeginEdit();
                        for (int i = 0; i < fieldlist.Count; i++)
                        {
                            d[i] = trimSpaces ? fieldlist[i].Trim() : fieldlist[i].ToString();
                        }
                        d.EndEdit();
                        d.AcceptChanges();
                    }
                    catch
                    {
                       // Do Nothing
                    }
                }
                #endregion
            }

            #endregion

            MakeFirstLineHeader();
        }

        private void formatData()
        {
            if (InputData.Rows.Count == 0)
                return;

            txtOutputData.Clear();

            // this method is faster that the method access of the object
            List<bool> quoteElementList = new List<bool>();
            for (int i = 0; i < clbQuoteElements.Items.Count; i++)
            {
                if (clbQuoteElements.CheckedItems.Contains(clbQuoteElements.Items[i]))
                {
                    quoteElementList.Add(true);
                }
                else
                {
                    quoteElementList.Add(false);
                }
            }
            if (cbxFirstLineHeader.Checked == true)
            {
                txtOutputData.AppendText("INSERT" + Environment.NewLine + "( ");
                foreach (DataColumn c in InputData.Columns)
                {
                    txtOutputData.AppendText("[" + c.ColumnName + "], ");
                }
                // remove last comma
                txtOutputData.Text = txtOutputData.Text.Remove(txtOutputData.Text.Length -2, 2);
                txtOutputData.AppendText(" )" + Environment.NewLine + 
                                         "VALUES" + Environment.NewLine);
            }
            // Build Values
            for (int i = 0; i < InputData.Rows.Count; i++)
            {
                if (InputData.Rows[i].RowState == DataRowState.Deleted)
                {
                    continue;
                }

                #region Pad Lines
                switch (spaceCount)
                {
                    case 0:
                        break;
                    case 1:
                        txtOutputData.AppendText(" ");
                        break;
                    case 2:
                        txtOutputData.AppendText("  ");
                        break;
                    case 3:
                        txtOutputData.AppendText("   ");
                        break;
                    case 4:
                        txtOutputData.AppendText("    ");
                        break;
                    case 5:
                        txtOutputData.AppendText("     ");
                        break;
                    case 6:
                        txtOutputData.AppendText("      ");
                        break;
                    case 7:
                        txtOutputData.AppendText("       ");
                        break;
                    case 8:
                        txtOutputData.AppendText("        ");
                        break;
                    case 9:
                        txtOutputData.AppendText("         ");
                        break;
                    case 10:
                        txtOutputData.AppendText("          ");
                        break;
                }
                #endregion

                txtOutputData.AppendText("( ");
                for (int j = 0; j < InputData.Columns.Count; j++)
                {
                    if (ckbAllowNulls.Checked == true && InputData.Rows[i][j].ToString() == String.Empty)
                    {
                        txtOutputData.AppendText(
                            "NULL" + // Don't quote nulls
                            ((j < InputData.Columns.Count - 1) ? ", " : "")     // Delimeter for next value
                        );
                    }
                    else
                    {
                        txtOutputData.AppendText(
                            (((bool)quoteElementList[j]) ? "\"" : "") +    // Element Quote
                            InputData.Rows[i][j].ToString() +               // Element Value
                            (((bool)quoteElementList[j]) ? "\"" : "") +    // Element Quote
                            ((j < InputData.Columns.Count - 1) ? ", " : "")     // Delimeter for next value
                         );
                    }
                }
                txtOutputData.AppendText( (((i + 1) != InputData.Rows.Count)?(" ),"):(" )")) + Environment.NewLine);
            }
            // remove last comma
            txtOutputData.Text = txtOutputData.Text.Remove(txtOutputData.Text.Length - 3, 3);
        }

        private void MakeFirstLineHeader()
        {
            try
            {
                if (firstLineHeader && InputData.Rows.Count > 0)
                {
                    for (int i = 0; i < InputData.Columns.Count; i++)
                    {
                        InputData.Columns[i].ColumnName = InputData.Rows[0][i].ToString();
                        clbQuoteElements.Items[i] = InputData.Rows[0][i].ToString();
                    }

                    InputData.Rows[0].Delete();
                    InputData.Rows[0].AcceptChanges();
                }
            }
            catch
            {
                // Do nothing
            }
        }

        #endregion Business Logic

        #endregion Private Methods
    }
}
