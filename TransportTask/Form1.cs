using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportTask
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonAddX_Click(object sender, EventArgs e)
        {
            dataInputMain.Columns.Add(dataInputMain.Columns.Count.ToString(), "");
            dataInputX.Columns.Add(dataInputX.Columns.Count.ToString(), "");

            if (dataInputMain.Columns.Count == 1)
            {
                dataInputY.Columns.Add(dataInputY.Columns.Count.ToString(), "");
                dataInputY.Rows.Add();
                dataInputMain.Rows.Add();
                dataInputX.Rows.Add();

                dataInputMain.ClearSelection();
                dataInputX.ClearSelection();
                dataInputY.ClearSelection();
            }
        }

        private void buttonAddY_Click(object sender, EventArgs e)
        {
            dataInputMain.Rows.Add();
            dataInputY.Rows.Add();

            if (dataInputMain.Columns.Count == 1)
            {
                dataInputX.Columns.Add(dataInputY.Columns.Count.ToString(), "");
                dataInputX.Rows.Add();
                dataInputMain.Rows.Add();

                dataInputMain.ClearSelection();
                dataInputX.ClearSelection();
                dataInputY.ClearSelection();
            }

            
        }

        private void buttonRemoveX_Click(object sender, EventArgs e)
        {
            if (dataInputMain.Columns.Count != 0)
            {
                dataInputMain.Columns.RemoveAt(dataInputMain.Columns.Count - 1);
                dataInputX.Columns.RemoveAt(dataInputX.Columns.Count - 1);
                if (dataInputMain.Columns.Count == 0)
                {
                    dataInputY.Columns.RemoveAt(dataInputY.Columns.Count - 1);
                }
                dataInputMain.ClearSelection();
                dataInputX.ClearSelection();
                dataInputY.ClearSelection();
            }
        }

        private void buttonRemoveY_Click(object sender, EventArgs e)
        {
            if (dataInputMain.Columns.Count != 0)
            {
                dataInputMain.Rows.RemoveAt(dataInputMain.Rows.Count - 1);
                dataInputY.Rows.RemoveAt(dataInputY.Rows.Count - 1);
                if (dataInputMain.Rows.Count == 0)
                {
                    dataInputMain.Columns.Clear();
                    dataInputX.Columns.Clear();
                    dataInputY.Columns.Clear();
                }
                dataInputMain.ClearSelection();
                dataInputX.ClearSelection();
                dataInputY.ClearSelection();
            }
        }
    }
}
