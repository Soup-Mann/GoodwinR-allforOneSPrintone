using Microsoft.AspNetCore.Mvc;
using MiniChallengeJaun.models;

namespace MiniChallengeJaun.Controllers;

[ApiController]
[Route("[controller]")]
public class AllForOneController : ControllerBase
{

        [HttpGet]
    [Route("addTwo/{number1}/{number2}")]
    public int addTwoUp(string number1, string number2){
    int convertNum1 = Convert.ToInt32(number1);
    int convertNum2 = Convert.ToInt32(number2);
    return convertNum1 + convertNum2;

}

//Say Wsp
[HttpGet]
    [Route("sayHi/{name}")]
    public string sayHello(string name){
        
return $"whats up {name}";
}


//MadLib
[HttpGet]
    [Route("madLib/{time}/{person}/{feels}/{place}/{car}/{celeb}/{food}/{personTwo}/{obj}/{music}")]
    public string Madder(string time, string person, string feels, string place, string car, string celeb, string food, string personTwo, string obj, string music){
        
return $"One {time}, {person} was chilling minding their own bussines when suddenly they feel {feels}. So they decide to go to {place} in their {car}. While headind to {place} they stop to get gas and see {celeb}. They walk over and invite them to com along! They head out together and end up at {place} They decide to eat {food} and while eating they see {personTwo} they come over. Person two grabs {obj} out from underneath their jacket and runs out yelling! {music} The end!";
}


//GreaterOrLess
[HttpGet]
    [Route("greaterOrLess/{greater}/{lessthan}")]
    public string sayHello(int greater, int lessthan){
    string result = "";

        if (greater > lessthan)
    {
        result = greater + " Is greater than " + lessthan + "!";
    }
    else if (greater == lessthan)
    {
      result = greater + " Is equal too " + lessthan + "!";
    }
    else{
        result = greater + " Is less than " + lessthan + "!";
    }       return result;
}


//OddOrEven
[HttpGet]
    [Route("oddOrEven/{isit}")]
    public string isitodd(string isitodd){
        
return $"{isitodd} this number is a number";
}


[HttpGet]
    [Route("reverseIt/{uOne}")]
    public string rev(string uTwo, string uOne){



            for (int i = 0; i < uOne.Length; i++)
            {
                Console.Write(uOne[i]);
            };
    


            string reversedString = String.Empty;
            for (int i = uOne.Length - 1; i > -1; i--)
            {
                reversedString += uOne[i];

            };

            Console.WriteLine(reversedString);

             for (int i = 0; i < uTwo.Length; i++)
            {
                Console.Write(uTwo[i]);
            };
    


            string reversedString2 = String.Empty;
            for (int i = uTwo.Length - 1; i > -1; i--)
            {
                reversedString2 += uTwo[i];

            };

            return reversedString2;


       
}


[HttpGet]
    [Route("asking/{him}/{me}")]
    public string him(string him, string me){

        
return $"{him} is my name and {me} is my age";

}

public List<studentListModel> studentsList = new List<studentListModel>()
        {
            // call the constructor to add the students
           new studentListModel(){
                firstName = "Danny",
                lastName = "Tran",
                slackName = "Danny Tran",
                email = "dannytran@gmail.com",
                hobbies = "Being an awesome TA"
            },
            new studentListModel(){
                firstName = "Scott",
                lastName = "Morenzone",
                slackName = "Scott Morenzone",
                email = "scottmorenzone@gmail.com",
                hobbies = "Just being the best TA"
            },
            new studentListModel(){
                firstName = "Ken",
                lastName = "Martinez",
                slackName = "Ken Martinez",
                email = "kenmartinez@gmail.com",
                hobbies = "Being the best Boss ever!!!!"
            },new studentListModel(){
                firstName = "Harrison",
                lastName = "busby",
                slackName = "Hattison Busby",
                email = "hbusby@codestack.co",
                hobbies = "Piano"
            },
            new studentListModel(){
                firstName = "Brandon",
                lastName = "Le",
                slackName = "Brandon Le",
                email = "ble@codestack.co",
                hobbies = "Eating & Sleeping"
            },
            new studentListModel(){
                firstName = "jessie",
                lastName = "Lamzon",
                slackName = "jessie Lamzon",
                email = "jlamzon@codestack.co",
                hobbies = "Eating, traveling"
            },
            new studentListModel(){
                firstName = "Andrea",
                lastName = "Burr",
                slackName = "Andrea Burr",
                email = "aburr@codestack.co",
                hobbies = "Horse Riding"
            },
            new studentListModel(){
                firstName = "Pedro",
                lastName = "Castanedra",
                slackName = "Pedro Castanedra",
                email = "pcastaneda@codestack.co",
                hobbies = "hiking and traveling"
            },
            new studentListModel(){
                firstName = "Jeremy",
                lastName = "Lapham",
                slackName = "Musccle Baby",
                email = "jedkok@codstack.co",
                hobbies = "Body building, powerlifting, wresting"
            },
            new studentListModel(){
                firstName = "Jacob",
                lastName = "Dekok",
                slackName = "Jacob Dekok",
                email = "jdekok@codestack.co",
                hobbies = "Copying Jeremy, Body building, powerlifting, wrestiling"
            },
            new studentListModel(){
                firstName = "Kenneth",
                lastName = "Fujimura",
                slackName = "Kenneth Fujimura",
                email = "kfujimura@codestack.co",
                hobbies = "Games, Sports, Model Kits, Anime, Naps, Culinary Tourism"
            },
            new studentListModel(){
                firstName = "Fernando",
                lastName = "Aguilar",
                slackName = "Freddy Aguilar",
                email = "faguilar@codestack.co",
                hobbies = "playing videogames, reading, writing"
            },
            new studentListModel(){
                firstName = "Jovann",
                lastName = "Contreas",
                slackName = "Jovann Contreras",
                email = "jcontreras@codestack.co",
                hobbies = "Nothing at the time"
            },
            new studentListModel(){
                firstName = "Andrew",
                lastName = "Nilsson",
                slackName = "Drew Nilsson",
                email = "anilsson@codestack.co",
                hobbies = "Playing video games"
            },
            new studentListModel(){
                firstName = "Lerissa",
                lastName = "Lazar",
                slackName = "Lerissa Lazar",
                email = "llazar@codestack.co",
                hobbies = "Drawing & watching anime"
            },
            new studentListModel(){
                firstName = "N. Harrison",
                lastName = "Wilkins",
                slackName = "Harrison Wilkins",
                email = "nwilkins@codestack.co",
                hobbies = "Nothing at the time"
            },
            new studentListModel(){
                firstName = "Madeline",
                lastName = "Gowen",
                slackName = "Maddie Gowan",
                email = "mgowan@codestack.co",
                hobbies = "Rodents"
            },
            new studentListModel(){
                firstName = "Manuel",
                lastName = "Leyva",
                slackName = "Manuel Leyva",
                email = "mleyva@codestack.co",
                hobbies = "Photography"
            },
            new studentListModel(){
                firstName = "Elizar",
                lastName = "Garcia",
                slackName = "Elizar Garcia",
                email = "Egarcia@codestack.co",
                hobbies = "Bowling and Sleeping"
            },
            new studentListModel(){
                firstName = "Mark",
                lastName = "Ramirez",
                slackName = "mark ramirez",
                email = "mramirez@codestack.co",
                hobbies = "games and drinking way to much water"
            },
            new studentListModel(){
                firstName = "Chris",
                lastName = "Martinez",
                slackName = "ChrisMartinez",
                email = "cmartinez@codestack.co",
                hobbies = "nothing at the time"
            },
            new studentListModel(){
                firstName = "Samuel",
                lastName = "Laguna",
                slackName = "Samuel Laguna",
                email = "slaguna@codestack.co",
                hobbies = "nothing at the time"
            },
            new studentListModel(){
                firstName = "Isaiah",
                lastName = "Ferguson",
                slackName = "Isaiah Ferguson",
                email = "IFerguson@codestack.co",
                hobbies = "nothing at the time"
            },
            new studentListModel(){
                firstName = "Jhon",
                lastName = "Magpantay",
                slackName = "Jhon Magpantay",
                email = "jmagpantay",
                hobbies = "FPS games"
            },
            new studentListModel(){
                firstName = "Reed",
                lastName = "Goodwin",
                slackName = "Reed Goodwin",
                email = "rgoodwin@codestack.co",
                hobbies = "Skateboarding, snowboarding, videogames"
            },
            new studentListModel(){
                firstName = "Amar",
                lastName = "Mann",
                slackName = "Amar",
                email = "amann@codestack.co",
                hobbies = "Kicking rocks"
            },
            new studentListModel(){
                firstName = "Marcel",
                lastName = "Rodriguez",
                slackName = "Marcel Rodrigez",
                email = "mrodriguez@codestack.co",
                hobbies = "nothing at the time"
            },
            new studentListModel(){
                firstName = "Ricard",
                lastName = "Johnson",
                slackName = "Richard Johnson",
                email = "johson@codestack.co",
                hobbies = "Watching youtube, sketching, playing video games"
            },
            new studentListModel(){
                firstName = "Ulises",
                lastName = "Ortega",
                slackName = "Ulises Ortega",
                email = "uortega@codestack.co",
                hobbies = "Video Games, Rollerblading, Board Games"
            },
            new studentListModel(){
                firstName = "Caroline",
                lastName = "Hana",
                slackName = "Caroline Hana",
                email = "chana@codestack.co",
                hobbies = "video games, anime, hanging out w friends"
            },
            new studentListModel(){
                firstName = "Aisha",
                lastName = "Mashrah",
                slackName = "Aisha Mashrah",
                email = "amashrah@codestack.co",
                hobbies = "painting"
            }

        };

