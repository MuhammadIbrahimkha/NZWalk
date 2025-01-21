﻿using System.Reflection.Metadata.Ecma335;

namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Area { get; set; }
        public  double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }


        // Navigation Properties


        // One region can have multiple walks inside it.
        public IEnumerable<Walk> Walks { get; set; }





    }
}
