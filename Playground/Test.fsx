

#r @"../DnDSimulator\bin\Release\netstandard2.0/DnDSimulator.dll"
#r @"../DnDDatabaseHandler\bin\Release\netstandard2.0/DnDDatabaseHandler.dll"
#r @"C:\Program Files\dotnet\sdk\NuGetFallbackFolder\microsoft.netcore.app\2.2.0\ref\netcoreapp2.2\netstandard.dll"
#r @"C:\Users\Patrick\source\repos\MzDatabasesLibrary\MzDatabasesLibrary\bin\Debug\System.Data.SQLite.dll"


open DnDSimulator.Model
open DnDSimulator.Handler
open System.Data.SQLite
open DnDDatabase.Charakters

//let patrick = new Charakter("Patrick", 8, 3, 2, 4, 6, 12)
//let troll = new Charakter("Troll", 8, 3, 2, 4, 6, 12)

//patrick
//troll

//RollHandler.RollDisadvantage()
//RollHandler.RollAdvantage()

//let test = new Round([patrick; troll] |> System.Collections.Generic.List)

//(test.Particioners.Item 0).Charakter.Name
//(test.Particioners.Item 1).Charakter.Name

////let charakter = test.PickCharakter()

//test.PickCharakter().Name
//test.PickCharakter().Attack(patrick)
//test.PickCharakter().Move(6)

//test.PickedCharakter()

new CharDatabase()
