public class Queue {
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();
    // Push element x to the back of queue.
    public void Push(int x) {
        stack1.Push(x);
    }

    // Removes the element from front of queue.
    public void Pop() {
        MoveStack();
        stack2.Pop();
    }

    // Get the front element.
    public int Peek() {
        MoveStack();
        return stack2.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty() {
        return stack1.Count==0 && stack2.Count==0;
    }
    
    private void MoveStack(){
        if(stack2.Count==0){
            stack2 = new Stack<int>(stack1.ToArray());
            stack1.Clear();
        }
    }
}