namespace AdaptiveRouting
{
    public struct Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Cost { get; set; }
        public Node(int x, int y, int cost = 1)
        {
            X = x;
            Y = y;
            Cost = cost;
        }
       
    }
}
