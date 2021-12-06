using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        public string Name { get; set; } = " ";
        public int NumSides { get; set; } = 0;
        public double sideLength = 0;
        public double area = 0;
    
        
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
        public Rectangle(double sideLength) : base(Name, NumSides)
        {
            this.sideLength = sideLength;
        }

        public override void SetArea(){

            this.area = this.sideLength * this.sideLength;
        }
    }
}
