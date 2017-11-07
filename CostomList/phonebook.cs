using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace CostomList
{
    class phonebook
    {
        public string name { get; set; }
        public string phone { get; set; }
        public phonebook(string _name, string _phone)
        { 
            name=_name;
            phone=_phone;
        }
        public static ObservableCollection<phonebook> create()
        {
            ObservableCollection<phonebook> list = new ObservableCollection<phonebook>();
            list.Add(new phonebook("иванов", "+599808080"));
            list.Add(new phonebook("петров", "+765855780"));
            list.Add(new phonebook("сидоров", "+575855780"));
            return list;
        }
    };
    

}
