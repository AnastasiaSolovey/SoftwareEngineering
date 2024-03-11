using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareEngineering
{
    public partial class Form1 : Form
    {
        int m, n;        //размеры матрицы
        double[,] A;      //матрица

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            m = Convert.ToInt32(mBox.Text);
            n = Convert.ToInt32(nBox.Text);
            A = new double[m, n];

            // Чистка DataGridView, если они не пусты
            int k = 0;
            k = MatrixDataGridView.ColumnCount;
            if (k != 0)
                for (int i = 0; i < k; i++)
                    MatrixDataGridView.Columns.RemoveAt(0);

            // Заполнение DataGridView столбцами
            AddColumns(n, MatrixDataGridView);
            // Заполнение DataGridView строками
            AddRows(m, MatrixDataGridView);


        }
        private void AddColumns(int n, DataGridView dgw)
        {
            // добавляет n столбцов в элемент управления dgw
            DataGridViewColumn column;
            for (int i = 0; i < n; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Column" + i.ToString();
                column.Name = "Column" + i.ToString();
                dgw.Columns.Add(column);
            }
        }

        private void CheckInput_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            string elem = "";
            bool correct = true;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        elem = MatrixDataGridView.Rows[i].Cells[j].Value.ToString();
                        A[i, j] = Convert.ToDouble(elem);
                        ErrorLabel.Visible = true;
                        ErrorLabel.ForeColor = Color.Green;
                        ErrorLabel.Text = "Значения верны";
                    }
                    catch (Exception any)
                    {
                        ErrorLabel.Visible = true;
                        ErrorLabel.ForeColor = Color.Red;
                        ErrorLabel.Text = "Значение элемента A[i,j]  не корректно. Повторите ввод";
                        MatrixDataGridView.Rows[i].Cells[j].Selected = true;
                        return;
                    }
                }
            
        }

        private void ChangeMinElement_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < m; i++)
    {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] < 0)
                    {
                        break;
                    }
                    else
                    {
                        A[i, j] = 0;
                        MatrixDataGridView.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();

        }

        private void AddRows(int m, DataGridView dgw)
        {
            // добавляет m строк в элемент управления dgw
            for (int i = 0; i < m; i++)
            {
                dgw.Rows.Add();
                dgw.Rows[i].HeaderCell.Value = "row" + i.ToString();
            }
        }

    }
}
