using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    { 
        struct PostIt
        {
            public string Text;
            public string TextColor;
            public string BackGroundColor;
        }

        static void Main(string[] args)
        {
            PostIt postit1;
            postit1.Text = "Idea1";
            postit1.TextColor = "blue";
            postit1.BackGroundColor = "orange";

            PostIt postit2;
            postit2.Text = "Awesome";
            postit2.TextColor = "black";
            postit2.BackGroundColor = "pink";

            PostIt postit3;
            postit3.Text = "Superb";
            postit3.TextColor = "green";
            postit3.BackGroundColor = "yellow";
        }
    }
}