# Workshop Eat Sleep Code Repeat
* Sign in to GitHub (create an account if neccesary)
* Fork this repository to your own account.
* Clone the project on your development machine (git clone https://github.com/YourAccountNameHere/Workshop-EatSleepCodeRepeat.git)
* Open the solution in Visual Studio (The solution should compile without errors)

## Lab 1: Configuring a CI pipeline
* Go to the website of [AppVeyor](https://appveyor.com) and log in with your GitHub account.
* Add the Workshop-EatSleepCodeRepeat project.
* The project should start building without any further configuration --> The build will fail due to a failing unit test.

* Go to Visual Studio and implement the missing functionality in the Calculator class and make the unit test pass.
* Commit your local changes (git add *, git commit -m "your comment here").
* Push the changes to your Github repository (git push).

* The AppVeyor CI should queue a build for the new commit that now succeeds.
* Optional: Add the Appveyor Badge to this README.MD file.

## Lab 2: Use BetterCodeHub to find refactoring candidates
* Go to [BetterCodeHub.com](https://bettercodehub.com) and log in with your GitHub account.
* Run and analyze the Workshop-EatSleepCodeRepeat repository with BetterCodeHub.
* Refactor the code in Visual Studio Lab2 to comply with the first three guidelines.
* Commit and push your changes to GitHub after refactoring
* Run the analysis in BetterCodeHub.com --> The project should now comply to 9 of the 10 guidelines.
* Send a pull request with your version of the refactoring

## Lab 3: Use BetterCodeHub to find refactoring candidates
Similar to Lab 2:
* Refactor the code in Lab3 to comply with the last guideline.
* Don't forget to send a pull request.

## Lab 4: Analyzing existing open-source projects
Fork one of the available open-source projects to your own GitHub account:
* [Netflix Fido](https://github.com/BetterCodeHub/Fido)
* [codemaid](https://github.com/BetterCodeHub/codemaid)
* [ShareX](https://github.com/BetterCodeHub/ShareX)
* [GitHub Scientist.NET](https://github.com/BetterCodeHub/Scientist.net)
* Optional: Fork your own favourite open-source project.

Go to [BetterCodeHub.com](https://bettercodehub.com) and analyze an open-source project.
Compare the quality of different open source projects with respect to the guidelines.
Look for potential refactoring candidates and investigate how much refactoring is neccesary to make the project comply to a guideline.
Discuss the results with your peers.

## Lab 5: Refactoring an open-source project

Use the input from Lab 4 to refactor the code of an open-source system:
* Clone your forked repository to your local machine.
* Try to open the project in Visual Studio and compile the solution (this might take some effort to get things working)
* Make a small improvement to the code-base.
* Commit and push your change.
* Run the analysis on BetterCodeHub to learn how your change affected the adherance to the guidelines.
* Create a pull request (WARNING: Only create pull requests to the BetterCodeHub fork and not to real projects, otherwise we will not be able to track your change).



