
namespace ADO_.NET_07._Include;

    class Group
    {
    public int Id { get; set; }
    public string GroupName { get; set; }

    public List<Student> Students { get; set; }

    public override string ToString()
    {
        return GroupName;
    }
}

