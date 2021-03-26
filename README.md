# TextToACIIGenerator
This will allow users to type in a string that will then be converted to ACII art letters.

Users can type in any character and it will output something like this. 

![Demo](/CroppedHelloWorld.gif)
 
 The ToList function simply returns a single list<string> and takes in a string. This function does NOT allow new lines, as only a single list is used
 
The ToLists function returns a List<List<string>> and takes in a string. This function DOES allow multiple new lines.

New Lines can be entered by using /

      As for printing Options, Print simply prints the single list and takes in a List can take an optional color parameter.
     PrintWDelay prints out the list and takes in a sinlge list with and an int with the number of ms of delay. It also has an optional boolean parameter for random color.
     PrintLists takes in a List<List<string>> and prints them all out.
     PrintListsWDelay exists as well and takes in a two-dimensional list of lists with and an int with the number of ms of delay. It also has an optional boolean parameter for random color.
     
