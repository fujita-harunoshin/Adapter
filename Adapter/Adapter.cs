namespace Adapter;

internal class Adapter(Adaptee adaptee) : ITarget
{
    private readonly Adaptee _adaptee = adaptee;

    public string GetRequest()
    {
        return $"This is '{_adaptee.GetSpecificRequest()}'";
    }
}
