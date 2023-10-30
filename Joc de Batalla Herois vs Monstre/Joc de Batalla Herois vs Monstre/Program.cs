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
            const int BarbarianMinRangeHP = 3000, BarbarianMaxRangeHP = 3750, BarbarianMinRangeDMG = 150, BarbarianMaxRangeDMG = 250, BarbarianMinRangeReduct = 35, BarbarianMaxRangeReduct = 45;
            const int MageMinRangeHP = 1000, MageMaxRangeHP = 1500, MageMinRangeDMG = 300, MageMaxRangeDMG = 350, MageMinRangeReduct = 20, MageMaxRangeReduct = 35;
            const int DruidMinRangeHP = 2000, DruidMaxRangeHP = 2500, DruidMinRangeDMG = 70, DruidMaxRangeDMG = 120, DruidMinRangeReduct = 25, DruidMaxRangeReduct = 40;
            const int MonsterMinRangeHP = 9000, MonsterMaxRangeHP = 12000, MonsterMinRangeDMG = 250, MonsterMaxRangeDMG = 400, MonsterMinRangeReduct = 20, MonsterMaxRangeReduct = 30;

            const string MsgAction = "Introdueix la teva acció: ";
            const string MsgCharacterActions = "\n1. Atacar\n2. Protegir-se\n3. Habilitat especial";
            const string MsgInputNotValid = "Aquesta entrada no és vàlida.";
            const string MsgOutOfTries = "S'han acabat els intents.";
            const string MsgPlay = "\n1. Iniciar una nova batalla";
            const string MsgQuit = "2. Sortir\n";

            const string MsgOutOfTriesStats = "T'has equivocat 3 vegades, torna a introduir els atributs.";
            const string MsgOutOfTriesCharacters = "T'has equivocat 3 vegades donant atributs als personatges, tornes al menu principal.";

            const string MsgArcherName = "Arquera";
            const string MsgArcherHP = "Introdueix la vida de l'arquera (entre 1500 i 2000): ";
            const string MsgArcherDMG = "Introdueix l'atac de l'arquera (entre 180 i 300): ";
            const string MsgArcherReduct = "Introdueix la reducció de dany de l'arquera (entre 25% i 40%): ";

            const string MsgBarbarianName = "Bàrbar";
            const string MsgBarbarianHP = "Introdueix la vida del bàrbar (entre 3000 i 3750): ";
            const string MsgBarbarianDMG = "Introdueix l'atac del bàrbar (entre 150 i 250): ";
            const string MsgBarbarianReduct = "Introdueix la reducció de dany del bàrbar (entre 35% i 45%): ";

            const string MsgMageName = "Maga";
            const string MsgMageHP = "Introdueix la vida del mag (entre 1000 i 1500): ";
            const string MsgMageDMG = "Introdueix l'atac del mag (entre 300 i 350): ";
            const string MsgMageReduct = "Introdueix la reducció de dany del mag (entre 20% i 35%): ";

            const string MsgDruidName = "Druida";
            const string MsgDruidHP = "Introdueix la vida del druida (entre 2000 i 2500): ";
            const string MsgDruidDMG = "Introdueix l'atac del druida (entre 70 i 120): ";
            const string MsgDruidReduct = "Introdueix la reducció de dany del druida (entre 25% i 40%): ";

            const string MsgMonsterName = "Monstre";
            const string MsgMonsterHP = "Introdueix la vida del monstre (entre 9000 i 12000): ";
            const string MsgMonsterDMG = "Introdueix l'atac del monstre (entre 250 i 400): ";
            const string MsgMonsterReduct = "Introdueix la reducció de dany del monstre (entre 20% i 30%): ";

            const string MsgBattle = "Comença la batalla!";
            const string MsgTurn = "Torn ";

            int startGame, menuTries, statsTries = 3, characterTries = 3, turnTries = 3, actionChosen = 0, turn = 1;

            double archerHP = 0, archerDMG = 0, archerReduct = 0;
            double barbarianHP = 0, barbarianDMG = 0, barbarianReduct = 0;
            double mageHP = 0, mageDMG = 0, mageReduct = 0;
            double druidHP = 0, druidDMG = 0, druidReduct = 0;
            double monsterHP = 0, monsterDMG = 0, monsterReduct = 0;

        

            bool exitGame = false, archerCompleted = false, barbarianCompleted = false, mageCompleted = false, druidCompleted = false, monsterCompleted = false;

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

                            // Vida Arquera
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

                            // Vida Bàrbar
                            while ((barbarianHP < BarbarianMinRangeHP || barbarianHP > BarbarianMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgBarbarianHP);
                                barbarianHP = Convert.ToDouble(Console.ReadLine());

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
                            if (!((barbarianHP < BarbarianMinRangeHP || barbarianHP > BarbarianMaxRangeHP) && (barbarianDMG < BarbarianMinRangeDMG || barbarianDMG > BarbarianMaxRangeDMG) && (barbarianReduct < BarbarianMinRangeReduct || barbarianReduct > BarbarianMaxRangeReduct)))
                            {

                                barbarianCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                characterTries--;
                            }
                        }

                        //Maga
                        mageCompleted = false;

                        while (characterTries > 0 && !(mageCompleted))
                        {

                            statsTries = 3;
                            mageHP = 0;
                            mageDMG = 0;
                            mageReduct = 0;

                            // Vida Maga
                            while ((mageHP < MageMinRangeHP || mageHP > MageMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgMageHP);
                                mageHP = Convert.ToDouble(Console.ReadLine());

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
                            if (!((mageHP < MageMinRangeHP || mageHP > MageMaxRangeHP) && (mageDMG < MageMinRangeDMG || mageDMG > MageMaxRangeDMG) && (mageReduct < MageMinRangeReduct || mageReduct > MageMaxRangeReduct)))
                            {

                                mageCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                characterTries--;
                            }
                        }

                        //Druida
                        druidCompleted = false;

                        while (characterTries > 0 && !(druidCompleted))
                        {

                            statsTries = 3;
                            druidHP = 0;
                            druidDMG = 0;
                            druidReduct = 0;

                            // Vida Druida
                            while ((druidHP < DruidMinRangeHP || druidHP > DruidMaxRangeHP) && statsTries > 0)
                            {
                                Console.Write(MsgDruidHP);
                                druidHP = Convert.ToDouble(Console.ReadLine());

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
                            if (!((druidHP < DruidMinRangeHP || druidHP > DruidMaxRangeHP) && (druidDMG < DruidMinRangeDMG || druidDMG > DruidMaxRangeDMG) && (druidReduct < DruidMinRangeReduct || druidReduct > DruidMaxRangeReduct)))
                            {

                                druidCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                characterTries--;
                            }
                        }

                        //Monstre
                        monsterCompleted = false;

                        while (characterTries > 0 && !(monsterCompleted))
                        {

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
                            if (!((monsterHP < MonsterMinRangeHP || monsterHP > MonsterMaxRangeHP) && (monsterDMG < MonsterMinRangeDMG || monsterDMG > MonsterMaxRangeDMG) && (monsterReduct < MonsterMinRangeReduct || monsterReduct > MonsterMaxRangeReduct)))
                            {

                                monsterCompleted = true;

                            }
                            else
                            {
                                Console.WriteLine(MsgOutOfTriesStats);
                                characterTries--;
                            }
                        }

                        // Comprova si l'usuari s'ha quedat sense intents
                        if (characterTries == 0)
                        {
                            Console.WriteLine(MsgOutOfTriesCharacters);
                            break;
                        }

                        string MsgArcherAttack = "Arquera ataca a Monstre amb " + archerDMG + " de dany. El monstre es defensa i rep només " + (archerDMG * (barbarianReduct / 100)) + " de dany. Vida restant del Monstre: " + monsterHP;


                        // Joc

                        Console.WriteLine(MsgBattle);

                        turn = 1;

                        while((archerHP > 0 || barbarianHP > 0 || mageHP > 0 || druidHP > 0) && monsterHP > 0 && turnTries > 0)
                        {   
                            
                            Console.WriteLine(MsgTurn + turn);

                            // Torn Arquera
                            while(turnTries > 0)
                            {
                                Console.WriteLine(MsgArcherName + " - " + MsgAction + MsgCharacterActions);
                                actionChosen = Convert.ToInt32(Console.ReadLine());

                                if(actionChosen < 1 || actionChosen > 3)
                                {
                                    turnTries--;
                                    Console.WriteLine(MsgInputNotValid);
                                }
                                else
                                {
                                    switch (actionChosen)
                                    {
                                        case 1:
                                            monsterHP -= archerDMG * (barbarianReduct / 100);
                                            Console.WriteLine(MsgArcherName + " ataca a " + MsgMonsterName + " amb " + archerDMG + " de dany. El monstre es defensa i rep només " + (archerDMG - archerDMG*(barbarianReduct / 100)) + " de dany. Vida restant del Monstre: " + monsterHP);
                                            break;
                                    }
                                }

                            }

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