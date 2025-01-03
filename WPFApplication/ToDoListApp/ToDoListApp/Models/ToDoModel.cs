using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ToDoListApp.Models
{
    class ToDoModel : INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        [JsonProperty(propertyName: "creationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [JsonProperty(propertyName: "isDone")]
        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                if (IsDone == value)
                {
                    return;
                }

                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        [JsonProperty(propertyName: "text")]
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text == value)
                {
                 return;   
                }

                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
