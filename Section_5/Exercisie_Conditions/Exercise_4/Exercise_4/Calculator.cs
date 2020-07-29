using System;

namespace Exercise_4
{
    public class Calculator
    {
        public int CalculatePoints(int velocity, int speedLimit)
        {
            int points;
            float difference;

            if (speedLimit >= velocity)
                points = 0;
            else
                points = (int)Math.Round((double)((velocity - speedLimit) / 5));
            return points;
        }
    }
 }
