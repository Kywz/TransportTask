using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportTask.Transport.TransportTable;

namespace TransportTask
{
    public partial class formMain : Form
    {
        List<DataGridView> processTableList = new List<DataGridView>();
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonAddX_Click(object sender, EventArgs e)
        {
            dataInputMain.Columns.Add(dataInputMain.Columns.Count.ToString(), "");
            dataInputX.Columns.Add(dataInputX.Columns.Count.ToString(), "");

            dataFinal.Columns.Add(dataFinal.Columns.Count.ToString(), "");
            dataFinalX.Columns.Add(dataFinalX.Columns.Count.ToString(), "");

            if (dataInputMain.Columns.Count == 1)
            {
                dataInputY.Columns.Add(dataInputY.Columns.Count.ToString(), "");
                dataInputY.Rows.Add();
                dataInputMain.Rows.Add();
                dataInputX.Rows.Add();

                dataFinalY.Columns.Add(dataFinalY.Columns.Count.ToString(), "");
                dataFinalY.Rows.Add();
                dataFinal.Rows.Add();
                dataFinalX.Rows.Add();

                dataClearSelection();
            }
        }

        private void buttonAddY_Click(object sender, EventArgs e)
        {
            if (dataInputMain.Columns.Count != 0)
            {
                dataInputMain.Rows.Add();
                dataInputY.Rows.Add();

                dataFinal.Rows.Add();
                dataFinalY.Rows.Add();

            }
            else
            {
                dataInputMain.Columns.Add(dataInputMain.Columns.Count.ToString(), "");
                dataInputMain.Rows.Add();
                dataInputX.Columns.Add(dataInputX.Columns.Count.ToString(), "");
                dataInputX.Rows.Add();
                dataInputY.Columns.Add(dataInputY.Columns.Count.ToString(), "");
                dataInputY.Rows.Add();

                dataFinal.Columns.Add(dataFinal.Columns.Count.ToString(), "");
                dataFinal.Rows.Add();
                dataFinalX.Columns.Add(dataFinalX.Columns.Count.ToString(), "");
                dataFinalX.Rows.Add();
                dataFinalY.Columns.Add(dataFinalY.Columns.Count.ToString(), "");
                dataFinalY.Rows.Add();
            }
            dataClearSelection();

        }

        private void buttonRemoveX_Click(object sender, EventArgs e)
        {
            if (dataInputMain.Columns.Count != 0)
            {
                dataInputMain.Columns.RemoveAt(dataInputMain.Columns.Count - 1);
                dataInputX.Columns.RemoveAt(dataInputX.Columns.Count - 1);

                dataFinal.Columns.RemoveAt(dataFinal.Columns.Count - 1);
                dataFinalX.Columns.RemoveAt(dataFinalX.Columns.Count - 1);
                if (dataInputMain.Columns.Count == 0)
                {
                    dataInputY.Columns.RemoveAt(dataInputY.Columns.Count - 1);

                    dataFinalY.Columns.RemoveAt(dataFinalY.Columns.Count - 1);
                }
                dataClearSelection();
            }
        }

        private void buttonRemoveY_Click(object sender, EventArgs e)
        {
            if (dataInputMain.Columns.Count != 0)
            {
                dataInputMain.Rows.RemoveAt(dataInputMain.Rows.Count - 1);
                dataInputY.Rows.RemoveAt(dataInputY.Rows.Count - 1);

                dataFinal.Rows.RemoveAt(dataFinal.Rows.Count - 1);
                dataFinalY.Rows.RemoveAt(dataFinalY.Rows.Count - 1);
                if (dataInputMain.Rows.Count == 0)
                {
                    dataInputMain.Columns.Clear();
                    dataInputX.Columns.Clear();
                    dataInputY.Columns.Clear();

                    dataFinal.Columns.Clear();
                    dataFinalX.Columns.Clear();
                    dataFinalY.Columns.Clear();
                }
                dataClearSelection();
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            List<DataGridView> dataInput = new List<DataGridView>();
            dataInput.Add(dataInputMain);
            dataInput.Add(dataInputX);
            dataInput.Add(dataInputY);

            List<DataGridView> dataOutput = new List<DataGridView>();
            dataOutput.Add(dataFinal);
            dataOutput.Add(dataFinalX);
            dataOutput.Add(dataFinalY);
            if (dataInputMain.Columns.Count == 0)
            {
                MessageBox.Show("Таблиця введення порожня!\nВикористайте кнопки у меню для додавання та видалення рядків та стовбчків.");
                return;
            }

            else if (!(DataProcessor.isDataGridFilled(dataInput)))
            {
                MessageBox.Show("Деякі комірки не були заповнені, або були заповнені не числами!");
                return;
            }

            else if (dataInputX.Columns.Count != dataInputY.Rows.Count)
            {
                while (dataInputX.Columns.Count != dataInputY.Rows.Count)
                {
                    if (dataInputX.Columns.Count > dataInputY.Rows.Count)
                    {
                        buttonAddY_Click(sender, e);

                    }
                    else if (dataInputY.Rows.Count > dataInputX.Columns.Count)
                    {
                        buttonAddX_Click(sender, e);
                    }
                }
                MessageBox.Show("Було надано задачу откритого типу, таблицю було преобразовано для подальшого вирішення.\nЗаповніть нові рядки.");
                return;
            }
            else if (!(DataProcessor.checkForEquality(dataInputX, dataInputY))){
                MessageBox.Show("Сума значень потреб та запасів не рівні!\nЗаповніть таблиці потреб та запасів так, щоб задача була збалансована.");
                return;
            }
            labelText_Cost.Visible = true;
            labelText_CostLabel.Visible = true;
            DataProcessor.northWestAngleMethodSollution(dataInput, dataOutput, labelText_Cost);

        }
        private void dataClearSelection()
        {
            dataInputMain.ClearSelection();
            dataInputX.ClearSelection();
            dataInputY.ClearSelection();
            dataFinal.ClearSelection();
            dataFinalX.ClearSelection();
            dataFinalY.ClearSelection();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataInputMain.Columns.Clear();
            dataInputX.Columns.Clear();
            dataInputY.Columns.Clear();
            dataFinal.Columns.Clear();
            dataFinalX.Columns.Clear();
            dataFinalY.Columns.Clear();
            labelText_Cost.Visible = false;
            labelText_CostLabel.Visible = false;
        }
    }
}
