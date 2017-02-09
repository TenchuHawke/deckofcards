using System;
using System.Collections.Generic;

namespace CardGame {
    class Program {
        static void Main (string [] args) {
            Deck pokerDeck = new Deck ();
            List<Player> players = new List<Player> ();
            players.Add (new Player ("Jeff"));
            players.Add (new Player ("Bill"));
            players.Add (new Player ("Bob"));
            players.Add (new Player ("Sam"));
            // Beginning of hand
            //first deal
            public void deal (Deck deckCurrent, List playersList) 
            pokerDeck.shuffle ();
            foreach (Player gamer in players) {
                gamer.draw(pokerDeck);
            }

        }
    }
}