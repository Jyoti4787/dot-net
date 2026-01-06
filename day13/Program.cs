// using System;

// delegate void PaymentDelegate(decimal payment);

// class PaymentService
// {
//     public void ProcessPayment(decimal payment)
//     {
//         Console.WriteLine("Payment of " + payment + " processed successfully.");
//     }
// }

// static class PaymentExtensions
// {
//     public static bool IsValidPayment(this decimal amount)
//     {
//         return amount > 0 && amount <= 1_000_000;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         PaymentService service = new PaymentService();
//         PaymentDelegate payment = service.ProcessPayment;

//         decimal amount = 5000;

//         if (amount.IsValidPayment())
//         {
//             payment(amount);   // delegate call
//         }
//         else
//         {
//             Console.WriteLine("Invalid payment amount.");
//         }
//     }
// }

// using System;

// delegate void OrderDelegate(string orderID);

// class NotificationService
// {
//     public void SendEmail(string id)
//     {
//         Console.WriteLine("Email sent for order " + id);
//     }

//     public void SendSMS(string id)
//     {
//         Console.WriteLine("SMS sent for order " + id);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         NotificationService service = new NotificationService();

//         OrderDelegate notify = null;

//         notify += service.SendEmail;
//         notify += service.SendSMS;

//         notify?.Invoke("ORD1001");   // Safe invocation
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Action<string> logActivity = message => //Action<T>:void Method(string value)
//             Console.WriteLine("Log Entry: "+message);
        
//         logActivity("User logged in at 10:30AM");
//     }
// }

//Func Delegate

// using System;
// class Program
// {
//     static void Main()
//     {
//         Func<decimal, decimal, decimal> calculateDiscount=(price, discount)=>price-(price*discount/100);

//         Console.WriteLine(calculateDiscount(1000, 10));
//     }
// }

//Predicate Deligate

// using System;
// class Program
// {
//     static void Main()
//     {
//           Predicate<int> isEligible = age => age >= 18;

//           Console.WriteLine(isEligible(20));
//     }
// }

//anonymous delegate

//using System;

// delegate void ErrorDelegate(string message);

// class Program
// {
//     static void Main()
//     {
//         ErrorDelegate errorHandler = delegate (string msg)
//         {
//             Console.WriteLine("Error: " + msg);
//         };

//         errorHandler("File not found");
//     }
// }

// using System;

// class Button
// {
//     // Delegate
//     public delegate void ClickHandler();

//     // One event
//     public event ClickHandler Clicked;

//     // Raise the event
//     public void Click()
//     {
//         Console.WriteLine("Button clicked");
//         Clicked?.Invoke();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Button btn = new Button();

//         // Attaching multiple methods to ONE event
//         btn.Clicked += OnClickHandler1;
//         btn.Clicked += OnClickHandler2;
//         btn.Clicked += OnClickHandler3;

//         btn.Click();
//     }

//     static void OnClickHandler1()
//     {
//         Console.WriteLine("Handler 1: Sound played");
//     }

//     static void OnClickHandler2()
//     {
//         Console.WriteLine("Handler 2: UI updated");
//     }

//     static void OnClickHandler3()
//     {
//         Console.WriteLine("Handler 3: Log saved");
//     }
// }

// using System;
// using System.Collections.Generic;

// namespace SmartHomeSecurity
// {
//     // 1. DEFINITION: The "Contract" for any security response.
//     // Any method responding to an alert must be void and take a string location.

//     public delegate void SecurityAction(string zone); // definition

//     public class MotionSensor
//     {
//         // The delegate instance (The Panic Button)
//         public SecurityAction OnEmergency; // instance creation

//         public void DetectIntruder(string zoneName)
//         {
//             Console.WriteLine($"[SENSOR] Motion detected in {zoneName}!");
            
//             // 3. INVOCATION: Triggering the Panic Button
//             if (OnEmergency != null)
//             {
//                 OnEmergency(zoneName); // string value = Main Lobby or panicSequence?
//             }
//         }
//     }

//     // Diverse classes that don't know about each other
//     public class AlarmSystem
//     {
//         public void SoundSiren(string zone) => Console.WriteLine($"[ALARM] WOO-OOO! High-decibel siren active in {zone}.");
//     }

//     public class PoliceNotifier
//     {
//         public void CallDispatch(string zone) => Console.WriteLine($"[POLICE] Notifying local precinct of intrusion in {zone}.");
//     }

//     class Program
//     {
//         static void Main()
//         {
//             // Objects Initialization
//             MotionSensor livingRoomSensor = new MotionSensor();
//             AlarmSystem siren = new AlarmSystem();
//             PoliceNotifier police = new PoliceNotifier();

//             // 2. INSTANTIATION & MULTICASTING
//             // We "Subscribe" different methods to the sensor's delegate
//             SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
//             panicSequence += police.CallDispatch;

//             // Linking the sequence to the sensor
//             livingRoomSensor.OnEmergency = panicSequence;
// 	// class_object.delegate_instance = delegate_instance_multicast

//             // Simulation
//             livingRoomSensor.DetectIntruder("Main Lobby");
//         }
//     }
// }

using System;
using System.Threading;

namespace CallbackDemo
{
    // STEP 1: Define the Delegate
    public delegate void DownloadFinishedHandler(string fileName);
    //When download finishes, I’ll call a method that takes a file name.

    class FileDownloader
    {
        // STEP 2: Method that accepts the callback
        public void DownloadFile(string name, DownloadFinishedHandler callback)
        //string name → File to download. DownloadFinishedHandler callback → Method to call after download. This is callback injection
        {
            Console.WriteLine($"Starting download: {name}...");
            
            // Simulating work
            Thread.Sleep(2000); //is used to simulate a long-running task. 
            //Blocks the current thread (synchronous simulation)
            
            Console.WriteLine($"{name} download complete.");

            // STEP 3: Execute the Callback
            if (callback != null)//Safety check
            {
                callback(name); //Invokes the callback method
            }
            //This is callback invocation
        }
    }

    class Program //Provides the callback logic. //Completely independent of FileDownloader
    {
        // STEP 4: The actual Callback Method
        static void DisplayNotification(string file) //It is called indirectly via delegate
        {
            Console.WriteLine($"NOTIFICATION: You can now open {file}.");
            //Executes when callback is triggered
        }

        static void Main()
        {
            FileDownloader downloader = new FileDownloader();
            //Creates the worker object

            // Pass the method 'DisplayNotification' as a callback

            downloader.DownloadFile("Presentation.pdf", DisplayNotification);
            //DisplayNotification is passed as a method reference
            //DownloadFile runs
            //After completion, callback is executed
        }
    }
}

