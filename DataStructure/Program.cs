using DataStructure;
using System;
using DataStructure.UnorderedList;
using System.Net.NetworkInformation;
using DataStructure.BalancedParanthesis;

namespace DataStructure
{
    class Program
    {
        static string unOrderedFilePath = @"E:\BridgeGateProblems\DataStructure\DataStructure\UnorderedList\UnOrderList.txt";
        static string OrderedFilePath = @"E:\BridgeGateProblems\DataStructure\DataStructure\OrderedList\OrderedList.txt";
        static string BalanceParenthesisFilepath = @"E:\BridgeGateProblems\DataStructure\DataStructure\BalancedParanthesis\BalancedParanthesisText.txt";
        static void Main(string[] args)
        {
            UnorderedListOperations operation = new UnorderedListOperations();
            operation.ReadFileAndPerformOperation(unOrderedFilePath);

            OrderedListOperations operation2 = new OrderedListOperations();
            operation2.ReadAndPerformOperation(OrderedFilePath);

            BalancedParanthesisOperation operation3 = new BalancedParanthesisOperation();
            operation3.ReadAndPerformOperation(BalanceParenthesisFilepath);
        }
    }
}