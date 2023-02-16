class Test
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Test(string name)
    {
        this.name = name;
    }
}