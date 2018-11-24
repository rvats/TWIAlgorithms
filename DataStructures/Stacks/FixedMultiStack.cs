using System;

namespace DataStructures.Stacks
{
    class FixedMultiStack
    {
        private int NumberOfStacks = 3;
        private int StackCapacity;
        private int[] Values;
        private int[] Sizes;

        public FixedMultiStack(int stackSize)
        {
            StackCapacity = stackSize;
            Values = new int[stackSize * NumberOfStacks];
            Sizes = new int[NumberOfStacks];
        }

        public void Push(int stackNum, int value)
        {
            if (IsFull(stackNum))
            {
                throw new StackOverflowException();
            }
            Sizes[stackNum]++;
            Values[IndexOfTop(stackNum)] = value;
        }

        public int Pop(int stackNum)
        {
            if (IsEmpty(stackNum))
            {
                throw new StackOverflowException();
            }
            int topIndex = IndexOfTop(stackNum);
            int value = Values[IndexOfTop(stackNum)];
            Values[topIndex] = 0;
            Sizes[stackNum]--;
            return value;
        }

        public int Peek(int stackNum)
        {
            if (IsEmpty(stackNum))
            {
                throw new StackOverflowException();
            }
            return Values[IndexOfTop(stackNum)];
        }

        public bool IsFull(int stackNum)
        {
            return Sizes[stackNum]==StackCapacity;
        }

        public bool IsEmpty(int stackNum)
        {
            return Sizes[stackNum] == 0;
        }

        private int IndexOfTop(int stackNum)
        {
            int offSet = stackNum*StackCapacity;
            int size = Sizes[stackNum];
            return offSet + size - 1;
        }
    }
}
