using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutA.cs
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> _animals = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }
        public AnimalFarm()
        {

        }
        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { AnimalList.Insert(index, value); }
        }
        public int count
        {
            get { return animalList.Count;
            }
            IEnumerator IEnumerable.GetEnumerator(){
            return animalList.getEnumerator();
            }
    
    }
}