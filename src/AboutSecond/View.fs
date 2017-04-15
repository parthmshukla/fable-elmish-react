module AboutSecond.Views

open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
  div
    [ ClassName "content" ]
    [ h1
        [ ]
        [ str "AboutSecond page" ]
      p
        [ ]
        [ str "[About second page is loading.......]" ] ]
