using System.ComponentModel;
using Windows.ApplicationModel;

namespace App16ObservColl.Models
{
    public class Content : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Content()
        {
            if (DesignMode.DesignModeEnabled)
            {
                Category = "Human Fx";
                Title = "Out the Door CheckList";
                MediaType = "Speech";
                PlayTime = "10:00 AM";
                //PlaySet = "True";//Daily Routine-Weekday 
            }
            else
            {
                //Category = "";
                //Title = "";
                //MediaType = "";
                //PlayTime = "";
                ////PlaySet = "";
                Category = "Human Fx";
                Title = "Out the Door CheckList";
                MediaType = "Speech";
                PlayTime = "10:00 AM";
            }
        }

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        #region Class/Model/Record Props & Fields
        public int Id { get; set; }

        private string category;
        public string Category
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        private string mediaType;//Speech,Audio,Video
        public string MediaType
        {
            get => mediaType;
            set
            {
                mediaType = value;
                OnPropertyChanged("MediaType");
            }
        }

        private string playTime;
        public string PlayTime
        {
            get => playTime;
            set
            {
                playTime = value;
                OnPropertyChanged("PlayTime");
            }
        }

        private string titleSet;
        public string TitleSet
        {
            get => titleSet;
            set
            {
                titleSet = value;
                OnPropertyChanged("TitleSet");
            }
        }

        private string playSet;
        public string PlaySet
        {
            get => playSet;
            set
            {
                playSet = value;
                OnPropertyChanged("PlaySet");
            }
        }

        private bool repeatsIsOn;
        public bool RepeatsIsOn
        {
            get => repeatsIsOn;
            set
            {
                repeatsIsOn = value;
                OnPropertyChanged("RepeatsIsOn");
            }
        }

        #endregion

        #region Remaining Fields
        public string TitleNo { get; set; }

        public string FileName { get; set; }

        public string Path { get; set; }

        public string RepeatIntervalName { get; set; }

        public string MediaUses { get; set; }
        #endregion

        public override string ToString()
        {
            return Title + " ," + Category + " ," + MediaType + " " + PlayTime;
        }

    }
}
