/*
  Copyright (c) 2011-2012, HL7, Inc
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Hl7.Fhir.Model
{
    [System.Diagnostics.DebuggerDisplay(@"\{{Value}}")]
    public partial class Time : IStringValue
    {
        public static bool IsValidValue(string value)
        {
            return Regex.IsMatch(value as string, "^" + Time.PATTERN + "$", RegexOptions.Singleline);

            // TODO: Additional checks not implementable by the regex
        }

        public static bool operator >(Time a, Time b)
        {
            if (object.ReferenceEquals(a, null))
                throw new ArgumentNullException("a");
            if (object.ReferenceEquals(b, null))
                throw new ArgumentNullException("b");
            return String.Compare(a.Value, b.Value) > 0;
        }

        public static bool operator >=(Time a, Time b)
        {
            if (object.ReferenceEquals(a, null))
                throw new ArgumentNullException("a");
            if (object.ReferenceEquals(b, null))
                throw new ArgumentNullException("b");
            return String.Compare(a.Value, b.Value) >= 0;
        }

        public static bool operator <(Time a, Time b)
        {
            if (object.ReferenceEquals(a, null))
                throw new ArgumentNullException("a");
            if (object.ReferenceEquals(b, null))
                throw new ArgumentNullException("b");
            return String.Compare(a.Value, b.Value) < 0;
        }

        public static bool operator <=(Time a, Time b)
        {
            if (object.ReferenceEquals(a, null))
                throw new ArgumentNullException("a");
            if (object.ReferenceEquals(b, null))
                throw new ArgumentNullException("b");
            return String.Compare(a.Value, b.Value) <= 0;
        }

        public static bool operator ==(Time a, Time b)
        {
            // If both are null then the are the same
            if (object.ReferenceEquals(a, null) && object.ReferenceEquals(b, null))
                return true;
            if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null))
                return false;

            return String.Compare(a.Value, b.Value) == 0;
        }

        public static bool operator !=(Time a, Time b)
        {
            return !(a == b);
        }
    }
}