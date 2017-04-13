## Build and running the app

1. Install npm dependencies: `yarn install` or `npm install`
2. Install dotnet dependencies: `dotnet restore`
3. Start Fable server and Webpack dev server: `dotnet fable npm-run start`
4. In your browser, open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.




##Solution for intellisense

Here is my way to work for the moment:
Delete the folders bin and obj
Execute in the terminal: set UseCommonOutputDirectory=true(windows) or export UseCommonOutputDirectory=true (unix)
Execute in the terminal: dotnet restore
Open VSCode from the same terminal code .


## Module change conflict

Change module name as per new update that is about to come. - done

https://github.com/fable-compiler/fable-elmish/pull/68