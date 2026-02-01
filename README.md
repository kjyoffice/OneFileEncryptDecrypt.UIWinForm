# OneFileEncryptDecrypt.UIWinForm

### OneFileEncryptDecrypt program support WinForm UI

## Require(Dependency) App

- [OneFileEncryptDecrypt](https://github.com/kjyoffice/OneFileEncryptDecrypt)

## Build Require

.NET Framework 4.8.1

VisualStudio 2022 or 2026

## Build

### 1. Clone this repository.

### 2. Execute VisualStudio

### 3. Open solution

- VisualStudio 2022 

      OneFileEncryptDecrypt.UIWinForm.sln

- VisualStudio 2026

      OneFileEncryptDecrypt.UIWinForm.slnx

### 3. Build

### 4. Move Binary Directory 

`SOLUTION_DIRECTORY` > `OneFileEncryptDecrypt.UIWinForm` > `bin` > `Debug`

OR

`SOLUTION_DIRECTORY` > `OneFileEncryptDecrypt.UIWinForm` > `bin` > `Release`

### 5. Install

Install is simple.

Build binary diectory all files, copy to want directory.

*(Recommend binary is `Release`.)*

### 6. Setting

Open `OneFileEncryptDecrypt.UIWinForm.exe.config` file 

using `Notepad` or `VisualStudio Code` or you want text editor.

Modify XML node `InStorageDirectoryPath` and `OFEDAppPath` value.

Node `OFEDAppPath` value is `Require(Dependency) App` build binary `OneFileEncryptDecrypt.exe` file path.

### 7. Execute

### 😁

## Code modify time

This program is WinForm embeded WebView2.

WebView content root directory is `WebViewRoot`.

And if modify JS, looking directory is `WebViewRoot_TS`.

Execute VisualStudio Code(*Recommend*) after open directory `WebViewRoot_TS`.

Modify TypeScript code after compile code, execute `tsc`.

And VisualStudio load solution build and debug.

    TypeScript is global install please.
    
[typescriptlang.org - Globally Installing TypeScript](https://www.typescriptlang.org/download/)













