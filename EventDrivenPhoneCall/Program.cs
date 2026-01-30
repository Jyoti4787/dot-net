using System;

public class PhoneCall
{
    // 1. Delegate
    public delegate void Notify();

    // 2. Event
    public event Notify PhoneCallEvent;

    // 3. Message Property
    public string Message { get; private set; }

    // 4. Event Handlers
    private void OnSubscribe()
    {
        Message = "Subscribed to Call";
    }

    private void OnUnSubscribe()
    {
        Message = "UnSubscribed to Call";
    }

    // 5. Event Trigger Method
    public void MakeAPhoneCall(bool notify)
    {
        if (notify)
        {
            PhoneCallEvent += OnSubscribe;
        }
        else
        {
            PhoneCallEvent += OnUnSubscribe;
        }

        // Safe event invocation
        PhoneCallEvent?.Invoke();

        // Clear event after invocation to avoid duplicate calls
        PhoneCallEvent = null;
    }
}

// 6. Driver Code
public class Test
{
    public static void Main(string[] args)
    {
        PhoneCall call = new PhoneCall();

        call.MakeAPhoneCall(true);
        Console.WriteLine($"{call.Message}");

        call.MakeAPhoneCall(false);
        Console.WriteLine($"{call.Message}");
    }
}
