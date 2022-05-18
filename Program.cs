using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_6
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileViewer file = new FileViewer();
            int[,] graf = file.ReadFile();
            Incident IncidentMat = new Incident();
            Adjacency AdjacencyMat = new Adjacency();

            Console.WriteLine("Матриця Інцидентності");
            int[,] incidentMatrix = IncidentMat.CreateMatrix(file, graf);
            Incident.PrintMatrix(incidentMatrix, file);
            file.WriteIncidentMatrix(incidentMatrix);

            Console.WriteLine("\nМатриця Суміжності");
            int[,] adjacencyMatrix = AdjacencyMat.CreateMatrix(file, graf);
            Adjacency.PrintMatrix(adjacencyMatrix, file);
            file.WriteAdjacencyMatrix(adjacencyMatrix);

            Console.ReadKey();
        }
    }
}
