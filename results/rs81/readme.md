# Changes from ReSharper 8.0 to 8.1 (notes)

Please note these are notes only. They are not a migration document, and does not constitute an exhaustive list of changes.

## Annotations

New Annotations added:

* `AspMvcAreaMasterLocationFormatAttribute`
* `AspMvcAreaPartialViewLocationFormatAttribute`
* `AspMvcAreaViewLocationFormatAttribute`
* `AspMvcMasterLocationFormatAttribute`
* `AspMvcPartialViewLocationFormatAttribute`
* `AspMvcViewLocationFormatAttribute`

Assembly level attributes to provide format strings for locating master pages, views and partial views.

## Decompiler

Minor changes to APIs for internal implementation of decompiler. Not significant for plugin authors.

## External Sources

Minor implementation changes. Not significant for plugin authors.

## I18n

Minor implementation changes. Not significant for plugin authors.

## Live Templates

* `HtmlMacroImplBase` now requires two type parameters, `TLanguage`, which must derive from `HtmlLanguage` and `TFile` which must implement `IHtmlFile`. Allows for macro to be used with HTML like languages, e.g. ASP.net + Razor
* Addition of TypeScript scopes

## Resources (Part of Platform)

* `ReSharperApplicationDescriptor+ProductVersionOverride` allows overriding product version in tests. You can use this in your test assembly's `ReSharperTestEnvironmentAssembly` class by overriding the `CreateApplicationDescriptor` method
* Updated help IDs. Not significant to plugin authors

## Solution Analysis

* `CheckForInterrupt` usage has been replace by `Func<bool>`
* `IssueTypesManager.Instance` is marked obsolete. Use Component Model injection
* Support for VS theming
* Minor changes for implementation. Most not significant for plugin authors.

## Solution Builder

No changes.

## Test Frameworks

(Work in Progress - JetBrains.ReSharper.TestFramework only)

* Removed attributes that were used to setup references:
	* `TestMvc2Attribute`
	* `TestMvc3Attribute`
	* `TestMvc4Attribute`
	* `TestMvcAttribute`
	* `TestRazor2Attribute`
	* `TestRazorAttribute`
	* `TestWebMatrix2Attribute`
	* `TestWebMatrixAttribute`
* `ITestLibraryRefrencesProvider`, and so also `TestReferencesAttribute`'s `GetReferences` now gets passed a `PlatformID`
* `BaseTestWithSolution` typo fixed in `SetPlatformVersion` method name (was "Platfrom")
* `ReferencesTestBase.DoTest` gets new override that takes `IEnumerable<string>` for files
* `TestFrameworkUtil.DumpReferencePositions` is now obsolete. Use override which takes `IBuffer`
* Updates to testable versions of classes. Mostly useful for testing ReSharper implementation, not plugins. 

## Work in Progress

* Platform
* PsiFeatures.VisualStudio
* Daemon
* Feature.Services
* Features
* Intentions
* Product
* PSI
* Refactorings
* Unit Test
