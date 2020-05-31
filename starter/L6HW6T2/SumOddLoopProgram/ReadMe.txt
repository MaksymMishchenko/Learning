Task 2
Using Visual Studio, create a project using the Console Application template.
Given two numbers A and B (A <B) print the sum of all the numbers located between these numbers on the screen.
Given two numbers A and B (A <B) print all the odd values ​​located between the given numbers.


Solution

1.We ask the person to enter the first and second number. We read what numbers the user entered, convert to Int32. Using a loop, create a condition. In the body of the loop, create a variable and assign it the result of adding numbers between the specified user numbers. When the condition in the loop becomes false, display the sum of all numbers on the screen.

2.To output all the odd numbers, we use the for loop and the if construct in the body of the loop. In the loop condition, create the counter i, to which we assign the value of the first number entered +1. If the counter is less than the second entered number b, then we add +1 to it using the increment. In the condition of the if construction, we indicate that if the counter value is divided by 2, then it is = 1 (0 is an even number, 1 is an odd number). Display odd numbers on the screen.


