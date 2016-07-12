﻿/* Dexer Copyright (c) 2010-2013 Sebastien LEBRETON

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. */

using System.Text;

namespace Dexer.Core
{
	public class MethodReference : IMemberReference
	{
		public CompositeType Owner { get; set; }
		public string Name { get; set; }
		public Prototype Prototype { get; set; }

		public MethodReference()
		{
		}

		public MethodReference(CompositeType owner, string name, Prototype prototype) : this()
		{
			Owner = owner;
			Name = name;
			Prototype = prototype;
		}

		public override string ToString()
		{
			var builder = new StringBuilder();
			builder.Append(Owner);
			builder.Append("::");
			builder.Append(Name);
			builder.Append(Prototype);
			return builder.ToString();
		}

		public bool Equals(MethodReference other)
		{
			return Owner.Equals(other.Owner)
				&& Name.Equals(other.Name)
				&& Prototype.Equals(other.Prototype);
		}

		public virtual bool Equals(IMemberReference other)
		{
			return (other is MethodReference)
				&& Equals(other as MethodReference);
		}
	}
}
