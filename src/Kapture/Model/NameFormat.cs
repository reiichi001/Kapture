﻿// ReSharper disable MemberCanBePrivate.Global

using System.Collections.Generic;
using System.Linq;

namespace KapturePlugin
{
    public class NameFormat
    {
        private static readonly List<NameFormat> NameFormats = new List<NameFormat>();
        public static readonly List<string> NameFormatNames = new List<string>();

        public static readonly NameFormat FullName = new NameFormat(0, "Full Name");
        public static readonly NameFormat FirstName = new NameFormat(1, "First Name");
        public static readonly NameFormat Initials = new NameFormat(2, "Initials");

        public NameFormat()
        {
        }

        private NameFormat(int code, string name)
        {
            Code = code;
            Name = name;
            NameFormats.Add(this);
            NameFormatNames.Add(name);
        }

        public int Code { get; }
        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}