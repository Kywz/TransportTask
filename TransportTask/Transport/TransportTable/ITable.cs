using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportTask.Transport.TransportTable
{
    interface ITable
    {
        float[,] center { get; set; }
        float[] X { get; set; }
        float[] Y { get; set; }

    }

    class Table:ITable
    {
        public float[,] center { get; set; }
        public float[] X { get; set; }
        public float[] Y { get; set; }

        public Table(float[,] center, float[] X, float[] Y)
        {
            this.center = center;
            this.X = X;
            this.Y = Y;
        }
        public Table(List<DataGridView> input)
        {
            this.center = getArrayFromDGVXY(input[0]);
            this.X = getArrayFromDGVX(input[1]);
            this.Y = getArrayFromDGVY(input[2]);
        }

        public float[,] getArrayFromDGVXY(DataGridView dataInput)
        {
            float[,] result = new float[dataInput.Columns.Count, dataInput.Rows.Count];

            for (int i = 0; i < dataInput.Rows.Count; i++)
            {
                for (int j = 0; j < dataInput.Rows[i].Cells.Count; j++)
                {
                    result[i, j] = Convert.ToInt32(dataInput.Rows[i].Cells[j].Value);
                }
            }
            return result;
        }

        public float[] getArrayFromDGVX(DataGridView dataInput)
        {
            float[] result = new float[dataInput.Rows[0].Cells.Count];

            for (int i = 0; i < dataInput.Rows[0].Cells.Count; i++)
            {
                result[i] = Convert.ToInt32(dataInput.Rows[0].Cells[i].Value);
            }

            return result;
        }

        public float[] getArrayFromDGVY(DataGridView dataInput)
        {
            float[] result = new float[dataInput.Rows.Count];

            for (int i = 0; i < dataInput.Rows.Count; i++)
            {
                result[i] = Convert.ToInt32(dataInput.Rows[i].Cells[0].Value);
            }

            return result;
        }

        public void outputTableToTextbox(RichTextBox textBox)
        {
            textBox.AppendText("");
            foreach (int i in X)
            {
                textBox.AppendText(i.ToString() + " | ");
            }
        }
    }
}
