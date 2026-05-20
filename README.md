# NTXRPC

<p align="center">
  <img src="Assets/Resources/Images/Logos/ntx/ntx-logo-white.png" width="180"/>
</p>

<p align="center">
Minimal Discord Rich Presence utility built with Unity 6 and the Discord Social SDK.
</p>

<p align="center">

![version](https://img.shields.io/badge/version-v0.1.1--alpha-blue)
![license](https://img.shields.io/badge/license-AGPL--3.0-green)
![platform](https://img.shields.io/badge/platform-Windows-purple)
![status](https://img.shields.io/badge/status-early%20alpha-orange)

</p>

---

## Overview

NTXRPC is a lightweight desktop utility designed to provide a simple and clean way to use Discord Rich Presence through Discord's official Social SDK.

Built with Unity 6, NTXRPC focuses on minimal resource usage, simplicity, and stability while remaining fully open source under the AGPL-3.0 license.

The project is currently in early alpha development and intended primarily for:
- beta testing
- SDK experimentation
- development preview
- early feedback collection

---

## Features

- Official Discord Social SDK integration
- Start / Stop Rich Presence controls
- Rich Presence asset support
- Timestamp support
- Lightweight desktop UI
- GitHub redirect button
- Native window minimize support
- Native window close support
- Open-source AGPL-3.0 licensing
- Windows desktop support

---

## Performance

NTXRPC is designed to remain lightweight during runtime.

### Estimated Resource Usage

| Resource | Estimated Usage |
|----------|----------------|
| CPU Usage | ~0.4% – 2% |
| Memory Usage | ~40 MB – 300 MB |
| GPU Usage | Minimal |

> Actual resource usage may vary depending on system hardware, Discord activity, background applications, and Unity runtime behavior.

---

## Current Status

> **NTXRPC v0.1.1-alpha**

This release ships with a fixed, non-customizable Rich Presence configuration. All presence data is currently hardcoded to a default preset and cannot yet be modified through the user interface.

### Build Information

| Property | Value |
|---|---|
| Version | `v0.1.1-alpha` |
| Build Size | `~105 MB` |
| Engine | `Unity 6.4` |
| Platform | `Windows x64` |

> ⚠️ This software is currently experimental and should not be used in production environments.

---

## System Requirements

### Supported Operating Systems

| OS | Supported |
|----|-----------|
| Windows 10 | ✅ |
| Windows 11 | ✅ |

### Required Software

NTXRPC requires the Discord Desktop App to be installed and running.

Supported Discord release channels:
- Stable
- PTB
- Canary

---

## Development Requirements

| Dependency | Version |
|------------|---------|
| Unity Editor | `6000.4.7f1` |
| Discord Social SDK | `1.9.15780` |

### Unity Editor Version

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

### Third-Party Licenses

Third-party licenses, notices, and attributions are located in:

```txt
/Licenses
```

Includes:
- Discord Social SDK notices
- Outfit Font (SIL Open Font License 1.1)

---

## Disclaimer

NTXRPC is an independent open-source project and is not affiliated with, endorsed by, or associated with Discord Inc.

Discord and all related trademarks belong to their respective owners.