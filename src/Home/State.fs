module Home.State

open Elmish
open Home.Types

let init () : Model * Cmd<Msg> =
  "", []

let update msg model : Model * Cmd<Msg> =
  match msg with
  | ChangeStr str ->
      str, []
