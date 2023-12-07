namespace Stirnreihe.Data;

public class LineOfPeople
{
    public Node? First { get; set; }
    public void AddToFront(Person person)
    {
        Node node = new Node
        {
            Person = person,
            Next = First
        };
        First = node;

    }
    public void Clear()
    {
        First = null;
    }

}
