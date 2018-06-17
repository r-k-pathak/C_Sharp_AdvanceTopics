using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics
{
    class Point
    {
        public int X;
        public int Y;
        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        //over loading Move method based on type,order of method arguments but with same name
        public void Move(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newLocation)
        {
            //intead of writing below code we can call another over loaded method 
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
            //like this one
            if(newLocation==null)
            {
                throw new ArgumentException("Invalid Argument");
            }
            Move(newLocation.X, newLocation.Y);
            //but we have one issue with this approach , if Point is null then we will need to handle this in out code
            // also we need global mechanisum to handle exceptions
            

        }
    }
}
