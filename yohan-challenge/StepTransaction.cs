using System;

namespace yohan_challenge
{
    public class StepTransaction
    {
        public StepTransaction(int partailSum, string operand, int value, Guid parentId, int parentStep)
        {
            ParentStep = parentStep;
            PartialSum = partailSum;
            Operand = operand;
            Value = value;
            ParentId = parentId;
            Id = Guid.NewGuid();
        }

        public readonly int ParentStep;
        public readonly Guid Id;
        public readonly Guid ParentId;
        public readonly int PartialSum;
        public readonly string Operand;
        public readonly int Value;
    }
}
