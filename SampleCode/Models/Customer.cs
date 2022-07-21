using System.ComponentModel;

namespace SampleCode.Models
{

    public class Customer : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of Customer Class
        /// </summary>
        public Customer(string customerName)
        {
            Name = customerName;
        }

        public string _Name;
        /// <summary>
        /// Gets or Sets Customer's name.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { 
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

           if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
