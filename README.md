# Consolde og debug i VS Code

C# kan sagtens kodes i vs code. Men der er problemer når man bruger de lidt mere smarte metoder i `Console` objektet, som f.eks. `Console.SetCursorPosition(x,y)` eller `Console.Clear()`, og prøver at køre programmet i _Debuggeren_.

![](readme_assets/2024-04-25-22-19-17.png)

Det sker med _VS Code_'s default `InternalConsole`.

![](readme_assets/2024-04-25-22-22-58.png)

I Menuen __File__, vælg __Preferences__ og __Settings__ .  
I søgefeltet kan du navigere frem til `csharp.debug.console`. Og her vælge _interatedConsole_ i stedet for default _internalConsole_.

![](readme_assets/2024-04-25-22-00-25.png)

På billedet her over har jeg vælgt at gemme instillingen i _User_-space. Det har den fordel at indstillingen vil virke for alle nye c-sharp projekter.  
Man kan også vælge _Workspace_. Så genereres filen `settings.json` i en ny mappe i din _workspace_-mappe: `.vscode`. Jeg har allerede lavet denne fil i dette projekt.

![](readme_assets/2024-04-25-22-35-15.png)

Nu virker debuggeren:

![](readme_assets/2024-04-25-22-40-41.png)