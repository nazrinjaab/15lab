
using _15lab.extencions;
using _15lab.interfaces;
using _15lab.Structs;

namespace _15lab.Models
{




    internal class PuzzleGameApp : App, ICoop
    {
        public string puzzleType { get; set; }
        public bool IsKeyBoardAllowed { get; set; }
        public bool IsKeyboardAllowed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PuzzleGameApp ( string _Name, AppCategory category, double price, AppRating rating,string puzzletype, bool isKeyboardAllowed)
        {
            puzzleType = puzzletype;
            IsKeyBoardAllowed = isKeyboardAllowed;
        }
        public void StartCoop ()
        {
            Console.WriteLine( " CO-OP GAME IS STARTED");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine( ); 
            
        }
    }
}
