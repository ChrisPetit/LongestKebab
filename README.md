# Challenge 3: The Longest Kebab

The most common problem in this festival is calculating how much material is needed to create the longest possible kebab based on the amount of material you have on hand. Since there are so many people at the festival, and you'd like to serve them all, the materials must be calculated quickly.
## Solution
This is a .NET Core function App.

## Try it yourself
In Powershell:

```PowerShell
Invoke-RestMethod https://longestkebab.azurewebsites.net/api/CalculateLongestKebab/?kilosGroundLamb=200
```

or open the link in your browser...[https://longestkebab.azurewebsites.net/api/CalculateLongestKebab/?kilosGroundLamb=200](https://longestkebab.azurewebsites.net/api/CalculateLongestKebab/?kilosGroundLamb=200)

## How to run this

You can run this using either [Visual Studio](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-your-first-function-visual-studio), [Visual Studio ](https://docs.microsoft.com/en-us/azure/azure-functions/create-first-function-vs-code-csharp)Code or your C# IDE of choice...

Clone the repo, open the *.sln file and choose build. Then you can run it...(F5 in Visual Studio). If you want, you can also publish it to an Azure Function App, wich I did, check the link above.

I reckoned that you can make 8 thin kebabs of 20 cm each using 1 kilo of ground lamb. That should provide 8 poeple with a portion.


 