using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class FileServiceMoq
    {
        public int RemoveFilesIdDirectory(IFileService fileService)
        {
            return fileService.RemoveTemporaryFiles("DSDS");
        }

        public int RemoveFilesIdDirectoryExp(IFileService fileService)
        {
            throw new ArgumentException();
        }

    }
}
