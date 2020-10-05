using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WhiteboardCSharp
{
    public class Challenge106
    {
        public static string GetFilename(string path)
        {
            return Path.GetFileName(path);
        }
    }
}