        [HttpGet]
        [Route("GetStudentByFirstName/{studentFirstName}")]
        public studentListModel GetStudentByFirstName(string studentFirstName)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].firstName == studentFirstName)
                {
                    result = studentsList[i];
                    break;
                }
                // else{
                //     result.firstName = "N/A";
                //     result.lastName = "N/A";
                //     result.slackName = "N/A";
                //     result.email = "N/A";
                //     result.hobbies = "N/A";
                // }
            }

            return result;
        }

         [HttpGet]
        [Route("GetStudentByLastName/{studentLastName}")]
        public studentListModel GetStudentByLastName(string studentLastName)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].lastName == studentLastName)
                {
                    result = studentsList[i];
                    break;
                }
                // else{
                //     result.firstName = "N/A";
                //     result.lastName = "N/A";
                //     result.slackName = "N/A";
                //     result.email = "N/A";
                //     result.hobbies = "N/A";
                // }
            }

            return result;
        }


         [HttpGet]
        [Route("GetStudentBySlackName/{studentSlackName}")]
        public studentListModel GetStudentBySlackName(string studentSlackName)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].slackName == studentSlackName)
                {
                    result = studentsList[i];
                    break;
                }
                // else{
                //     result.firstName = "N/A";
                //     result.lastName = "N/A";
                //     result.slackName = "N/A";
                //     result.email = "N/A";
                //     result.hobbies = "N/A";
                // }
            }

            return result;
        }

         [HttpGet]
        [Route("GetStudentByEmail/{studentEmail}")]
        public studentListModel GetStudentByEmail(string studentEmail)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].lastName == studentEmail)
                {
                    result = studentsList[i];
                    break;
                }
                // else{
                //     result.firstName = "N/A";
                //     result.lastName = "N/A";
                //     result.slackName = "N/A";
                //     result.email = "N/A";
                //     result.hobbies = "N/A";
                // }
            }

            return result;
        }


