# demo of bug in vscode 1.70.2

bug is present in windows, wsl and devcontainer inside wsl

open this repository in vscode 1.70.1 and uncomment the tests in `src/Project.Tests./UnitTest1.cs`

revert

open this repository in vscode 1.70.2 and do the same to see the test-explorer error

i *suspect* this is related to either of these issues that 1.70.2 fixed
- https://github.com/microsoft/vscode/issues/157273
- https://github.com/microsoft/vscode/issues/155030
