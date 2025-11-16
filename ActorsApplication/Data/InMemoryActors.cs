using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorsApplication.Data
{

    public static class InMemoryActors
    {
        public static List<Actor> GetActors()
        {
            return new List<Actor>
            {
                new Actor
                {
                    LastName = "DiCaprio",
                    FirstName = "Leonardo",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/4/46/Leonardo_Dicaprio_Cannes_2019.jpg",
                    BirthYear = 1974,
                    ShortBio = "An American actor and producer known for his roles in Titanic, Inception, and The Revenant."
                },
                new Actor
                {
                    LastName = "Johansson",
                    FirstName = "Scarlett",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Scarlett_Johansson_by_Gage_Skidmore_2019.jpg/1200px-Scarlett_Johansson_by_Gage_Skidmore_2019.jpg",
                    BirthYear = 1984,
                    ShortBio = "An American actress known for her roles in the Marvel Cinematic Universe and Lost in Translation."
                },
                new Actor
                {
                    LastName = "Pitt",
                    FirstName = "Brad",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Brad_Pitt_2019_by_Glenn_Francis.jpg/800px-Brad_Pitt_2019_by_Glenn_Francis.jpg",
                    BirthYear = 1963,
                    ShortBio = "An American actor and producer, famous for roles in Fight Club, Once Upon a Time in Hollywood, and 12 Monkeys."
                },
                new Actor
                {
                    LastName = "Washington",
                    FirstName = "Denzel",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/4/40/Denzel_Washington_2018.jpg",
                    BirthYear = 1954,
                    ShortBio = "An American actor, director, and producer known for his roles in Training Day, Glory, and Malcolm X."
                },
                new Actor
                {
                    LastName = "Blunt",
                    FirstName = "Emily",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/2/23/Emily_Blunt_SAG_Awards_2019.png",
                    BirthYear = 1983,
                    ShortBio = "A British-American actress known for roles in The Devil Wears Prada, A Quiet Place, and Edge of Tomorrow."
                },
                new Actor
                {
                    LastName = "Depp",
                    FirstName = "Johnny",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/2/21/Johnny_Depp_2020.jpg",
                    BirthYear = 1963,
                    ShortBio = "An American actor, known for his eccentric roles in films like Pirates of the Caribbean and Edward Scissorhands."
                },
                new Actor
                {
                    LastName = "Lawrence",
                    FirstName = "Jennifer",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/5/54/Jennifer_Lawrence_in_2016.jpg",
                    BirthYear = 1990,
                    ShortBio = "An American actress, known for her roles in The Hunger Games series and Silver Linings Playbook."
                },
                new Actor
                {
                    LastName = "Bale",
                    FirstName = "Christian",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/0/0a/Christian_Bale-7837.jpg",
                    BirthYear = 1974,
                    ShortBio = "A British actor known for his roles in The Dark Knight Trilogy, American Psycho, and The Fighter."
                },
                new Actor
                {
                    LastName = "Roberts",
                    FirstName = "Julia",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/3/36/Julia_Roberts_Delivers_Remarks_at_the_2022_Kennedy_Center_Honors_Dinner_%2852542372884%29_%28cropped%29.jpg",
                    BirthYear = 1967,
                    ShortBio = "An American actress known for her roles in Pretty Woman, Erin Brockovich, and My Best Friend's Wedding."
                },
                new Actor
                {
                    LastName = "Cumberbatch",
                    FirstName = "Benedict",
                    ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/6/6e/BCumberbatch_Comic-Con_2019.jpg",
                    BirthYear = 1976,
                    ShortBio = "A British actor known for his roles in Sherlock, Doctor Strange, The Imitation Game and pronouncing penguins as \"penwings, penlings\"."
                }
            };
        }
    }
}
