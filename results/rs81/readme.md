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

## Intentions

* Introduced and updated quick fix implementations
* Introduced `ContextActionAsActionHandler` as a base class to implement `IActionHandler` with a context action's implementation
* `ContextActionTable.InstantiateAction` introduced to allow creating an action handler. Used by `ContextActionAsActionHandler`

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

## Visual Studio Integration

These assemblies are not usually referenced by plugins - they make plugins Visual Studio version specific. However, it is possible to reference JetBrains.Platform.ReSharper.VisualStudio.Core for version agnostic functionality.

* VS interfaces added to the component model can be exposed as "Optional", using `VsServiceMap.QueryService<SService>.As<IService>.Optional()`. This means the service might not exist on the end user's machine at runtime. When consuming the component in a constructor, it should be consumed as `Optional<IService>`, which is similar to `Nullable<T>`.
* `ConnectionPointCookie<T>` no longer derive from `IDisposable` and takes a `Lifetime` parameter instead for more flexibility for cleanup
* Added `VsConstants.HtmlXLanguageServiceGuid`
* Visual Studio integration implementation changes (e.g. Peek Definition support)
* Support for Html + Xaml typing assistance

## Work in Progress

* Platform
* Daemon
* Feature.Services
* Features
* Product
* PSI
* Refactorings
* Unit Test
