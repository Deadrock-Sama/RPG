using System;

namespace ObjectsCreator.MVVM.Components
{
    public class EcObservableCollectionItemChangedEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
    }
}
