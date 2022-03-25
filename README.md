# Github Actions Lab

Because Travis CI is no longer free, we are going to look at how Github Actions can provide continuous integration on a sample project.

Continuous integration can be used to perfom checks on written code, making sure that unit tests always pass or that formatting is followed, and that when changes are made, they don't break other areas of the code.

Fork and clone the repo to your computer to get started.

## Run the Console App
Just as a sanity check, make sure that everything is working before you begin. Try out the console app, see if you can break it and where the weaknesses in the code are. Try manually running the tests.

## Set up Github Actions to build the Console App

.NET is not native to the Gihub Action ecosystem, so we need to containerize it.

To do this, modify the Dockerfile in the root directory of the project.

```

```

- Commit and push these changes to master
- Open travis-ci.org and see if your build is running. 
- A running build will look like the following in the left drawer:

![travis running](./img/travis-running.png)

You can follow along with the build log by clicking the gray circle in the upper-right of the build log:

![follow button](./img/follow-button.png)

You also might have noticed that the "build passing" badge at the top of the readme is also right here (though it might not say passing right now). To get your own link, just click that badge, and from the dropdown, select the link as markdown. It will look something similar to `[![Build Status](https://travis-ci.org/username/TravisCI.svg?branch=master)](https://travis-ci.org/username/TravisCI)`. It's really nice to have that in your readme file, so that you always know the build status of your master branch.

## Implement the Power method
Once Github Actions is up and running, it should rebuild every time you push a change, or open a pull request. Let's test this out.

- Implement the `Power` method found in `Program.cs`.
- Commit and push the change to a different branch.
- Open a pull request.

## Set up Github Actions to run Unit Tests
To run the tests after every change, we'll have to modify the Travis config slightly. 
Adjust the `script` section to be the following. 

```
script:
  - msbuild /p:Configuration=Release TravisCI.sln
  - mono ./packages/NUnit.ConsoleRunner.*/tools/nunit3-console.exe ./Tests/bin/Release/Tests.dll
```

This is the NUnit test runner, and will allow Travis CI to run the tests on the server from the command line.
Commit and push this change to master.
Open Travis and make sure the build completes.

If you've done this correctly, the following should appear at the bottom of your build log:

![nunit-tests](./img/nunit-tests.png)

## Implement the other unit tests
Follow the same format as the addition unit tests, and implement tests for the rest of the operations defined in `Program.cs`.

- Run the tests locally, and intentionally make one fail.
- Commit and push the changes to a different branch.
- Open a new pull request.

Travis CI will detect the pull request, and build it. Since we have a test failing, it should detect that. A failed build will look like the following;

![failed build](./img/failed-build.png)

And in GitHub it will look like:

![pr overview failed](./img/pr-overview-failed.png)
![pr detailed failed](./img/pr-detailed-failed.png)

- Push a change on the same branch to fix the test.
- See if the build completes successfully.

In GitHub, that will look like the following:

![pr overview passed](./img/pr-overview-passed.png)
![pr detailed passed](./img/pr-detailed-passed.png)

If everything passes, feel free to merge. You are now using CI.

This is a pretty simple setup for Travis CI. There's a lot of customization that can be done, so check out https://docs.travis-ci.com/ if you're curious about how it could be used. This is a free service, so if you have a public side project, I'd encourage you to set up Travis CI on it. Even if you don't really need to use it, it's great practice.
