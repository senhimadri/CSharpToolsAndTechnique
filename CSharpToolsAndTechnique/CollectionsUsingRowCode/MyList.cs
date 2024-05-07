using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.CollectionsUsingRowCode
{
    public interface IMyList<T>
    {
        void Add(T item);
        void Remove(T item);
        void Display();
    }
    public class MyList<T>: IMyList<T>
    {

        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[0];
            count = 0;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        } 

        private void ResizeArray()
        {
            T[] newarray = new T[items.Length*2];
        }
    }

    public class TestCalssDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
