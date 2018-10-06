using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.Data.Sqlite;
using Microsoft.Data.Sqlite.Internal;
using System.Collections.Generic;
using System.Diagnostics;
using App16ObservColl.Models;

namespace App16ObservColl
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //Code needed to launch a Different Page
            var t = Dispatcher.RunAsync(
              Windows.UI.Core.CoreDispatcherPriority.Normal,
              () =>
              {
                  //Frame.Navigate(typeof(Views.SettingsPage));
                  //Frame.Navigate(typeof(Views.Titles_List_DbPage));
              });
        }

        private void AppBarBtnAddText_Click(object sender, RoutedEventArgs e)
        {
            using (SqliteConnection db = new SqliteConnection("FileName=sqliteSample.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                //Use parameterized query to Prevent SQ injection attacks
                insertCommand.CommandText = "INSERT INTO Titles VALUES (NULL, @Entry);";
                insertCommand.Parameters.AddWithValue("Entry", boxInputTitle.Text);

                try
                {
                    insertCommand.ExecuteReader();
                }
                catch (SqliteException error)
                {
                    //Handle error
                    Debug.WriteLine(error.Message.ToString());
                    return;
                }
                db.Close();
            }
           // listViewOutput.ItemsSource = Grab_Entries();
        }

        private List<String> Grab_Entries()
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db = new SqliteConnection("FileName=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand =
                    new SqliteCommand("SELECT Text_Entry from Titles", db);
                SqliteDataReader query;
                try
                {
                    query = selectCommand.ExecuteReader();
                }
                catch (SqliteException error)
                {
                    //Handle error
                    Debug.WriteLine(error.Message.ToString());
                    return entries;
                }
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
        }

        //private void btnRemoveSelectedItems(object sender, RoutedEventArgs e)
        //{
        //    //Replace Class with your object type
        //    while (listViewOutput.SelectedItems.Count > 0)
        //    {
        //        .Remove((Content)listViewOutput.SelectedItem);
        //    }
        //}
    }
}
