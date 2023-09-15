using System.Diagnostics;

internal class AnimalThread
{
    public Thread thread;
    public string name;

    public AnimalThread(string name)
    {
        this.name = name;
    }
}

