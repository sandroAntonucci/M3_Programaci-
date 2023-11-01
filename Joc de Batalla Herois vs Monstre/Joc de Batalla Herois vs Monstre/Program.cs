using System;

namespace GameProject
{

    //hola

    class AntonucciSandroCode
    {

        static void Main()
        {

            const int Zero = 0, One = 1, Two = 2, Three = 3, Percent = 100;
            const int ArcherMinRangeHP = 1500, ArcherMaxRangeHP = 2000, ArcherMinRangeDMG = 180, ArcherMaxRangeDMG = 300, ArcherMinRangeReduct = 25, ArcherMaxRangeReduct = 40;
            const int BarbarianMinRangeHP = 3000, BarbarianMaxRangeHP = 3750, BarbarianMinRangeDMG = 150, BarbarianMaxRangeDMG = 250, BarbarianMinRangeReduct = 35, BarbarianMaxRangeReduct = 45;
            const int MageMinRangeHP = 1000, MageMaxRangeHP = 1500, MageMinRangeDMG = 300, MageMaxRangeDMG = 350, MageMinRangeReduct = 20, MageMaxRangeReduct = 35;
            const int DruidMinRangeHP = 2000, DruidMaxRangeHP = 2500, DruidMinRangeDMG = 70, DruidMaxRangeDMG = 120, DruidMinRangeReduct = 25, DruidMaxRangeReduct = 40, DruidHeal = 500;
            const int MonsterMinRangeHP = 9000, MonsterMaxRangeHP = 12000, MonsterMinRangeDMG = 250, MonsterMaxRangeDMG = 400, MonsterMinRangeReduct = 20, MonsterMaxRangeReduct = 30;

            const string MsgAction = " · Introdueix la teva acció: ";
            const string MsgCharacterActions = "\n  1.- Atacar\n  2.- Protegir-se\n  3.- Habilitat especial\n\n";
            const string MsgInputNotValid = "\n - Aquesta entrada no és vàlida.\n\n";
            const string MsgOutOfTries = "S'han acabat els intents.";
            const string MsgProtect = " es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.";
            const string MsgCooldown = "L'habilitat especial encara té temps d'espera. Falten ";
            const string MsgLost = "El monstre ha matat a tot el grup. Has perdut :/";
            const string MsgWon = "Felicitats, has matat al monstre!";
            const string MsgStart = " Benvingut a Herois vs Monstre!\n Que vols fer?";
            const string MsgPlay = "\n 1. Iniciar una nova batalla";
            const string MsgQuit = " 0. Sortir\n";
            const string MsgCharStats = "\nOK! Començem amb la creació de personatges. ";

            const string MsgDecoration = "\n\n-----------------------------------------\n\n";
            const string MsgDecorationArcher = "\n\n--- Estadístiques d'arquera ---\n\n";
            const string MsgDecorationBarbarian = "\n\n--- Estadístiques de bàrbar ---\n\n";
            const string MsgDecorationMage = "\n\n--- Estadístiques de maga ---\n\n";
            const string MsgDecorationDruid = "\n\n--- Estadístiques de druida ---\n\n";
            const string MsgDecorationMonster = "\n\n--- Estadístiques de monstre ---\n\n";

            const string MsgOutOfTriesStats = "\nT'has equivocat 3 vegades, torna a introduir els atributs.";
            const string MsgOutOfTriesCharacters = "\nT'has equivocat 3 vegades donant atributs als personatges, tornes al menu principal.";

            const string MsgArcherName = "Arquera";
            const string MsgArcherHP = "\n - Introdueix la vida de l'arquera (entre 1500 i 2000): ";
            const string MsgArcherDMG = "\n - Introdueix l'atac de l'arquera (entre 180 i 300): ";
            const string MsgArcherReduct = "\n - Introdueix la reducció de dany de l'arquera (entre 25% i 40%): ";
            const string MsgArcherSpecial = "\n - L'arquera activa la seva habilitat especial i el monstre no pot atacar durant dos torns.";
            const string MsgArcherDied = "\nL'arquera ha mort :(";

            const string MsgBarbarianName = "Bàrbar";
            const string MsgBarbarianHP = "\n - Introdueix la vida del bàrbar (entre 3000 i 3750): ";
            const string MsgBarbarianDMG = "\n - Introdueix l'atac del bàrbar (entre 150 i 250): ";
            const string MsgBarbarianReduct = "\n - Introdueix la reducció de dany del bàrbar (entre 35% i 45%): ";
            const string MsgBarbarianSpecial = "\n - El bàrbar activa la seva habilitat especial i augmenta la seva defensa al 100% durant 3 torns.";
            const string MsgBarbarianMaxReduct = "\nLa reducció de dany del bàrbar ja està al 100%";
            const string MsgBarbarianDied = "El bàrbar ha mort :(";


            const string MsgMageName = "Maga";
            const string MsgMageHP = "\n - Introdueix la vida del mag (entre 1000 i 1500): ";
            const string MsgMageDMG = "\n - Introdueix l'atac del mag (entre 300 i 350): ";
            const string MsgMageReduct = "\n - Introdueix la reducció de dany del mag (entre 20% i 35%): ";
            const string MsgMageSpecial = "\n - La maga activa la seva habilitat especial i dispara una bola de foc que fa 3 cops el seu atac.";
            const string MsgMageDied = "El mag ha mort :(";

            const string MsgDruidName = "Druida";
            const string MsgDruidHP = "\n - Introdueix la vida del druida (entre 2000 i 2500): ";
            const string MsgDruidDMG = "\n - Introdueix l'atac del druida (entre 70 i 120): ";
            const string MsgDruidReduct = "\n - Introdueix la reducció de dany del druida (entre 25% i 40%): ";
            const string MsgDruidSpecial = "\n - El druida activa la seva habilitat especial i cura a tothom 500 de vida.";
            const string MsgDruidDied = "El druida ha mort :(";

            const string MsgMonsterName = "Monstre";
            const string MsgMonsterHP = "\n - Introdueix la vida del monstre (entre 9000 i 12000): ";
            const string MsgMonsterDMG = "\n - Introdueix l'atac del monstre (entre 250 i 400): ";
            const string MsgMonsterReduct = "\n - Introdueix la reducció de dany del monstre (entre 20% i 30%): ";
            const string MsgMonsterAttack = "\nEl monstre ataca a tots els herois: "; 
            const string MsgMonsterCantAttack = "\nEl monstre està atordit i no pot atacar.";

            const string MsgBattle = "Comença la batalla!";
            const string MsgTurn = "Torn ";

            int startGame, menuTries, statsTries = 3, characterTries = 3, turnTries = 3, actionChosen = 0, turn = 1;

            double archerHP = 0, archerMaxHP = 0, archerDMG = 0, archerReduct = 0, currentArcherReduct = 0, archerSpecialCooldown = 0;
            double barbarianHP = 0, barbarianMaxHP = 0, barbarianDMG = 0, barbarianReduct = 0, currentBarbarianReduct = 0, barbarianSpecialCooldown = 0, barbarianReductSpecialTurns = 0;
            double mageHP = 0, mageMaxHP = 0, mageDMG = 0, mageReduct = 0, currentMageReduct = 0, mageSpecialCooldown = 0;
            double druidHP = 0, druidMaxHP = 0, druidDMG = 0, druidReduct = 0, currentDruidReduct = 0, druidSpecialCooldown = 0;
            double monsterHP = 0, monsterDMG = 0, monsterReduct = 0, monsterStun = 0;

        

            bool exitGame = false, archerCompleted = false, barbarianCompleted = false, mageCompleted = false, druidCompleted = false, monsterCompleted = false, turnEnded = false;

            while (!(exitGame))         //Joc interminable mentre el jugador no vulgui sortir.
            {

                menuTries = 3;


                //Recull l'acció de l'usuari mentre tingui intents.
                do
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(MsgDecoration);
                    Console.WriteLine(MsgStart);
                    Console.WriteLine(MsgPlay);
                    Console.WriteLine(MsgQuit);

                    if (menuTries < Three)
                    {
                        Console.Write(MsgInputNotValid);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(MsgAction);

                    startGame = Convert.ToInt32(Console.ReadLine());

                    menuTries--;

                    Console.Clear();

                } while (startGame != One && startGame != Zero && menuTries > Zero);


                if (menuTries == Zero)
                {
                    Console.WriteLine(MsgOutOfTries + " Es tanca el joc.");
                    Console.ReadKey();
                    startGame = Zero;
                }

                //Menu principal -0 és sortir i 1 és jugar -
                switch (startGame)
                {
                    case Zero:         // Sortida

                        Console.WriteLine("Adéu!");
                        exitGame = true;
                        break;

                    case One:         // Joc

                        Console.WriteLine(MsgCharStats);
                        Console.ReadKey();

                        // Introducció de característiques
                        // Estadístiques Arquera

                        characterTries = 3;
                        archerCompleted = false;

                        while (characterTries > 0 && !(archerCompleted))
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(MsgDecorationArcher);

                            statsTries = 3;
                            archerHP = 0;
                            archerDMG = 0;
                            archerReduct = 0;

                            // Cada while comprova si el stat està dins del rang i si tens intents, si no, et resta un intent i torna a demanar stat

                            // Vida Arquera
                            while ((archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgArcherHP);
                                archerHP = Convert.ToDouble(Console.ReadLine());
                                archerMaxHP = archerHP;

                                if (archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Dany arquera
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

                            // Reducció de dany arquera
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

                            // Comprova si tots els stats de l'arquera son correctes per a poder continuar cap al següent personatge
                            if (!(archerHP < ArcherMinRangeHP || archerHP > ArcherMaxRangeHP) && !(archerDMG < ArcherMinRangeDMG || archerDMG > ArcherMaxRangeDMG) && !(archerReduct < ArcherMinRangeReduct || archerReduct > ArcherMaxRangeReduct))
                            {

                                archerCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                Console.ReadKey();
                                characterTries--;
                            }
                        }

                        // Estadístiques Bàrbar
                        barbarianCompleted = false;

                        while (characterTries > 0 && !(barbarianCompleted))
                        {

                            Console.Clear();
                            Console.Write(MsgDecorationBarbarian);

                            statsTries = 3;
                            barbarianHP = 0;
                            barbarianDMG = 0;
                            barbarianReduct = 0;

                            // Vida Bàrbar
                            while ((barbarianHP < BarbarianMinRangeHP || barbarianHP > BarbarianMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgBarbarianHP);
                                barbarianHP = Convert.ToDouble(Console.ReadLine());
                                barbarianMaxHP = barbarianHP;

                                if (barbarianHP < BarbarianMinRangeHP || barbarianHP > BarbarianMaxRangeHP)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Dany Bàrbar
                            while ((barbarianDMG < BarbarianMinRangeDMG || barbarianDMG > BarbarianMaxRangeDMG) && statsTries > 0)
                            {
                                Console.Write(MsgBarbarianDMG);
                                barbarianDMG = Convert.ToDouble(Console.ReadLine());

                                if (barbarianDMG < BarbarianMinRangeDMG || barbarianDMG > BarbarianMaxRangeDMG)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Reducció de dany Bàrbar
                            while ((barbarianReduct < BarbarianMinRangeReduct || barbarianReduct > BarbarianMaxRangeReduct) && statsTries > 0)
                            {
                                Console.Write(MsgBarbarianReduct);
                                barbarianReduct = Convert.ToDouble(Console.ReadLine());

                                if (barbarianReduct < BarbarianMinRangeReduct || barbarianReduct > BarbarianMaxRangeReduct)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Comprova si tots els stats de l'arquera son correctes per a poder continuar cap al següent personatge
                            if (!(barbarianHP < BarbarianMinRangeHP || barbarianHP > BarbarianMaxRangeHP) && !(barbarianDMG < BarbarianMinRangeDMG || barbarianDMG > BarbarianMaxRangeDMG) && !(barbarianReduct < BarbarianMinRangeReduct || barbarianReduct > BarbarianMaxRangeReduct))
                            {

                                barbarianCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                Console.ReadKey();
                                characterTries--;
                            }
                        }

                        // Estadístiques Maga
                        mageCompleted = false;

                        while (characterTries > 0 && !(mageCompleted))
                        {

                            Console.Clear();
                            Console.Write(MsgDecorationMage);

                            statsTries = 3;
                            mageHP = 0;
                            mageDMG = 0;
                            mageReduct = 0;

                            // Vida Maga
                            while ((mageHP < MageMinRangeHP || mageHP > MageMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgMageHP);
                                mageHP = Convert.ToDouble(Console.ReadLine());
                                mageMaxHP = mageHP;

                                if (mageHP < MageMinRangeHP || mageHP > MageMaxRangeHP)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Dany Maga
                            while ((mageDMG < MageMinRangeDMG || mageDMG > MageMaxRangeDMG) && statsTries > 0)
                            {
                                Console.Write(MsgMageDMG);
                                mageDMG = Convert.ToDouble(Console.ReadLine());

                                if (mageDMG < MageMinRangeDMG || mageDMG > MageMaxRangeDMG)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Reducció de dany Maga
                            while ((mageReduct < MageMinRangeReduct || mageReduct > MageMaxRangeReduct) && statsTries > 0)
                            {
                                Console.Write(MsgMageReduct);
                                mageReduct = Convert.ToDouble(Console.ReadLine());

                                if (mageReduct < MageMinRangeReduct || mageReduct > MageMaxRangeReduct)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Comprova si tots els stats del mag son correctes per a poder continuar cap al següent personatge
                            if (!(mageHP < MageMinRangeHP || mageHP > MageMaxRangeHP) && !(mageDMG < MageMinRangeDMG || mageDMG > MageMaxRangeDMG) && !(mageReduct < MageMinRangeReduct || mageReduct > MageMaxRangeReduct))
                            {

                                mageCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                Console.ReadKey();
                                characterTries--;
                            }
                        }

                        // Estadístiques Druida
                        druidCompleted = false;

                        while (characterTries > 0 && !(druidCompleted))
                        {

                            Console.Clear();
                            Console.Write(MsgDecorationDruid);

                            statsTries = 3;
                            druidHP = 0;
                            druidDMG = 0;
                            druidReduct = 0;

                            // Vida Druida
                            while ((druidHP < DruidMinRangeHP || druidHP > DruidMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgDruidHP);
                                druidHP = Convert.ToDouble(Console.ReadLine());
                                druidMaxHP = druidHP;

                                if (druidHP < DruidMinRangeHP || druidHP > DruidMaxRangeHP)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Dany Druida
                            while ((druidDMG < DruidMinRangeDMG || druidDMG > DruidMaxRangeDMG) && statsTries > 0)
                            {
                                Console.Write(MsgDruidDMG);
                                druidDMG = Convert.ToDouble(Console.ReadLine());

                                if (druidDMG < DruidMinRangeDMG || druidDMG > DruidMaxRangeDMG)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Reducció de dany Druida
                            while ((druidReduct < DruidMinRangeReduct || druidReduct > DruidMaxRangeReduct) && statsTries > 0)
                            {
                                Console.Write(MsgDruidReduct);
                                druidReduct = Convert.ToDouble(Console.ReadLine());

                                if (druidReduct < DruidMinRangeReduct || druidReduct > DruidMaxRangeReduct)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Comprova si tots els stats del druida son correctes per a poder continuar cap al següent personatge
                            if (!(druidHP < DruidMinRangeHP || druidHP > DruidMaxRangeHP) && !(druidDMG < DruidMinRangeDMG || druidDMG > DruidMaxRangeDMG) && !(druidReduct < DruidMinRangeReduct || druidReduct > DruidMaxRangeReduct))
                            {

                                druidCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                Console.ReadKey();
                                characterTries--;
                            }
                        }

                        // Estadístiques Monstre
                        monsterCompleted = false;

                        while (characterTries > 0 && !(monsterCompleted))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(MsgDecorationMonster);

                            statsTries = 3;
                            monsterHP = 0;
                            monsterDMG = 0;
                            monsterReduct = 0;

                            // Vida Monstre
                            while ((monsterHP < MonsterMinRangeHP || monsterHP > MonsterMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgMonsterHP);
                                monsterHP = Convert.ToDouble(Console.ReadLine());

                                if (monsterHP < MonsterMinRangeHP || monsterHP > MonsterMaxRangeHP)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Dany Monstre
                            while ((monsterDMG < MonsterMinRangeDMG || monsterDMG > MonsterMaxRangeDMG) && statsTries > 0)
                            {
                                Console.Write(MsgMonsterDMG);
                                monsterDMG = Convert.ToDouble(Console.ReadLine());

                                if (monsterDMG < MonsterMinRangeDMG || monsterDMG > MonsterMaxRangeDMG)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Reducció de dany Monstre
                            while ((monsterReduct < MonsterMinRangeReduct || monsterReduct > MonsterMaxRangeReduct) && statsTries > 0)
                            {
                                Console.Write(MsgMonsterReduct);
                                monsterReduct = Convert.ToDouble(Console.ReadLine());

                                if (monsterReduct < MonsterMinRangeReduct || monsterReduct > MonsterMaxRangeReduct)
                                {
                                    Console.WriteLine(MsgInputNotValid);
                                    statsTries--;
                                }
                            }

                            // Comprova si tots els stats del druida son correctes per a poder continuar cap al següent personatge
                            if (!(monsterHP < MonsterMinRangeHP || monsterHP > MonsterMaxRangeHP) && !(monsterDMG < MonsterMinRangeDMG || monsterDMG > MonsterMaxRangeDMG) && !(monsterReduct < MonsterMinRangeReduct || monsterReduct > MonsterMaxRangeReduct))
                            {

                                monsterCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                Console.ReadKey();
                                characterTries--;
                            }
                        }

                        // Comprova si l'usuari s'ha quedat sense intents
                        if (characterTries == 0)
                        {
                            Console.WriteLine(MsgOutOfTriesCharacters);
                            break;
                        }




                        // Joc

                        Console.WriteLine("\n - " + MsgBattle);
                        Console.ReadKey();

                        turn = 1;
                        turnTries = 3;

                        // Aquest while s'executa mentre hi quedi un personatge viu, el monstre no hagi mort i hi quedin intents
                        while ((archerHP > 0 || barbarianHP > 0 || mageHP > 0 || druidHP > 0) && monsterHP > 0 && turnTries > 0)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;

                            //Cada torn resta un al cooldown de les habilitats si està actiu

                            if (archerSpecialCooldown > 0) archerSpecialCooldown--;

                            if(barbarianSpecialCooldown > 0) barbarianSpecialCooldown--;
                            if(barbarianReductSpecialTurns > 0) barbarianReductSpecialTurns--;

                            if(mageSpecialCooldown > 0) mageSpecialCooldown--; 

                            if(druidSpecialCooldown > 0) druidSpecialCooldown--;

                            turnTries = 3;

                            // Torn Arquera
                            while (turnTries > 0 && turnEnded == false && archerHP > 0 && monsterHP > 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("--- " + MsgTurn + turn + " ---\n\n");

                                Console.Write(" - " + MsgArcherName + " - \n" + MsgCharacterActions + MsgAction);
                                actionChosen = Convert.ToInt32(Console.ReadLine());

                                // Si la entrada no es vàlida, es treu un intent i es torna a executar el while
                                if(actionChosen < 1 || actionChosen > 3)
                                {
                                    turnTries--;
                                    Console.WriteLine(MsgInputNotValid);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    // Switch per a executar l'acció escollida pel jugador
                                    switch (actionChosen)
                                    {

                                        // Acció d'atacar
                                        case 1:
                                            monsterHP -= archerDMG * ((Percent - monsterReduct) / 100);
                                            Console.WriteLine("\n - " + MsgArcherName + " ataca a " + MsgMonsterName + " amb " + archerDMG + " de dany. El monstre es defensa i rep només " + (archerDMG * ((Percent - monsterReduct) / 100)) + " de dany.");
                                            Console.ReadKey();
                                            Console.WriteLine("\n - Monstre: " + monsterHP + " HP");
                                            currentArcherReduct = archerReduct;
                                            turnEnded = true;
                                            break;

                                        // Acció de protegir-se
                                        case 2:
                                            Console.WriteLine("\n - La " + MsgArcherName + MsgProtect);
                                            Console.ReadKey();
                                            currentArcherReduct = archerReduct * 2;
                                            turnEnded = true;
                                            break;

                                        // Acció d'habilitat especial. Si te cooldown, torna a demanar una acció.
                                        case 3:

                                            // Comprova si la pot utilitzar
                                            if(archerSpecialCooldown > 0)
                                            {
                                                Console.WriteLine("\n - " + MsgCooldown + archerSpecialCooldown + " torns per poder utilitzar-la.");
                                                turnEnded = true;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine(MsgArcherSpecial);
                                                currentArcherReduct = archerReduct;
                                                archerSpecialCooldown = 5;
                                                monsterStun = 2;
                                                turnEnded = true;
                                                break;
                                            }
                                    }
                                }
                            }

                            // Comprovem si s'han gastat tots els intents
                            if (turnTries > 0)
                            {
                                turnTries = 3;
                                Console.ReadKey();
                            }
                            turnEnded = false;

                            // Torn Bàrbar
                            while (turnTries > 0 && turnEnded == false && barbarianHP > 0 && monsterHP > 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("--- " + MsgTurn + turn + " ---\n\n");

                                Console.Write(" - " + MsgBarbarianName + " - \n" + MsgCharacterActions + MsgAction);
                                actionChosen = Convert.ToInt32(Console.ReadLine());

                                // Si la entrada no es vàlida, es treu un intent i es torna a executar el while
                                if (actionChosen < 1 || actionChosen > 3)
                                {
                                    turnTries--;
                                    Console.WriteLine(MsgInputNotValid);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    // Switch per a executar l'acció escollida pel jugador
                                    switch (actionChosen)
                                    {
                                        // Acció d'atacar
                                        case 1:
                                            monsterHP -= barbarianDMG * ((Percent - monsterReduct) / 100);
                                            Console.WriteLine("\n - " + MsgBarbarianName + " ataca a " + MsgMonsterName + " amb " + barbarianDMG + " de dany. El monstre es defensa i rep només " + (barbarianDMG * ((Percent - monsterReduct) / 100)) + " de dany.");
                                            Console.ReadKey();
                                            Console.WriteLine("\n - Monstre: " + monsterHP + " HP");

                                            if (barbarianSpecialCooldown <= 0)
                                            {
                                                currentBarbarianReduct = barbarianReduct;
                                            }

                                            turnEnded = true;
                                            break;

                                        // Acció de protegir-se
                                        case 2:

                                            if(barbarianSpecialCooldown > 0)
                                            {
                                                Console.WriteLine("\n - " + MsgBarbarianMaxReduct);
                                                Console.ReadKey();
                                                turnEnded = true;

                                            }
                                            else
                                            {

                                                Console.WriteLine("\n - El " + MsgBarbarianName + MsgProtect);
                                                Console.ReadKey();
                                                currentBarbarianReduct = barbarianReduct * 2;
                                                turnEnded = true;
                                            }

                                            break;

                                        // Acció d'habilitat especial. Si te cooldown, torna a demanar una acció.
                                        case 3:

                                            // Comprova si la pot utilitzar
                                            if (barbarianSpecialCooldown > 0)
                                            {
                                                Console.WriteLine("\n - " + MsgCooldown + barbarianSpecialCooldown + " torns per poder utilitzar-la.");
                                                turnEnded = true;
                                                break;
                                            }
                                            // Defensa al 100% si no té cooldown
                                            else
                                            {
                                                Console.WriteLine(MsgBarbarianSpecial);
                                                currentBarbarianReduct = Percent;
                                                barbarianSpecialCooldown = 5;
                                                barbarianReductSpecialTurns = 3;
                                                turnEnded = true;
                                                break;
                                            }
                                    }
                                }
                            }

                            if (turnTries > 0)
                            {
                                turnTries = 3;
                                Console.ReadKey();
                            }
                            turnEnded = false;

                            // Torn Maga
                            while (turnTries > 0 && turnEnded == false && mageHP > 0 && monsterHP > 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("--- " + MsgTurn + turn + " ---\n\n");

                                Console.Write(" - " + MsgMageName + " - \n" + MsgCharacterActions + MsgAction);
                                actionChosen = Convert.ToInt32(Console.ReadLine());

                                // Si la entrada no es vàlida, es treu un intent i es torna a executar el while
                                if (actionChosen < 1 || actionChosen > 3)
                                {
                                    turnTries--;
                                    Console.WriteLine(MsgInputNotValid);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    // Switch per a executar l'acció escollida pel jugador
                                    switch (actionChosen)
                                    {

                                        // Acció d'atacar
                                        case 1:
                                            monsterHP -= mageDMG * ((Percent - monsterReduct) / 100);
                                            Console.WriteLine("\n - " + MsgMageName + " ataca a " + MsgMonsterName + " amb " + mageDMG + " de dany. El monstre es defensa i rep només " + (mageDMG * ((Percent - monsterReduct) / 100)) + " de dany.");
                                            Console.ReadKey();
                                            Console.WriteLine("\n - Monstre: " + monsterHP + " HP");

                                            currentMageReduct = mageReduct;
                                            turnEnded = true;
                                            break;

                                        // Acció de protegir-se
                                        case 2:

                                            Console.WriteLine("\n - La " + MsgMageName + MsgProtect);
                                            Console.ReadKey();
                                            currentMageReduct = mageReduct * 2;
                                            turnEnded = true;
                                            break;


                                        // Acció d'habilitat especial. Si te cooldown, torna a demanar una acció.
                                        case 3:

                                            // Comprova si la pot utilitzar
                                            if (mageSpecialCooldown > 0)
                                            {
                                                Console.WriteLine(MsgCooldown + mageSpecialCooldown + " torns per poder utilitzar-la.");
                                                turnEnded = true;
                                                break;
                                            }
                                            // Fa el dany del seu atac per 3
                                            else
                                            {
                                                currentMageReduct = mageReduct;

                                                Console.WriteLine(MsgMageSpecial);

                                                monsterHP -= mageDMG * 3 * ((Percent - monsterReduct) / 100);
                                                Console.WriteLine("\n - " + MsgMageName + " ataca a " + MsgMonsterName + " amb " + (mageDMG*3) + " de dany. El monstre es defensa i rep només " + (mageDMG * 3 * ((Percent - monsterReduct) / 100)) + " de dany.");
                                                Console.ReadKey();
                                                Console.WriteLine("\n - Monstre: " + monsterHP + " HP");


                                                mageSpecialCooldown = 5;
                                                turnEnded = true;
                                                break;
                                            }
                                    }
                                }
                            }

                            if (turnTries > 0)
                            {
                                turnTries = 3;
                                Console.ReadKey();
                            }
                            turnEnded = false;

                            // Torn Druida
                            while (turnTries > 0 && turnEnded == false && druidHP > 0 && monsterHP > 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("--- " + MsgTurn + turn + " ---\n\n");

                                Console.Write(" - " + MsgDruidName + " - \n" + MsgCharacterActions + MsgAction);
                                actionChosen = Convert.ToInt32(Console.ReadLine());

                                // Si la entrada no es vàlida, es treu un intent i es torna a executar el while
                                if (actionChosen < 1 || actionChosen > 3)
                                {
                                    turnTries--;
                                    Console.WriteLine(MsgInputNotValid);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    // Switch per a executar l'acció escollida pel jugador
                                    switch (actionChosen)
                                    {

                                        // Acció d'atacar
                                        case 1:
                                            monsterHP -= druidDMG * ((Percent - monsterReduct) / 100);
                                            Console.WriteLine("\n - " + MsgDruidName + " ataca a " + MsgMonsterName + " amb " + druidDMG + " de dany. El monstre es defensa i rep només " + (druidDMG * ((Percent - monsterReduct) / 100)) + " de dany.");
                                            Console.ReadKey();
                                            Console.WriteLine("\n - Monstre: " + monsterHP + " HP");
                                            currentDruidReduct = druidReduct;
                                            turnEnded = true;
                                            break;

                                        // Acció de protegir-se
                                        case 2:

                                            Console.WriteLine("\n - El " + MsgDruidName + MsgProtect);
                                            Console.ReadKey();
                                            currentDruidReduct = druidReduct * 2;
                                            turnEnded = true;
                                            break;


                                        // Acció d'habilitat especial. Si te cooldown, torna a demanar una acció.
                                        case 3:

                                            // Comprova si la pot utilitzar
                                            if (druidSpecialCooldown > 0)
                                            {
                                                Console.WriteLine("\n - " + MsgCooldown + druidSpecialCooldown + " torns per poder utilitzar-la.");
                                                turnEnded = true;
                                                break;
                                            }
                                            // Cura a tothom 500 de vida si están vius
                                            else
                                            {
                                                currentDruidReduct = druidReduct;

                                                Console.WriteLine("\n - " + MsgDruidSpecial);

                                                // Comprovem que el personatge estigui viu
                                                if(archerHP > 0)
                                                {
                                                    // Operador ternari per que la cura no sobrepassi la vida màxima
                                                    archerHP = archerHP + DruidHeal > archerMaxHP ? archerHP = archerMaxHP : archerHP += DruidHeal;
                                                }

                                                // Comprovem que el personatge estigui viu
                                                if (barbarianHP > 0)
                                                {
                                                    // Operador ternari per que la cura no sobrepassi la vida màxima
                                                    barbarianHP = barbarianHP + DruidHeal > barbarianMaxHP ? barbarianHP = barbarianMaxHP : barbarianHP += DruidHeal;
                                                }

                                                // Comprovem que el personatge estigui viu
                                                if (mageHP > 0)
                                                {
                                                    // Operador ternari per que la cura no sobrepassi la vida màxima
                                                    mageHP = mageHP + DruidHeal > mageMaxHP ? mageHP = mageMaxHP : mageHP += DruidHeal;
                                                }

                                                // En el cas del Druida no comprovem si està viu ja que si no ho estigués no podria fer l'habilitat especial
                                                druidHP = druidHP + DruidHeal > druidMaxHP ? druidHP = druidMaxHP : druidHP += DruidHeal;

                                                druidSpecialCooldown = 5;
                                                turnEnded = true;
                                                break;
                                            }
                                    }
                                }
                            }

                            if (turnTries > 0)
                            {
                                turnTries = 3;
                                Console.ReadKey();
                            }
                            turnEnded = false;

                            
                            // Torn monstre

                            if(monsterHP > 0 && turnTries > 0) 
                            {

                                Console.Clear();
                                Console.WriteLine("--- " + MsgTurn + turn + " ---");
                                Console.ForegroundColor = ConsoleColor.Red;

                                // Comprovem si pot atacar o no depenent de si s'ha activat l'habilitat de l'arquera
                                if (monsterStun > 0)
                                {
                                    Console.WriteLine(MsgMonsterCantAttack);
                                    Console.ReadKey();
                                    monsterStun--;
                                }
                                else
                                {
                                    Console.WriteLine(MsgMonsterAttack + "\n");

                                    // Ataca a l'arquera si està viva

                                    if (archerHP > 0)
                                    {
                                        archerHP -= monsterDMG * ((Percent - currentArcherReduct) / 100);
                                        Console.WriteLine(MsgMonsterName + " ataca a " + MsgArcherName + " amb " + monsterDMG + " de dany. L'arquera es defensa i rep només " + (monsterDMG * ((Percent - currentArcherReduct) / 100)) + " de dany. Vida restant de l'Arquera: " + archerHP + " HP");

                                        // Comprovem si ha mort per comunicar-ho al jugador
                                        if (archerHP <= 0) Console.WriteLine(MsgArcherDied);
                                        Console.ReadKey();
                                    }

                                    // Ataca al bàrbar si està viu

                                    if (barbarianHP > 0)
                                    {
                                        barbarianHP -= monsterDMG * ((Percent - currentBarbarianReduct) / 100);
                                        Console.WriteLine(MsgMonsterName + " ataca a " + MsgBarbarianName + " amb " + monsterDMG + " de dany. El bàrbar es defensa i rep només " + (monsterDMG * ((Percent - currentBarbarianReduct) / 100)) + " de dany. Vida restant del bàrbar: " + barbarianHP + " HP");

                                        // Comprovem si ha mort per comunicar-ho al jugador
                                        if (barbarianHP <= 0) Console.WriteLine(MsgBarbarianDied);
                                        Console.ReadKey();
                                    }

                                    // Ataca a la maga si esta viva
                                    if (mageHP > 0)
                                    {
                                        mageHP -= monsterDMG * ((Percent - currentMageReduct) / 100);
                                        Console.WriteLine(MsgMonsterName + " ataca a " + MsgMageName + " amb " + monsterDMG + " de dany. La maga es defensa i rep només " + (monsterDMG * ((Percent - currentMageReduct) / 100)) + " de dany. Vida restant de la maga: " + mageHP + " HP");

                                        // Comprovem si ha mort per comunicar-ho al jugador
                                        if (mageHP <= 0) Console.WriteLine(MsgMageDied);
                                        Console.ReadKey();
                                    }

                                    // Ataca al druida si està viu
                                    if (druidHP > 0)
                                    {
                                        druidHP -= monsterDMG * ((Percent - currentDruidReduct) / 100);
                                        Console.WriteLine(MsgMonsterName + " ataca a " + MsgDruidName + " amb " + monsterDMG + " de dany. El druida es defensa i rep només " + (monsterDMG * ((Percent - currentDruidReduct) / 100)) + " de dany. Vida restant del druida: " + druidHP + " HP");

                                        // Comprovem si ha mort per comunicar-ho al jugador
                                        if (druidHP <= 0) Console.WriteLine(MsgDruidDied);
                                        Console.ReadKey();
                                    }

                                }

                            }
                            
                            turn++;
                        }

                        // Quan s'acaba la partida comprovem qui ha perdut

                        if (turnTries == 0)// Tanca el joc si t'has quedat sense intents
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(MsgOutOfTries + " Adéu!");
                            Console.ReadKey();
                            Console.Clear();
                            exitGame = true;
                        }
                        else if (monsterHP > 0) // Tanca el joc si t'has quedat sense intents
                        {
                            Console.WriteLine(MsgDecoration);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(MsgLost);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine(MsgDecoration);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(MsgWon);
                            Console.ReadKey();
                            Console.Clear();
                        }

                       



                        break;

                }

            }

        }

    }

}