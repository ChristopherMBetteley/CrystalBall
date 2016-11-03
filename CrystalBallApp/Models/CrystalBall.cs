using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        //get random number
        //create an array of strings for response
        public string getResponse()
        {
            string[] responses = { "You are Loved", "Its best to serve soup warm", "I like ponies" };
            //get random number object
            Random randomNum = new Random();
            var num = randomNum.Next(0,responses.Length);
            return responses[num];
        }

    }
}