//The Secret Message (Caesar Cipher AKA Shift Code) using hash set
//British intelligence needs help decoding messages from the field. Their field agents
//have encoded messages using a simple rule. Your mission is to decode a series of secret
//messages to uncover their real meaning.
//The decoding rules are as follows: 
//    1 Each character is shifted 5 positions in the alphabet

//    a.Therefore a is encoded as f, b => g, c-> h, etc., 
//	b.The last 5 characters wrap back to the beginning
//     (so v -> a, w -> b, x->c, y->d, z->e)
//    2.   Spaces should be ignored and not decoded.
//    3.   Any uppercase letters should be made lower case
//Write a program that will prompt the user for a string message.
//Output the decoded message based on these rules.
//Continue to prompt the user for messages until the user enters:
//   STOP
//For example the message : 'mjqqt' would be decoded by your program to 'hello'

using System;
using System.Collections.Generic;
using System.Text;

namespace DowningCipherHash
{
    class Program
    {

        static void Main(string[] args)
        {

            Dictionary<char, char> substitute = new Dictionary<char, char>();
            substitute.Add('f', 'a');
            substitute.Add('g', 'b');
            substitute.Add('h', 'c');
            substitute.Add('i', 'd');
            substitute.Add('j', 'e');
            substitute.Add('k', 'f');
            substitute.Add('l', 'g');
            substitute.Add('m', 'h');
            substitute.Add('n', 'i');
            substitute.Add('o', 'j');
            substitute.Add('p', 'k');
            substitute.Add('q', 'l');
            substitute.Add('r', 'm');
            substitute.Add('s', 'n');
            substitute.Add('t', 'o');
            substitute.Add('u', 'p');
            substitute.Add('v', 'q');
            substitute.Add('w', 'r');
            substitute.Add('x', 's');
            substitute.Add('y', 't');
            substitute.Add('z', 'u');
            substitute.Add('a', 'v');
            substitute.Add('b', 'w');
            substitute.Add('c', 'x');
            substitute.Add('d', 'y');
            substitute.Add('e', 'z');


            Console.WriteLine("Agent Downing's Secret Decoder! \n");

            string userString = null;

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Type a string to decrypt. Type STOP to quit:");
                userString = Console.ReadLine();

                if (userString.ToLower() == "stop")
                {
                    keepGoing = false;
                    Console.Write("\n OK, I will stop.");
                    break;
                }

                Console.WriteLine("\n");




                Console.WriteLine("Decrypted Data:");

                string output = Decipher(userString, substitute);



                Console.Write("\n {0}", output);

                Console.WriteLine("\n");
            }
        }

        private static string Decipher(string userString, Dictionary<char, char> subs)
        {
            userString = userString.ToLower();
            

            StringBuilder sb = new StringBuilder();

            foreach (char ch in userString)
            {
                if (subs.ContainsKey(ch))
                {
                    sb.Append(subs[ch]);
                }
                else
                {
                    sb.Append(ch);
                }
                
            }
            return sb.ToString();
        }
    }
}
    

    
