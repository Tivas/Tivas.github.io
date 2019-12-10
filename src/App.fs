module App

open Elmish
open Elmish.React
open Feliz
open Feliz.Router

type State = { CurrentUrl : string list }
type Msg = UrlChanged of string list

let init() = { CurrentUrl = [ ] }

let update (UrlChanged segments) state =
    { state with CurrentUrl = segments }

// View

let renderNavBar =
  Html.nav [
    prop.classes ["navbar"; "is-transparent"; "is-offset-one-fifth";"container"]
    prop.style [ style.backgroundColor "transparent" ]
    prop.children [
      Html.div [
        prop.classes ["container"]
        prop.children [
          Html.a [
            prop.classes ["navbar-item"]
            prop.href (Router.format(""))
            prop.text "Forside" 
          ]
          Html.a [ 
            prop.classes ["navbar-item"]
            prop.href (Router.format("kontakt"))
            prop.text "Priser og Kontakt" 
          ]
          Html.div [
            prop.classes ["navbar-end"]
            prop.children [
              Html.div [ 
                prop.id "contactEmail"
                prop.classes ["navbar-item"]
                prop.text "Email: "
                prop.children [
                  Html.a [
                    prop.href "mailto:akasha-engelsen@gmail.com"
                    prop.text "akasha-engelsen@gmail.com"
                  ]
                ]
              ]
            ]
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

  // style="background-color: black; opacity: 20%"
let renderTitle =
  Html.div [
    prop.classes ["hero"; "is-medium"]
    // prop.style [ style.backgroundImageUrl "books.png" ] // Opacity 70%
    prop.style [ style.borderRadius 8 ]
    prop.id "titleHero"
    prop.children [
      Html.div [
        prop.classes ["hero-body";"textCenter"]
        prop.children [ 
          Html.h1 [
            // prop.classes ["opacityZero"]
            prop.style [ style.fontSize 50; style.color "white"  ]
            prop.text "Laura Engelsen"
          ]
          Html.h2 [
            prop.style [ style.color "white"  ]
            prop.text "Akasha vejleder og healer"
          ]
        ]
      ]
    ]
  ]


let renderDescription =
  Html.div [
    prop.classes ["hero"; "is-small"]
    prop.children [
      Html.div [
        prop.classes ["hero-body"]
        prop.children [ 
          Html.div [
            prop.classes ["columns"]
            prop.children [
              Html.div [
                prop.classes ["column"]
                prop.children [
                  Html.h1 [
                    prop.classes [ "title" ] 
                    prop.text "Akasha"
                  ]
                  Html.h2 [
                    prop.classes [ "Subtitle" ] 
                    prop.text ""
                  ]
                  Html.p [
                   prop.text "Føler du også, at ligemeget hvor meget du søger dig selv, dit indre lys, dit højere guddommelige selv, dine åndelige vejledere og dit sande ståsted her i livet, i din krop og på denne jord, at du altid har en modstand på det. Som om, at du ikke rigtig trænger igennem lagene, barrierne og blokeringerne, til dig selv og det guddommelige."
                  ]
                  Html.br []
                  Html.p [
                    prop.text "Så er det formentlig fordi, at du som menneske i denne nye tid, er klar til at slippe blokeringer og reparere skader fra dette liv, tidligere liv, dette univers og andre universer."
                  ]
                  Html.br []
                  Html.p [
                    prop.text "Vi har alle gennemgået mange liv med mange traumer og tung baggage, som har sat sig som en stor tyngde på vores krop og sjæl. Det forhindrer dig i at leve fuldt ud til din sjæls aller højeste vej og formål, og det giver dig en masse temaer og overbevisninger, som ikke længere tjener dig."
                  ]
                  Html.br []
                  Html.p [
                    prop.text "I en akasha clearing går jeg ind og finder og fjerner de blokeringer, som du er klar til at slippe, og som ikke længere tjener dig og tynger dig ned."
                  ]
                  Html.br []
                  Html.p [
                    prop.text " Jeg kigger på de temaer og overbevisninger disse har skabt hos dig, for derigennem, at give dig en større forståelse for dig selv, og hvorfor du hele tiden havner i de samme velkendte mønstre og vaner gennem de tanker og overbevisninger du har om dig selv."
                  ]
                  ]
                ]
              Html.div [
                prop.classes ["column";"centerImage"]
                prop.children [
                  Html.img [
                    prop.classes [ "centerImage" ]
                    // prop.style [ style.height 472 ; style.borderRadius 8]
                    prop.style [ style.height 472 ; style.borderRadius 8 ]
                    prop.src "laura_magi_cropped.jpg"
                  ]
                ]
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
              Html.div [
                prop.classes ["columns"]
                // prop.style [ style.backgroundColor "pink"]
                prop.children [
                  Html.div [
                    prop.classes ["column"; "centerImage"]
                    prop.children [
                      Html.img [
                        prop.classes ["centerImage"]
                        prop.style [ style.height 472 ; style.borderRadius 8]
                        prop.src "laura_haek2.jpg"
                      ]
                    ]
                  ]
                  Html.div [
                    prop.classes ["column"]
                    prop.children [
                      Html.h1 [
                        prop.classes ["title"] 
                        prop.text "Om mig"
                      ]
                      Html.p [
                        prop.text "Jeg er født i københavn i 1985. Lige fra mine allerførste erindringer i min hukommelse, har jeg altid vidst at der var mere til dette liv, end hvad jeg kunne se med det blotte øje. Min interesse for det åndelige har holdt ved, og op gennem de sene teenageår og 20‘erne, begyndte jeg at studere en masse om sjæletyper, parallel universer, engle, og alt andet jeg kunne komme i nærheden af."
                      ]
                      Html.br []
                      Html.p [
                        prop.text "I 2009 blev jeg uddannet sygeplejerske, og har arbejdet som dette lige siden. Jeg elsker mit erhverv, men jeg har også altid følt, at der må være mere til sundhed og sygdom, end hvad vi praktiserer i sygehusvæsnet."
                      ]
                      Html.br []
                      Html.p [
                        prop.text "Jeg er uddannet akasha vejleder og healer, og elsker at hjælpe folk med at fjerne alt det der ikke længere tjener dem, så de kan løftes op på et sjæleligt højere niveau, og for hver dag, være i stand til at leve endnu mere til deres højeste vej og formål."
                      ]
                    ]
                  ]
                ]
              ]
            ]
          ]
        ]
      ]
    ]
  ]

let renderContact =
    Html.div [
      prop.children [
        Html.p [
          prop.text "Jeg fejrer åbningen af min hjemmeside med en fuld skriftlig akasha session til kun 395 kr"
        ]
        Html.p [
          prop.text "I den skriftlige sessionen får du:"
        ]
        Html.p [
          prop.text "En læsning og en clearing af de blokeringer og overbevisninger som ikke længere tjener dit højeste vej og formål og som dukker op i sessionen"
        ]
        Html.p [
          prop.text "En analyse af din sjæl. Hvor den kommer fra, hvilken stråle den er under påvirkning af, hvad er din sjæls kvaliteter og hvad er du kommet her til jorden for at lære"
        ]
        Html.p [
          prop.text "En opfølgning efter 2-4 måneder, hvor jeg tjekker at alt er som det skal være, og om der er kommet nyt op til overfladen, som er klar til at slippe."
        ]
        Html.p [
          prop.text "Kontaktoplysninger:"
        ]
        Html.p [
          prop.text "Send en mail på akasha-engelsen@gmail.com og aftal en tid for sessionen"
        ]
        Html.p [
          prop.text "Til udarbejdelsen skal jeg brude dit fulde navn, fødselsdato og fødeby"
        ]
      ]
    ]


let render (state: State) (dispatch: Msg -> unit) =
  let staticContent = [renderNavBar; renderTitle ]
  let frontContent =  staticContent @ [ renderDescription; renderBody ]
  let contactContent = staticContent @ [ renderContact ]


  let currentPage =
    let shell (content: Fable.React.ReactElement list) = 
      Html.div [
        prop.id "mainDiv"
        prop.children [
          Html.div [
            prop.classes ["container"]
            prop.children content 
          ]
        ]
      ]
    match state.CurrentUrl with
    | [] -> shell frontContent
    | ["kontakt"] -> shell contactContent
    | _ -> Html.h1 "Not found"

  Router.router [
    Router.onUrlChanged (UrlChanged >> dispatch)
    Router.application currentPage
  ]


Program.mkSimple init update render
|> Program.withReactSynchronous "elmish-app"
|> Program.run