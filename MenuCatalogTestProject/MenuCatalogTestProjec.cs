using UML3Gustav;
namespace MenuCatalogTestProject
{
    [TestClass]
    public class MenuCatalogTestProjec
    {
        private MenuCatalog menu = new MenuCatalog();

        private void Setup()
        {
            Pizza piz2 = new Pizza(7, "Cal'Zone", "Den er indbagt med svampe og skinke", 65, ItemType.Pizza, false, false, false);
            Pizza piz3 = new Pizza(11, "Veggietale", "Til dem der ikke har en aftale med kaninerne", 65, ItemType.Pizza, true, false, false);
            Beverage bev2 = new Beverage(64, "Hyldebrus", "Vand med smag der bruser", 25, ItemType.Beverage, true, true, false, 33);
            Beverage bev3 = new Beverage(67, "Ayran", "Youghurt drik", 25, ItemType.Beverage, false, false, false, 33);
            Pasta pas1 = new Pasta(14, "Bollo", "Pasta med kødsovs", 75, ItemType.Pasta, false, false);
            Pasta pas2 = new Pasta(17, "Aglio e Olio", "Peber og hvidløg", 65, ItemType.Pasta, true, false);
            Topping top1 = new Topping(103, "Dres", "Til din piz med dres", 8, ItemType.Topping, false, false);
            Sandwich san1 = new Sandwich(73, "Falafel", "Falafel sandwich", 50, ItemType.Sandwich, true, false);
            Sandwich san2 = new Sandwich(75, "Bresola", "Bresola sandwich", 60, ItemType.Sandwich, false, false);
            Side sid1 = new Side(92, "Pommes (lille)", "Kartofler der er snittet og friturestegt", 30, ItemType.Side, true, false);

            List<IMenuItem> list = new List<IMenuItem>() { piz2, piz3, bev2, bev3, pas1, pas2, top1, san1, san2, sid1 };
            try
            {
                menu.AddRange(list);
            }
            catch (MenuItemNumberExist miex)
            {
                Console.WriteLine(miex.Message);
            }
            menu.PrintItemTypeMenu(ItemType.Pizza);

        }
        [TestMethod]
        public void TestMethodDelete()
        {
            Setup();

            int count = menu.Count;
            menu.Delete(17);

            Assert.AreEqual(count-1, menu.Count);
        }

        [TestMethod]
        public void TestMethodUpdate()
        {
            Setup();

            Pizza piz = new Pizza(13, "Veggietale", "Med aubergine, squash, svampe og artiskok", 75, ItemType.Pizza, true, false, false);
            menu.Update(11, piz);

            Assert.AreEqual(piz, menu.Search(13));

        }

        [TestMethod]
        public void TestMethodMostExpensive()
        {
            Setup();
            //menu.Add(new Beverage(42, "Bare den dyeste, tak", "Den er ret god", 1000, ItemType.Beverage, true, true, true, 42));
            //Assert.AreEqual(1000, menu.MostExpensiveMenuItem().Price);
            Assert.AreEqual(75, menu.MostExpensiveMenuItem().Price);

        }

        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberExist))]
        public void TestMethodAddFail()
        {
            Setup();
            menu.Add(new Sandwich(73, "Knoppers", "Til når kl er 10", 10, ItemType.Sandwich, false, false));
        }

        [TestMethod]
        public void TestMethodFindVegan()
        {
            Setup();
            Sandwich san1 = new Sandwich(74, "Hallumi", "Hallumi sandwich", 50, ItemType.Sandwich, true, false);
            Sandwich san2 = new Sandwich(76, "Vegansk kylling", "Vegansk kylling sandwich", 50, ItemType.Sandwich, true, false);
            menu.Add(san1);
            menu.Add(san2);
            List<IMenuItem> vegan = menu.FindAllVegan(ItemType.Sandwich);
            foreach (var item in vegan)
            {
                Assert.IsTrue(item.IsVegan);
            }
        }
    }
}