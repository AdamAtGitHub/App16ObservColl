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

        public VM_Base_ObsColl()
        {
            Cmd_ADDModelPropsList = new Cmd_ADDModelPropsList(this);

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

    }
}
