# Logical-Error 2
--------------------ISSUE---------------------------------
The problem is that the if-statement checks if age is over 18. It would work if we were only checking for 18 and not 30 and 50 becasue if the age is over 18 it prints out "over 18" but 30 is also over 18 so it prints out "over 18" again and same for 50.
You can make it sort of work if you remove the else if's and replace them with if's but it still casues some issues. 

--------------------FIX-----------------------------------
I fixed it by making it check if your over or equal to 18 but under 30, over or equal to 30 but under 50 and then over or equal to 50. 
