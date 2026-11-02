// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// yaroslav.Health = 75;

// Console.WriteLine(">>> Герой <<<");
// Console.WriteLine($"Имя: {yaroslav.Name}");
// Console.WriteLine($"Здоровье: {yaroslav.Health}");
// Console.WriteLine($"Уровень: {yaroslav.Level}");
// Console.WriteLine($"Опыт: {yaroslav.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 2 <<<");
// Console.WriteLine($"Имя: {anastasia.Name}");
// Console.WriteLine($"Здоровье: {anastasia.Health}");
// Console.WriteLine($"Уровень: {anastasia.Level}");
// Console.WriteLine($"Опыт: {anastasia.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 3 <<<");
// Console.WriteLine($"Имя: {artem.Name}");
// Console.WriteLine($"Здоровье: {artem.Health}");
// Console.WriteLine($"Уровень: {artem.Level}");
// Console.WriteLine($"Опыт: {artem.Experience}");

Game persona = new Game("Persona 3 Reload", "JRPG");
Game zelda = new Game("The Legend Of Zelda: Breath Of The Wild", "Cool");
Game gta = new Game("GTA VI", "Action");

persona.ReleaseYear = 2022;
persona.Rating = 10.0;

zelda.ReleaseYear = 2018;
zelda.Rating = 10.0;

gta.ReleaseYear = 2026;
gta.Rating = 10.0;

Console.WriteLine("Игра 1");
Console.WriteLine($"Название: {persona.Title}");
Console.WriteLine($"Жанр: {persona.Genre}");
Console.WriteLine($"Год выхода: {persona.ReleaseYear}");
Console.WriteLine($"Рейтинг: {persona.Rating}");

Console.WriteLine();

Console.WriteLine("Игра 2");
Console.WriteLine($"Название: {zelda.Title}");
Console.WriteLine($"Жанр: {zelda.Genre}");
Console.WriteLine($"Год выхода: {zelda.ReleaseYear}");
Console.WriteLine($"Рейтинг: {zelda.Rating}");

Console.WriteLine();

Console.WriteLine("Игра 3");
Console.WriteLine($"Название: {gta.Title}");
Console.WriteLine($"Жанр: {gta.Genre}");
Console.WriteLine($"Год выхода: {gta.ReleaseYear}");
Console.WriteLine($"Рейтинг: {gta.Rating}");
