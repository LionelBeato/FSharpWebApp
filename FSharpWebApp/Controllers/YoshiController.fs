namespace FSharpWebApp.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open FSharpWebApp.Models

[<ApiController>]
[<Route("[controller]")>]
type YoshiController (logger : ILogger<YoshiController>) =
    inherit ControllerBase()
   
    [<HttpGet>]
    member this.Get() =
        this.Ok { Id = 1
                  ShoeColor = "yellow"
                  Color = "black" }