README.md
Download the code, build the project in visual studio, and run the application in the build folder! 
# Word Counter

`Word Counter` is a small Windows Forms desktop application that allows the user to paste some text to determine the character and word counts.

## Features

- live word count
- live character count
- character count excluding whitespace
- reset button to clear the input and counters
- lightweight single-window interface

## Tech Stack

- C#
- Windows Forms
- .NET for Windows

## Build

Open `WordCounter.slnx` in Visual Studio, or build from the command line on Windows with the .NET SDK installed:

```bash
dotnet build WordCounter.csproj
```

## Run

```bash
dotnet run --project WordCounter.csproj
```

You can also run it directly through Visual Studio.

## Repository Layout

- `Program.cs`: application startup
- `Form1.cs`: live text counting logic
- `Form1.Designer.cs`: Windows Forms UI layout
- `WordCounter.csproj`: project configuration

## License

This project is released under the MIT License.
