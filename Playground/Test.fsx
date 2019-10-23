

#r @"../DungeonsAndDragonsSimulator\bin\Release\netcoreapp2.2/DungeonsAndDragonsSimulator.dll"


open DnDSimulator.Model
open DnDSimulator.Handler

let patrick = new Charakter("Patrick", 8, 3, 12, 4, 6, 12)
let troll = new Charakter("Troll", 8, 3, 2, 4, 6, 12)

patrick
troll

patrick.Attack(troll)
patrick.ShowBonusActions()


RollHandler.RollDisadvantage()
RollHandler.RollAdvantage()

patrick.Move(1)
patrick.CheckMovement()

new Round([patrick; troll] |> System.Collections.Generic.List)
