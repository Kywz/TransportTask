using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportTask.Transport.TransportTable;

namespace TransportTask.Transport.TransportTable
{
    public class DataProcessor
    {
        public static bool isDataGridFilled(List<DataGridView> input)
        {
            int currentInt; 
            foreach(DataGridView data in input)
            {
                foreach(DataGridViewRow row in data.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        
                        if (row.Cells[i].Value == null)
                        {
                            return false;
                        }
                        if (!(int.TryParse(row.Cells[i].Value.ToString(), out currentInt)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static void northWestAngleMethodSollution(List<DataGridView> dataInput, List<DataGridView> dataOutput, Label sumOut)
        {
            Table table = new Table(dataInput);
            TransportProblem transportSolution = new TransportProblem(table.Y, table.X, table.center);
            float [,] Support = transportSolution.NordWest();
            float[,] Optimum = transportSolution.PotenMeth(Support);

            for (int i = 0; i < table.Y.Length; i++)
                for (int j = 0; j < table.X.Length; j++)
                    if (float.IsNaN(Optimum[i, j]))
                        Optimum[i, j] = 0.0f;

            float sum = 0;
            for (int i = 0; i < table.Y.Length; i++)
                for (int j = 0; j < table.X.Length; j++)
                {
                    if (Optimum[i, j] != 0.0)
                        dataOutput.ElementAt(0).Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Green;
                    dataOutput.ElementAt(0).Rows[i].Cells[j].Value = (Optimum[i, j]).ToString();
                    sum += Optimum[i, j] * table.center[i, j];
                }
            sumOut.Text = sum.ToString();
            for(int i = 0; i < dataInput.ElementAt(2).Rows.Count; i++)
            {
                dataOutput[1].Rows[0].Cells[i].Value = dataInput[1].Rows[0].Cells[i].Value;
                dataOutput[2].Rows[i].Cells[0].Value = dataInput[2].Rows[i].Cells[0].Value;
            }
        }
        public static bool checkForEquality(DataGridView X, DataGridView Y)
        {
            int sumX = 0;
            int sumY = 0;

            for (int i = 0; i < X.Columns.Count; i++)
            {
                sumX += Convert.ToInt32(X.Rows[0].Cells[i].Value);
            }
            for (int i = 0; i < Y.Rows.Count; i++)
            {
                sumY += Convert.ToInt32(Y.Rows[i].Cells[0].Value);
            }

            if (sumX == sumY)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
