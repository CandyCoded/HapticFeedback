# HapticFeedback

> Perform haptic feedback on both iOS and Android devices.

## Installation

### Unity Package Manager

<https://docs.unity3d.com/Packages/com.unity.package-manager-ui@2.0/manual/index.html>

#### Git

```json
{
  "dependencies": {
    "xyz.candycoded.hapticfeedback": "https://github.com/CandyCoded/HapticFeedback.git#v1.0.0",
    ...
  }
}
```

## Usage

First include the package.

```csharp
using CandyCoded.HapticFeedback;
```

### Light Feedback

```csharp
HapticFeedback.LightFeedback();
```

### Medium Feedback

```csharp
HapticFeedback.MediumFeedback();
```

### Heavy Feedback

```csharp
HapticFeedback.HeavyFeedback();
```
