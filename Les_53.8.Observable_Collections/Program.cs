using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

// ObservableCollection

namespace Les_53._8
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User{ Name = "Bill"},
                new User{ Name = "Tom" },
                new User{ Name = "Alice" }
            };

            users.CollectionChanged += Users_CollectionChanged;

            users.Add(new User { Name = "Bob" });
            users.RemoveAt(1);
            users[0] = new User { Name = "Anders" };

            foreach (User user in users) { Console.WriteLine(user.Name); }

            Console.Read();
        }

        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:     // if add
                    User newUser = e.NewItems[0] as User;
                    Console.WriteLine("Added new object: {0}", newUser.Name);
                    break;
                case NotifyCollectionChangedAction.Remove:  // if delete
                    User oldUser = e.OldItems[0] as User;
                    Console.WriteLine("Deleted the object: {0}", oldUser.Name);
                    break;
                case NotifyCollectionChangedAction.Replace: // if replace
                    User replacedUser = e.OldItems[0] as User;
                    User replacingUser = e.NewItems[0] as User;
                    Console.WriteLine("Object {0} was replaced by {1}", replacedUser.Name, replacingUser.Name);
                    break;
            }
        }
    }

    class User { public string Name { get; set; } }
}
