# Baseline for Web Testing in Selenium (CSharp)

#### High-Level Architecture

NUnit (runner and tests) -> Tasks (interactions decoupled from page objects) -> PageObjects (elements only)

#### What is this?

It's a baseline for Web Testing in Selenium (C#), intended to be extended. The **Tests** and assertions are NUnit. The tests have interactions which have been decoupled from traditional page objects, known here as **Tasks**. **Page** objects are fed into the tasks. This encourages a task-centric way of creating tests, rather than getting hung up on what interactions and waits to use with which page. This is loosely based on the Screenplay pattern - see: https://www.infoq.com/articles/Beyond-Page-Objects-Test-Automation-Serenity-Screenplay/

#### How to set this up and run it?

1. Git clone as usual
2. Assuming you're using dotnet cli, build the project: `dotnet build`
4. Run the tests: `dotnet test`

#### ToDo:

1. Make this runnable from repository dashboard