//MANY VARIABLES AND OTHER PIECES OF CODE ARE NOT USED DUE TO THE FACT I WANT TO FURTHER DEVELOP THIS PAST THE POINT OF THE HOMEWORK
#region variables
Random random = new Random();
//Stats
int buildchoice, level, vigor, mind, endurance, strength, dexterity, intelligence, faith, arcane;
//weapon slots
string RightWeaponOne, RightWeaponTwo, LeftWeaponOne, LeftWeaponTwo;
//spell slots
string SpellOne, SpellTwo, SpellThree, SpellFour;
//Build type
string build = "";
//name of the chosen attack
string attackname = "";
//damage of the chosen attack
int attackdamage;
//Response to wether or not they chose the right build
string answer;
//Number used to decide which spell the astrologer or prisoner use
int spell = random.Next(1, 4);
//locations
string StormveilCastle, RayaLucariaAcademy, LeyndellRoyalCapital, MountainTopsOfTheGiants, CrumblingFarumAzula, AshenCapital, Erdtree;
//Bosses
string Margit, Renala, GodfreyGS, Morgott, FireGiant, BeastClergyman, Maliketh, SirGideon, Godfrey, HoarahLoux, Radagon, EldenBeast;
//Stores the location in which the user is curretnly in
string location;
//boss damage numbers
int MargitDamage, RenalaDamage, GodfreyGSDamage, MorgottDamage, FireGiantDamage, BeastClergymanDamage, MalikethDamage, SirGideonDamage, GodfreyDamage, HoarahLouxDamage, RadagonDamage, EldenBeastDamage;
//boss health numbers
int MargitHealth = 200, RenalaHealth = 200, GodfreyGSHealth = 250, MorgottHealth = 260, FireGiantHealth = 400, BeastClergymanHealth = 200, MalikethHealth = 200, SirGideonHealth = 190, GodfreyHealth = 250, HoarahLouxHealth = 250, RadagonHealth = 300, EldenBeastHealth = 350;
#endregion

