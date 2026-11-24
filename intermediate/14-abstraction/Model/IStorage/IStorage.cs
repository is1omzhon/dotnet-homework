namespace abstraction.Model;

public interface IStorage
{
    public void Upload(string fileName);
    public void Download(string fileName);

}