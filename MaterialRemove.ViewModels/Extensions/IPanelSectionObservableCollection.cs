using MaterialRemove.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace MaterialRemove.ViewModels.Extensions
{
    internal interface IPanelSectionObservableCollection : ICollection<IPanelSection>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        void Add(IList<IPanelSection> items);
        bool Remove(IList<IPanelSection> items);
        void AddAndRemove(IList<IPanelSection> items, IList<IPanelSection> removeItems);
    }
}
