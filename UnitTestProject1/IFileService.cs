﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public interface IFileService
    {
        int MergeTemporaryFiles(string dir);
        int RemoveTemporaryFiles(string dir);
    }
}
