using Aglomera;
using Aglomera.Linkage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clustering.forms
{
    public enum tipos
    {
        euclidean,
        geodesic,
        angularEuclidean
    }
    
    public partial class Form1 : Form
    {
        public static tipos tipo = tipos.euclidean;

        public int currentColor = 0;

        public Random r = new Random();

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Maximum = -46.28;
            chart1.ChartAreas[0].AxisY.Minimum = -47;

            chart1.ChartAreas[0].AxisX.Maximum = -23.3;
            chart1.ChartAreas[0].AxisX.Minimum = -23.8;

            var dataPoints = new HashSet<DataPoint<int>>();

            var dataPointsCount =00;

            currentColor = 0;

            //gera n datapoints (entregas)
            //for (var i = 0; i < dataPointsCount; i++)
            //{
            //    dataPoints.Add(new DataPoint<int>(i, (r.NextDouble() * 360) - 180, (r.NextDouble() * 360) - 180));
            //}


            dataPoints.Add(new DataPoint<int>(1, -23.63073700, -46.76284400));
            dataPoints.Add(new DataPoint<int>(2, -23.47246600, -46.69145700));
            dataPoints.Add(new DataPoint<int>(3, -23.65500100, -46.63606800));
            dataPoints.Add(new DataPoint<int>(4, -23.51356100, -46.47214400));
            dataPoints.Add(new DataPoint<int>(5, -23.54063600, -46.50772000));
            dataPoints.Add(new DataPoint<int>(6, -23.60148400, -46.67020800));
            dataPoints.Add(new DataPoint<int>(7, -23.69411200, -46.50984100));
            dataPoints.Add(new DataPoint<int>(8, -23.71454600, -46.53431000));
            dataPoints.Add(new DataPoint<int>(9, -23.69517900, -46.49237500));
            dataPoints.Add(new DataPoint<int>(10, -23.54964100, -46.70074200));
            dataPoints.Add(new DataPoint<int>(11, -23.63106400, -46.75923500));
            dataPoints.Add(new DataPoint<int>(12, -23.59850700, -46.79617100));
            dataPoints.Add(new DataPoint<int>(13, -23.55167100, -46.77553600));
            dataPoints.Add(new DataPoint<int>(14, -23.61762400, -46.75971400));
            dataPoints.Add(new DataPoint<int>(15, -23.58806100, -46.74067200));
            dataPoints.Add(new DataPoint<int>(16, -23.63106400, -46.75923500));
            dataPoints.Add(new DataPoint<int>(17, -23.59850700, -46.79617100));
            dataPoints.Add(new DataPoint<int>(18, -23.61762400, -46.75971400));
            dataPoints.Add(new DataPoint<int>(19, -23.58421900, -46.70453400));
            dataPoints.Add(new DataPoint<int>(20, -23.55734400, -46.63531400));
            dataPoints.Add(new DataPoint<int>(21, -23.57086600, -46.53910000));
            dataPoints.Add(new DataPoint<int>(22, -23.46006300, -46.58104200));
            dataPoints.Add(new DataPoint<int>(23, -23.56266200, -46.64730900));
            dataPoints.Add(new DataPoint<int>(24, -23.59850700, -46.79617100));
            dataPoints.Add(new DataPoint<int>(25, -23.55167100, -46.77553600));
            dataPoints.Add(new DataPoint<int>(26, -23.61762400, -46.75971400));
            dataPoints.Add(new DataPoint<int>(27, -23.58421900, -46.70453400));
            dataPoints.Add(new DataPoint<int>(28, -23.51714500, -46.77178900));
            dataPoints.Add(new DataPoint<int>(29, -23.58806100, -46.74067200));
            dataPoints.Add(new DataPoint<int>(30, -23.54540300, -46.71281600));
            dataPoints.Add(new DataPoint<int>(31, -23.59938500, -46.67723000));
            dataPoints.Add(new DataPoint<int>(32, -23.53176900, -46.73454700));
            dataPoints.Add(new DataPoint<int>(33, -23.52588300, -46.44842800));
            dataPoints.Add(new DataPoint<int>(34, -23.56689100, -46.56070800));
            dataPoints.Add(new DataPoint<int>(35, -23.56245800, -46.58221300));
            dataPoints.Add(new DataPoint<int>(36, -23.57098900, -46.59345500));
            dataPoints.Add(new DataPoint<int>(37, -23.55827300, -46.58927300));
            dataPoints.Add(new DataPoint<int>(38, -23.54494800, -46.54692000));
            dataPoints.Add(new DataPoint<int>(39, -23.56508600, -46.64181700));
            dataPoints.Add(new DataPoint<int>(40, -23.53549100, -46.59959600));
            dataPoints.Add(new DataPoint<int>(41, -23.56126700, -46.63685900));
            dataPoints.Add(new DataPoint<int>(42, -23.49011300, -46.60249200));
            dataPoints.Add(new DataPoint<int>(43, -23.49372500, -46.70626100));
            dataPoints.Add(new DataPoint<int>(44, -23.45219200, -46.72911700));
            dataPoints.Add(new DataPoint<int>(45, -23.68508000, -46.46266700));
            dataPoints.Add(new DataPoint<int>(46, -23.40663400, -46.45492800));
            dataPoints.Add(new DataPoint<int>(47, -23.55130200, -46.54233600));
            dataPoints.Add(new DataPoint<int>(48, -23.52856500, -46.68533500));
            dataPoints.Add(new DataPoint<int>(49, -23.69260400, -46.57037500));
            dataPoints.Add(new DataPoint<int>(50, -23.68161500, -46.51300200));
            dataPoints.Add(new DataPoint<int>(51, -23.51844400, -46.58564600));
            dataPoints.Add(new DataPoint<int>(52, -23.48603700, -46.38723500));


            MelhorCluster(dataPoints.ToHashSet());
                                              
            //dataPointsCount = 60;           
                                              
            //dataPoints = new HashSet<DataPoint<int>>();

            ////gera n datapoints (entregas)
            //for (var i = 0; i < dataPointsCount; i++)
            //{
            //    dataPoints.Add(new DataPoint<int>(i, (r.NextDouble() * 200) - 100, (r.NextDouble() * 200) - 100));
            //}

            //MelhorCluster(dataPoints.ToHashSet());

        }

        private void MelhorCluster(HashSet<DataPoint<int>> dataPoints)
        {
            

            //inicializa classes do algoritmo
            var metric = new DissimilarityMetric<int>();
            var linkage = new AverageLinkage<DataPoint<int>>(metric);
            var algorithm = new AgglomerativeClusteringAlgorithm<DataPoint<int>>(linkage);

            //enquanto tiverem entregas pra clusterizar
            while (dataPoints.Any())
            {
                //clusteriza
                var clusteringResult = algorithm.GetClustering(dataPoints);

                //printa a clusterização
                clusteringResult.Select(x =>
                {
                    Console.WriteLine(x);

                    return 0;

                }).ToArray();

                //maximo de itens por cluster
                var MAX_ITEMS = 7;

                //vai ser feito uma força bruta no número minimo de itens, começando igual ao MAX_ITEMS e decrementando até 1 (uma entrega)
                var minItems = MAX_ITEMS;

                //Variavel de retorno da operação
                Cluster<DataPoint<int>> bestCluster = null;

                //força bruta
                while (minItems > 0)
                {
                    //vai percorrendo a lista de clusters do ultimo ao primeiro
                    for (var i = clusteringResult.Count() - 1; i >= 0; i--)
                    {
                        //ordenando decrescente pela quantidade de entregas pega o primeiro q tem a mesma quantidade ou menos q o MAX_ITEMS
                        bestCluster = clusteringResult[i].
                            OrderByDescending(x => x.Count()).
                            FirstOrDefault(y => y.Count() <= MAX_ITEMS);

                        //se a quantidade de entregas nesse cluster for igual ao minimo q estamos decrescendo finaliza o processo
                        if (bestCluster?.Count() == minItems)
                            break;
                    }

                    //como são dois loops, verifica de novo e repete o break
                    if (bestCluster?.Count() == minItems)
                        break;

                    //decresce o minItens pra tentar de novo
                    minItems--;
                }

                //resultado dessa iteração
                Console.WriteLine(bestCluster);

                var c = Color.FromArgb(200, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));

                chart1.Series.Add("series" + currentColor.ToString());

                chart1.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                bestCluster.Select(x => {

                    chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
                    {
                        XValue = x.lat,
                        YValues = new double[] { x.lon },
                       // MarkerColor = c,
                       //Label = tipo.ToString() + " "+ currentColor.ToString() + " " + x.id.ToString(),
                        MarkerSize = 10
                    });

                    return false;
                }).ToArray();

                Application.DoEvents();

               // Thread.Sleep(2000);

                currentColor++;

                //remove as entregas já clusterizadas
                dataPoints.RemoveWhere(x => bestCluster.Any(y => y.id == x.id));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipo = tipos.euclidean;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipo = tipos.geodesic;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tipo = tipos.angularEuclidean;
        }
    }

    public class DissimilarityMetric<T> : IDissimilarityMetric<DataPoint<T>>
    {
        public double Calculate(DataPoint<T> instance1, DataPoint<T> instance2)
        {
            return instance1.CompareTo(instance2);
        }
    }

    public class DataPoint<T> : IComparable<DataPoint<T>>
    {
        public T id { get; set; }

        public double lat { get; set; }

        public double lon { get; set; }

        public double Origemlat { get; set; }

        public double Origemlon { get; set; }

        public DataPoint(T id, double lat, double lon, double origemlat, double origemlon)
        {
            this.id = id;

            this.lat = lat;

            this.lon = lon;

            this.Origemlat = origemlat;

            this.Origemlon = origemlon;
        }


        public DataPoint(T id, double lat, double lon) : this(id, lat, lon, -23.55, -46.6)
        {
        }

        public int CompareTo(DataPoint<T> other)
        {
            if (Form1.tipo == tipos.euclidean)
                return (int)this.Euclidean(other);

            if (Form1.tipo == tipos.geodesic)
                return (int)this.Geodesic(other);

            return (int)this.AngularEuclidean(other);
        }

        public override string ToString()
        {
            return id.ToString();
        }

        public double Euclidean(DataPoint<T> other)
        {
            return Math.Sqrt(Math.Pow(this.lat - other.lat, 2) + Math.Pow(this.lon - other.lon, 2)) * 10000;
        }

        public double Geodesic(DataPoint<T> other)
        {
            return new GeoCoordinate(this.lat, this.lon).GetDistanceTo(new GeoCoordinate(other.lat, other.lon));
        }

        public double AngularEuclidean(DataPoint<T> other)
        {
            var deltaX = this.lat - this.Origemlat;
            var deltaY = this.lon - this.Origemlon;
            var rad = Math.Atan2(deltaY, deltaX);

            var deltaX2 = other.lat - other.Origemlat;
            var deltaY2 = other.lon - other.Origemlon;
            var rad2 = Math.Atan2(deltaY2, deltaX2);

            var pi2 = Math.PI * 2;

            var dx = Math.Abs(rad - rad2);
            if (dx > pi2 / 2)
                dx = pi2 - dx;

           // Console.WriteLine(this.id + " " +other.id + ": " + dx.ToString() +  "---" + ((rad - rad2) * (180 / Math.PI)).ToString() + "  " + (rad - rad2).ToString());

            return dx * (180 / Math.PI);
        }
    }
}
