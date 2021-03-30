•ASP.NET

-ASP.NET är ett framework som används för att skapa bl.a. webservrar och webappar.

När programmet startas så kallar det det på Startup.cs
Först i Startup.cs så laddas det in lite settings (Configuration).
Sedan så finns det 2 metoder, ConfigureServices och Configure.
I den första så lägger vi till vilka services webhosten behöver, så att vi kan komma åt dem i programmet. RazorPages och DbContext i vårt fall.
I den andra så bestämmer man vilka steg appen tar för att svara på http requests mha middleware komponenter.
Varje middleware komponent kallar på nästa i ledet tills att endpoint nås(Razor page) och sedan så görs samma steg igen fast åt andra hållet med svaret.

-wwwroot
Filer som alltid är likadana. Det kan vara bl.a HTML, CSS och JS filer (t.ex så finns bootstrap här).


•Razor Pages

Razor pages låter oss att blanda HTML och C# kod för att skapa dynamsika websidor.
En razor page är uppdelad i två delar, en Content Page och en Page Model, som sammarbetar med varandra mha bl.a bindings och olika helpers.

-Content Page (.cshtml):
Här är det som syns på websidan. Mycket HTML, undvik att stoppa in logik här så mycket som möjligt.

-Page Model (.cshtml.cs):
Här sker det mesta av programmeringen, och här har vi våra Page Handlers som gör så att vi kan få saker att hända med sidan.
OnGet() Här kan vi stoppa in saker som vi vill ska hända när sidan har kallats på. T.ex lista en databas.
OnPost() För att ta emot något.


•MVC (Model View Controller)

Controllern tar hand om alla requests från användare och styr vad resten av servern ska göra med requestet, den agerar mellanhand mellan Model och View.
Model och View har aldrig direkt kontakt med varandra.
När Controllern fått en request så ber den Model om data. Model hanterar all data logik och är den delen som hanterar databasen.
Efter att Model har svarat Controllern med data så skickas Controllern datan till View som hanterar presentationen av datan.
När presentationen är klar så skickas den tillbaka till Controllern som i sin tur skickar den till användaren som gjorde requesten.
Alltså är Controllern den enda kontakten användaren har till servern.

