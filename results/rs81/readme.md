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

## Solution Builder

No changes.

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
* Resources
* Solution Analysis
* Unit Test