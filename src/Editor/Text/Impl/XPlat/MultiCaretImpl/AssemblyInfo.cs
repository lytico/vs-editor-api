﻿//
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License. See License.txt in the project root for license information.
//
// This file contain implementations details that are subject to change without notice.
// Use at your own risk.
//
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;

//
// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//

#pragma warning disable CS0436 // Type conflicts with imported type
[assembly: InternalsVisibleTo("Microsoft.VisualStudio.Text.TextViewUnitTestHelper, PublicKey=" + ThisAssembly.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.VisualStudio.Language.Intellisense.UnitTestHelper, PublicKey=" + ThisAssembly.PublicKey)]
#pragma warning restore CS0436 // Type conflicts with imported type

[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]
#pragma warning disable 618
[assembly: SecurityPermission (SecurityAction.RequestMinimum, Flags = SecurityPermissionFlag.Execution)]
#pragma warning restore 618
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.MayFail)]
