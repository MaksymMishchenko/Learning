Task 3
Using Visual Studio, create a project using the Console Application template.
Write a program for determining whether a user-specified number from 0 to 100 falls into the numerical range [0 - 14] [15 - 35] [36 - 50] [50 - 100]. If so, indicate in which period. If the user indicates a number that is not included in any of the available numerical spaces, a corresponding message is displayed.

Solution:

Create a result variable of type double and zero it. We assign the user input value to the result variable. Using the branching operator SWITCH CASE, we find out which number of the four intervals the user entered in the range from 0 to 100 and we display the corresponding result for the user.

If the number entered by the user exits limits, we display a message: "You entered a large or small value."