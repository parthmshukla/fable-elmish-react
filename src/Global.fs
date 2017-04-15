module Global

type Page =
  | Home
  | Counter
  | About
  | AboutSecond
  | Dashboard

let toHash =
  function
  | About -> "#about"
  | Counter -> "#counter"
  | Home -> "#home"
  | AboutSecond -> "#aboutsecond"
  | Dashboard -> "#dashboard"

module Helpers =

  open Fable.Helpers.React.Props

  let internal classList classes =
    classes
    |> List.fold (fun complete -> function | (name,true) -> complete + " " + name | _ -> complete) ""
    |> ClassName
