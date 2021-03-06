// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System;

namespace LLVMSharp.Interop
{
    public unsafe partial struct LLVMRemarkArgRef : IEquatable<LLVMRemarkArgRef>
    {
        public IntPtr Handle;

        public LLVMRemarkArgRef(IntPtr handle)
        {
            Handle = handle;
        }

        public static implicit operator LLVMRemarkArgRef(LLVMRemarkOpaqueArg* value) => new LLVMRemarkArgRef((IntPtr)value);

        public static implicit operator LLVMRemarkOpaqueArg*(LLVMRemarkArgRef value) => (LLVMRemarkOpaqueArg*)value.Handle;

        public static bool operator ==(LLVMRemarkArgRef left, LLVMRemarkArgRef right) => left.Handle == right.Handle;

        public static bool operator !=(LLVMRemarkArgRef left, LLVMRemarkArgRef right) => !(left == right);

        public override bool Equals(object obj) => (obj is LLVMRemarkArgRef other) && Equals(other);

        public bool Equals(LLVMRemarkArgRef other) => this == other;

        public override int GetHashCode() => Handle.GetHashCode();

        public override string ToString() => $"{nameof(LLVMRemarkArgRef)}: {Handle:X}";
    }
}
