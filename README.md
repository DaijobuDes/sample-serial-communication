# sample-serial-communication
Application made in C# to communicate using arduino's serial pins.

## Requirements
Arduino SDK/IDE

dotnet 4.7.3

[Virtual Serial Port](https://www.eltima.com/products/vspdxp/) from Electronic Team, Inc. (for simulation in Proteus, optional, if you dont have an arduino)

## Building
Open the solution then build the GUI, after that, build the `ino` file inside `arduino/serial` or use the hex files provided.

Upload the hex file to the arduino (or place the hex file in the part properties in Proteus).
