' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Composition
Imports System.Linq
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.CodeFixes
Imports Microsoft.CodeAnalysis.VisualBasic
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace Microsoft.QualityGuidelines.Analyzers     
    ''' <summary>
    ''' CA2119: Seal methods that satisfy private interfaces
    ''' </summary>
    <ExportCodeFixProvider(LanguageNames.VisualBasic), [Shared]>
    Public NotInheritable Class BasicSealMethodsThatSatisfyPrivateInterfacesFixer
        Inherits SealMethodsThatSatisfyPrivateInterfacesFixer 

    End Class
End Namespace
