using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace ObjectsCreator.MVVM.Models
{   
    public abstract class ValidatableViewModel : ViewModel, INotifyDataErrorInfo
    {
        protected readonly Dictionary<string, string> _fieldErrors = new();
        public bool HasErrors => _fieldErrors.Any(_ => !string.IsNullOrEmpty(_.Value));
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (propertyName == null)
            {
                propertyName = "";
            }
            if (_fieldErrors.ContainsKey(propertyName))
                yield return _fieldErrors[propertyName];
        }
        public void SetError(string description, [CallerMemberName] string name = "")
        {
            _fieldErrors[name] = description;
            RaiseError(name);
            Notify(nameof(HasErrors));
        }
        public void ClearError([CallerMemberName] string name = "")
        {
            _fieldErrors.Remove(name);
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(name));
            Notify(nameof(HasErrors));
        }
        public virtual bool IsCompleted() => true;


        protected virtual void RaiseError([CallerMemberName] string name = "")
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(name));
        }
    }
}
