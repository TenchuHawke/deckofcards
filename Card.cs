using System;

namespace CardGame {
    public class Card {
        public string stringVal;
        public int val;
        public string suit;
        public Card (int CardNumber) {
            val = (CardNumber % 13) + 1;
            if (CardNumber < 14) {
                suit = "Spades";
            }
            else if (CardNumber < 27) {
                suit = "Diamonds";
            }
            else if (CardNumber < 40) {
                suit = "Clubs";
            }
            else {
                suit = "Hearts";
            }
            switch (val) {
                case (1):
                    stringVal = "Ace";
                    break;
                case (2):
                case (3):
                case (5):
                case (6):
                case (7):
                case (8):
                case (9):
                case (10):
                    stringVal = $"{val}";
                    break;
                case (11):
                    stringVal = "Jack";
                    break;

                case (12):
                    stringVal = "Queen";
                    break;
                case (13):
                    stringVal = "King";
                    break;
                default:
                    stringVal = "Card definition error.";
                    break;

            }
        }

    }
}