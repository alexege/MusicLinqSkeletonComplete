using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist artist = Artists.FirstOrDefault(city => city.Hometown == "Mount Vernon");
            System.Console.WriteLine(artist.ArtistName);
            //Who is the youngest artist in our collection of artists?
            int smallest_num = Artists.Min(age => age.Age);
            var youngest = Artists.Where(age => age.Age == smallest_num);
            foreach(var art in youngest)
            {
                System.Console.WriteLine(art.ArtistName + " : " + art.Age);
            }

            System.Console.WriteLine("\n");

            //Display all artists with 'William' somewhere in their real name
            var willIam = Artists.Where(name => name.RealName.Contains("William"));
            foreach(var will in willIam)
            {
                System.Console.WriteLine(will.ArtistName);
            }

            System.Console.WriteLine("\n");

            //Display the 3 oldest artist from Atlanta
            var ATL = Artists.Where(artst => artst.Hometown == "Atlanta");
            var oldest3 = ATL.OrderByDescending(age => age.Age).Take(3);
            foreach(var oldest in oldest3)
            {
                System.Console.WriteLine(oldest.ArtistName + " from " + oldest.Hometown + " age :" + oldest.Age);
            }


            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
	        // Console.WriteLine(Groups.Count);
        }
    }
}
