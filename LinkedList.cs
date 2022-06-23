
class LinkedList
{
    private Node _head; //reference to the head of the list
    private Node _tail; //reference to he tail of the list
    private int _length = 0;

    public void Add(object newData)
    {
        if (_head == null && _tail == null)
        {
            _head = new Node();   //create new node at head
            _tail = _head;        //have tail reference head
            _tail.Data = newData; //set data for the tail 
        }
        else
        {
            Node newNode = new Node();//create new node
            newNode.Data = newData;   //set the new node's data
            _tail.Next = newNode;     //add the node to end of the list
            _tail = newNode;          //make new node the new tail of the list
        }//end if

        //INCREASE LENGTH
        _length += 1;
    }//end method

    public object Get(int targetIndex)
    {
        //SETUP CURRENT INDEX AND HAVE CURRENT REF. HEAD
        int currentIndex = 0;
        Node current = _head;

        //OUT OF BOUNDS EXCEPTIONS
        if (targetIndex >= _length)
        {
            throw new IndexOutOfRangeException($"Target index {targetIndex} must be less than this LinkedList's length of {_length}.");
        }
        else if (targetIndex < 0)
        {
            throw new IndexOutOfRangeException($"Target index {targetIndex} must be greater than index 0.");
        }//end if

        //LOOP WHILE CURRENT != TARGET
        while (currentIndex != targetIndex)
        {
            current = current.Next;
            currentIndex = currentIndex + 1;
        }//end while

        //RETURN CURRENT NODE'S DATA
        return current.Data;
    }//end method

    public int FindIndexOf(object targetObject)
    {
        //to do  - return index in the list of the first occurance of that object
        //to do  - if the value isnt found in the list return -1
        Node current = _head;
        int currentIndex = 0;
        
        //LOOP WHILE CURRENT != NULL
        while(current != null)
        {
            //RETURN INDEX OF EQUAL DATA
            if (current.Data.Equals(targetObject))
            {
                return currentIndex;
            }
                        
            current = current.Next;
            currentIndex++;
           
        }//end while
         
        return -1;

    }//end method

    public void InsertFront(object newData)
    {
        //CREATE NEW NODE
        Node newHead = new Node();

        //STORE newData IN NEW NODE
        newHead.Data = newData;

        //SET newHead NEXT TO HEAD
        newHead.Next = _head;

        //SAVE newHead AS HEAD NODE
        _head = newHead;

        _length++;
    }//end method

    public void InsertRear(object newData)
    {
        //CREATE NEW NODE
        Node newTail = new Node();

        //STORE newData IN newTail NODE
        newTail.Data = newData;

        //MAKE oldTail NEXT newTail
        _tail.Next = newTail;

        //SAVE newTail AS TAIL LOCATION
        _tail = newTail;

        _length++;
    }//end method

    public void Insert(int i, object newData)
    {
        int currentIndex = 0;
        Node current = _head;

        while(currentIndex <= i)
        {
            if(currentIndex == i)
            {
                Node newNode = new Node();
                newNode.Data = newData;
                newNode.Next = current.Next;
                current.Next = newNode;
            }

            current = current.Next;
            currentIndex += 1;
        }
    }

}//end class
