module App.Types


open Global

type Msg =
  | CounterMsg of Counter.Types.Msg
  | HomeMsg of Home.Types.Msg
  | DashboardMsg of Dashboard.Types.LoginMsg

type Model = {
    currentPage: Page
    counter: Counter.Types.Model
    home: Home.Types.Model
    dashboard: Dashboard.Types.Model
  }
