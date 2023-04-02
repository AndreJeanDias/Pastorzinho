using System;
using System.Threading;

class Program {
    static void Main(string[] args) {
        int delay = 220;

        string melody = "CDEFFFCDCDDEEEFF";

        for (int i = 0; i < melody.Length; i++) {
            char note = melody[i];

            switch (note) {
                case 'C':
                    Console.Beep(261, 500); // C
                    break;
                case 'D':
                    Console.Beep(293, 500); // D
                    break;
                case 'E':
                    Console.Beep(329, 500); // E
                    break;
                case 'F':
                    Console.Beep(349, 500); // F
                    break;
            }

            Console.WriteLine(note);
            Thread.Sleep(delay);
        }
    }
}
