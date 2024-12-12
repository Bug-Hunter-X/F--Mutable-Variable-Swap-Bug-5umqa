# F# Mutable Variable Swap Bug

This example demonstrates a common pitfall in F# when dealing with mutable variables and function parameters.  The initial `swap` function attempts to swap two mutable integer variables, but it fails to correctly swap their values because the function parameters are not references. The solution demonstrates how to use `ref` cells to correctly swap the values.