﻿using System.IO;

namespace MightyStruct.Basic
{
    public class SafeStream
    {
        private Stream Stream { get; }

        public long pos => Stream.Position;
        public long size => Stream.Length;

        public SafeStream(Stream stream)
        {
            Stream = stream;
        }
    }
}