using System;
using System.Collections.Generic;

namespace CardGame {
    public class Deck {
        List<object> cards = new List<object> ();
        public void shuffle () {
            Random rand = new Random ();
            foreach (int location in cards) {
                object temp = cards [location];
                int newLocation = (rand.Next (0, 51));
                cards [location] = cards [newLocation];
                cards [newLocation] = temp;
            }
        }
        public object draw () {
            int topCardIndex = cards.Count;
            if (topCardIndex == 0) {
                return null;
            }
            object topCard = cards [topCardIndex];
            return topCard;
        }
        public void reset () {
            cards.Clear ();
            for (int i = 0; i < 52; i++) {
                cards.Add (new Card (i));
            }
        }
        public Deck () {
            for (int i = 0; i < 52; i++) {
                cards.Add (new Card (i));
            }
        }
    }
}
