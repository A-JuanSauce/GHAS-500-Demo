var tasks = new List<string>();
var isRunning = true;

Console.WriteLine("Welcome to Tiny Tasks!");

while (isRunning)
{
    Console.WriteLine();
    Console.WriteLine("1. Show tasks");
    Console.WriteLine("2. Add a task");
    Console.WriteLine("3. Remove a task");
    Console.WriteLine("4. Quit");
    Console.Write("Choose an option: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ShowTasks(tasks);
            break;
        case "2":
            AddTask(tasks);
            break;
        case "3":
            RemoveTask(tasks);
            break;
        case "4":
            isRunning = false;
            break;
        default:
            Console.WriteLine("Please enter a number from 1 to 4.");
            break;
    }
}

Console.WriteLine("Goodbye!");

static void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Your task list is empty.");
        return;
    }

    Console.WriteLine("Your tasks:");
    for (var index = 0; index < tasks.Count; index++)
    {
        Console.WriteLine($"{index + 1}. {tasks[index]}");
    }
}

static void AddTask(List<string> tasks)
{
    Console.Write("Enter a task: ");
    var task = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(task))
    {
        Console.WriteLine("A task cannot be empty.");
        return;
    }

    tasks.Add(task);
    Console.WriteLine($"Added: {task}");
}

static void RemoveTask(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("There are no tasks to remove.");
        return;
    }

    ShowTasks(tasks);
    Console.Write("Enter the task number to remove: ");
    var input = Console.ReadLine();

    if (!int.TryParse(input, out var taskNumber) || taskNumber < 1 || taskNumber > tasks.Count)
    {
        Console.WriteLine("That is not a valid task number.");
        return;
    }

    var removedTask = tasks[taskNumber - 1];
    tasks.RemoveAt(taskNumber - 1);
    Console.WriteLine($"Removed: {removedTask}");
}
