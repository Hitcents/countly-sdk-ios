#!/bin/bash
sharpie -tlm-do-not-submit bind --output=. --namespace=CountlySDK --sdk=iphoneos10.0 ../../*.h
mv -f ApiDefinitions.cs ApiDefinition.cs
mv -f StructsAndEnums.cs Structs.cs