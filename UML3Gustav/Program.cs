using Microsoft.VisualBasic;
using UML3Gustav;

MenuCatalog menu = new MenuCatalog();
Pizza piz1 = new Pizza(3, "Bobby's piz", "Den er bar' lækker", 65, ItemType.Pizza, false, false, true);
Pizza piz2 = new Pizza(7, "Cal'Zone", "Den er indbagt med svampe og skinke", 65, ItemType.Pizza, false, false, false);
Pizza piz3 = new Pizza(11, "Veggietale", "Til dem der ikke har en aftale med kaninerne", 65, ItemType.Pizza, true, false, false);
Beverage bev1 = new Beverage(65, "Fizzy water", "Vand med smag der bruser", 25, ItemType.Beverage, false, true, false, 33);
Beverage bev2 = new Beverage(64, "Hyldebrus", "Vand med smag der bruser", 25, ItemType.Beverage, true, true, false, 33);
Beverage bev3 = new Beverage(67, "Ayran", "Youghurt drik", 25, ItemType.Beverage, false, false, false, 33);
Pasta pas1 = new Pasta(14, "Bollo", "Pasta med kødsovs", 75, ItemType.Pasta, false, false);
Pasta pas2 = new Pasta(17, "Aglio e Olio", "Peber, olie og hvidløg", 65, ItemType.Pasta, true, false);
Topping top1 = new Topping(103, "Dres", "Til din piz med dres", 8, ItemType.Topping, false, false);
Sandwich san1 = new Sandwich(73, "Falafel", "Falafel sandwich", 50, ItemType.Sandwich, true, false);
Sandwich san2 = new Sandwich(75, "Bresola", "Bresola sandwich", 60, ItemType.Sandwich, false, false);
Side sid1 = new Side(92, "Pommes (lille)", "Kartofler der er snittet og friturestegt", 30, ItemType.Side, true, false);

List<IMenuItem> list = new List<IMenuItem>() { piz1, piz2, piz3, bev1, bev2, bev3, pas1, pas2, top1, san1, san2, sid1};
try
{
    menu.AddRange(list);
}catch(MenuItemNumberExist miex)
{
    Console.WriteLine(miex.Message);
}

Console.WriteLine("Printing Pizza Menu");
menu.PrintItemTypeMenu(ItemType.Pizza);

Pizza piz4 = new Pizza(3, "Det en fejl", "Den er bar' ik' go'", 65, ItemType.Pizza, false, false, true);

try { menu.Add(piz4); } catch(MenuItemNumberExist miex)
{
    Console.WriteLine($"\n {miex.Message} \n");
}
Console.WriteLine("Printing beverage menu");
menu.PrintBeveragesMenu();
Console.WriteLine("And these are vegan");
Console.WriteLine(string.Join("\n", menu.FindAllVegan(ItemType.Beverage)));
Console.WriteLine(string.Join("\n", menu.FindAllVegan(ItemType.Pasta)));
Console.WriteLine(string.Join("\n", menu.FindAllVegan(ItemType.Pizza)));
Console.WriteLine(string.Join("\n", menu.FindAllVegan(ItemType.Sandwich)));
Console.WriteLine(string.Join("\n", menu.FindAllVegan(ItemType.Side)));

Console.WriteLine();
Console.WriteLine($"This is the most expensive item: \n {menu.MostExpensiveMenuItem().PrintInfo()}");
menu.Update(3, new Pizza(3, "Bobby's piz", "Den er bar' lækker, og så er den med bernaise", 70, ItemType.Pizza, false, false, true));
menu.Delete(14);
Console.WriteLine("Deleting");
Console.WriteLine($"This is the most expensive item: \n {menu.MostExpensiveMenuItem().PrintInfo()}");

menu.PrintToppingsMenu();


