# C# Property Value Inconsistency After Modification

This repository demonstrates a subtle bug in C# related to property access and modification within the same method.  The comparison within the `DoSomething()` method might unexpectedly fail due to compiler optimizations or other unpredictable factors, even though the logic appears sound.

## Bug Description

The `ExampleClass`'s `DoSomething()` method retrieves the `Value` property, modifies it, and then checks if the modified value is equal to the expected value. While this should always be true, it might not be due to compiler optimizations or caching mechanisms that reorder operations.

## Solution

The solution avoids direct comparison after modification. Instead, it introduces a temporary variable to capture the new value after the assignment and perform the comparison with that variable for reliable results.