using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs13
{
    class Human
    {
        private int height { get; set; }
        private int weight { get; set; }
        private int age { get; set; }
        public string Name { get; set; }

    public void SetAge (int age)
        {
            this.age = age;
        }

        public void SetWeight(int weight)
        {
            this.weight = weight;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetWeight()
        {
            return this.weight;
        }
        public int GetHeight()
        {
            return this.height;
        }

        public virtual int GetAge()
        {
            return this.age;
        }

    }
    
}
