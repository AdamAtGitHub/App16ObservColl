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

            //if (DesignMode.DesignModeEnabled)
            //{
            //    for (int i = 1; i < 3; i++)
            //    {
            //        Add(new Content()
            //        {
            //            Category = "IT " + 1,
            //            Title = "Lists " + 1,
            //            MediaType = "Speech " + 1
            //            });
            //    }
            //}
        }


        public void ADDModelPropsList(Content content)
        {
            Debug.WriteLine(content);
            Add(content);
        }

    }
}
