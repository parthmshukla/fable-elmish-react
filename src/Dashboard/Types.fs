module Dashboard.Types

type Login = 
    { UserName : string
      Password : string }

type LoginState =
| LoggedOut
| LoggedIn

type Model = { 
    State : LoginState
    Login : Login
    ErrorMsg : string }

type LoginMsg =
  | SetUserName of string
  | SetPassword of string
  | ClickLogIn