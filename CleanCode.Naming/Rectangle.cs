using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        // First side
        private int _SideALength;

        // Second side
        private int SideBLength;


        private DateTime _Date;

        public bool DisplayType {get; set;}

        public Rectangle(int a, int b)
        {
            _SideALength = a;
            SideBLength = b;

            _Date = DateTime.Now;
        }

        public int getField()
        {
            return _SideALength * SideBLength;
        }
        
       
        public int getDurationOfExistenceInMs()
        {
             return (int)(_Date - DateTime.Now).TotalMilliseconds;
        }

       

        public int getDurationOfExistenceInS()
        {
            return (int)(_Date - DateTime.Now).TotalSeconds;
        }
    }
}
