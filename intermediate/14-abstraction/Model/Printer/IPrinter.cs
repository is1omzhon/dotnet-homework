namespace abstraction.Model;

public interface IPrinter
{
    public void Print(string documentName);
    public void PrintPreview(string documentName);
    public void Clean();
}