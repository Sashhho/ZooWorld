namespace ZooWorld.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LifeExpectancy { get; set; }
        public int ContinentId { get; set; }
        public Continent Continent { get; set; }


    }
}
