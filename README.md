This is the source code for the Core Tabular command-line compiler, tc.exe.

#License

See LICENSE.txt

#Requirements:

 1. Infer.NET v2.6

 CoreTabular uses Infer.NET as a backend.  Before building
 CoreTabular, the binaries for Infer.NET must be downloaded and
 installed in sibling directory ..\Dependencies\infernet\2.6.

 2. Visual Studio 2013 (Optional)

#Building:

In Visual Studio 2013:
  1. Open the Tabular.sln file in VS 2013.
  2. In Solution Explorer window, right-click on the solution and "Enable nuget package restore".
  3. Click Build.

Or just type msbuild from the command-line.

#Documentation:

tc.exe gives command line options.
tc.exe --help gives a summary of tabular syntax

#Samples:

The project comes with two sample application, Samples\TrueSkill and
Samples\Faithful.  Each contains a script run.bat that invokes the
Tabular compiler tc.exe to compile the model (from Tabular to
Infer.NET) and run inference.
  






