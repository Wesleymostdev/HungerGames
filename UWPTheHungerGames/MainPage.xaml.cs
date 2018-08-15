using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPTheHungerGames.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPTheHungerGames
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

        private IList<Contestant> contestantsList = new List<Contestant>();

        public IList<Contestant> ContestantsList
        {
            get { return this.contestantsList; }
        }
         // Using a loop to add (24) Contestants to List
         public void AddContestantToList_Click(object sender,RoutedEventArgs e)
        {
            for(int i = 0; i < 1 ; i++)
            {
                contestantsList.Add(new Contestant(1, "Zorro", Gender.MALE, new District() { Id = 1, DistrictName = "District 1" }));
                contestantsList.Add(new Contestant(2, "Superman", Gender.MALE, new District() { Id = 2, DistrictName = "District 2" }));
                contestantsList.Add(new Contestant(3, "Batman", Gender.MALE, new District() { Id =3, DistrictName = "Distric 3" }));
                contestantsList.Add(new Contestant(4, "Robin", Gender.MALE, new District() { Id = 4, DistrictName = "District 4  " }));
                contestantsList.Add(new Contestant(5, "Splinter", Gender.MALE, new District() { Id = 5, DistrictName = "District 5" }));
                contestantsList.Add(new Contestant(6, "Rafaello", Gender.MALE, new District() { Id = 6, DistrictName = "District 6" }));
                contestantsList.Add(new Contestant(7, "Donnatello", Gender.MALE, new District() { Id = 7, DistrictName = "District 7" }));
                contestantsList.Add(new Contestant(8, "Hulk", Gender.MALE, new District() { Id = 8, DistrictName = "District 8" }));
                contestantsList.Add(new Contestant(9, "Blade", Gender.MALE, new District() { Id = 9, DistrictName = "District 9" }));
                contestantsList.Add(new Contestant(10, "Captain Ammerica", Gender.MALE, new District() { Id = 10, DistrictName = "District 10" }));
                contestantsList.Add(new Contestant(11, "Destroyer", Gender.MALE, new District() { Id = 11, DistrictName = "District 11" }));
                contestantsList.Add(new Contestant(12, "Wesley", Gender.MALE, new District() { Id = 12, DistrictName = "District 12" }));
                contestantsList.Add(new Contestant(13, "CatWomen", Gender.FEMALE, new District() { Id = 13, DistrictName = "District 1" }));
                contestantsList.Add(new Contestant(14, "Xena", Gender.FEMALE, new District() { Id = 14, DistrictName = "District 2" }));
                contestantsList.Add(new Contestant(15, "BatWomen", Gender.FEMALE, new District() { Id = 15, DistrictName = "District 3" }));
                contestantsList.Add(new Contestant(16, "CatWoman", Gender.FEMALE, new District() { Id = 16, DistrictName = "District 4" }));
                contestantsList.Add(new Contestant(17, "Hollow", Gender.FEMALE, new District() { Id = 17, DistrictName = "District 5" }));
                contestantsList.Add(new Contestant(18, "Huntress", Gender.FEMALE, new District() { Id = 18, DistrictName = "District 6" }));
                contestantsList.Add(new Contestant(19, "HawkGirl", Gender.FEMALE, new District() { Id = 19, DistrictName = "District 7" }));
                contestantsList.Add(new Contestant(20, "Nova", Gender.FEMALE, new District() { Id = 20, DistrictName = "District 8" }));
                contestantsList.Add(new Contestant(21, "Nomarita", Gender.FEMALE, new District() { Id = 21, DistrictName = "District 9" }));
                contestantsList.Add(new Contestant(22, "Rogue", Gender.FEMALE, new District() { Id = 22, DistrictName = "District 10" }));
                contestantsList.Add(new Contestant(23, "Storm", Gender.FEMALE, new District() { Id = 23, DistrictName = "District 11" }));
                contestantsList.Add(new Contestant(24, "SuperGirl", Gender.FEMALE, new District() { Id = 24, DistrictName = "District 12" }));

                MyContestantList.ItemsSource = ContestantsList;
            }
        }
    }
}
