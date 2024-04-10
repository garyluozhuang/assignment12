/// build task
Task("build")
    .Does(() =>
{
    MSBuild("./HelloWorld/HelloWorld.csproj", new MSBuildSettings{
        Verbosity = Verbosity.Minimal
    });
});


Task("default")
    .IsDependentOn("build");


/// run task
RunTarget(target);