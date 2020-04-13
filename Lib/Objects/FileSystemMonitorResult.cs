﻿using System;
namespace AttackSurfaceAnalyzer.Objects
{
    public class FileSystemMonitorResult
    {
        public FileSystemEventArgs evt { get; set; }
        public NotifyFilters filter { get; set; }

        public FileSystemMonitorResult(FileSystemEventArgs evtIn)
        {
            evt = evtIn;
        }
    }
}
