module App.Views

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open App.Types
open State.App
open Global
open Global.Helpers

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props

let menuItem label page currentPage dispatch =
    li
      [ ]
      [ a
          [ classList [ "is-active", page = currentPage ]
            Href (toHash page) ]
          [ str label ] ]

let menu currentPage dispatch =
  aside
    [ ClassName "menu" ]
    [ p
        [ ClassName "menu-label" ]
        [ str "General" ]
      ul
        [ ClassName "menu-list" ]
        [ menuItem "Home" Home currentPage dispatch
          menuItem "Counter sample" Counter currentPage dispatch
          menuItem "About" Page.About currentPage dispatch
          menuItem "AboutSecond" Page.AboutSecond currentPage dispatch
          menuItem "Dashboard" Page.Dashboard currentPage dispatch ] ]

let root model dispatch =

  let pageHtml =
    function
    | Page.About -> About.Views.root
    | Counter -> Counter.Views.root model.counter (CounterMsg >> dispatch)
    | Home -> Home.Views.root model.home (HomeMsg >> dispatch)
    | Page.AboutSecond -> AboutSecond.Views.root
    | Page.Dashboard -> Dashboard.Views.root model.dashboard (DashboardMsg >> dispatch)

  div
    []
    [ div
        [ ClassName "navbar-bg" ]
        [ div
            [ ClassName "container" ]
            [ Navbar.Views.root ] ]
      div
        [ ClassName "section" ]
        [ div
            [ ClassName "container" ]
            [ div
                [ ClassName "columns" ]
                [ div
                    [ ClassName "column is-3" ]
                    [ menu model.currentPage dispatch ]
                  div
                    [ ClassName "column" ]
                    [ pageHtml model.currentPage ] ] ] ] ]

open Elmish.React
open Elmish.Debug

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
|> Program.withReact "elmish-app"
|> Program.run
