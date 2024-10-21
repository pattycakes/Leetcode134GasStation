namespace Leetcode134GasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gas1 = { 1, 2, 3, 4, 5 };
            int[] cost1 = { 3, 4, 5, 1, 2 };

            Console.WriteLine("ex1:" + CanCompleteCircuit(gas1, cost1));


            int[] gas2 = { 2, 3, 4 };
            int[] cost2 = { 3, 4, 3 };

            Console.WriteLine("ex2:" + CanCompleteCircuit(gas2, cost2));
        }

        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Sum() < cost.Sum()) {
                return -1;
            }

            int currentGas = 0;
            int index = 0;

            for (int i = 0; i < gas.Length; i++) 
            {
                currentGas += (gas[i] - cost[i]);
                if (currentGas < 0)
                {
                    currentGas = 0;
                    index = i + 1;
                }
            }
            return index;
        }
    }
}
