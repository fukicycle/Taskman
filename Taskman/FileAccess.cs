using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Taskman.Const;
using static Taskman.Setting;

namespace Taskman
{
    public class FileAccess
    {
        public int CreateFileOnCurrentDirectory(string fileName, string subDir)
        {
            string dir = string.IsNullOrEmpty(subDir) ? CURRENT_DIRECTORY : Path.Combine(CURRENT_DIRECTORY, subDir);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            if (File.Exists(Path.Combine(dir, fileName))) return RESULT_FAIL;
            File.Create(Path.Combine(CURRENT_DIRECTORY, subDir, fileName));
            return RESULT_SUCCESS;
        }
    }
}
