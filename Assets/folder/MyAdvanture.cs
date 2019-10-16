using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdvanture : MonoBehaviour
{
    //dit geeft alle states weer die in de game zitten
    private enum states
    {
        Start,
        Intro,
        wasja,
        wasnee,
        buiten,
        reset,
        auto,
        fietsend,
        thuis,
        lopend,
        psychopaat_dood,
        lopengoed,
        binnen,
        slapen,
        eten,
        win
    }
    //currentstate houd bij in welke state de game is
    private states currentstate = states.Start;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        Terminal.WriteLine("dit is de terminal");
        ShowMainMenu();
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    //onUserInput detecteerd wat de user input en stuurt ze vervolgens door naar de juiste input
    void OnUserInput(string input)
    {
        switch (currentstate)
        {
            case states.Start:
            {
                if (input == "start")
                {
                    startintro();
                }
                else if (input == "3991")
                {
                    Terminal.WriteLine("jij bent slim!");
                }
                else if (input == "rlm")
                {
                    Terminal.WriteLine("hzo weet jij mijn begin letters creep");
                }
                else
                {
                    Terminal.WriteLine("je moet start typen als je me game wil spelen he!");
                }
            } 
                break;
            
            case states.Intro:
            {
                if (input == "ja")
                {
                    wasja();
                }
                else if (input == "nee")
                {
                    wasnee();
                }
            }
                break;

            case states.wasja:
            {
                if (input == "buiten")
                {
                    buiten();
                }
            }
                break;

            case states.wasnee:
            {
                if (input == "wel")
                {
                    buiten();
                }
                else if (input == "echt niet")
                {
                    StankDood();
                }
            }
                break;

            case states.reset:
            {
                if (input == "reset")
                {
                    startintro();
                }
            }
                break;

            case states.buiten:
            {
                if (input == "auto")
                {
                    PopoDood();
                }
                else if (input == "fiets")
                {
                    fietsend();
                }
                else if (input == "lopen")
                {
                    lopend();
                }
            }
                break;

            case states.lopend:
            {
                if (input == "korte")
                {
                    psychopaat_dood();
                }
                else if (input == "zelfde")
                {
                    lopengoed();
                }
            }
                break;

            case states.fietsend:
            {
                if (input == "binnen")
                {
                    thuis();
                }
            }
                break;
            
            case states.lopengoed:
            {
                if (input == "binnen")
                {
                    thuis();
                }
            }
                break;

            case states.thuis:
            {
                if (input == "slapen")
                {
                    slapen();
                }
                else if (input == "eten")
                {
                    eten();
                }
            }
                break;

            case states.eten:
            {
                if (input == "next")
                {
                    win();
                }
            }
                break;
        }
    }
    //dit geeft de text door aan de terminal
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij unfairlife");
        Terminal.WriteLine("veel suc6");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ start om te beginnen");
    }
    
    void startintro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je wordt wakker.");
        Terminal.WriteLine("je moet je zelf wassen");
        Terminal.WriteLine("");
        Terminal.WriteLine("type ja om je te wassen");
        Terminal.WriteLine("type nee om je niet te wassen");
        currentstate = states.Intro;
    }

    void wasja()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je voelt je heerlijk fris");
        Terminal.WriteLine("");
        Terminal.WriteLine("type buiten om door te gaan");
        currentstate = states.wasja;
    }

    void wasnee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je voelt je smerig en denkt dat je maar wel had moeten wassen");
        Terminal.WriteLine("je kan je nog wassen");
        Terminal.WriteLine("");
        Terminal.WriteLine("als je je wel wilt wassen type wel");
        Terminal.WriteLine("als je je niet wilt wassen type");
        Terminal.WriteLine("echt niet");
        currentstate = states.wasnee;
    }

    void buiten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je wilt graag naar buiten ga je met de auto fiets of lopend");
        Terminal.WriteLine("");
        Terminal.WriteLine("type auto om met de auto te gaan");
        Terminal.WriteLine("type lopen om lopend te gaan");
        Terminal.WriteLine("type fiets om met de fiets te gaan");
        currentstate = states.buiten;
    }

    void StankDood()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent dood ge gaan door je");
        Terminal.WriteLine("eigen stank");
        Terminal.WriteLine("");
        Terminal.WriteLine("type reset om terug te gaan");
        currentstate = states.reset;
    }

    void PopoDood()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je bedenkt je op eens dat je 15 bent");
        Terminal.WriteLine("en niet kan auto rijden gelukig houd");
        Terminal.WriteLine("de politie je aan voor dat je dood gaat");
        Terminal.WriteLine("");
        Terminal.WriteLine("type reset om opnieuw te beginnen");
        currentstate = states.reset;
    }

    void fietsend()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je hebt een stukje gefietst en gaat");
        Terminal.WriteLine("weer naar huis");
        Terminal.WriteLine("");
        Terminal.WriteLine("type binnen om naar binnen te gaan");
        currentstate = states.fietsend;
    }

    void thuis()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent weer thuis ga je even wat eten");
        Terminal.WriteLine(" of ga je slapen");
        Terminal.WriteLine("");
        Terminal.WriteLine("type slapen om te gaan slapen");
        Terminal.WriteLine("type eten om eerst te eten");
        currentstate = states.thuis;
    }

    void lopend()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je hebt een groot stuk gelopen en wilt");
        Terminal.WriteLine("weer naar huis maar vind het lang");
        Terminal.WriteLine("duuren neem je de afsij routen of neem");
        Terminal.WriteLine("je de zelfde weg terug");
        Terminal.WriteLine("");
        Terminal.WriteLine("type korte voor de afsnij roeten terug");
        Terminal.WriteLine("type zelfde voor de zelfde roeten terug");
        currentstate = states.lopend;
    }

    void psychopaat_dood()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je vind een psychopaat in het steegje");
        Terminal.WriteLine("waar je door heen gaat en hij vermoord je");
        Terminal.WriteLine("");
        Terminal.WriteLine("type reset om opnieuwe te beginnen");
        currentstate = states.reset;
    }

    void lopengoed()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je neemt de zelfde weg terug en");
        Terminal.WriteLine("je gaat weer naar huis");
        Terminal.WriteLine("");
        Terminal.WriteLine("type binnen om naar binnen te gaan");
        currentstate = states.lopengoed;
    }

    void slapen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je gaat dood in je slaap omdat");
        Terminal.WriteLine("je niet gegeten hebt");
        Terminal.WriteLine("");
        Terminal.WriteLine("type reset om opnieuwe te beginnen");
        currentstate = states.reset;
    }

    void eten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je eet een broodje met kaas");
        Terminal.WriteLine("je merkt dat het weer avond is en gaat slapen");
        Terminal.WriteLine("");
        Terminal.WriteLine("type next om door te gaan");
        currentstate = states.eten;
    }

    void win()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent niet gestorven goed gedaan");
        Terminal.WriteLine("");
        Terminal.WriteLine("type end to close the game");
    }

    void end()
    {
        Application.Quit();
    }
}
