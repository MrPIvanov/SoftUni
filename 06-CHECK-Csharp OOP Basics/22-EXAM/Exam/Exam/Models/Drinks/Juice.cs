﻿namespace Exam.Models.Drinks
{
    public class Juice : Drink
    {
        private const decimal JuicePrice = 1.8m;

        public Juice(string name, int servingSize, string brand)
            : base(name, servingSize, JuicePrice, brand)
        {
        }
    }
}
