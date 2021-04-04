
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeFit.Forms;

namespace BeFit.Classes
{
    public class Profile
    {


        public string Name { get; set; }
        public List<Day_Meals> List_Of_meals { get; set; }



        public Profile(string name)
        {
            Name = name;
            List_Of_meals = new List<Day_Meals>();

        }

        public string GetPathJson()
        {

            string projectDirectory = ReturnProjectDirectory.GetProfilesPath();
            projectDirectory += Name + ".json";
            return projectDirectory;

        }
        public void SaveProfileToJson()
        {

            FindAndRemoveOutdatedMeals();
            using (StreamWriter writer = File.CreateText(GetPathJson()))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, this);
            }
        }

        private void FindAndRemoveOutdatedMeals()
        {

            for (int i = List_Of_meals.Count - 1; i >= 0; i--)
            {
                if (List_Of_meals[i].Date.AddDays(30) < DateTime.Now.Date)
                {
                    List_Of_meals.RemoveAt(i);
                }
            }
        }

        public void LoadProfileFromJson()
        {
            string jsonstring = File.ReadAllText(GetPathJson());
            var profile = JsonConvert.DeserializeObject<Profile>(jsonstring);
            this.List_Of_meals = profile.List_Of_meals;
        }

    }
}