#region class chooser
Console.Clear();
Console.WriteLine("####### #       ######  ####### #     #       ######  ### #     #  #####          #    #####   #####  ####### \r\n#       #       #     # #       ##    #       #     #  #  ##    # #     #        ##   #     # #     # #       \r\n#       #       #     # #       # #   #       #     #  #  # #   # #             # #   #     # #     # #       \r\n#####   #       #     # #####   #  #  #       ######   #  #  #  # #  ####         #    ######  #####  ######  \r\n#       #       #     # #       #   # #       #   #    #  #   # # #     #         #         # #     #       # \r\n#       #       #     # #       #    ##       #    #   #  #    ## #     #         #   #     # #     # #     # \r\n####### ####### ######  ####### #     #       #     # ### #     #  #####        #####  #####   #####   #####  ");
Console.WriteLine("Welcome to the lands between tarnished, press any key to continue");
Console.ReadKey();
Console.Clear();
while (classChosen == true)
{
    Console.Clear();
    Console.WriteLine("What class would you like to be?\r\nVagabond (1) \r\nWarrior (2) \r\nHero (3) \r\nBandit (4) \r\nAstrologer (5) \r\nProphet (6) \r\nSamurai (7) \r\nPrisoner (8) \r\nConfessor (9) \r\nWretch (10)");
    buildchoice = Int32.Parse(Console.ReadLine());
    switch (buildchoice)
    {
        case 1:
            build = "Vagabond";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 9");
            Console.WriteLine("Vigor: 15 \r\nMind: 10 \r\nEndurance: 11 \r\nStrength: 14 \r\nDexterity: 13 \r\nIntelligence: 9 \r\nFaith: 9 \r\nArcane: 7");
            Console.WriteLine("Weapons: Longsword, Halberd");
            Console.WriteLine("Spells: None");
            level = 9;
            vigor = 15;
            mind = 10;
            endurance = 11;
            strength = 14;
            dexterity = 13;
            intelligence = 9;
            faith = 9;
            arcane = 7;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 2:
            build = "Warrior";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 8");
            Console.WriteLine("Vigor: 11 \r\nMind: 12 \r\nEndurance: 11 \r\nStrength: 10 \r\nDexterity: 16 \r\nIntelligence: 10 \r\nFaith: 8 \r\nArcane: 9");
            Console.WriteLine("Weapons: Scimitar, Scimitar");
            Console.WriteLine("Spells: None");
            level = 8;
            vigor = 11;
            mind = 12;
            endurance = 11;
            strength = 10;
            dexterity = 16;
            intelligence = 10;
            faith = 8;
            arcane = 9;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }       
            break;
        case 3:
            build = "Hero";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 7");
            Console.WriteLine("Vigor: 14 \r\nMind: 9 \r\nEndurance: 12 \r\nStrength: 16 \r\nDexterity: 9 \r\nIntelligence: 7 \r\nFaith: 8 \r\nArcane: 11");
            Console.WriteLine("Weapons: Battle Axe");
            Console.WriteLine("Spells: None");
            level = 7;
            vigor = 14;
            mind = 9;
            endurance = 12;
            strength = 16;
            dexterity = 9;
            intelligence = 7;
            faith = 8;
            arcane = 11;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 4:
            build = "Bandit";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 5");
            Console.WriteLine("Vigor: 10 \r\nMind: 11 \r\nEndurance: 10 \r\nStrength: 9 \r\nDexterity: 13 \r\nIntelligence: 9 \r\nFaith: 8 \r\nArcane: 14");
            Console.WriteLine("Weapons: Great Knife");
            Console.WriteLine("Spells: None");
            level = 5;
            vigor = 10;
            mind = 11;
            endurance = 10;
            strength = 9;
            dexterity = 13;
            intelligence = 9;
            faith = 8;
            arcane = 14;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 5:
            build = "Astrologer";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 6");
            Console.WriteLine("Vigor: 9 \r\nMind: 15 \r\nEndurance: 9 \r\nStrength: 8 \r\nDexterity: 12 \r\nIntelligence: 16 \r\nFaith: 7 \r\nArcane: 9");
            Console.WriteLine("Weapons: Astrologer's Staff");
            Console.WriteLine("Spells: Glintstone Pebble, Glintstone Arc");
            level = 6;
            vigor = 9;
            mind = 15;
            endurance = 9;
            strength = 8;
            dexterity = 12;
            intelligence = 16;
            faith = 7;
            arcane = 9;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 6:
            build = "Prophet";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 7");
            Console.WriteLine("Vigor: 10 \r\nMind: 14 \r\nEndurance: 8 \r\nStrength: 11 \r\nDexterity: 10 \r\nIntelligence: 7 \r\nFaith: 16 \r\nArcane: 10");
            Console.WriteLine("Weapons: Short Spear, Finger Seal");
            Console.WriteLine("Spells: Heal, Catch Flame");
            level = 7;
            vigor = 10;
            mind = 14;
            endurance = 8;
            strength = 11;
            dexterity = 10;
            intelligence = 7;
            faith = 16;
            arcane = 10;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 7:
            build = "Samurai";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 9");
            Console.WriteLine("Vigor: 12 \r\nMind: 11 \r\nEndurance: 13 \r\nStrength: 12 \r\nDexterity: 15 \r\nIntelligence: 9 \r\nFaith: 8 \r\nArcane: 8");
            Console.WriteLine("Weapons: Uchigatana");
            Console.WriteLine("Spells: None");
            level = 9;
            vigor = 12;
            mind = 11;
            endurance = 13;
            strength = 12;
            dexterity = 15;
            intelligence = 9;
            faith = 8;
            arcane = 8;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 8:
            build = "Prisoner";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 9");
            Console.WriteLine("Vigor: 11 \r\nMind: 12 \r\nEndurance: 11 \r\nStrength: 11 \r\nDexterity: 14 \r\nIntelligence: 14 \r\nFaith: 6 \r\nArcane: 9");
            Console.WriteLine("Weapons: Glintstone Staff");
            Console.WriteLine("Spells: Magic Glintblade");
            level = 9;
            vigor = 11;
            mind = 12;
            endurance = 11;
            strength = 11;
            dexterity = 14;
            intelligence = 14;
            faith = 6;
            arcane = 9;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 9:
            build = "Confessor";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 10");
            Console.WriteLine("Vigor: 10 \r\nMind: 13 \r\nEndurance: 10 \r\nStrength: 12 \r\nDexterity: 12 \r\nIntelligence: 9 \r\nFaith: 14 \r\nArcane: 9");
            Console.WriteLine("Weapons: Broadsword, Finger Seal");
            Console.WriteLine("Spells: Heal");
            level = 10;
            vigor = 10;
            mind = 13;
            endurance = 10;
            strength = 12;
            dexterity = 12;
            intelligence = 9;
            faith = 14;
            arcane = 9;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;
        case 10:
            build = "Wretch";
            Console.Clear();
            Console.WriteLine(build);
            Console.WriteLine("Level: 1");
            Console.WriteLine("Vigor: 10 \r\nMind: 10 \r\nEndurance: 10 \r\nStrength: 10 \r\nDexterity: 10 \r\nIntelligence: 10 \r\nFaith: 10 \r\nArcane: 10");
            Console.WriteLine("Weapons: Club");
            Console.WriteLine("Spells: None");
            level = 1;
            vigor = 10;
            mind = 10;
            endurance = 10;
            strength = 10;
            dexterity = 10;
            intelligence = 10;
            faith = 10;
            arcane = 10;
            Console.ReadKey();
            Console.WriteLine("Is this the class you want to choose");
            answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                classChosen = false;
                break;
            }
            break;


    }
}
#endregion

