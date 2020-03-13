using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace UnitTestProject1
{
    class FileService
    {
        private readonly IFileService _fileService;

        public FileService(IFileService fileService)
        {
            _fileService = fileService;
        }
        public FileService()
        {
            
        }

        public int MergeTemporaryFiles(string dir)
        {
            int count = 0;
            if (Directory.Exists(dir))
            {
                string _type = "*.tmp";
                if(Directory.GetFiles(dir , _type).Length <= 0)
                {
                    return 0;
                }
                var resule = Directory.EnumerateFiles(dir, _type);
                try
                {
                    StreamWriter file = new StreamWriter("D:/Test/backup.txt");
                    foreach (string s in resule)
                    {
                        count++;
                        file.Write(s);
                        File.Delete(s);
                    }
                    file.Close();
                }
                catch(Exception ex)
                {
                }
            }
            else throw new NullReferenceException("Данная дериктория не существуте на диске");
            return count;
            
        }

        public int RemoveTemporaryFiles(string dir)
        {

            return _fileService.RemoveTemporaryFiles(dir);
            //if (Directory.Exists(dir))
            //{
            //    string readPath;
            //    if (dir.EndsWith("\\"))
            //    {
            //        readPath = dir + "ToRemove.txt";
            //    }
            //    else
            //    {
            //        readPath = dir + "\\ToRemove.txt";
            //    }
            //    if (File.Exists(readPath))
            //    {
            //        StreamReader reader = new StreamReader(readPath, Encoding.Default);
            //        string fileName = "";
            //        int delBytes = 0;
            //        while (fileName != null)
            //        {
            //            fileName = reader.ReadLine();
            //            if (fileName == null)
            //                break;
            //            string deletePath;
            //            if (dir.EndsWith("\\"))
            //            {
            //                deletePath = dir + fileName;
            //            }
            //            else
            //            {
            //                deletePath = dir + "\\" + fileName;
            //            }
            //            if (File.Exists(deletePath))
            //            {
            //                FileInfo fi = new FileInfo(deletePath);
            //                delBytes += Convert.ToInt32(fi.Length);
            //                File.Delete(deletePath);
            //            }
            //            else
            //            {
            //                string errorLogPath;
            //                if (dir.EndsWith("\\"))
            //                {
            //                    errorLogPath = dir + "error.log";
            //                }
            //                else
            //                {
            //                    errorLogPath = dir + "\\" + "error.log";
            //                }
            //                StreamWriter writer = new StreamWriter(errorLogPath, true, Encoding.Default);
            //                writer.WriteLine($"Файл '{fileName}' не был найден!");
            //                writer.Close();
            //            }
            //        }
            //        reader.Close();
            //        return delBytes;
            //    }
            //    else
            //    {
            //        throw new Exception($"В заданной директории не найден файл 'ToRemove.txt'");
            //    }
            //}
            //else
            //{
            //    throw new Exception($"Директория '{dir}' не найдена!");
            //}
        }

        public void CreateTempFileForDelete(string dir)
        {
            if (dir.EndsWith("\\"))
            {
                dir += "temp.txt";
            }
            else
            {
                dir = dir + "\\" + "temp.txt";
            }
            StreamWriter writer = new StreamWriter(dir, false, Encoding.Default);
            writer.Write("123");
            writer.Close();
        }
    }
}
