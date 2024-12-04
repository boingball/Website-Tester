# Website Tester
A Windows application that checks a website URL against 4 different entry points and shows the results in a WebView frame.
Transforms the URL input with the following entrys
http://url
https://url
http://www.url
https://www.url

Created to allow a quick test multiple websites, to make sure all http / www redirections were correct.

![Screenshot of the Website Tester application window, showing the application after entering the url banfi.co.uk and pressing Enter.](/assets/website-tester.png)

If a website is missing one of these redirects - you will get a different result in one of the WebView frames

![Screenshot of the Website Tester application window, showing the application after entering the url postoffice.co.uk and pressing Enter.](/assets/website-tester-failed-test.png)


## Requirements 
.NET 8.0 is required to run
Tested on latest Windows 10 and Windows 11

## How to install
Download the latest release,
Run the setup.exe

## How to Use
Open up Website Tester, Enter a url (without http) and press enter on the keyboard or click [Go]
This will open up 4 pages of the same website with the different entry points.

## License
Copyright (c) 2024, Darren Banfi
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 

## This software is using libraries and functions from the following NuGet Packages

### Microsoft.Web.WebView2 v1.0.2903.40 by Microsoft

Copyright (C) Microsoft Corporation. All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are
met:

   * Redistributions of source code must retain the above copyright
notice, this list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above
copyright notice, this list of conditions and the following disclaimer
in the documentation and/or other materials provided with the
distribution.
   * The name of Microsoft Corporation, or the names of its contributors 
may not be used to endorse or promote products derived from this
software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

