using DataStructure;
using System;
using DataStructure.UnorderedList;
using System.Net.NetworkInformation;



namespace DataStructure
{
    class Program
    {
        static string unOrderedFilePath = @"E:\BridgeGateProblems\DataStructure\DataStructure\UnorderedList\UnOrderList.txt";
        static string OrderedFilePath = @"E:\BridgeGateProblems\DataStructure\DataStructure\OrderedList\OrderedList.txt";
        static void Main(string[] args)
        {
            UnorderedListOperations operation = new UnorderedListOperations();
            operation.ReadFileAndPerformOperation(unOrderedFilePath);

            OrderedListOperations operation2 = new OrderedListOperations();
            operation2.ReadAndPerformOperation(OrderedFilePath);
        }
    }
}