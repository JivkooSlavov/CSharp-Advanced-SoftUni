﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }

        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }
        public bool RemoveCloth(string color)
        {
            Cloth cloth = Clothes.FirstOrDefault(x => x.Color == color);
            bool isRemoved = Clothes.Remove(cloth);
            return isRemoved;
        }
        public Cloth GetSmallestCloth() => Clothes.OrderBy(x => x.Size).FirstOrDefault();

        public Cloth GetCloth(string color) => Clothes.FirstOrDefault(c => c.Color == color);

        public int GetClothCount() => Clothes.Count;

        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (var cloth in Clothes.OrderBy(x => x.Size))
            {
                sb.AppendLine(cloth.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