[HttpGet]
[Route("{lame}")]
public string deeznuts(string lame){

Random rndNum = new Random();


if(lame != "1" || lame != "2" || lame != "3" || lame != "4"){
string[] FastFood = {"Taco Bell", "Mcdonalds", "Jack in the Box", "Carls Jr", "Popeyes", "Kanes", "Panda Express", "KFC", "Papa Johns", "Dominoes"};
string[] DineIn = {"Strings", "Mikasa Sushi", "Petes Restaurant", "Titos", "Las Casuelas", "Cafe Platano", "AppleBees", "Chilis's", "West Coast Sourdough", "Indian Cafe"};
string[] Adventure = {"Go find the nearest taco truck!!", "Call Your next of Kin and Ask them to name the first restaurant that comes to mind!", "Ask a random person off the street for their input", "drive a random direction until you find someplace to eat!", "Find the worst rated place on yelp", "Find the highest rated place on yelp", "Find a place close to you that youve never eaten at", "Go to a breakfast place for dinner", "Call ur friend and ask them what you should get", "park ur car downtown and walk until you see something good!"};
string[] raandom = {"Taco Bell", "Mcdonalds", "Jack in the Box", "Carls Jr", "Popeyes", "Kanes", "Panda Express", "KFC", "Papa Johns", "Dominoes", "Strings", "Mikasa Sushi", "Petes Restaurant", "Titos", "Las Casuelas", "Cafe Platano", "AppleBees", "Chilis's", "West Coast Sourdough", "Indian Cafe", "Go find the nearest taco truck!!", "Call Your next of Kin and Ask them to name the first restaurant that comes to mind!", "Ask a random person off the street for their input", "drive a random direction until you find someplace to eat!", "Find the worst rated place on yelp", "Find the highest rated place on yelp", "Find a place close to you that youve never eaten at", "Go to a breakfast place for dinner", "Call ur friend and ask them what you should get", "park ur car downtown and walk until you see something good!"};
switch(lame){
    case "1":
    int den = rndNum.Next(0,9);
    return $"You have Chosen fast food!\n--{FastFood[den]}-- ";
    case "2":
    int dinen = rndNum.Next(0,9);
    return $"You have chosen Dine-In!\n--{DineIn[dinen]}--";
    case "3":
    int advent = rndNum.Next(0,9);
    return $"You have chosen Adventure!\n--{Adventure[advent]}--";
    case "4":
    int thirty = rndNum.Next(0,29);
     return $"You have chosen Random!\n--{raandom[thirty]}-- ";
     
}

}
return $"{lame} is not a whole number between 1-4 :)\nThanks for playing !";
}



}


