using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;
        public Engine()
        {
            this.Displacement = default;
            this.Efficiency = default;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
        public int Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }
        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"  {this.Model}:");
            stringBuilder.AppendLine($"    Power: {this.Power}");
            if (this.displacement != default)
            {
                stringBuilder.AppendLine($"    Displacement: {this.Displacement}");
            }
            else
            {
                stringBuilder.AppendLine($"    Displacement: n/a");
            }
            if (this.efficiency != default)
            {
                stringBuilder.AppendLine($"    Efficiency: {this.Efficiency}");
            }
            else
            {
                stringBuilder.AppendLine($"    Efficiency: n/a");

            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
