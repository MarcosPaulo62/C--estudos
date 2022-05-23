using static System.Console;
using desafio01.src.Entities;

Knight hero = new Knight("Arus", 42, "Knight");
Ninja ninja = new Ninja("Wedge", 53, "Ninja");
Wizard wizard = new Wizard("Jennica", 21, "White Wizard");
BlackWizard black = new BlackWizard("Topapa", 75, "BlackWizard");

WriteLine(hero);

WriteLine(ninja.Attack());

WriteLine(wizard.Attack(1));

WriteLine(black.Attack(10));