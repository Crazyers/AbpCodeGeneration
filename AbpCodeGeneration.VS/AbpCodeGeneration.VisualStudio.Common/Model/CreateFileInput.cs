﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCodeGeneration.VisualStudio.Common.Model
{
    public class CreateFileInput
    {
        public string AbsoluteNamespace { get; set; }
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public string LocalName { get; set; }
        public string DirectoryName { get; set; }

        public bool IsFirst { get; set; } = true;

        public string KeyType { get; set; }
        public ICollection<DtoPropertyInfo> PropertyInfos { get; set; }
    }
}