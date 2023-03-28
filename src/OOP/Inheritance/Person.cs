class Person 
{
    private string name;
    private int age;

    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;
    }

    public string GetName() 
    {
        return name;
    }

    public void SetName(string value) 
    {
        name = value;
    }

    public int GetAge() 
    {
        return age;
    }

    public void GetAge(int value) 
    {
        age = value;
    }
}