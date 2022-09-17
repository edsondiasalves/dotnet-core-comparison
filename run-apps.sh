#!/bin/bash
dotnet run --project ./dotnet3.1/dotnet3.1.csproj --configuration Release &
P1=$!

dotnet run --project ./dotnet6.0/dotnet6.0.csproj --configuration Release &
P2=$!

wait $P2 $P1