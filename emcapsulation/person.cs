public class Mahasiswa  // mahasiswa class defined with public class so that we can access the class in the same project
{
    private string name;
    private string nim;
    private int nilai;
    private string matkul;// name,nim,nilai, and matkul is a private field that can be acessed with mahasisswa class

    public string GetName()
    {
        return name;
    }
    public void SetName(string newName)
    {
        this.name = newName;
    }

    public string GetNim()
    {
        return nim;
    }

    public void SetNim(string newNim)
    {
        this.nim = newNim ;
    }
     
    public int GetNilai()
    {
     return nilai;
    }

    public void SetNilai(int newNilai)
    {
        this.nilai = newNilai;
    }

    public string GetMatkul()//Getname,GetNim,Getnilai,GetMatkul is a method to return the value of the field, and then we can retrieve value from external code
    {
        return matkul;
    }

    public void SetMatkul(string newMatkul)//Setname,SetNim,setNilai,Set Matkul used for parameter and asigning to the private  field
   
    {
       this.matkul = newMatkul;
    }
}