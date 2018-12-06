using System;
using System.Collections.Generic;

public class DayTwoPartTwo
{

    

    public string DoPartTwo()
    {
        

            var boxIds = new List<string>() {"aba", "abb", "abc", "abc"};
            var checkedList = new List<string>(){};

        foreach(string boxId in boxIds)
        {
           if(checkedList.Contains(boxId))
           {
               return boxId;
           }
           else{
               checkedList.Add(boxId);
           }
        }
        return "hello world";
    }
}