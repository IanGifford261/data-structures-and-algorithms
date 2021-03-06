using System;
using Xunit;
using StacksanQueues.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForEmptyStack()
        {
            Stack emptyTest = new Stack();
            Assert.Null(emptyTest.Top);
        }

        [Fact]
        public void TestForEmptyQueue()
        {
            Queue emptyTest = new Queue();
            Assert.Null(emptyTest.Front);
        }

        [Fact]
        public void TestForPushOntoStack()
        {
            Stack stackTest = new Stack();
            Node newNode = new Node(1);
            stackTest.PushNode(newNode);
            Assert.Equal(1, stackTest.Top.Val);
        }
    }
}
