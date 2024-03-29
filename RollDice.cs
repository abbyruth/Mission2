﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
// Abby Harris
// Section 001

namespace Mission2
{
    // this class holds a method that simulates a dice roll 
    internal class RollDice
    {
        public int[] DiceRoll(int numRolls)
        {
            Random random = new Random();
            int[] results = new int[13];

            for (int i = 0; i < numRolls; i++)
            {
                // two random integers added together to simulate two dice being rolled
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;
                results[sum]++;
            }

            return results;
        }
    }
}
