# azure-functions-with-serilog-console
Sample repo for demo issue with using Serilog Console in Azure Functions projects

The projects have been setup with inspiration from this guide:

https://medium.com/@hany.habib1988/using-serilog-with-azure-function-and-net-6-ef019d4a07f2

This works perfectly with a NET6.0 (In-process) project but fails with .NET6.0 Isolated and .NET8.0 Isolated.

The problem is that the colorization of the log entries on the console is lost.

# The projects

## FunctionApp_6_0
Setup as described in the link above.

**WORKING**

![alt text](/Assets/Log6.0.png "Image Title")

## FunctionApp_6_0_Isolated
Setup (almost) as described in the link above but with a .NET6.0 Isolated project.

**NOT WORKING**

![alt text](/Assets/Log6.0Isolated.png "Image Title")

## FunctionApp_8_0_Isolated
Setup (almost) as described in the link above but with a .NET8.0 Isolated project and configured in `program.cs`

**NOT WORKING**

![alt text](/Assets/Log8.0Isolated.png "Image Title")

