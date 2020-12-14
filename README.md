# OnionSeed

Contains common components, utilities, and scaffolding to enable applications to be created more quickly, following the tenets of DDD and Onion Architecture.

## Supported Platforms

| Platforms</br>Currently Supported | End of Support   | .NET Standard</br>1.2 | .NET Standard</br>1.3 | .NET Standard</br>1.4 | .NET Standard</br>1.5 | .NET Standard</br>1.6 | .NET Standard</br>2.0 | .NET Standard</br>2.1 |
| --------------------------------- | ---------------- | :-------------------: | :-------------------: | :-------------------: | :-------------------: | :-------------------: | :-------------------: | :-------------------: |
| .NET 5                            |                  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |
| .NET Core 3.1                     | December 3, 2022 |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |
| .NET Core 2.1                     | August 21, 2021  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |
| .NET Framework 4.8                | \<see below †\>  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          N/A          |
| .NET Framework 4.7.2              | \<see below †\>  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          N/A          |
| .NET Framework 4.7.1              | \<see below †\>  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          N/A          |
| .NET Framework 4.7                | \<see below †\>  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          N/A          |
| .NET Framework 4.6.2              | \<see below †\>  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          N/A          |
| .NET Framework 4.6.1              | \<see below †\>  |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          ✔️           |          N/A          |
| .NET Framework 4.6                | \<see below †\>  |          ✔️           |          ✔️           |          N/A          |          N/A          |          N/A          |          N/A          |          N/A          |
| .NET Framework 4.5.2              | \<see below †\>  |          ✔️           |          N/A          |          N/A          |          N/A          |          N/A          |          N/A          |          N/A          |

† .NET Framework is supported as long as it's on a supported Windows OS, as show below:

| Operating System</br>Currently Supported | End of Support    | .NET Framework</br>4.5.2 | .NET Framework</br>4.6 | .NET Framework</br>4.6.1 | .NET Framework</br>4.6.2 | .NET Framework</br>4.7 | .NET Framework</br>4.7.1 | .NET Framework</br>4.7.2 | .NET Framework</br>4.8 |
| ---------------------------------------- | ----------------- | :----------------------: | :--------------------: | :----------------------: | :----------------------: | :--------------------: | :----------------------: | :----------------------: | :--------------------: |
| Windows 10                               | October 14, 2025  |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| &nbsp;&nbsp;&nbsp;&nbsp;├─ version 20H2  | May 10, 2022      |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| &nbsp;&nbsp;&nbsp;&nbsp;├─ version 2004  | December 14, 2021 |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| &nbsp;&nbsp;&nbsp;&nbsp;└─ version 1909  | May 11, 2021      |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| Windows 8.1                              | January 10, 2023  |            ✔             |           ✔            |            ✔             |            ✔             |           ✔            |            ✔             |            ✔             |           ✔            |
| ──────────────────────                   | ───────────────── |          ─────           |          ───           |          ─────           |          ─────           |          ───           |          ─────           |          ─────           |          ───           |
| Windows Server (2019)                    | January 9, 2029   |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| &nbsp;&nbsp;&nbsp;&nbsp;├─ version 20H2  | May 10, 2022      |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| &nbsp;&nbsp;&nbsp;&nbsp;├─ version 2004  | December 14, 2021 |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| &nbsp;&nbsp;&nbsp;&nbsp;└─ version 1909  | May 11, 2021      |                          |                        |                          |                          |                        |                          |            ✔             |           ✔            |
| Windows Server 2016                      | January 12, 2027  |                          |                        |                          |            ✔             |           ✔            |            ✔             |            ✔             |           ✔            |
| Windows Server 2012 R2                   | October 10, 2023  |            ✔             |           ✔            |            ✔             |            ✔             |           ✔            |            ✔             |            ✔             |           ✔            |
| Windows Server 2012                      | October 10, 2023  |            ✔             |           ✔            |            ✔             |            ✔             |           ✔            |            ✔             |            ✔             |           ✔            |

More information about support can be found here:

- [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) implementation
- [.NET Core & .NET 5](https://dotnet.microsoft.com/platform/support/policy/dotnet-core) support policy
- [.NET Framework](https://docs.microsoft.com/en-us/dotnet/framework/get-started/system-requirements) support (by OS)
- [Microsoft Product & Service Lifecycle information](https://docs.microsoft.com/en-us/lifecycle/products/) (search page)
  - [Windows 10 Home and Pro](https://docs.microsoft.com/en-us/lifecycle/products/windows-10-home-and-pro) release support
  - [Windows Server](https://docs.microsoft.com/en-us/lifecycle/products/windows-server) release support
