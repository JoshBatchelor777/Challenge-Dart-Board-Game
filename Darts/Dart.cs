using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; } // 1 to 20 spaces
        public int Multiplier { get; set; } // Variable to hold a range of 1 to 100.
        public bool isDouble { get; set; } // Check if score should be doubled.
        public bool isTriple { get; set; } //  Check if score should be trippled.

        private Random initialRandomDartProperty = new Random(); 
        // using "_random" is just quicker and can be done when
        // "Random" is private.

        // Overloaded Constructor for making a new random each time a dart is initialized.
        // This says what should happen with "Dart" each time it's called.
        public Dart(Random NewRandomDartProperty)
        {
            // Every time Dart is called, the random property of the dart class
            // is now reassigned to a completely new variable, which is also
            // System.Random, and is a new blank slate random value.
            initialRandomDartProperty = NewRandomDartProperty;

            // THIS ALSO MEANS WHENEVR DART IS CALLED, IT WILL EXPECT A ***NEW***
            // RANDOM VALUE TO BE PASSED IN, IN NewRandomDartProperty's PLACE.
        }

        // Void method, because it's not returning anything, only performing a function.
        // Set Score equal to a random number within the range: 1 to 20.
            // Then check the range of multiplier: First check for the multiplier
            // to land on the last 5 digist of 95 to 100 (a 5% chance).
            // Otherwise, if not at least greater than 95, check from that place
            // of not being 95, down to 90, another 5 digits, thus another 5% chance.
             
        public void Throw()
        {
            Score = initialRandomDartProperty.Next(0, 21);
            Multiplier = initialRandomDartProperty.Next(1, 101);
            if (Multiplier > 95) isTriple = true;
            else if (Multiplier > 90) isDouble = true; 
        }
    }
}
