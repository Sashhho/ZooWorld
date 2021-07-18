namespace ZooWorld.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Categories
    {
        public int Id { get; set; }
        public string Carnivore { get; set; }
        public string Omnivore { get; set; }
        public string Herbivore { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
