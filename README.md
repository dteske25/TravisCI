![Build](https://github.com/kgerot/GithubActions/actions/workflows/run-app.yml/badge.svg)

# Github Actions Lab

Because Travis CI is no longer free, we are going to look at how Github Actions can provide continuous integration on a sample project.

Continuous integration can be used to perfom checks on written code, making sure that unit tests always pass or that formatting is followed, and that when changes are made, they don't break other areas of the code.

Fork and clone the repo to your computer to get started.

## Run the Console App
Just as a sanity check, make sure that everything is working before you begin. Try out the console app, see if you can break it and where the weaknesses in the code are. Try manually running the tests.

## Set up Github Actions to build the Console App

First, let's explore the Action UI on Github. Go to the Actions Tab and look at any running jobs.
Currently, there should be one job that has run successfully. 

![Actions Tab](./img/actions-tab)

Next let's configure the readme so you can see if *your* tests have passed (as it is currently showing mine).
Edit the Readme on the website and replace

`![Build](https://github.com/kgerot/GithubActions/actions/workflows/run-app.yml/badge.svg)`

with

`![Build](https://github.com/username/GithubActions/actions/workflows/run-app.yml/badge.svg)`

where username is your github username.


If you open that job, you'll see we've prorammed the action to just echo `Hello, World!`.

We want our action to build our project. To do this, navigate to the file `.github/workflows/run-app.yaml`.
This is where we have define a workflow that runs a process called `Basic Action` that echos `Hello, World!`. It runs on the latest Ubuntu OS and runs everytime you push.

Replace the contents of the file with the code below

```yaml
name: 'Run App'

on: [push]

jobs:
  check-bats-version:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v2
      - uses: actions/setup-dotnet@v1
        with:
          dotnet-version: '5.0.301'
      - uses: nuget/setup-nuget@v1
      - name: Nuget Restore
        run: nuget restore GithubActions.sln
      - name: Install dependencies
        run: dotnet restore GithubActions.sln
      - name: Build
        run: msbuild /p:Configuration=Release GithubActions.sln
```

- Commit and push these changes to master
- Open the Actions and see if your build is running (should be under the name of your commit). 


## Implement the Power method
Once Github Actions is up and running, it should rebuild every time you push a change, or open a pull request. Let's test this out.

- Implement the `Power` method found in `Program.cs`.
- Commit and push the change to a different branch.
- Open a pull request **to your repository's main branch** (Do not submit a pull request to `kgerot/GithubActions` or `dteske/TraviCI` and delete the request if you do)

## Set up Github Actions to run Unit Tests
To run the tests after every change, we'll have to modify the .yaml slightly. 

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
