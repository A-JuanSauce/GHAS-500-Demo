# Tiny Tasks: your first .NET app

Tiny Tasks is a small command-line to-do list written in C#. Add, view, and
remove tasks while the app is running. The list is kept in memory, so it starts
empty each time you launch the app.

## Run it

Install the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0), then
run these commands from this folder:

```bash
dotnet run
```

Choose an option from the menu and follow the prompts. Enter `4` to quit.

## What to look at

- `TinyTasks.csproj` sets the target framework and enables nullable checks.
- `Program.cs` starts with top-level statements, so there is no extra application
  class to get in the way while learning.
- The `List<string>` stores tasks, and the `while` loop keeps showing the menu.
- The `switch` handles each menu choice.
- `ShowTasks`, `AddTask`, and `RemoveTask` are methods that keep each action
  separate.
- `Console.ReadLine` gets input, and `int.TryParse` checks that a task number is
  valid before it is used.

## Try next

Change the menu text, add a task count, or save tasks to a file so they are still
there the next time you run the app.
