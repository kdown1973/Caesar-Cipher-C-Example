# Caesar-Cipher-C-Example
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
