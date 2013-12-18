Highcharts Basic Area
=====================

```fsharp
#load "FsPlot.fsx"

open FsPlot.Options
open FsPlot.Charting
open FsPlot.DataSeries

let stackedArea =
    let asia = Series.Area("Asia", [502; 635; 809; 947; 1402; 3634; 5268])
    let africa = Series.Area("Africa", [106; 107; 111; 133; 221; 767; 1766])
    let europe = Series.Area("Europe", [163; 203; 276; 408; 547; 729; 628])
    let america = Series.Area("America", [18; 31; 54; 156; 339; 818; 1201])
    let oceania = Series.Area("Oceani", [2; 2; 2; 6; 13; 30; 46])
    Highcharts.Area [asia; africa; europe; america; oceania]

stackedArea.Categories <- ["1750"; "1800"; "1850"; "1900"; "1950"; "1999"; "2050"]

stackedArea.SetStacking Stacking.Normal

stackedArea.ShowLegend()

stackedArea.SetTitle "Historic and Estimated Worldwide Population Growth by Region"

stackedArea.SetPointFormat "{series.name} <b>{point.y}</b> millions"
```
![Highcharts Area](https://raw.github.com/TahaHachana/FsPlot/master/screenshots/StackedArea.PNG)