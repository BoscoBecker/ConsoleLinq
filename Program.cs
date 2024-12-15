namespace ConsoleLinq {
    internal static class Program {
        private static void Main() {
            
            // ⚡ LINQ - Language Integrated Query ⚡
            // https://docs.microsoft.com/en-us/dotnet/csharp/linq/ 

            // Specify a data source
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            // Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);
            foreach (var num in result) {
                Console.WriteLine(num);
            }
        }
    }
}