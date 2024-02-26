namespace OOPInheritance;
internal class Animale
{
    public string Nome { get; set; }
    public bool Domestico { get; set; }
    public string Proprietario { get; set; }

    // metodo virtuale, può essere sovrascritto nelle classi derivate
    public virtual string EseguiVerso()
    {
        return "Verso generico";
    }
}
