using System;
using App16ObservColl.Models;
using App16ObservColl.ViewModels.Commands;
//using Microsoft.Data.Sqlite;
using Windows.ApplicationModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace App16ObservColl.ViewModels
{
    public class VM_Base_ObsColl : ObservableCollection<Content>
    {
        public Cmd_ADDModelPropsList Cmd_ADDModelPropsList { get; set; }
        public Cmd_RemoveModPropsList Cmd_RemoveModPropsList { get; set; }
        //private ObservableCollection<Content> selectedTitles;

        //private Content selectedTitle;
        //public Content SelectedTitle
        //{
        //    get => selectedTitle;
        //    set
        //    {
        //        selectedTitle = value;
        //        //OnPropertyChanged("SelectedTitles");
        //    }
        //}

        //Declare collection and asign a few collections Items (Props n vals)

        //public ObservableCollection<Content> SelectedTitles =
        //    new ObservableCollection<Content>();


        //    {
        //        new Content{Category="Helper Reminder", Title="Weekend"},
        //        new Content{Category="IT-Stuff", Title="Collections"},
        //        new Content{Category="SED-IB", Title="The Hard Sell"}
        //    };

        //SelectedTitles = new ObservableCollection<Content>()
        //{
        //new Content{Category="Helper Reminder", Title="Weekend"},
        //new Content{Category="IT-Stuff", Title="Collections"},
        //new Content{Category="SED-IB", Title="The Hard Sell"}
        // };
        //public ObservableCollection<Content> SelectedTitles =
        //  new ObservableCollection<Content>();

        public VM_Base_ObsColl()
        {
            Cmd_ADDModelPropsList = new Cmd_ADDModelPropsList(this);
            Cmd_RemoveModPropsList = new Cmd_RemoveModPropsList(this);

           

            if (DesignMode.DesignModeEnabled)
            {
                for (int i = 1; i < 3; i++)
                {
                    Add(new Content()
                    {
                        Category = "Category " + 1+i,
                        Title = "Title " + 1+i,
                        MediaType = "Media Type " + 1+i,
                        PlayTime = "8:00 AM " + 1 + i
                    });
                }        
            }
        }

        private object observableCollectionItem;

        public object ObservableCollectionItem
        {
            get
            {
                return observableCollectionItem;
            }
            set
            {
                observableCollectionItem = value;
                //OnPropertyChanged("ObservableCollectionItem");
            }
        }


        public void ADDModelPropsList(Content content)
        {     
            Content c = new Content();
            c.Category = content.Category;
            c.Title = content.Title;
            c.MediaType = content.MediaType;
            c.PlayTime= content.PlayTime;
            Add(c);
            Debug.WriteLine(c);
        }

        public void RemoveModPropsList(Content c)
        {
            Remove(c);
            // ObservableCollection<Content> .observableCollectionItem);
            //RemoveAt(ObservableCollection).IndexOf(ObservableCollectionItem));
            //ObservableCollection<Content>.RemoveAt(ObservableCollection).IndexOf(ObservableCollectionItem));
        }

        //public void RemoveModPropsList(Content content)
        //{

        //    //RemoveAt(ObservableCollection).IndexOf(ObservableCollectionItem));
        //    ObservableCollection<Content>.RemoveAt(ObservableCollection).IndexOf(ObservableCollectionItem));
        //}

    }
}
