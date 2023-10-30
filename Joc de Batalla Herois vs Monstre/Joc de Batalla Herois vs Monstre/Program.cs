using System;

namespace GameProject
{

    //hola

    class AntonucciSandroCode
    {

        static void Main()
        {

            const int Zero = 0, One = 1, Two = 2, Three = 3;
            const int ArcherMinRangeHP = 1500, ArcherMaxRangeHP = 2000, ArcherMinRangeDMG = 180, ArcherMaxRangeDMG = 300, ArcherMinRangeReduct = 25, ArcherMaxRangeReduct = 40;
            const int BarbarianMinRangeHP = 1500, BarbarianMaxRangeHP = 2000, BarbarianMinRangeDMG = 180, BarbarianMaxRangeDMG = 300, BarbarianMinRangeReduct = 25, BarbarianMaxRangeReduct = 40;

            const string MsgAction = "Introdueix la teva acció: ";
            const string MsgInputNotValid = "Aquesta entrada no és vàlida.";
            const string MsgOutOfTries = "S'han acabat els intents.";
            const string MsgPlay = "\n1. Iniciar una nova batalla";
            const string MsgQuit = "2. Sortir\n";

            const string MsgOutOfTriesStats = "T'has equivocat 3 vegades, torna a introduir els atributs.";
            const string MsgOutOfTriesCharacters = "T'has equivocat 3 vegades donant atributs als personatges, tornes al menu principal.";

            const string MsgArcherHP = "Introdueix la vida de l'arquera (entre 1500 i 2000): ";
            const string MsgArcherDMG = "Introdueix l'atac de l'arquera (entre 180 i 300): ";
            const string MsgArcherReduct = "Introdueix la reducció de dany de l'arquera (entre 25% i 40%): ";

            const string MsgBarbarianHP = "Introdueix la vida del bàrbar (entre 3000 i 3750): ";
            const string MsgBarbarianDMG = "Introdueix l'atac del bàrbar (entre 150 i 250): ";
            const string MsgBarbarianReduct = "Introdueix la reducció de dany del bàrbar (entre 35% i 45%): ";

            const string MsgMageHP = "Introdueix la vida del mag (entre 1000 i 1500): ";
            const string MsgMageDMG = "Introdueix l'atac del mag (entre 300 i 350): ";
            const string MsgMageReduct = "Introdueix la reducció de dany del mag (entre 20% i 35%): ";

            const string MsgDruidHP = "Introdueix la vida del druida (entre 2000 i 2500): ";
            const string MsgDruidDMG = "Introdueix l'atac del druida (entre 70 i 120): ";
            const string MsgDruidReduct = "Introdueix la reducció de dany del druida (entre 25% i%): ";

            int startGame, menuTries, statsTries = 3, characterTries = 3;

            double archerHP = 0, archerDMG = 0, archerReduct = 0;
            double barbarianHP = 0, barbarianDMG = 0, barbarianReduct = 0;
            double mageHP = 0, mageDMG = 0, mageReduct = 0;
            double druidHP = 0, druidDMG = 0, druidReduct = 0;

            bool exitGame = false, archerCompleted = false, barbarianCompleted = false;

            while (!(exitGame))         //Joc interminable mentre el jugador no vulgui sortir.
            {

                menuTries = 3;


                // Recull l'acció de l'usuari mentre tingui intents.
                do
                {

                    Console.WriteLine(MsgPlay);
                    Console.WriteLine(MsgQuit);

                    if (menuTries < Three)
                    {
                        Console.Write(MsgInputNotValid);
                    }

                    Console.Write(MsgAction);

                    startGame = Convert.ToInt32(Console.ReadLine());

                    menuTries--;

                } while (startGame != One && startGame != Two && menuTries > Zero);


                if (menuTries == Zero)
                {
                    Console.WriteLine(MsgOutOfTries);
                    startGame = Two;
                }


                switch (startGame)
                {

                    case One:         // Joc


                        // Introducció de característiques
                        // Arquera

                        characterTries = 3;
                        archerCompleted = false;

                        while (characterTries > 0 && !(archerCompleted))
                        {

                            statsTries = 3;
                            archerHP = 0;
                            archerDMG = 0;
                            archerReduct = 0;

                            // Cada while comprova si el stat està dins del rang i si tens intents, si no, et resta un intent i torna a demanar stat

                            while ((archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgArcherHP);
                                archerHP = Convert.ToDouble(Console.ReadLine());

                                if (archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            while ((archerDMG < ArcherMinRangeDMG || archerDMG > ArcherMaxRangeDMG) && statsTries > 0)
                            {
                                Console.Write(MsgArcherDMG);
                                archerDMG = Convert.ToDouble(Console.ReadLine());

                                if (archerDMG < ArcherMinRangeDMG || archerDMG > ArcherMaxRangeDMG)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            while ((archerReduct < ArcherMinRangeReduct || archerReduct > ArcherMaxRangeReduct) && statsTries > 0)
                            {
                                Console.Write(MsgArcherReduct);
                                archerReduct = Convert.ToDouble(Console.ReadLine());

                                if (archerReduct < ArcherMinRangeReduct || archerReduct > ArcherMaxRangeReduct)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            if (!((archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP) && (archerDMG < ArcherMinRangeDMG || archerDMG > ArcherMaxRangeDMG) && (archerReduct < ArcherMinRangeReduct || archerReduct > ArcherMaxRangeReduct)))
                            {

                                archerCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                characterTries--;
                            }
                        }

                        //Bàrbar
                        barbarianCompleted = false;

                        while (characterTries > 0 && !(barbarianCompleted))
                        {

                            statsTries = 3;
                            barbarianHP = 0;
                            barbarianDMG = 0;
                            barbarianReduct = 0;

                            while ((barbarianHP < BarbarianMinRangeHP || archerHP > ArcherMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgArcherHP);
                                archerHP = Convert.ToDouble(Console.ReadLine());

                                if (archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            while ((archerDMG < ArcherMinRangeDMG || archerDMG > ArcherMaxRangeDMG) && statsTries > 0)
                            {
                                Console.Write(MsgArcherDMG);
                                archerDMG = Convert.ToDouble(Console.ReadLine());

                                if (archerDMG < ArcherMinRangeDMG || archerDMG > ArcherMaxRangeDMG)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            while ((archerReduct < ArcherMinRangeReduct || archerReduct > ArcherMaxRangeReduct) && statsTries > 0)
                            {
                                Console.Write(MsgArcherReduct);
                                archerReduct = Convert.ToDouble(Console.ReadLine());

                                if (archerReduct < ArcherMinRangeReduct || archerReduct > ArcherMaxRangeReduct)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            if (!((archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP) && (archerDMG < ArcherMinRangeDMG || archerDMG > ArcherMaxRangeDMG) && (archerReduct < ArcherMinRangeReduct || archerReduct > ArcherMaxRangeReduct)))
                            {

                                archerCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                characterTries--;
                            }
                        }

                        if (characterTries == 0)
                        {
                            Console.WriteLine(MsgOutOfTriesCharacters);
                        }






















                        break;

                    case Two:         // Sortida

                        exitGame = true;
                        break;

                }

            }

        }

    }

}