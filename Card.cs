using System;

namespace CardGame {
    public class Card {
        public string stringVal {
            get {
                switch (val) {
                    case (1):
                        return "Ace";
                        break;
                    case (2):
                    case (3):
                    case (4):
                    case (5):
                    case (6):
                    case (7):
                    case (8):
                    case (9):
                    case (10):
                        return val.ToString ();
                        break;
                    case (11):
                        return "Jack";
                        break;

                    case (12):
                        return "Queen";
                        break;
                    case (13):
                        return "King";
                        break;
                    default:
                        return "Card definition error.";
                        break;
                }
            }
        }
        public int val;
        public string suit;
        public override string ToString () {
            return stringVal + " of " + suit;
        }
        public Card (int CardNumber) {
            val = (CardNumber % 13) + 1;
            if (CardNumber < 13) {
                suit = "Spades";
            } else if (CardNumber < 26) {
                suit = "Diamonds";
            } else if (CardNumber < 39) {
                suit = "Clubs";
            } else {
                suit = "Hearts";
            }

        }

    }
}