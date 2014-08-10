﻿module HtmlApp.View

open HtmlApp.Model
open HtmlApp.Skin
open IntelliFactory.Html

let home =
    Skin.withHomeTemplate "FsPlot" <| fun ctx ->
        [

        ]

let googleCharts =
    Skin.withGoogleTemplate "FsPlot · Google Charts Support" <| fun ctx ->
        [
        ]


let highcharts =
    Skin.withHighchartsTemplate "FsPlot · Highcharts Support" <| fun ctx ->
        [

        ]

let chart title gistId =
     Skin.withChartTemplate ("FsPlot · " + title) <| fun ctx ->
        [
            Div [Class "page-header"] -< [
                H1 [Text title]
            ]
            H2 [Text "Code"]
            Div [Id "gist"] -< [
                Script [Src <| "https://gist.github.com/TahaHachana/" + gistId + ".js"]
            ]
            H2 [Text "Chart"]
            IFrame [Src <| "../iframe/" + gistId + ".html"; Id "chart-iframe"]
        ]