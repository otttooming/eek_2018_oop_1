﻿using System;
namespace eek_2018_oop
{
    public class SantaClause
    {
        private string name;
        private int dateOfBirth;
        private int numOfPresents;
        private double weightOfPresents;

        public SantaClause(string name = "John Smith", int dateOfBirth=0, int numOfPresents=0, double weight=0)
        {
            this.dateOfBirth = dateOfBirth;
            this.numOfPresents = numOfPresents;
            this.name = name;
            /*
                this.weightOfPresents not required if func argument is not the same as private defined value
            */
            weightOfPresents = weight;
        }

        public void printMe()
        {
            Console.Write("{0, -15} {1, 4} {2, 2} {3, 2:f1}",
                          name, dateOfBirth, numOfPresents, weightOfPresents);
        }
    }
}