using MaterialRemove.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace MaterialRemove.ViewModels.Extensions
{
    internal class PanelSectionObservableCollection : IPanelSectionObservableCollection
    {
        private object _lock = new object();
        private Dictionary<int, IPanelSection> _sections = new Dictionary<int, IPanelSection>();

        public int Count
        {
            get
            {
                lock (_lock)
                {
                    return _sections.Count;
                }
            }
        }

        public bool IsReadOnly => false;

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IList<IPanelSection> items)
        {
            lock (_lock)
            {
                foreach (var item in items)
                {
                    _sections.Add(item.Id, item);
                }
            }

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, items as IList));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
        }

        public void Add(IPanelSection item)
        {
            lock(_lock)
            {
                _sections.Add(item.Id, item);
            }

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
        }

        public void Clear()
        {
            lock (_lock)
            {
                _sections.Clear();
            }

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
        }

        public bool Contains(IPanelSection item)
        {
            lock (_lock)
            {
                return _sections.ContainsKey(item.Id);
            }
        }

        public void CopyTo(IPanelSection[] array, int arrayIndex)
        {
            foreach (var section in _sections.Values)
            {
                if (arrayIndex < array.Length)
                {
                    array[arrayIndex++] = section;
                }
                else
                {
                    throw new ArgumentException("Array is not large enough to hold the sections.");
                }
            }
        }

        public IEnumerator<IPanelSection> GetEnumerator() => _sections.Values.GetEnumerator();

        public bool Remove(IList<IPanelSection> items)
        {
            var removedCount = 0;

            lock (_lock)
            {                
                foreach (var item in items)
                {
                    if (_sections.Remove(item.Id))
                    {
                        removedCount++;
                    }
                }
            }

            if (removedCount > 0)
            {
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, items as IList));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }

            return removedCount > 0;
        }

        public bool Remove(IPanelSection item)
        {
            bool result = false;

            lock (_lock)
            {
                result = _sections.Remove(item.Id);
            }

            if (result)
            {
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }

            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddAndRemove(IList<IPanelSection> items, IList<IPanelSection> removeItems)
        {
            lock (_lock)
            {
                foreach (var item in removeItems)
                {
                    _sections.Remove(item.Id);
                }
                foreach (var item in items)
                {
                    _sections.Add(item.Id, item);
                }
            }

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, items as IList));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removeItems as IList));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
        }
    }
}
