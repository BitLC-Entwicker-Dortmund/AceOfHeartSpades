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
            ZeigeStapel ( kartenStack );

            Console.Read ( );
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
