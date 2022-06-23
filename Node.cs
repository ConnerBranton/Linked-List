
class Node
{
    private object _data;
    private Node _next;

    public object Data
    {
        get { return _data; }
        set { _data = value; }
    }//end property

    public Node Next
    {
        get { return _next; }
        set { _next = value; }
    }//end property

    public Node(object initialData = null)
    {
        _data = initialData;
    }//end constructor


}//end class
