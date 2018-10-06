using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Console_Test_Lists
{
    public class Program
    {
        //View
        static void Main(string[] args)
        {
            var addedcontents = new ViewModel().AddedContentObsColl();
            var selectedcontents = new ViewModel().SelectedContent();
            #region Below works Non Lambda
            //var IndexLessThan2 =
            //    contents.FindAll(IsSelectedIndexLessThan2);

            //foreach (var content in IndexLessThan2)
            //{
            //    Console.WriteLine(content.Title);
            //}
            #endregion

            #region With Lambda Expressions - List
            var IndexLessThan2 =
                selectedcontents.FindAll(s => s.SelectedIndex <= 3);

            foreach (var content in IndexLessThan2)
            {
                Console.WriteLine(content.Title);
            }
            #endregion
            //#region With Lambda Expressions  - ObsColl
            //var IndexMoreThan1 =
            //    addedcontents.RemoveAt(ObservableCollection<Content>(2);
            //   // contents.FindAll(c => c.SelectedIndex >= 1);

            //foreach (var content in IndexLessThan2)
            //{
            //    Console.WriteLine(content.Category);
            //}
            //#endregion
            Console.ReadLine();
        }
        //Below pred method not needed if using Lambda Expressions
        //Predicate Method(means if condition is satisfied) 
        //static bool IsSelectedIndexLessThan2(Content content)
        //{
        //    return content.SelectedIndex < 2;
        //}
    }

    class ViewModel
    {
        #region using Generic Collection List<T> -> T is Content
        public List<Content> SelectedContent()
        {
            return new List<Content>
            {
                new Content() {Title="Title 1", Category="Category 1", SelectedIndex=0},
                new Content() {Title="Title 2", Category="Category 2", SelectedIndex=1},
                new Content() {Title="Title 3", Category="Category 3", SelectedIndex=2},
                new Content() {Title="Title 4", Category="Category 4", SelectedIndex=3}
            };
        }
        #endregion

        public ObservableCollection<Content> AddedContentObsColl()
        {
            return new ObservableCollection<Content>
            {
                new Content() {Title="Title 1", Category="Category 1", SelectedIndex=0},
                new Content() {Title="Title 2", Category="Category 2", SelectedIndex=1},
                new Content() {Title="Title 3", Category="Category 3", SelectedIndex=2},
                new Content() {Title="Title 4", Category="Category 4", SelectedIndex=3}
            };
        }
    }

    class Content
    {
        public string Title;
        public string Category;
        public double SelectedIndex;
    }
}
