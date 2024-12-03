# Logical-Error 2
--------------------ISSUE---------------------------------
The problem is that the if-statement checks if age is over 18. It would work if we were only checking for 18 and not 30 and 50 becasue if the age is over 18 it prints out "over 18" but 30 is also over 18 so it prints out "over 18" again and same for 50.
You can make it sort of work if you remove the else if's and replace them with if's but it still casues some issues. 

--------------------FIX-----------------------------------
I fixed it by making it check if your over or equal to 18 but under 30, over or equal to 30 but under 50 and then over or equal to 50. 


# Logical-Error 3
---------------------ISSUE------------------------------
The issue is that there was a for loop, the for loop doesent loop the numbers of the array but it loops the length of it (in this case 5 times).  

--------------------FIX---------------------------------
This was fixed by using the foreach loop instead. The foreach loop takes the numbers in the array.
