// В алфавите 4 буквы "а","и","с","в". покажите все слова, состоящие из Т букв этого алфавита. Рекурсия
int n = 1;
void FindWorlds (string alphabet, char[] world, int length = 0)
{
    if (length == world.Length)
    {
        Console.WriteLine($"{n++} {new String(world)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        world[length] = alphabet[i];
        FindWorlds(alphabet, world, length + 1);
    }
}

FindWorlds("аисв",new char[5]);