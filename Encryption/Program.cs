using System;

/*
 * a company wants to send data over the internet and wants me to write a program to encrypt it.
 * data is transmitted as four-digit integers
 * read a four digit integer entered by the user and encrypt it
 * replace each digit with the result of adding 7 to the digit. and getting the remainder after dividing the new value by 10
 * swap the first digit with the third, and swap the second digit with the fourth. then display the encrypted integer using D4 format
 * 
 * 
 * (Main)
 * prompt user to enter four digit integer
 * read in integer
 * if integer is 4 four digits long call solve with the integer if not prompt user invalid integer ask for another integer.
 * 
 * 
 * 
 * Prompt user to enter 4 digit number for encryption
 * make sure it is an int and also 4 digits long
 * call solve() with 4 digit int
 * inside solve *
 * get each individual digit
 * replace each digit with the result of adding 7 to the digit % 10
 * swap the first digit with the third
 * swap the second digit with the fourth
 * 
 *  
 * 
 */
class Program
{

    static void Solve(int code)
    {
        //get individual digits
        int firstDigit = (code / 1000) % 10;
        int secondDigit = (code / 100) % 10;
        int thirdDigit = (code / 10) % 10;
        int fourthDigit = code % 10;

        //add 7 and take the remainder after dividing by 10
        firstDigit = (firstDigit + 7) % 10;
        secondDigit = (secondDigit + 7) % 10;
        thirdDigit = (thirdDigit + 7) % 10;
        fourthDigit = (fourthDigit + 7) % 10;

        int encryptedCode = (thirdDigit * 1000) + (fourthDigit * 100) + (firstDigit * 10) + secondDigit;

        Console.WriteLine($"This is the encrypted code: {encryptedCode:D4}");
    }

    static void Main()
    {
        int counter = 0;
        while (counter == 0)
        {

            Console.Write("Please enter 4 digit integer for encryption: ");
            String input = Console.ReadLine();
            int code; //hold a valid input
            bool success = int.TryParse(input, out code); //see if input can be converted to int

            //check if int is 4 digits long and if it is a int
            if (input.Length == 4 && success)
            {
                counter++;
                Solve(code);
            }
            else
            {
                Console.WriteLine("Invalid Integer");
            }
        }
    }
}