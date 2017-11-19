using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').ToList();
        var command = Console.ReadLine();
        
        while (command != "3:1")
        {
            var commandArgs = command.Split(' ');
            var commandName = commandArgs[0];
            if(commandName == "merge")
            { 
                var startIndex = int.Parse(commandArgs[1]);
                var endIndex = int.Parse(commandArgs[2]);
                input = Merge(input, startIndex, endIndex);             
            }
            if(commandName == "divide")
            {
                var index = int.Parse(commandArgs[1]);
                var partitions = int.Parse(commandArgs[2]);
                input = Devide(input, index, partitions);
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", input));
    }

    private static List<string> Devide(List<string> input, int index, int partitions)
    {
        index = CheckingIndex(index, input);
        string element = input[index];
        int partitionLenght = element.Length / partitions;
        List<string> dividedPartitions = new List<string>();
        for (int i = 0; i < partitions; i++)
        {
            if(i == partitions - 1)
            {
                dividedPartitions.Add(element.Substring(i * partitionLenght));
            }
            else
            {
                dividedPartitions.Add(element.Substring(i * partitionLenght, partitionLenght));
            }
        }
        input.RemoveAt(index);
        input.InsertRange(index, dividedPartitions);
        return input;
    }

    private static List<string> Merge(List<string> input, int startIndex, int endIndex)
    {
        startIndex = CheckingIndex(startIndex, input);
        endIndex = CheckingIndex(endIndex, input);
        List<string> newList = new List<string>();
        StringBuilder mergedData = new StringBuilder();

        for (int i = 0; i < startIndex; i++)
        {
            newList.Add(input[i]);
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            mergedData.Append(input[i]);
        }
        newList.Add(mergedData.ToString());
        for (int i = endIndex + 1; i < input.Count; i++)
        {
            newList.Add(input[i]);
        }
        return newList;
    }

    public static int CheckingIndex(int index, List<string> input)
    {
       if(index < 0)
        {
            index = 0;
        }
       if(index >= input.Count)
        {
            index = input.Count - 1;
        }
        return index;      
    }
}

