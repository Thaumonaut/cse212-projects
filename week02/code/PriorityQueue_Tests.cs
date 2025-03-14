using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: When items are added to the queue they are placed at that back.
    // Expected Result: items are placed in queue in the order they were called.
    // Defect(s) Found: None 😎
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 1);
        priorityQueue.Enqueue("item2", 2);
        Console.WriteLine(priorityQueue);
        var expected = "[item1 (Pri:1), item2 (Pri:2)]";
        Assert.AreEqual(priorityQueue.ToString(), expected);
    }

    [TestMethod]
    // Scenario: Add multiple items to queue with unique priority and dequeue the item with the highest priority.
    // Expected Result: The value of the item with the highest priority is returned when the dequeue function is called
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("item_1", 5);
        priorityQueue.Enqueue("item_2", 3);
        priorityQueue.Enqueue("item_3", 8);
        priorityQueue.Enqueue("item_4", 3);

        var highest = priorityQueue.Dequeue();
        var expected = "item_3";

        Assert.AreEqual(highest, expected);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Add multiple items to queue with a pair of the same priority and dequeue to get the highest priority.
    // Expected Result: The value of the first item with the highest priority is returned when the dequeue function is called
    // Defect(s) Found: Last item with highest priority was returned.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("item_1", 8);
        priorityQueue.Enqueue("item_2", 3);
        priorityQueue.Enqueue("item_3", 8);
        priorityQueue.Enqueue("item_4", 3);

        var highest = priorityQueue.Dequeue();
        var expected = "item_1";

        Assert.AreEqual(highest, expected);
    }

    [TestMethod]
    // Scenario: Attempts to dequeue when there are no items in the queue
    // Expected Result: Invalid Operation Exception is called.
    // Defect(s) Found: none
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}