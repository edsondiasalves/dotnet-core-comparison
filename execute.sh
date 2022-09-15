#!/bin/bash
dotnet run --project ./dotnet3.1/dotnet3.1.csproj &
P1=$!
dotnet run --project ./dotnet6.0/dotnet6.0.csproj &
P2=$!
wait $P1 $P2