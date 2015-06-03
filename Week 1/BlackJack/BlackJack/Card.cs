using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public struct Card
    {
        public int Id;
        public int Face;
        public char Suite;

        public override string ToString()
        {

        string facestr = Face.ToString();
        switch (Face)
        {
            case (0):
            facestr = "K";
            break;
            case (1):
            facestr = "A";
            break;
            case (11):
            facestr = "J";
            break;
            case (12):
            facestr = "Q";
            break;


        }

        return String.Format("{0} {1}", facestr, Suite);
        }
    }
}
