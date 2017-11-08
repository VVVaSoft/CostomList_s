using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace CostomList
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        phonebook selectedPhone;
        public ObservableCollection<phonebook> Phones { get; set; }
        public phonebook SelectedPhone  { get{
            return selectedPhone;}
           
         set{
            selectedPhone=value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedPhone"));
        } }

        public ApplicationViewModel() {
            Phones=phonebook.create();

            RemoveCommand = new MyCommand(obj =>
                    {
                        phonebook phone = obj as phonebook;
                        if (phone != null)
                        {
                            Phones.Remove(phone);
                        }
                    },
                    (obj) => Phones.Count > 0 && selectedPhone!=null);

            AddCommand = new MyCommand(obj =>
                    {
                        phonebook phone = new phonebook("user","");
                        
                        SelectedPhone = phone;
                        Phones.Insert(0, phone);
                        PropertyChanged(this, new PropertyChangedEventArgs(""));
                    });
        }

        public MyCommand AddCommand{get;set;}
        public MyCommand RemoveCommand{get;set;}
       

    }
}
