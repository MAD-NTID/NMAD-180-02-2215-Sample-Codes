using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Grade
    {
        public string firstName;
        public string lastName;
        public int score;
        public string courseName;

        const double PASS_SCORE = 75.0;
        

        public string Record()
        {
            return $"{firstName} - {lastName} - {courseName} - {score}";
        }

        public bool IsPassed()
        {
            return score >= PASS_SCORE;
        }
    }
}
