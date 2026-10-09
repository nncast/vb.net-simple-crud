# Security Policy

## Reporting a Vulnerability

**Please do not open a public GitHub issue for security vulnerabilities.** Publicly disclosing a vulnerability before it's fixed puts anyone who copied this code as a starter template at risk.

Instead, report it privately through **GitHub Private Vulnerability Reporting**: go to this repository's **Security** tab → **Report a vulnerability** ([direct link](https://github.com/nncast/vb.net-simple-crud/security/advisories/new)). This opens a private conversation visible only to the maintainer, and lets you track the fix without exposing details publicly. ([GitHub's guide to reporting a vulnerability](https://docs.github.com/en/code-security/security-advisories/guidance-on-reporting-and-writing/privately-reporting-a-security-vulnerability))

When reporting, please include:
- A description of the vulnerability and its potential impact
- Steps to reproduce it (a minimal example is ideal)
- The affected version/commit, if known
- Any suggested fix, if you have one — optional, but appreciated

## What to Expect

This is a small, single-maintainer project (a student project, not a funded security team), so please have reasonable patience — but every report will get a response acknowledging receipt, and a fix or mitigation plan once the issue is understood. Credit is happily given in the fix's release notes unless you'd prefer to stay anonymous.

## Scope

This covers the simpleCRUD application in this repo — the shared database module (`Conn.vb`), the five CRUD forms, and how the connection string is read from `App.config` / `simpleCRUD.exe.config`.

Of particular interest: any query that can still be injected into despite the parameterized queries introduced in v0.1.1, and anything that leaks the connection string or database credentials.

Out of scope: the sample connection string's `root` user with no password (it targets a local XAMPP/WAMP setup for learning and is meant to be changed), the configuration of your MySQL server itself, and vulnerabilities in MySQL Connector/NET or the .NET Framework (please report those upstream).

## Supported Versions

As a single-track project without parallel maintained release branches, only the **latest release** (see the [Releases page](https://github.com/nncast/vb.net-simple-crud/releases)) receives security fixes. If you're running an older version, please update before reporting an issue that's already fixed in a later release.
