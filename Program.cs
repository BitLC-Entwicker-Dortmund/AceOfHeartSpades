using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfHeartSpades {
    class Program {
        static void Main ( string [ ] args ) {

            Stack<Spielkarte> herzStack = new Stack<Spielkarte> ( );
            Stack<Spielkarte> pikStack = new Stack<Spielkarte> ( );
            Stack<Spielkarte> kartenStack = new Stack<Spielkarte> ( );

            for ( int i = 0 ; i < 13 ; i++ ) {
                herzStack.Push ( new Spielkarte ( ) { Farbe=(Farbe)1, Wertigkeit = (Wertigkeit) i} );
                pikStack.Push ( new Spielkarte ( ) { Farbe=(Farbe)2, Wertigkeit = (Wertigkeit) i} );
            }            

            //ZeigeStapel ( herzStack);
            //ZeigeStapel ( pikStack);            

            kartenStack = Program.ErstEinmalMischen (herzStack, pikStack );
            //ZeigeStapel ( kartenStack );

            List<Stack<Spielkarte>> ListeVonStacksSpielkarte = Program.DynStackListe( kartenStack, 4 );

            foreach ( Stack<Spielkarte> listeMitSpielkarten in ListeVonStacksSpielkarte ) {
                ZeigeStapel ( listeMitSpielkarten );
                Console.WriteLine ("==========");
            }

            Console.Read ( );
        }

        static List<Stack<Spielkarte>> DynStackListe ( Stack<Spielkarte> kartenStack , int anzahl ) {
            List<Stack<Spielkarte>> liste = new List<Stack<Spielkarte>>();

            for ( int i = 0 ; i < anzahl ; i++ ) {
                liste.Add ( new Stack<Spielkarte>());
            }

            while ( kartenStack.Count > 0 ) {
                for ( int i = 0 ; i < liste.Count ; i++ ) {
                    if ( kartenStack.Count > 0 ) {
                        liste [ i ].Push ( kartenStack.Pop ( ) );
                    } else break;
                }
            }

            return liste;
        }

         static void ZeigeStapel (Stack<Spielkarte> spielkarten  ) {
            foreach ( var item in spielkarten ) {
                Console.WriteLine (item.Farbe + " " +item.Wertigkeit);
            }
        }

         static Stack<Spielkarte> ErstEinmalMischen (Stack<Spielkarte> herz, Stack<Spielkarte> pik ) {
            Stack<Spielkarte> ergebnisStack = new Stack<Spielkarte> ( );

            for ( int i = 0 ; i < 13 ; i++ ) {
                ergebnisStack.Push ( herz.Pop());
                ergebnisStack.Push ( pik.Pop());
            }
            return ergebnisStack;
        }
    }
}
