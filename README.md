# GamesCollection

Zadání pro cvičení z Webů. Pracujte čistě pomocí LINQ metod a Entity Frameworku. Cílem je vytvoření aplikace s pohledy master/detail/detail. 
Na základě poskytnutého kódu vytvořte část aplikace obsahující seznam herních společností.
Důležité je udělat kód pro akce, ten pak provádět prostřednictvím parametrů URL, následně je možné dokončit UI.
Máte hotové připojení k databázi, modely databáze, migrace.

Vytvořte:
1. Na titulní stránce (Index)
   1. Zobrazení všech firem v tabulce
   1. Filtrování seznamu firem podle země původu
   1. Filtrování seznamu firem podle části názvu
   1. Filtrování seznamu firem podle mateřské firmy (eventuálně samostatnosti, některé firmy nemají vlastníka)
   1. Změna řazení seznamu firem podle země a podle názvu (pomocí odkazů v záhlaví tabulky, vzestupně i sestupně)
1. Vytvořte stránku Detail pro podrobnosti o herní společnosti
   1. Zobrazte na stránce jiné společnosti, které tato firma vlastní
   1. Zobrazte na stránce všechny hry, které tato firma produkovala nebo vyvíjela (je možné je vypisovat dohromady nebo ve dvou skupinách)
1. Vytvořte stránku Game pro podrobnosti o hře
1. Všechny stránky propojte pomocí odkazů

Další cvičení:
1. Vytvořte stránku pro přidávání nových firem
1. Vytvořte stránku pro editaci firmy
1. Vytvořte stránku pro odstranění firmy zobrazující kontrolní dotaz před smazáním položky. Firmu by nemělo být možné smazat pokud s ní souvisí jiné položky databáze (firmy nebo hry).
1. Vytvořte stránku pro zobrazení všech her zobrazující také vývojáře
   1. Umožněte hry filtrovat podle názvu
   1. Umožněte hry filtrovat podle vývojáře
   1. Umožněte hry filtrovat podle kategorií hry
1. Vytvořte stránku pro přidávání nových her
1. Vytvořte stránku pro editaci her
1. Vytvořte rozhraní pro přiřazování her do kategorií
