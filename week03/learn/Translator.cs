public class Translator
{
    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car")); // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???

        Console.WriteLine();

        englishToGerman = new Translator();
        englishToGerman.AddWord("Coding", "Codierung");
        englishToGerman.AddWord("Smart", "Schlau");
        englishToGerman.AddWord("Error", "Fehler");
        Console.WriteLine(englishToGerman.Translate("Coding")); // Codierung 
        Console.WriteLine(englishToGerman.Translate("Smart")); // Schlau 
        Console.WriteLine(englishToGerman.Translate("Error")); // Fehler
        Console.WriteLine(englishToGerman.Translate("Computer")); // ???
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord)
    {
        _words.Add(fromWord, toWord);
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        var word = "";
        
        if(_words.ContainsKey(fromWord)) {
            word = _words[fromWord];
        }
        else {
            word = "???";
        }

        return word;
    }
}