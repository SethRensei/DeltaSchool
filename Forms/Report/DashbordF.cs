using DeltaSchool.Data;
using DeltaSchool.Data.Repository;
using DeltaSchool.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DeltaSchool.Forms.Report
{
    public partial class DashbordF : Form
    {
        private readonly IUnitOfWork _uow;

        public DashbordF()
        {
            InitializeComponent();

            var ctx = new DeltaSchoolContext();
            _uow = new UnitOfWork(ctx);
        }

        private void DashbordF_Load(object sender, EventArgs e)
        {
            var nbParents = _uow.ParentStudents.GetAll().Count();
            var nbStaffs = _uow.Staffs.GetAll().Count();
            var nbStudents = _uow.Students.GetAll().Count();

            lblParentCount.Text = nbParents.ToString();
            lblStaffCount.Text = nbStaffs.ToString();
            lblStudentCount.Text = nbStudents.ToString();

            var list = _uow.Students.GetAll()
                .GroupBy(s => s.Classe.Name)
                .Select(g => new { Label = g.Key, Value = g.Count() })
                .ToList();
            DrawPie();
            DrawChart();

        }

        private void DashbordF_FormClosed(object sender, FormClosedEventArgs e)
            => _uow.Dispose();


        private void DrawPie()
        {
            var data = _uow.Students.GetAll()
            .GroupBy(s => s.Gender)
            .Select(g => new
            {
                Gender = g.Key,
                Total = g.Count()
            })
            .ToList();

            chartPie.Series.Clear();
            chartPie.ChartAreas.Clear();
            chartPie.Legends.Clear();
            chartPie.ChartAreas.Add(new ChartArea("PieArea"));

            var legend = new Legend("Legend1")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                LegendStyle = LegendStyle.Table
            };
            chartPie.Legends.Add(legend);

            var series = new Series("Répartition par genre")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "PieArea",
                Legend = "Legend1"
            };

            int totalAll = data.Sum(x => (int)x.Total);

            foreach (var g in data)
            {
                var idx = series.Points.AddXY(g.Gender, g.Total);
                var pt = series.Points[idx];

                pt.AxisLabel = g.Gender;

                pt.LegendText = g.Gender == "MALE" ? "Masculin" : "Féminin";

                double pct = totalAll == 0 ? 0 : (double)g.Total * 100.0 / totalAll;
                pt.Label = $"{pct:0}%\n{g.Total}";
                pt.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                pt.LabelForeColor = Color.Black;
            }

            // Vertical orientation (up/down)
            series["PieStartAngle"] = "270";
            series["PieDrawingStyle"] = "SoftEdge";
            series["PieLabelStyle"] = "Inside"; // or "Outside"

            chartPie.Series.Add(series);
            chartPie.Invalidate();
        }

        private void DrawChart()
        {
            var studentsByClass = _uow.Students.GetAll()
                .GroupBy(s => s.Classe.Name)
                .Select(g => new { Classe = g.Key, Total = g.Count() })
                .ToList();

            chartBar.Series.Clear();
            chartBar.ChartAreas.Clear();
            chartBar.ChartAreas.Add(new ChartArea("BarArea"));

            var series = new Series("Élèves par classe")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "BarArea"
            };

            foreach (var c in studentsByClass)
            {
                series.Points.AddXY(c.Classe, c.Total);
            }

            chartBar.Series.Add(series);
        }
    }
}
