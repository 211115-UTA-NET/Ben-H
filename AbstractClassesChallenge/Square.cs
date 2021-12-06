using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        public string Name { get; set; } = " ";
        public int NumSides { get; set; } = 0;
        protected double sideLength = 0;
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
        public Square(string Name, int NumSides, double sideLength)
        {
            this.Name = Name;
            this.NumSides = NumSides;
            this.sideLength = sideLength;
        }

        
    }
}