#region player damage calculator
if (build == "Vagabond")
{
    attackname = "Longsword";
    attackdamage = 25;
}
else if (build == "Warrior")
{
    attackname = "Scimitar";
    attackdamage = 22;
}
else if (build == "Hero")
{
    attackname = "Battle Axe";
    attackdamage = 27;
}
else if (build == "Thief")
{
    attackname = "Great Knife";
    attackdamage = 21;
}
else if (build == "Samurai")
{
    attackname = "Uchigatana";
    attackdamage = 23;
}
else if (build == "Wretch")
{
    attackname = "Club";
    attackdamage = 23;
}
else if (build == "Confessor")
{
    attackname = "Broadsword";
    attackdamage = 24;
}
else if (build == "Prophet")
{
    attackname = "Catch Flame";
    attackdamage = 27;
}
else if (build == "Astrolgoer" || build == "Prisoner")
{
    switch (spell)
    {
        case 1:
            attackname = "Magic Glintbalde";
            if (build == "Prisoner")
            {
                attackdamage = 22 * 2;
            }
            break;
        case 2:
            attackname = "Magic Glintbalde";
            if (build == "Prisoner")
            {
                attackdamage = 22 * 2;
            }
            break;
        case 3:
            attackname = "Glintstone Arc";
            if (build == "Astrologer")
            {
                attackdamage = 15 * 2;
            }
            break;
    }
}
#endregion

#region boss damage calculator
//Margit's Damage
MargitDamage = random.Next(29, 36);
#endregion

#region Stormveil Castle
Console.Clear();
Console.WriteLine("You have chosen to be " + build);
location = "Stormveil Castle";
Console.WriteLine("You're currently in " + location);
Console.WriteLine("You have encountered Margit the Fell Omen");
Console.WriteLine(MargitHealth);
Console.WriteLine("Margit used Staff Swing and did " + MargitDamage + " damage to your " + build);
Console.WriteLine("You attacked using " + attackname + "");
Console.ReadKey();
#endregion
