module Dashboard.Views

// view dispatch method here
open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import
open Dashboard.Types
let root model dispatch =
   div [ClassName "signInBox" ] [
          h3 [ ClassName "text-center" ] [ str "Log in with 'test' / 'test'."]
           
          div [ ClassName "input-group input-group-lg" ] [
                span [ClassName "input-group-addon" ] [
                  span [ClassName "glyphicon glyphicon-user"] []
                ]
                input [ 
                    Id "username"
                    HTMLAttr.Type "text"
                    ClassName "form-control input-lg"
                    Placeholder "Username"
                    DefaultValue (U2.Case1 model.Login.UserName)
                    OnChange (fun ev -> dispatch (LoginMsg (SetUserName !!ev.target?value)))
                    AutoFocus true ] []
          ]

          div [ ClassName "input-group input-group-lg" ] [
                span [ClassName "input-group-addon" ] [
                  span [ClassName "glyphicon glyphicon-asterisk"] []
                ]
                input [ 
                        Id "password"
                        HTMLAttr.Type "password"
                        ClassName "form-control input-lg"
                        Placeholder "Password" ] []
                        DefaultValue (U2.Case1 model.Login.Password)
                        OnChange (fun ev -> dispatch (LoginMsg (SetPassword !!ev.target?value)))
                        //onEnter (LoginMsg ClickLogIn) dispatch  ] []
                    ]    
           
          div [ ClassName "text-center" ] [
              button [ClassName ("button is-primary")][ str "Loging In"]; //OnClick (fun _ -> dispatch (LoginMsg ClickLogIn)) ] [ str "Loging In" ]
          ]                   
        ]
    
   
