# HapticFeedback

> 📳 Perform haptic feedback on both iOS and Android devices.

[![npm](https://img.shields.io/npm/v/xyz.candycoded.hapticfeedback)](https://www.npmjs.com/package/xyz.candycoded.hapticfeedback)

## Installation

### Unity Package Manager

<https://docs.unity3d.com/Packages/com.unity.package-manager-ui@2.0/manual/index.html>

#### Git

```json
{
  "dependencies": {
    "xyz.candycoded.hapticfeedback": "https://github.com/CandyCoded/HapticFeedback.git#v1.0.3",
    ...
  }
}
```

#### Scoped UPM Registry

```json
{
  "dependencies": {
    "xyz.candycoded.hapticfeedback": "1.0.3",
    ...
  },
  "scopedRegistries": [
    {
      "name": "candycoded",
      "url": "https://registry.npmjs.com",
      "scopes": ["xyz.candycoded"]
    }
  ]
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
