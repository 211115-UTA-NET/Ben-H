using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
        public string Name { get; set; } = "";
        public int NumSides { get; set; } = 0;
        protected double aLength;
        protected double bLength;
        protected double cLength;
        public double area;
        
        protected double Area 
        { 
            get
            {
                return this.area;
            } 
            set
            {
                if(value > 0)
                    this.area = value;
            }
        }
        
        // Constructor
        public Triangle(double aLength, double bLength, double cLength) : base(Name, NumSides)
        {
            this.Name = Name;
            this.NumSides = NumSides;
            this.aLength = aLength;
            this.bLength = bLength;
            this.cLength = cLength;
        }

        public override void SetArea(){

            double semiPerimeter = (this.aLength + this.bLength + this.cLength) / 2; 

            this.Area = Math.Sqrt(semiPerimeter * (semiPerimeter - this.aLength) * (semiPerimeter - this.bLength) * (semiPerimeter - this.cLength));
        }
    }
}
