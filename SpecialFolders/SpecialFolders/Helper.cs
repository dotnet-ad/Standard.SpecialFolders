using System;
using System.Diagnostics;

namespace SpecialFolders
{
    public static class Helper
    {
        public static void LogSpecialFolders()
        {
            foreach (var value in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                var folder = (Environment.SpecialFolder)value;
                var path = Environment.GetFolderPath(folder);
                Debug.WriteLine($"[{folder}] : {path}");
            }
        }
    }
}
