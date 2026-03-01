using System;
using System.Collections.Generic;

public class GameObject : IDisposable
{
    public string Name { get; set; }
    private bool disposed = false;

    public GameObject(string name)
    {
        Name = name;
        Console.WriteLine($"Создан объект: {Name}");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine($"Освобождены управляемые ресурсы объекта: {Name}");
            }

            Console.WriteLine($"Освобождены неуправляемые ресурсы объекта: {Name}");
            disposed = true;
        }
    }

    ~GameObject()
    {
        Dispose(false);
    }
}

public class GameObjectManager : IDisposable
{
    private List<GameObject> gameObjects = new List<GameObject>();
    private bool disposed = false;

    public void AddObject(GameObject gameObject)
    {
        if (gameObject == null)
            throw new ArgumentNullException(nameof(gameObject));

        gameObjects.Add(gameObject);
        Console.WriteLine($"Добавлен объект: {gameObject.Name}");
    }

    public bool RemoveObject(GameObject gameObject)
    {
        if (gameObject == null)
            return false;

        bool removed = gameObjects.Remove(gameObject);
        if (removed)
        {
            gameObject.Dispose();
            Console.WriteLine($"Удален объект: {gameObject.Name}");
        }
        return removed;
    }

    public void Clear()
    {
        foreach (var gameObject in gameObjects)
        {
            gameObject.Dispose();
        }
        gameObjects.Clear();
        Console.WriteLine("Все объекты удалены");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Clear();
            }
            disposed = true;
        }
    }

    ~GameObjectManager()
    {
        Dispose(false);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ТЕСТИРОВАНИЕ СИСТЕМЫ УПРАВЛЕНИЯ ИГРОВЫМИ ОБЪЕКТАМИ \n");

        using (GameObjectManager manager = new GameObjectManager())
        {
            manager.AddObject(new GameObject("Игрок"));
            manager.AddObject(new GameObject("Враг 1"));
            manager.AddObject(new GameObject("Враг 2"));

            GameObject enemy = new GameObject("Враг 3");
            manager.AddObject(enemy);
            manager.RemoveObject(enemy);

            Console.WriteLine("\nСостояние перед очисткой");
        }

        Console.WriteLine("\nТЕСТ ЗАВЕРШЕН");

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}


using System;
using System.Collections.Generic;

public class Texture : IDisposable
{
    public string Name { get; set; }
    private bool disposed = false;

    public Texture(string name)
    {
        Name = name;
        Console.WriteLine($"Загружена текстура: {Name}");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine($"Освобождена текстура: {Name}");
            }
            disposed = true;
        }
    }

    ~Texture()
    {
        Dispose(false);
    }
}

public class TextureManager : IDisposable
{
    private Dictionary<string, Texture> textures = new Dictionary<string, Texture>();
    private bool disposed = false;

    public Texture LoadTexture(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя текстуры не может быть пустым", nameof(name));

        if (!textures.ContainsKey(name))
        {
            textures[name] = new Texture(name);
            Console.WriteLine($"Текстура '{name}' загружена в менеджер");
        }
        else
        {
            Console.WriteLine($"Текстура '{name}' уже загружена, возвращается существующая");
        }

        return textures[name];
    }

    public bool UnloadTexture(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return false;

        if (textures.TryGetValue(name, out Texture texture))
        {
            texture.Dispose();
            textures.Remove(name);
            Console.WriteLine($"Выгружена текстура: {name}");
            return true;
        }

        Console.WriteLine($"Текстура '{name}' не найдена для выгрузки");
        return false;
    }

    public void Clear()
    {
        foreach (var texture in textures.Values)
        {
            texture.Dispose();
        }
        int count = textures.Count;
        textures.Clear();
        Console.WriteLine($"Все текстуры ({count} шт.) выгружены");
    }

    public bool HasTexture(string name)
    {
        return textures.ContainsKey(name);
    }

    public int GetTextureCount()
    {
        return textures.Count;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Clear();
            }
            disposed = true;
        }
    }

    ~TextureManager()
    {
        Dispose(false);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ТЕСТИРОВАНИЕ СИСТЕМЫ УПРАВЛЕНИЯ ТЕКСТУРАМИ\n");

        using (TextureManager textureManager = new TextureManager())
        {
            textureManager.LoadTexture("Дерево");
            textureManager.LoadTexture("Камень");
            textureManager.LoadTexture("Трава");
            textureManager.LoadTexture("Дерево");

            Console.WriteLine($"\nТекущее количество текстур: {textureManager.GetTextureCount()}");

            textureManager.UnloadTexture("Камень");
            textureManager.UnloadTexture("Неизвестная текстура");

            Console.WriteLine($"\nТекущее количество текстур: {textureManager.GetTextureCount()}");

            textureManager.Clear();

            Console.WriteLine($"\nКоличество текстур после очистки: {textureManager.GetTextureCount()}");
        }

        Console.WriteLine("\nТЕСТ ЗАВЕРШЕН");

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}


using System;
using System.Collections.Generic;

public class Sound : IDisposable
{
    public string Name { get; set; }
    private bool disposed = false;

    public Sound(string name)
    {
        Name = name;
        Console.WriteLine($"Загружен звук: {Name}");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine($"Освобождён звук: {Name}");
            }
            disposed = true;
        }
    }

    ~Sound()
    {
        Dispose(false);
    }
}

public class SoundManager : IDisposable
{
    private Dictionary<string, Sound> sounds = new Dictionary<string, Sound>();
    private bool disposed = false;

    public Sound LoadSound(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя звука не может быть пустым", nameof(name));

        if (!sounds.ContainsKey(name))
        {
            sounds[name] = new Sound(name);
            Console.WriteLine($"Звук '{name}' загружен в менеджер");
        }
        else
        {
            Console.WriteLine($"Звук '{name}' уже загружен, возвращается существующий");
        }

        return sounds[name];
    }

    public bool UnloadSound(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return false;

        if (sounds.TryGetValue(name, out Sound sound))
        {
            sound.Dispose();
            sounds.Remove(name);
            Console.WriteLine($"Выгружен звук: {name}");
            return true;
        }

        Console.WriteLine($"Звук '{name}' не найден для выгрузки");
        return false;
    }

    public void Clear()
    {
        int count = sounds.Count;
        foreach (var sound in sounds.Values)
        {
            sound.Dispose();
        }
        sounds.Clear();
        Console.WriteLine($"Все звуки ({count} шт.) выгружены");
    }

    public bool HasSound(string name)
    {
        return sounds.ContainsKey(name);
    }

    public int GetSoundCount()
    {
        return sounds.Count;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Clear();
            }
            disposed = true;
        }
    }

    ~SoundManager()
    {
        Dispose(false);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ТЕСТИРОВАНИЕ СИСТЕМЫ УПРАВЛЕНИЯ ЗВУКАМИ\n");

        using (SoundManager soundManager = new SoundManager())
        {
            soundManager.LoadSound("Музыка");
            soundManager.LoadSound("Эффект 1");
            soundManager.LoadSound("Эффект 2");
            soundManager.LoadSound("Музыка");

            Console.WriteLine($"\nТекущее количество звуков: {soundManager.GetSoundCount()}");

            soundManager.UnloadSound("Эффект 1");
            soundManager.UnloadSound("Неизвестный звук");

            Console.WriteLine($"\nТекущее количество звуков: {soundManager.GetSoundCount()}");

            soundManager.Clear();

            Console.WriteLine($"\nКоличество звуков после очистки: {soundManager.GetSoundCount()}");
        }

        Console.WriteLine("\nТЕСТ ЗАВЕРШЁН");

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
