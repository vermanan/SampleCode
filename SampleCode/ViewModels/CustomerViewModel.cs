﻿using System;
using System.Diagnostics;
using SampleCode.Models;
using System.Windows.Input;
using SampleCode.Commands;

namespace SampleCode.ViewModels
{
    internal class CustomerViewModel
    {
        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// </summary>
        public CustomerViewModel()
        {
            _Customer = new Customer("Nancy");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        public bool CanUpdate { 
            get
            {
                if(Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        private Customer _Customer;
        /// <summary>
        /// Gets the customer instance
        /// </summary>
        public Customer Customer { 
            get { return _Customer;} 
        }

        /// <summary>
        /// Gets the UpdateCommand for the ViewModel.
        /// </summary>
        public ICommand UpdateCommand { get; private set; }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
        }
    }
}
