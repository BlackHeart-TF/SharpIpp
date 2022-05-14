﻿using System;

namespace SharpIpp.Protocol.Models
{
    public struct StringWithLanguage : IEquatable<StringWithLanguage>
    {
        public string Language { get; set; }

        public string Value { get; set; }

        public StringWithLanguage(string language, string value)
        {
            Language = language;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} ({Language})";
        }

        public bool Equals(StringWithLanguage other)
        {
            return Language == other.Language && Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            return obj is StringWithLanguage other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Language != null ? Language.GetHashCode() : 0) * 397) ^
                       (Value != null ? Value.GetHashCode() : 0);
            }
        }
    }
}
