[![Build Status](https://travis-ci.org/dteske25/TravisCI.svg?branch=master)](https://travis-ci.org/dteske25/TravisCI)

# Travis CI Lab

## Run the Console App
Try out the console app, see if you can break it and where the weaknesses in the code are.

## Set up Travis CI to build the Console App
Go to [travis-ci.org](http://travis-ci.org), and sign-in with your GitHub credentials.
Accept the GitHub access permissions confirmation.
Go to your profile page and enable this repository.
Click the gear icon, and make sure the settings are as follows:

![travis-ci config](./img/travis-ci-config.png)

Add a `.travis.yml` file to the root folder for your project. This is your Travis config file.
> We're following the information from [this](https://docs.travis-ci.com/user/languages/csharp/) guide to set up our project.

Put the following in your Travis config:
```
language: csharp
solution: TravisCI.sln
branches:
  only:
  - master
install:
  - nuget restore TravisCI.sln
script:
  - msbuild /p:Configuration=Release TravisCI.sln
```

Commit and push these files to master
Open travis-ci.org and see if your build is running. 

## Implement the Power method
Once Travis CI is up and running, it should rebuild every time you push a change. 
Implement the `Power` method found in `Program.cs`.
Commit and push the change to a different branch.
Open a pull request.
Verify that Travis CI started building your pull request.
Once the build completes, merge your pull request with master.
Verify Travis CI started building master.

## Set up Travis CI to run Unit Tests
To run the tests after every change, we'll have to modify the Travis config slightly. 
Adjust the `script` section to be the following. 

```
script:
  - msbuild /p:Configuration=Release TravisCI.sln
  - mono ./packages/NUnit.ConsoleRunner.*/tools/nunit3-console.exe ./Tests/bin/Release/Tests.dll
```
This is the NUnit test runner, and will allow Travis CI to run the tests on the server from the command line.
Commit and push this change to master.
Open travis-ci.org and make sure the build completes.

If you've done this correctly, the following should appear at the bottom of your build log:
![nunit-tests](./img/nunit-tests.png)

## Implement the other unit tests
Follow the same format as the addition unit tests, and implement tests for the rest of the operations defined in `Program.cs`.
Run the tests locally, and intentionally make one fail.
Commit and push the changes to a different branch.
Open a new pull request.
See if Travis CI will detect the failed test.
Push a change on the same branch to fix the test.
See if the build completes successfully.
Merge the pull request if it does, fix it otherwise.
