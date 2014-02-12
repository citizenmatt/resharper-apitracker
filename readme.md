## API Tracker for ReSharper

ReSharper doesn't have a plugin API as such. Plugin authors are free to use any public type or method, which gives a lot of flexibility and power - a plugin author can do nearly anything the dev team can.

However, this means that as the product evolves, the API will also evolve and introduce breaking changes. Major and minor revisions (e.g. 7.1 -> 8.0 and 8.0 -> 8.1) introduce breaking changes, and require plugins to be recompiled. Maintenance releases shouldn't have any breaking changes.

This repo uses Jake Ginnivan's [ApiApprover](https://github.com/JakeGinnivan/ApiApprover) ([blog post here](http://jake.ginnivan.net/apiapprover/)) to track changes to the public API. It generates a text file representing the public API of an assembly, and uses [ApprovalTests](http://approvaltests.sourceforge.net/) to compare that against a previously approved text file. Any differences are treated as a failing test, and the two files are displayed in a diff program. The changes can then be documented and approved.