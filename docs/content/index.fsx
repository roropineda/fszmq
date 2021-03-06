(*** hide ***)
#I "../../bin"
#load "docs.fs"
open docs
PATH.hijack ()

(**
fszmq
===================

fszmq is an MPLv2-licensed F# binding for the ZeroMQ  distributed computing library.
It provides a complete binding to versions 2.1.x, 3.2.x, and 4.0.x of ZeroMQ
(Note: each binding is a separate branch in git, as there are some non-compatible differences).
This library is primarily designed to be consumed from F#. However, where possible, the library has been designed
to appear "friendly" when consumed by other CLR languages (C#, et aliam).

<div class="row">
  <div class="span2">
    <img src="img/fszmq_logo.png" alt="fszmq" style="height:137px;margin:1.4em 0 0 2em;" />
  </div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The fszmq library can be <a href="https://www.nuget.org/packages/fszmq">installed from NuGet</a>:
      <pre>PM> Install-Package fszmq</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Getting Started
-------

The simplest thing we can do with fszmq is print the ZeroMQ version. That is, we can display the version,
which is not fixed at compile-time, of the native library (i.e. libzmq) against which fszmq.dll is current bound.
_(Note: the version of fszmq.dll, itself, may be retrieved via the normal mechanisms for CLR libraries.)_
*)
(*** define-output: vsn ***)
#r "fszmq.dll"
open fszmq

printfn "libzmq version: %A" ZMQ.version

(**
Running this code should produce something like the following (the actual numbers may be different on your machine):
*)
(*** include-output: vsn ***)

(*** hide ***)
PATH.release ()

(**
Samples & Documentation
-----------------------

This library features API documentation, and an ever-growing collection of samples. Most of these narrative-style examples
are also executable F# scripts, and may be found in [the content folder][content] (Hint: look for files ending in `.fsx`).

In particular, please review:

 * [Client/Server Tutorial](tutorial.html) ... contains a more complete, but simplistic, example of fszmq in action.

 * [API Reference](reference/index.html) ... contains automatically generated documentation for all types, modules,
   and functions in the library. This includes additional brief samples on using some of the functionality.

Additionally, general information about ZeroMQ maybe found at [http://zero.mq](http://zero.mq).
And [the zguide][zguide] is a well-written, exhaustive explanation of the library.
It should definitely be read. And then read again. Also, while the zguide features examples in many languages,
the [F#-specific zguide code samples][zguidefs] have been [collected here as a convenience][localguide].

Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues] 
(or, better yet, fork the project and submit pull requests. If you're adding a 
new public API, please also consider adding [samples][content] that can be 
turned into help docs. Also be sure to read the [contributor notes][contrib] 
before getting started.)

The fszmq library is available under the Mozilla Public License, v. 2.0.
For more information see the [license file][license] in the GitHub repository.

The documentation accompanying fszmq, and any sample code contained therein, is available under
the MIT LICENSE which allows modification and reuse for both commercial non-commercial purposes.
For more information see the [documentation license file][docslicense] in the GitHub repository.

---------------------------------------------------------------------------

###### Copyright � 2011-2015 Paulmichael Blasucci.

  [content]: https://github.com/zeromq/fszmq/tree/master/docs/content
  [gh]: https://github.com/zeromq/fszmq
  [issues]: https://github.com/zeromq/fszmq/issues
  [readme]: https://github.com/zeromq/fszmq/blob/master/README.md
  [contrib]: https://github.com/zeromq/fszmq/blob/master/CONTRIBUTING.md
  [license]: https://github.com/zeromq/fszmq/blob/master/LICENSE.txt
  [docslicense]: https://github.com/zeromq/fszmq/blob/master/docs/files/LICENSE.txt
  [zguide]: http://zguide.zeromq.org/page:all
  [zguidefs]: https://github.com/imatix/zguide/tree/master/examples/F%23
  [localguide]: zguide/index.html
*)
