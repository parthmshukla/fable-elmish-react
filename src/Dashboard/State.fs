module Dashboard.State

open Elmish
open Dashboard.Types

let init () : Model * Cmd<Msg> =
  model = {
      State: LoginState.LoggedOut
      Login: {  UserName: ""
                Password: ""
            }
        ErrorMsg: ""
      }, []

let update (msg:LoginMsg) model : Model*Cmd<LoginMsg> = 
   match msg with
    | LoginMsg.SetUserName name ->
        { model with Login = { model.Login with UserName = name; Password = "" }}, []
    | LoginMsg.SetPassword pw ->
        { model with Login = { model.Login with Password = pw }}, []
    | LoginMsg.ClickLogIn ->
        //model, authUserCmd model.Login "/api/users/login"
