using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;
        public Car()
        {
            this.Weight = default;
            this.Color = default;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.Model}:");
            stringBuilder.AppendLine($"{this.Engine.ToString()}");
            if (this.Weight != default)
            { 
                stringBuilder.AppendLine($"  Weight: {this.Weight}"); 
            }
            else
            { 
                stringBuilder.AppendLine($"  Weight: n/a"); 
            }
            if (this.Color != default)
            {
                stringBuilder.AppendLine($"  Color: {this.Color}");
            }
            else
            {
                stringBuilder.AppendLine($"  Color: n/a");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
