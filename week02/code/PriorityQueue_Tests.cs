using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_OrderByPriority()
    {
        var q = new PriorityQueue();
        q.Enqueue("A", 2);
        q.Enqueue("B", 5);
        q.Enqueue("C", 5);
        q.Enqueue("D", 3);

        Assert.AreEqual("B", q.Dequeue()); // Highest priority
        Assert.AreEqual("C", q.Dequeue()); // Same priority, added later
        Assert.AreEqual("D", q.Dequeue()); // Next highest
        Assert.AreEqual("A", q.Dequeue()); // Lowest
    }

    [TestMethod]
    public void TestPriorityQueue_EmptyQueueThrows()
    {
        var q = new PriorityQueue();

        try
        {
            q.Dequeue();
            Assert.Fail("Expected exception for empty queue.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}
