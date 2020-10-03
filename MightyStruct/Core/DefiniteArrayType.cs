﻿using MightyStruct.Abstractions;

namespace MightyStruct.Core
{
    public class DefiniteArrayType : IType
    {
        public IPotential<IType> BaseType { get; }
        public IPotential<int> Length { get; }

        public DefiniteArrayType(IPotential<IType> baseType, IPotential<int> length)
        {
            BaseType = baseType;
            Length = length;
        }

        public IStruct CreateInstance(Context context)
        {
            return new ArrayStruct(this, context);
        }
    }
}
