// Seonghyeon Choe
// schoe@seonghyeonchoe.com
// 2021

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            String direction = "";
            if (initialTy > lightY )
            {
                direction = direction + "N";
                --initialTy;
            }
            else if (initialTy < lightY )
            {
                direction = direction + "S";
                ++initialTy;
            }

            if (initialTx > lightX )
            {
                direction = direction + "W";
                --initialTx;
            }
            else if (initialTx < lightX )
            {
                direction = direction + "E";
                ++initialTx;
            }

            Console.WriteLine(direction);
        }
    }
}
