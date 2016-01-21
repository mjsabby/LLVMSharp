﻿namespace LLVMSharp
{
    public sealed class TargetLibraryInfo : IWrapper<LLVMTargetLibraryInfoRef>
    {
        LLVMTargetLibraryInfoRef IWrapper<LLVMTargetLibraryInfoRef>.ToHandleType()
        {
            return this._instance;
        }

        void IWrapper<LLVMTargetLibraryInfoRef>.MakeHandleOwner()
        {
        }

        private readonly LLVMTargetLibraryInfoRef _instance;

        internal TargetLibraryInfo(LLVMTargetLibraryInfoRef instance)
        {
            this._instance = instance;
        }

        public void AddTargetLibraryInfo(PassManager pm)
        {
            LLVM.AddTargetLibraryInfo(this.Unwrap(), pm.Unwrap());
        }
    }
}