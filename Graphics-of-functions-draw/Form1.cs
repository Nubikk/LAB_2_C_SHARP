using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphics_of_functions_draw
{
    
    public partial class Form1 : Form
    {
        Chart myChart = new Chart();
        Series mySeriesOfPoint = new Series("function");
        public Form1()
        {

            InitializeComponent();
           
            //кладем его на форму и растягиваем на все окно.
            myChart.Parent = this;
            myChart.Dock = DockStyle.None;
            myChart.Size = new Size (473,270);

            //добавляем в Chart область для рисования графиков, их может быть
            //много, поэтому даем ей имя.
            myChart.ChartAreas.Add(new ChartArea("Math functions"));
            //Создаем и настраиваем набор точек для рисования графика, в том
            //не забыв указать имя области на которой хотим отобразить этот
            //набор точек.
         
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySeriesOfPoint.ChartType = SeriesChartType.FastLine;
            mySeriesOfPoint.ChartArea = "Math functions";
            mySeriesOfPoint.Points.Clear();
            myChart.Series.Clear();
            for (int i = 0 ; i < dataGridView1.RowCount - 1; i++)
            {
                double x = Convert.ToDouble(dataGridView1[0, i].Value);
                double y = Convert.ToDouble(dataGridView1[1, i].Value);
                mySeriesOfPoint.Points.AddXY(x, y);
            }
            //Добавляем созданный набор точек в Chart
            myChart.Series.Add(mySeriesOfPoint);
        }
    }
}
