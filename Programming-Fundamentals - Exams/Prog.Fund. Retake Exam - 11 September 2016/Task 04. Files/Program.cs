namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Files
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> allFIles = new List<string>();
            for (int i = 0; i < n; i++)
            {
                allFIles.Add(Console.ReadLine());
            }
            var filter = Console.ReadLine().Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries);
            var filterExt = "." + filter[0];
            var filterRoot = filter[1] + @"\";

            Dictionary<string, long> fileSize = new Dictionary<string, long>();
            foreach (var f in allFIles)
            {
                var filePLusSize = f.Split(';');
                long size = long.Parse(filePLusSize[1]);
                var path = filePLusSize[0];
                if(path.StartsWith(filterRoot) && path.EndsWith(filterExt))
                {
                    var tokens = path.Split('\\');
                    var fileName = tokens[tokens.Length - 1];
                    fileSize[fileName] = size;
                }
            }
            if (fileSize.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            foreach (var fs in fileSize.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
            {
                Console.WriteLine($"{fs.Key} - {fs.Value} KB");
            }
        }
    }
}