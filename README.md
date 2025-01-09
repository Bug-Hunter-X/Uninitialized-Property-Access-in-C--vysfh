# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties can lead to unexpected behavior or runtime errors.

## The Problem

The `bug.cs` file shows a class with a property `MyProperty` that is not initialized in the constructor or anywhere else before it's accessed. When `MyMethod` executes, the value of `MyProperty` is read, but it could contain garbage data or the default value for the type (0 for integers). 

## The Solution

The `bugSolution.cs` file shows how to fix this issue by initializing the property either in the constructor or before it's used in `MyMethod`.