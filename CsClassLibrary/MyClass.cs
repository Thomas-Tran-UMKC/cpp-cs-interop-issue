using System;
using Windows.Foundation;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CsClassLibrary
{
    public sealed class MyClass
    {
        public static string HelloWorldFromCS()
        {
            return "Hello World from your C# component!";
        }

        public static IAsyncAction WinrtCompatibleType()
        {
            return Task.Run(async () => await Task.Delay(100)).AsAsyncAction();
        }
        // 1>CSC : warning CS8785: Generator 'SourceGenerator' failed to generate source. It will not contribute to the output and compilation errors may occur as a result. Exception was of type 'Win32Exception' with message 'Incorrect function'
        // 1>Failed to resolve WinRT.Runtime.dll.

        public static IDictionary<int, string> GetMapOfNames()
        {
            Dictionary<int, string> retval = new Dictionary<int, string>();
            retval.Add(1, "one");
            retval.Add(2, "two");
            retval.Add(3, "three");
            retval.Add(42, "forty-two");
            retval.Add(100, "one hundred");
            return retval;
        }
    }
}
