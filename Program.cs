using Aglomera;
using Aglomera.Linkage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace clustering
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var dataPoints = new HashSet<DataPoint<int>>();

                var dataPointsCount = 20;

                //gera n datapoints (entregas)
                for (var i = 0; i < dataPointsCount; i++)
                {
                    dataPoints.Add(new DataPoint<int>(i, (new Random()).NextDouble() * 5, (new Random()).NextDouble() * 5));
                }

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

                            //se a quantidade de entregas nesse cluster for igual ao minimo q estamos descrecendo finaliza o processo
                            if (bestCluster?.Count() == minItems)
                                break;
                        }

                        //como são dois loops, verifica de novo e repete o break
                        if (bestCluster?.Count() == minItems)
                            break;

                        //decresse o minItens pra tentar de novo
                        minItems--;
                    }

                    //resultado dessa iteração
                    Console.WriteLine(bestCluster);

                    //remove as entregas já clusterizadas
                    dataPoints.RemoveWhere(x => bestCluster.Any(y => y.id == x.id));

                    Console.WriteLine();

                    Console.WriteLine();

                    //acalma o coração e repete até não ter mais entregas pra clusterizar
                    Console.ReadLine();
                }
            }
        }
    }

    public class DissimilarityMetric<T> : IDissimilarityMetric<DataPoint<T>>
    {
        public double Calculate(DataPoint<T> instance1, DataPoint<T> instance2)
        {
            return instance1.Euclidean(instance2);
        }
    }

    public class DataPoint<T> : IComparable<DataPoint<T>>
    {
        public T id { get; set; }

        public double lat { get; set; }

        public double lon { get; set; }

        public DataPoint(T id, double lat, double lon)
        {
            this.id = id;

            this.lat = lat;

            this.lon = lon;
        }

        public int CompareTo(DataPoint<T> other)
        {
            return (int)this.Euclidean(other);
        }

        public override string ToString()
        {
            return id.ToString();
        }

        public double Euclidean(DataPoint<T> other)
        {
            return Math.Sqrt(Math.Pow(this.lat - other.lat, 2) + Math.Pow(this.lon - other.lon, 2));
        }
    }
}
