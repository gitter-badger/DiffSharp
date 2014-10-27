﻿//
// This file is part of
// DiffSharp -- F# Automatic Differentiation Library
//
// Copyright (C) 2014, National University of Ireland Maynooth.
//
//   DiffSharp is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   DiffSharp is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with DiffSharp. If not, see <http://www.gnu.org/licenses/>.
//
// Written by:
//
//   Atilim Gunes Baydin
//   atilimgunes.baydin@nuim.ie
//
//   Barak A. Pearlmutter
//   barak@cs.nuim.ie
//
//   Hamilton Institute & Department of Computer Science
//   National University of Ireland Maynooth
//   Maynooth, Co. Kildare
//   Ireland
//
//   www.bcl.hamilton.ie
//

//
// Script for generating library documentation
//

#I "../../../packages/FSharp.Compiler.Service.0.0.67/lib/net40/"
#r "FSharp.Compiler.Service.dll"
#I "../../../packages/RazorEngine.3.3.0/lib/net40/"
#r "RazorEngine.dll"
#I "../../../packages/Microsoft.AspNet.Razor.2.0.30506.0/lib/net40/"
#r "System.Web.Razor.dll"
#I "../../../packages/FSharp.Formatting.2.4.36/lib/net40/"
#r "FSharp.MetadataFormat.dll"
#r "FSharp.CodeFormat.dll"
#r "FSharp.Literate.dll"
#r "FSharp.Markdown.dll"
#r "CSharpFormat.dll"

open System.IO
open FSharp.Literate
open FSharp.MetadataFormat

//
// Setup output directory structure and copy static files
//

let source = __SOURCE_DIRECTORY__ 
let docs = Path.Combine(source, "../../")
let relative subdir = Path.Combine(docs, subdir)

let test = Directory.Exists (relative "output")

if not (Directory.Exists(relative "output")) then
    Directory.CreateDirectory(relative "output") |> ignore
if not (Directory.Exists(relative "output/img")) then
    Directory.CreateDirectory (relative "output/img") |> ignore
if not (Directory.Exists(relative "output/misc")) then
    Directory.CreateDirectory (relative "output/misc") |> ignore
if not (Directory.Exists(relative "output/reference")) then
    Directory.CreateDirectory (relative "output/reference") |> ignore

for fileInfo in DirectoryInfo(relative "input/files/misc").EnumerateFiles() do
    fileInfo.CopyTo(Path.Combine(relative "output/misc", fileInfo.Name), true) |> ignore

for fileInfo in DirectoryInfo(relative "input/files/img").EnumerateFiles() do
    fileInfo.CopyTo(Path.Combine(relative "output/img", fileInfo.Name), true) |> ignore


//
// Generate documentation
//

let tags = ["project-name", "DiffSharp"; "project-author", "Atılım Güneş Baydin"; "project-github", "http://github.com/gbaydin/DiffSharp"; "project-nuget", "https://www.nuget.org/packages/diffsharp"; "root", ""]

Literate.ProcessScriptFile(relative "input/index.fsx", relative "input/templates/template.html", relative "output/index.html", replacements = tags)
Literate.ProcessScriptFile(relative "input/api-overview.fsx", relative "input/templates/template.html", relative "output/api-overview.html", replacements = tags)
Literate.ProcessScriptFile(relative "input/gettingstarted-typeinference.fsx", relative "input/templates/template.html", relative "output/gettingstarted-typeinference.html", replacements = tags)
Literate.ProcessScriptFile(relative "input/gettingstarted-forwardad.fsx", relative "input/templates/template.html", relative "output/gettingstarted-forwardad.html", replacements = tags)
Literate.ProcessScriptFile(relative "input/gettingstarted-reversead.fsx", relative "input/templates/template.html", relative "output/gettingstarted-reversead.html", replacements = tags)
Literate.ProcessScriptFile(relative "input/gettingstarted-symbolicdifferentiation.fsx", relative "input/templates/template.html", relative "output/gettingstarted-symbolicdifferentiation.html")
Literate.ProcessScriptFile(relative "input/gettingstarted-numericaldifferentiation.fsx", relative "input/templates/template.html", relative "output/gettingstarted-numericaldifferentiation.html")
Literate.ProcessScriptFile(relative "input/benchmarks.fsx", relative "input/templates/template.html", relative "output/benchmarks.html", replacements = tags)
Literate.ProcessScriptFile(relative "input/examples-gradientdescent.fsx", relative "input/templates/template.html", relative "output/examples-gradientdescent.html", replacements = tags, fsiEvaluator = FsiEvaluator())
Literate.ProcessScriptFile(relative "input/examples-kinematics.fsx", relative "input/templates/template.html", relative "output/examples-kinematics.html", replacements = tags, fsiEvaluator = FsiEvaluator())
Literate.ProcessScriptFile(relative "input/examples-lhopitalsrule.fsx", relative "input/templates/template.html", relative "output/examples-lhopitalsrule.html", replacements = tags, fsiEvaluator = FsiEvaluator())

//
// Generate API reference
//

let library = relative "../src/DiffSharp/bin/Debug/DiffSharp.dll"
let layoutRoots = [relative "input/templates"; relative "input/templates/reference" ]

MetadataFormat.Generate(library, relative "output/reference", layoutRoots, tags, markDownComments = true)