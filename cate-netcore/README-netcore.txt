This is a new project, designed for building a .NET Core console app including an exe target.

It is basically a copy of the inklecate source code into a fresh .NET Core project, referencing a modified version of the runtime. There are a few code changes tagged with //CATE-NETCORE.

There are also some IMPORTANT tweaks to the .csproj. You WILL want to note the .csproj changes.

Also, every time I changed the runtime target, I had to delete and recreate my publish profile. Possibly multiple runtime targets would have solved this, but I don't care about optimal any more.

For this project to build, you also have to make a ton of accessibility changes to the runtime. See the README there for details.

