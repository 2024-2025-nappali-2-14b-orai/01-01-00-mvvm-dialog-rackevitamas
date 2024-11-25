using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreataProject.Models
{
    public class Product
    {
        public Product(Guid id, string name, string csalad, DateTime datumLejarat, int price, string oregsegiSzint)
        {
            Id = id;
            string Name = name;
            string Csalad = csalad;
            DateTime DatumLejarat = datumLejarat;
            int Price = price;
            OregsegiSzint = oregsegiSzint;  
        }

        public Product(string name, string csalad, DateTime datumLejarat, int price, string oregsegiSzint)
        {
            Id = new Guid();
            string Name = name;
            string Csalad = csalad;
            DateTime DatumLejarat = datumLejarat;
            int Price = price;
            string OregsegiSzint = oregsegiSzint;
        }

        public Product()
        {
            Id = new Guid();
            Name = string.Empty;
            Csalad = string.Empty;
            DatumLejarat = DateTime.MinValue;
            Price = 0;
            OregsegiSzint = string.Empty;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Csalad { get; set; }
        public DateTime DatumLejarat { get; set; }
        public int Price { get; set; }
        public string OregsegiSzint { get; set; }
        public bool HasId => Id != Guid.Empty;


        public override string ToString()
        {
            return $"{Name} {Csalad}, szavatossági lejárat: {DatumLejarat}, ára: {Price}, értéke: {OregsegiSzint}";
        }
    }
}
