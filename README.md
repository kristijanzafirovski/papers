# Papers

> This project was developed as a **FINKI course project** (Faculty of Computer Science and Engineering, Ss. Cyril and Methodius University in Skopje).

Papers is a Windows desktop application for keeping a simple catalogue of academic papers. For each paper it stores the title, authors and keywords, and it keeps a running count of how many papers each author has.

## Features

- **Add a paper** with a title, at least one author, and comma-separated keywords. Input is validated before the paper is saved.
- **Paper list** that formats each entry in citation style, using the first word of each author's name and the initial of the second word (`Name, I.`):
  - One author: `Name, I. - Title`
  - Two authors: `Name, I., Name, I. - Title`
  - Three or more authors: `Name, I., et al - Title`
- **Author summary** that lists every author with the number of papers they are linked to. The counts update automatically when a paper is added or deleted.
- **Delete a paper** to remove it from the list. Its authors' counts are decreased, and an author with no remaining papers is removed from the summary.

## Getting started

### Prerequisites

- Windows
- Visual Studio with the .NET desktop development workload
- .NET Framework 4.7.2 developer pack

### Run

1. Open `kolokvezba.sln` in Visual Studio.
2. Press **F5** to build and run.

## Project structure

| File | Purpose |
|---|---|
| `Form1.cs` | Main window: paper list, author summary, add and delete actions |
| `Addpaper.cs` | Dialog for entering a new paper, with input validation |
| `Paper.cs` | Paper model and citation-style formatting |
| `Program.cs` | Application entry point |

## Tech stack

C# · .NET Framework 4.7.2 · Windows Forms

## Author

**Kristijan Zafirovski**
