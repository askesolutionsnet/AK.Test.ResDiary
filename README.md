# AK.Test.ResDiary

Problem:
The goal is to divide the input array into N equally sized arrays, and if the size of the original array cannot be divided equally by N, the final part should have a length equal to the remainder.

Explanation:

1- The GroupArrayElements function takes an input array and a positive integer N as arguments.
2- It first checks if N is a positive integer greater than zero, throwing an exception if not.
3- The variable arraySize holds the length of the input array.
4- The variable chunkSize calculates the size of each chunk, ensuring that the last chunk has the remainder elements if the array cannot be divided equally.
5- I create a list of lists (result) to store the divided arrays.
6- The loop divides the array into chunks and adds each chunk to the result.
7- Finally, the function returns the list of divided arrays.


Note: This implementation follows real-world practices, including input validation, readable variable names, and clear comments to explain the logic.  Also, dependency injection
pattern and SoC as best software development practices.


Instruction:
1- Used .Net 7.  You should have .Net 7 framework and Visual Studio 2022 installed.
2- Clone and open the project from Git to your local using Visual Studio 2022.
3- Run the console App 'AK.Test.ResDiary'.  Make sure it set as startup project.
4- Just replace inputArray and N with your desired values to see expected results.
5- Also, you can see some unit test to validate the code.  

