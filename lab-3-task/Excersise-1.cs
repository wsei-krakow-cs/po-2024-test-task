namespace lab_3_task;
//Ćwiczenie 1
//Zmodyfikuj klasę Musician, aby można było tworzyć muzyków tylko dla klas pochodnych po Instrument.
//Po modyfikacji powinien pojawić się błąd w wierszu 19 (z komentarzem //POPRAW #1) oraz zniknąć błąd w wierszu 39
//Popraw ten wiersz, dodając klasę Musician

//Ćwiczenie 2
//Zdefiniuj klasę  Guitar pochodną po Instrument, w metodzie Play umieść instrukcję Console.WriteLine("GUITAR");

//Ćwiczenie 3
//Zdefiniuj klasę Drum pochodną po Instrument, w metodzie Play umieść instrukcję Console.WriteLine("DRUM");

//Usuń komentarze w metodzie Test

public class Excersise_1
{
    public static void Test()
    {
        Musician<string> musician = new Musician<string>() {Instrument = "guitar"}; //POPRAW #1
        // Musician<Keyboard> musician = new Musician<Keyboard>() {Instrument = new Keyboard()}; 
        // Console.WriteLine(musician);
        // Musician<Guitar> guitarist = new Musician<Guitar>() { Instrument = new Guitar()};
        // guitarist.Play();
        // Musician<Drum> drummer = new Musician<Drum>(){Instrument = new Drum()};
        // drummer.Play();
    }
}
interface IPlay
{
    void Play();
}

class Musician<T> : IPlay
{
    public T Instrument { get; init; }

    public void Play()
    {
        Instrument?.Play();
    }

    public override string ToString()
    {
        return "MUSICIAN";
    }
}

abstract class Instrument : IPlay
{
    public abstract void Play();
}

class Keyboard : Instrument
{
    public override void Play()
    {
        Console.WriteLine("KEYBOARD");
    }
}