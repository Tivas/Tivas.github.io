module App

open Elmish
open Elmish.React
open Feliz

type State = None 

type Msg =
    | Nop

let init() = None

let update (msg: Msg) (state: State): State =
  None

// View

let renderNavBar =
  Html.nav [
    prop.classes ["navbar"; "is-transparent"; "is-fixed-top"; "is-offset-one-fifth";"container"]
    prop.style [ style.backgroundColor "transparent" ]
    prop.children [
      Html.div [
        prop.classes ["container"]
        prop.children [
          Html.a [ 
            prop.classes ["navbar-item"]
            prop.text "Link 1" 
          ]
          Html.a [ 
            prop.classes ["navbar-item"]
            prop.text "Link 2" 
          ]
          Html.a [ 
            prop.classes ["navbar-item"]
            prop.text "Link 3" 
          ]
          Html.a [ 
            prop.classes ["navbar-item"]
            prop.text "Link 4" 
          ]
        ]
      ]
    ]
  ]

let renderNavBar2 =
  Html.div [
    prop.classes ["columns"]
    prop.children [
      Html.div [
        prop.classes ["column"]
        prop.children [
          Html.a [
            prop.text "Link 1"
          ]
        ]
      ]
      Html.div [
        prop.classes ["column"]
        prop.children [
          Html.a [
            prop.text "Link 2"
          ]
        ]
      ]
      Html.div [
        prop.classes ["column"]
        prop.children [
          Html.a [
            prop.text "Link 3"
          ]
        ]
      ]
    ]

  ]

let renderTitle =
  Html.div [
    prop.classes ["hero"; "is-medium"]
    prop.children [
      Html.div [
        prop.classes ["hero-body"]
        prop.children [ 
          Html.div [
            prop.children [
              Html.h1 [
                prop.classes [ "title" ] 
                prop.text "Akasha vejleder og healer"
              ]
              Html.h2 [
                prop.classes [ "Subtitle" ] 
                prop.text "Laura Engelsen"
              ]
            ]
          ]
        ]
      ]
    ]
  ]

let renderSpacer =
  Html.div [
    prop.classes ["hero"; "is-small"]
    prop.children [
      Html.div [
        prop.classes ["hero-body"]
        prop.children [ 
          Html.div [
            prop.children [
              Html.h1 [
                prop.classes [] 
              ]
            ]
          ]
        ]
      ]
    ]
  ]


let renderBody =
  Html.div [
    prop.classes ["hero"; "is-medium"]
    prop.children [
      Html.div [
        prop.classes ["hero-body"]
        prop.children [ 
          Html.div [
            prop.children [
              Html.h1 [
                prop.classes ["title"] 
                prop.text "Text Text"
              ]
              Html.p [
                prop.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
              ]
            ]
          ]
        ]
      ]
    ]
  ]

let render (state: State) (dispatch: Msg -> unit) =
  Html.div [
    prop.children [
      Html.div [
        prop.classes ["container"]
        prop.children [
            // renderNavBar
            renderTitle
            renderBody
            renderSpacer
            renderSpacer
            renderSpacer
        ]
      ]
    ]
  ]


Program.mkSimple init update render
|> Program.withReactSynchronous "elmish-app"
|> Program.run