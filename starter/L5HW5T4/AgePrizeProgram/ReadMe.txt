Task 4
Using Visual Studio, create a project using the ConsoleApplication template.
Write a program for calculating employee bonuses. Premiums are calculated according to the length of service.
If the length of service is up to 5 years, the bonus is 10% of the salary.
If the length of service is from 5 years (inclusive) to 10 years, the premium is 15% of the salary.
If the length of service is from 10 years (inclusive) to 15 years, the premium is 25% of the salary.
If the length of service is from 15 years (inclusive) to 20 years, the premium is 35% of the salary.
If the length of service is from 20 years (inclusive) to 25 years, the premium is 45% of the salary.
If the length of service is 25 years (inclusive) or more, the premium is 50% of the salary.
Calculation results, display.

Solution:

I created 6 variables with the string type, contributed there the percentage of premium depending on the length of service, in case the percentage changes.
Created a var age variable into which the number entered by the user falls.
Then, using the If else construct, we check to see if the user entered a negative number. Then we check how much to award bonuses to the employee depending on the years and display the result on the screen.
If the entered number does not correspond to the check, we deduce that the bonus is incorrect.