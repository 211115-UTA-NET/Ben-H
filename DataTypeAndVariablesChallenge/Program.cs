using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {

          byte myByte = 24;

          sbyte mySbyte = -50;

          int myInt = 0;

          uint myUint = 543;

          short myShort = -52;

          ushort myUShort = 52;

          float myFloat = 3.45f;

          double myDouble = 3.24;

          char myCharacter = 'c';

          bool myBool = true;

          string myText = "I control text";

          string numText = "50";


            Text2Num(myText);
            Text2Num(numText);
      }

      public static int Text2Num(string numText)
      {

        int a = 0;
        bool tf;
        tf = int.TryParse(numText, out a);

        Console.WriteLine("String original: " + numText + " String after parse: " + a + " Able to be parsed: " + tf);

        return a;

      }

    
    }
}