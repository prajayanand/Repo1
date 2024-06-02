namespace Generics
{
    public class Program
    {
        public static void Main()
        {
            // Example usage of MyStack<T>
            var stack = new MyStack<int>();
            stack.Push(10);
            stack.Push(30);
            Console.WriteLine(stack.Pop()); // Output: 20
            Console.WriteLine(stack.Count()); // Output: 1

            // Example usage of MyList<T>
            var list = new MyList<string>();
            list.Add("First");
            list.Add("Second");
            Console.WriteLine(list.Contains("First")); // Output: True
            Console.WriteLine(list.Find(1)); // Output: Second
            list.Remove(0);
            Console.WriteLine(list.Contains("First")); // Output: False

            // Example usage of GenericRepository<T>
            var repository = new GenericRepository<MyEntity>();
            var entity1 = new MyEntity { Id = 1, Name = "Entity1" };
            var entity2 = new MyEntity { Id = 2, Name = "Entity2" };
            repository.Add(entity1);
            repository.Add(entity2);
            repository.Save();
            Console.WriteLine(repository.GetById(1)?.Name); // Output: Entity1
            Console.WriteLine(repository.GetAll().Count()); // Output: 2
            repository.Remove(entity1);
            repository.Save();
            Console.WriteLine(repository.GetAll().Count()); // Output: 1
        }
    }

    public class MyEntity : Entity
    {
        public string Name { get; set; }
    }
}