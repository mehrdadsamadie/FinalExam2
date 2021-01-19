using System;

namespace final_exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var em = new Emrgancy();
            var boss = new Person("john", "6478623265");

            em.eventEmrgancy += boss.EmrgancyHappen;
            em.Emrgancyhappen("fire");

    
        }
        public class Person 
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public Person(string name, string phone) 
            {
                Name = name;
                Phone = phone;
            }
            public void EmrgancyHappen(object sender, EventPhone e)
            {
                Console.WriteLine("calling "+ e.Messgae);
            }
        }
        public class Emrgancy 
        {
            public event EventHandler<EventPhone> eventEmrgancy;
            public void Emrgancyhappen(string message) 
            {
                EmrgancyCall(message);
            }
            public void EmrgancyCall(string message) 
            {
                if (eventEmrgancy != null) 
                {
                    eventEmrgancy.Invoke(this, new EventPhone(message));


                }
            }
        }

        public class EventPhone : EventArgs 
        {
            public string Messgae { get; set; }
            public EventPhone(string message) 
            {
                Messgae = message;
            }
        }
        public class MySample 
        {
            public int MyProperty { get; set; }
        }
        public IEquatable<T> MyList: where T 
    }
}
