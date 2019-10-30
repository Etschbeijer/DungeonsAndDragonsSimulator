

#r @"../DungeonsAndDragonsSimulator\bin\Release\netcoreapp2.2/DungeonsAndDragonsSimulator.dll"
#r @"../DungeonsAndDragonsSimulator\bin\Release\netcoreapp2.2/DungeonsAndDragonsSimulator.dll"

open DnDSimulator.Model
open DnDSimulator.Handler

let patrick = new Charakter("Patrick", 8, 3, 2, 4, 6, 12)
let troll = new Charakter("Troll", 8, 3, 2, 4, 6, 12)

patrick
troll

RollHandler.RollDisadvantage()
RollHandler.RollAdvantage()

let test = new Round([patrick; troll] |> System.Collections.Generic.List)

(test.Particioners.Item 0).Charakter.Name
(test.Particioners.Item 1).Charakter.Name

//let charakter = test.PickCharakter()

test.PickCharakter().Name
test.PickCharakter().Attack(patrick)
test.PickCharakter().Move(6)

test.PickedCharakter()

