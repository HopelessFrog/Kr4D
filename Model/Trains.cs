using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.Sqlite;

namespace Multiprocessor_And_Multithreaded_Programming
{
    public class Trains
    {
        public Trains(string? trainsName, string? trainsDOC, DateTime departure, DateTime arrival, string? trainsType)
        {
            TrainsName = trainsName;
            TrainsDOC = trainsDOC;
            Departure = departure;
            Arrival = arrival;
            TrainsType = trainsType;
        }

        public int Id { get; set; }
     
        public string? TrainsName { get; set; } 
    
        public string? TrainsDOC { get; set; } 

        public string? TrainsType { get; set; } 

        public DateTime Departure { get; set; } 

        public DateTime Arrival { get; set; } 

        public int IdWhereWay { get; set; } 
        public WhereFromWay? WhereWay { get; set; } 
        
    }
}