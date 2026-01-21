using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Try to enqueue a single item
    // Expected Result: Count is 1
    // Test Results: All tests passed.
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 2);
        Assert.AreEqual(1, priorityQueue.Count);
    }

    [TestMethod]
    // Scenario: Try to enqueue and dequeue a single item
    // Expected Result: Count is 1, Dequeue returns the item, and Count is 0 after dequeue
    // Test Results: It wasn't returning the same item, passed after fixing the dequeue method.
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 2);
        Assert.AreEqual(1, priorityQueue.Count);
        Assert.AreEqual("Task1", priorityQueue.Dequeue());
        Assert.AreEqual(0, priorityQueue.Count);
    }

    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them
    // Expected Result: Items are dequeued in priority order (highest priority first)
    // Test Results: Passed since the items were iterated from back to front.
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 2);
        priorityQueue.Enqueue("Task2", 5);
        priorityQueue.Enqueue("Task3", 5);        
        Assert.AreEqual("Task2", priorityQueue.Dequeue());
    }
    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown with message "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
    
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}