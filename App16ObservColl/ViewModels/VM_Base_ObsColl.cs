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

            ObservableCollection<Content> contentReference = new ObservableCollection<Content>();
            Content obj = new Content("Category", "Title", "Speech", "ForceTalk", false);
           // Class1 obj = new Class1("Maria", 22203);


            if (DesignMode.DesignModeEnabled)
            {
                for (int i = 1; i < 3; i++)
                {
                    Add(new Content()
                    {
                        Category = "Category " + i,
                        Title = "Title " + i,
                        MediaType = "Media Type " + i,
                        PlayTime = "8:00 AM " + i,
                        RepeatsIsOn = false
                    });
                }
                Remove(new Content()
                {
                    Category = "Category",
                    Title = "Title ",
                    MediaType = "Media Type ",
                    PlayTime = "8:00 AM ",
                    RepeatsIsOn = false
                });
                //ObservableCollectionItem = new Content()(
                //     Category = "Category ",
                //        Title = "Title ",
                //        MediaType = "Media Type ",
                //        PlayTime = "8:00 AM ",
                //        RepeatsIsOn = false);
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
            ObservableCollection<Content> test = new ObservableCollection<Content>();
            Content obj = new Content();

            test.Add(obj);
           
            Debug.WriteLine(obj);

        }

        public void RemoveModPropsList(Content ObservableCollectionItem)
        {
            
           // ObservableCollectionItem
           // contentReference.Add(obj);
           // contentReference.Remove(obj); //This works


            //Remove(c);
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
