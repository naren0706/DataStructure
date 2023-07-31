using DataStructure;
using System;
using System.Net.NetworkInformation;



namespace DataStructure
{
    class Program
    {
        static string unOrderedFilePath = @"E:\BridgeGateProblems\DataStructure\DataStructure\UnorderedList\UnOrderList.txt";
        static string OrderedFilePath = @"E:\BridgeGateProblems\DataStructure\DataStructure\OrderedList\OrderedList.txt";
        static void Main(string[] args)
        {
            UnorderedlistOperation operation = new UnorderedlistOperation();
            operation.ReadFileAndPerformOperation(unOrderedFilePath);

        }
    }
}