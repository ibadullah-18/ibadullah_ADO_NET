// Dapper ORM
class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return Name;
    }

}
