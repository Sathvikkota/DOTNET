using System;

public delegate void EventHandler(string message);

public class Publisher
{
    public event EventHandler OnEventOccurred;

    public void PublishEvent(string message)
    {
        OnEventOccurred?.Invoke(message);
    }
}

public class Subscriber
{
    public void HandleEvent(string message)
    {
        Console.WriteLine("Event occurred: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // Subscribe to the event
        publisher.OnEventOccurred += subscriber.HandleEvent;

        // Publish an event
        publisher.PublishEvent("Hello, world!");

        // Unsubscribe from the event
        publisher.OnEventOccurred -= subscriber.HandleEvent;
    }
}
































/*using System;

public delegate void ArrayHandler<T>(object sender, ArrayEventArgs<T> e);

public class ArrayEventArgs<T> : EventArgs
{
    public int Id { get; set; }
    public T Value { get; set; }
    public string Message { get; set; }

    public ArrayEventArgs(int id, T value, string message)
    {
        Id = id;
        Value = value;
        Message = message;
    }
}

public class CustomArray<T>
{
    public event ArrayHandler<T> OnChangeElement;
    public event ArrayHandler<T> OnChangeEqualElement;

    private T[] array;
    private int startIndex;

    public CustomArray(int length, int startIndex)
    {
        if (length <= 0)
            throw new ArgumentException("Length must be greater than zero.", nameof(length));

        this.startIndex = startIndex;
        array = new T[length];
    }

    public int Length => array.Length;
    public int FirstIndex => startIndex;
    public int LastIndex => startIndex + array.Length - 1;

    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return array[index - startIndex];
        }
        set
        {
            CheckIndex(index);
            T oldValue = array[index - startIndex];
            array[index - startIndex] = value;

            if (!oldValue.Equals(value) && OnChangeElement != null)
                OnChangeElement(this, new ArrayEventArgs<T>(index, value, "Element value changed."));

            if (index.Equals(value) && OnChangeEqualElement != null)
                OnChangeEqualElement(this, new ArrayEventArgs<T>(index, value, "Element value set equal to index."));
        }
    }

    private void CheckIndex(int index)
    {
        if (index < startIndex || index > LastIndex)
            throw new ArgumentOutOfRangeException(nameof(index), $"Index must be between {startIndex} and {LastIndex}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomArray<int> intArray = new CustomArray<int>(5, 0);
        intArray.OnChangeElement += (sender, e) => HandleChange(sender, e, "Element value changed.");
        intArray.OnChangeEqualElement += (sender, e) => HandleChange(sender, e, "Element value set equal to index.");

        intArray[0] = 10; // Should raise OnChangeElement event
        intArray[1] = 1; // Should raise OnChangeEqualElement event
        intArray[1] = 1; // Should not raise any events
        intArray[2] = 20; // Should raise OnChangeElement event
    }

    static void HandleChange(object sender, ArrayEventArgs<int> e, string messageType)
    {
        Console.WriteLine($"Element at index {e.Id} changed to {e.Value}. Message: {messageType}");
    }
}
*/