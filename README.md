# NTXRpc

![NTXRpc](Assets/Resources/Images/Logos/ntx/ntx-logo-white.png)
> Minimal Discord Rich Presence utility built with Unity 6 and the Discord Social SDK.

![version](https://img.shields.io/badge/version-v0.1.0--alpha-blue)
![license](https://img.shields.io/badge/license-AGPL--3.0-green)
![platform](https://img.shields.io/badge/platform-Windows-purple)
![status](https://img.shields.io/badge/status-early%20alpha-orange)

---

## Overview

NTXRpc is a lightweight desktop utility designed to provide a simple and clean way to use Discord Rich Presence through Discord's official Social SDK. Built with Unity 6, NTXRpc focuses on minimal resource usage, stability, and simplicity while remaining fully open source under the AGPL-3.0 license. The project is currently in early alpha development and intended primarily for testing, experimentation, and future feature expansion.

---

## Features

- Official Discord Social SDK integration
- Start / Stop Rich Presence controls
- Rich Presence asset support
- Timestamp support
- Lightweight desktop UI
- GitHub redirect button
- Open-source AGPL-3.0 licensing
- Windows desktop support

---

## Performance

NTXRpc is designed to remain lightweight during runtime.

### Estimated Resource Usage

| Resource | Estimated Usage |
|----------|----------------|
| CPU | ~0.4% – 2% |
| Memory | ~40 MB – 300 MB |
| GPU | Minimal |

> Actual resource usage may vary depending on system hardware, Discord activity, background applications, and Unity runtime behavior.

---

## Current Status

> **NTXRpc v0.1.0-alpha**

This release ships with a fixed, non-customizable Rich Presence configuration. All presence data is currently hardcoded to a default preset and cannot yet be modified through the user interface.

The current alpha build is intended for:

- beta testing
- Discord Social SDK experimentation
- development preview
- early feedback collection

### Build Information

| Property | Value |
|---|---|
| Version | `v0.1.0-alpha` |
| Build Size | `~105 MB` |
| Engine | `Unity 6` |
| Platform | `Windows` |

> ⚠️ This software is currently experimental and should not be used in production environments.
---

## System Requirements

### Supported Operating Systems

| OS | Supported |
|----|-----------|
| Windows 10 | ✅ |
| Windows 11 | ✅ |

### Required Software

NTXRpc requires the Discord Desktop App to be installed and running. All release channels are supported, including Stable, PTB, and Canary.

---

## Development Requirements

| Dependency | Version |
|------------|---------|
| Unity Editor | `6000.4.7f1` |
| Discord Social SDK | `1.9.15780` |

### Editor Version

```txt
6000.4.7f1
```

### Discord Social SDK Version

```txt
1.9.15780
```

---

## License

This project is licensed under the [GNU Affero General Public License v3.0](LICENSE).

```txt
NTXRPC — Copyright (C) 2026 Fmasterpro27
Licensed under AGPL-3.0. See LICENSE for full license terms.
```