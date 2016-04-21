﻿using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;

namespace NTTool.Models
{
    public class MachineEntity 
    {
        public string DomainName { get; set; }

        public string MachineName { get; set; }

        public string IPAddress { get; set; }

        public string MachineType { get; set; }

        public string OpratingSystem { get; set; }

        public string SystemDirectory { get; set; }

        public string OpratingSystemVersion { get; set; }

        public string Manufacturer { get; set; }
        

        public DirectoryEntry MachineAdInfo { get; set; }

    }
}