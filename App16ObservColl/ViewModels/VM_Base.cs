using App16ObservColl.Models;
using App16ObservColl.ViewModels.Commands;
using System.Diagnostics;

namespace App16ObservColl.ViewModels
{
    public class VM_Base
    {
        public Cmd_SetExplicitProps Cmd_SetExplicitProps { get; set; }
        public Cmd_RemoveModPropsList Cmd_RemoveModPropsList { get; set; }

        public VM_Base()
        {
            Cmd_RemoveModPropsList = new Cmd_RemoveModPropsList(this);
            Cmd_SetExplicitProps = new Cmd_SetExplicitProps(this);
            //if (DesignMode.DesignModeEnabled)
            //{
            //}
        }

        public void SetExplicitProps(string content)
        {
            Debug.WriteLine(content);
        }

        public void RemoveModPropsList(string content)
        {
            Debug.WriteLine(content);
        }

    }
}
