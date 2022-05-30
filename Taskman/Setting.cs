using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskman
{
    public static class Setting
    {
        public static string CURRENT_DIRECTORY = Environment.CurrentDirectory;
        public static string TASK_DIRECTORY = "Task";
        public static string TASK_FILE_NAME = "task.json";
        public static string MSG_DIRECTORY = "Message";
        public static string MSG_FILE_NAME = "msg.csv";
        public static string IMAGE_DIRECTORY = "Images";
    }
}
