
using FirstApp;

{
    string[] meyveler = { "Elma", "Karpuz", "Vişne", "Kivi" };
	for (int i = 0; i < meyveler.Length; i++)
		Console.WriteLine($"{i+1} Ürün Adı : " + meyveler[i]);

	Console.WriteLine("---------------");

	foreach (var item in meyveler)
		Console.WriteLine("Ürün Adı : " + item);

	Console.WriteLine("---------------");

	List<string> listMeyveler = new List<string>();
	listMeyveler.Add("Visne");
	listMeyveler.Add("Elma");
	listMeyveler.Add("Kivi");
	listMeyveler.Add("Karpuz");

	foreach (var item in listMeyveler)
		Console.WriteLine("List Meyve Ürün Adı : " + item);


	Console.WriteLine("--------------");



}





