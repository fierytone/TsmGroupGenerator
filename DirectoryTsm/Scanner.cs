using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryTsm
{
    public class Scanner
    {
        private readonly string _rootPath;
        private readonly StringBuilder _output;
        private readonly string _outputPath;

        public string GeneratedText => _output.ToString();

        public Scanner(string rootpath)
        {
            _rootPath = rootpath;
            _output = new StringBuilder();
            _outputPath = _rootPath + "\\output.txt";
        }

        public void ScanFiles()
        {
            if (!Directory.Exists(_rootPath))
            {
                throw new DirectoryNotFoundException("Directory not found.");
            }

            var dirs = new Stack<string>(20);

            dirs.Push(_rootPath);

            while (dirs.Count > 0)
            {
                var current = dirs.Pop();
                
                if (current != _rootPath)
                {
                    _output.Append(_output.Length > 0 ? "," + AddGroup(current) : AddGroup(current));
                }

                var files = Directory.GetFiles(current, "items.txt");
                if (files.Length > 0)
                {
                    AddFiles(files);
                }

                var subDirs = Directory.GetDirectories(current);
                for (var i = subDirs.Length - 1; i >= 0; i--)
                {
                    dirs.Push(subDirs[i]);
                }
            }
        }

        public bool WriteFile()
        {
            try
            {
                File.WriteAllText(_outputPath, _output.ToString());
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public string GetOutputPath()
        {
            return _outputPath;
        }

        private void AddFiles(string[] files)
        {
            foreach (var file in files)
            {
                if (_output.Length > 0)
                {
                    _output.Append(",");
                }
                foreach (var line in File.ReadAllLines(file))
                {
                    _output.Append(line);
                }
            }
        }

        private string AddGroup(string path)
        {
            path = path.Replace(_rootPath + "\\", "");
            var dirs = path.Split('\\');
            return string.Format("group:{0}", dirs.Length > 0 ? string.Join("`", dirs) : dirs.FirstOrDefault());
        }
    }
}
