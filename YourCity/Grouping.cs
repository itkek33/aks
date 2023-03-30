using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourCity
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Name { get; private set; }
        public DateTime Key { get; }
        public IGrouping<DateTime, NewsObj> G { get; }

        public Grouping(K name, IEnumerable<T> items) : base(items)
        {
            Name = name;
        }

        
    }
}