using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Enemy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public float AvgDamage { get; set; }
        
        public int CalculateDamage()
        {
            Random dmg = new Random();
            return dmg.Next(MinDamage, MaxDamage);
        }
    }
}
