using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public int age;
        private float height;//altura
        private float weight;//peso
        private float imc;
        

        public Person(float height, float weight, int age=0)
        {
            this.height = height;//altura
            this.weight = weight;//peso
            this.age = age;
            this.calcImc();
        }

        public float getHeight()
        {
            return this.height;
        }

        public float getWeight()
        {
            return this.weight;
        }

        public float getImc()
        {
            return this.imc;
        }

        public void setHeight(float height)
        {
            this.height = height;
            this.calcImc();
        }

        public void setWeight(float weight)
        {
            this.weight = weight;
            this.calcImc();
        }

        private void calcImc()
        {
            this.imc = this.weight / (this.height * this.height);
        }
    }
}
