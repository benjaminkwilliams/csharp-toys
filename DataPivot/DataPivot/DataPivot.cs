using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DataPivot
{
    public partial class DataPivot : Form
    {
        #region Public Members

        public DataTable PivotData;
        public bool wrapItems;
        public int wrapCount;
        public bool useSpaces;
        public int spaceCount;
        public bool paraOwnLine;
        public bool quoteElements;
        public bool trimSpaces;

        #endregion

        #region Constructor

        public DataPivot()
        {
            InitializeComponent();
            
            if (PivotData == null)
            {
                PivotData = new DataTable();
                PivotData.TableName = "List";
                PivotData.Columns.Add(new DataColumn("Data"));
            }
            dgvDataToPivot.DataSource = PivotData;

            if (udSpaceCount.SelectedItem == null)
            {
                udSpaceCount.SelectedIndex = 10;
            }
            if (udWrapCount.SelectedItem == null)
            {
                udWrapCount.SelectedIndex = 10;
            }

            quoteElements = true;
            trimSpaces = true;
        }

        #endregion

        #region UpDown Events

        private void udSpaceCount_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                useSpaces = ((int)udSpaceCount.SelectedItem != 0);
                spaceCount = (int)udSpaceCount.SelectedItem;
            }
            catch
            {
                useSpaces = false;
                spaceCount = 0;
                udSpaceCount.SelectedIndex = 10;
            }
        }

        private void udWrapCount_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                wrapItems = ((int)udWrapCount.SelectedItem != 0);
                wrapCount = (int)udWrapCount.SelectedItem;
            }
            catch
            {
                wrapItems = false;
                wrapCount = 0;
                udWrapCount.SelectedIndex = 10;
            }
        }

        #endregion

        #region Checkbox Events

        private void cbxParaOwnLine_CheckedChanged(object sender, EventArgs e)
        {
            paraOwnLine = cbxParaOwnLine.Checked;
        }

        private void cbxQuoteElements_CheckedChanged(object sender, EventArgs e)
        {
            quoteElements = cbxQuoteElements.Checked;
        }

        private void cbxTrimSpaces_CheckedChanged(object sender, EventArgs e)
        {
            trimSpaces = cbxTrimSpaces.Checked;
        }

        #endregion

        #region Private Functions

        #region Simple

        private void copyData()
        {
            if (txtPivotData.TextLength > 0)
            {
                Clipboard.SetText(txtPivotData.Text);
            }
        }

        private void pasteFromClipboard()
        {
            IDataObject clipboardData = Clipboard.GetDataObject();

            pasteData(clipboardData);
        }

        private void newData()
        {
            PivotData.Rows.Clear();
            txtPivotData.Clear();
        }

        #endregion

        #region Business Logic

        private void pasteData(IDataObject clipboardData)
        {
            object DataObject = clipboardData.GetData(DataFormats.StringFormat);
            if (DataObject != null)
            {
                List<string> listString = ((string)DataObject).Split(new string[] { "\n", "\r\n", "\t", "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (string s in listString)
                {
                    if (trimSpaces)
                    {
                        if (String.IsNullOrWhiteSpace(s))
                        {
                            continue;
                        }
                    }

                    DataRow r = PivotData.NewRow();
                    PivotData.Rows.Add(r);
                    r.BeginEdit();
                    r["Data"] = trimSpaces ? s.Trim() : s;
                    r.EndEdit();
                    r.AcceptChanges();
                }
            }
        }

        private void pivotData()
        {
            bool firstline = true;

            if (PivotData.Rows.Count == 0)
                return;

            txtPivotData.Clear();
            txtPivotData.AppendText("( ");

            if (paraOwnLine) txtPivotData.AppendText(Environment.NewLine);

            for (int i = 0; i < PivotData.Rows.Count; i++)
            {
                if (PivotData.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (String.IsNullOrWhiteSpace(PivotData.Rows[i]["Data"].ToString()))
                    {
                        continue;
                    }

                    if (useSpaces && firstline)
                    {
                        switch (spaceCount)
                        {
                            case 0:
                                break;
                            case 1:
                                txtPivotData.AppendText(" ");
                                break;
                            case 2:
                                txtPivotData.AppendText("  ");
                                break;
                            case 3:
                                txtPivotData.AppendText("   ");
                                break;
                            case 4:
                                txtPivotData.AppendText("    ");
                                break;
                            case 5:
                                txtPivotData.AppendText("     ");
                                break;
                            case 6:
                                txtPivotData.AppendText("      ");
                                break;
                            case 7:
                                txtPivotData.AppendText("       ");
                                break;
                            case 8:
                                txtPivotData.AppendText("        ");
                                break;
                            case 9:
                                txtPivotData.AppendText("         ");
                                break;
                            case 10:
                                txtPivotData.AppendText("          ");
                                break;
                        }
                        firstline = false;
                    }

                    txtPivotData.AppendText(
                        (quoteElements ? "\'" : "") +
                        (trimSpaces ? PivotData.Rows[i]["Data"].ToString().Trim() : PivotData.Rows[i]["Data"].ToString())
                    );

                    if (i != PivotData.Rows.Count - 1)
                    {
                        txtPivotData.AppendText((quoteElements ? "\'" : "") + ", ");

                        if (wrapItems && ((i + 1) % wrapCount == 0))
                        {
                            txtPivotData.AppendText(Environment.NewLine);
                            firstline = true;
                        }
                    }
                    else
                    {
                        txtPivotData.AppendText((quoteElements ? "\'" : ""));
                    }
                }
            }

            txtPivotData.AppendText(paraOwnLine ? (Environment.NewLine + ')') : " )");
        }

        #endregion

        #endregion

        #region ToolStripMenuItem Click Events

        private void copytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.copyData();
        }

        private void pivotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pivotData();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pasteFromClipboard();
        }

        #endregion

        #region ToolStripButtons Click Events

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyData();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteFromClipboard();
        }

        private void btnPivot_Click(object sender, EventArgs e)
        {
            pivotData();

        } // End btnPivot_Click

        private void allToolStripButton_Click(object sender, EventArgs e)
        {
            pasteFromClipboard();
            pivotData();
            copyData();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newData();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Ben Williams", "PivotData", MessageBoxButtons.OK);
        }

        #endregion

    } // End public partial class DataPivot
} // End namespace DataPivot
