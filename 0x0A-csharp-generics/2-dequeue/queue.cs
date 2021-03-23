using System;
/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public System.Type CheckType()
    {
        return typeof(T);
    }
    /// <summary>
    /// 
    /// </summary>
    public class Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public Node(T input)
        {
            value = input;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public T value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public Node next { get; set; } = null;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Node head { get; set; } = null;
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Node tail { get; set; } = null;
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int count { get; set; } = 0;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="newVal"></param>
    public void Enqueue(T newVal)
    {
        Node mNN = new Node(newVal);
        if (head != null)
        {
            tail.next = mNN;
            tail = mNN;
        }
        else
        {
            head = mNN;
            tail = mNN;
        }
        count = count + 1;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return count;
    }
}
