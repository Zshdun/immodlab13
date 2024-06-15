using System;
using System.Windows.Forms;

namespace modelingLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double rateEuro, rateDollar;

        readonly Random random = new Random();

        readonly double mu = 0; // Параметр сноса
        double sigma1 = 0.15; // Параметр волатильности
        double sigma2 = 0.25;
        readonly double dt = 0.01;
        
        bool isActive = true; 
        
        public double NextGaussian()
        {
        double u1 = 1.0 - random.NextDouble();
        double u2 = 1.0 - random.NextDouble();
        double normalRandom = Math.Sqrt(-2.0 * Math.Log(u1)) *
                     Math.Sin(2.0 * Math.PI * u2); 
        return normalRandom;
        }

        public double sign()
        {
            if (random.NextDouble() - 0.5 < 0)
                return -1;
            else
                return 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rateEuro += sign() * Math.Exp((mu - 0.5 * sigma1 * sigma1) * dt + sigma1 * sigma1 * Math.Sqrt(dt) * NextGaussian()); 
            rateDollar += sign() * Math.Exp((mu - 0.5 * sigma2 * sigma2) * dt + sigma2 * sigma2 * Math.Sqrt(dt) * NextGaussian());
            chart1.Series[0].Points.AddXY(0, rateEuro);
            chart1.Series[1].Points.AddXY(0, rateDollar);


        }

        private void clear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear(); 
            chart1.Series[1].Points.Clear();
            isActive = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Legends.Add("euro");
            chart1.Series.Add("euro");
            
            chart1.Legends.Add("dollar");
            chart1.Series.Add("dollar");

            for (int i = 0; i < 2; i++)
            {
                chart1.Series[i].IsValueShownAsLabel = true;
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[i].BorderWidth = 3;
                chart1.Series[i].SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
                chart1.Series[i].SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
                chart1.Series[i].LabelFormat = "f3";
                chart1.Series[i].IsXValueIndexed = true;
            }   
        }

        private void init_Click(object sender, EventArgs e)
        {
            if (isActive) {
                rateEuro = (double)euroSP.Value; 
                rateDollar = (double)dollarSP.Value; 
                chart1.Series[0].Points.Clear(); 
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(0, rateEuro);
                chart1.Series[1].Points.AddXY(0, rateDollar);
            }
            isActive = false;

            if (initButton.Text == "Старт") {
                initButton.Text = "Стоп";
                timer1.Start(); 
            } else {
                initButton.Text = "Старт";
                timer1.Stop();
            }
        }
    }
}
