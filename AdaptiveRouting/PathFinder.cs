using System.Collections.Generic;

namespace AdaptiveRouting
{
    public class PathFinder
    { 
        public int[,] GetMapDistance(int[,] map, Node start) {
            var searchQueue = new Queue<Node>();
            searchQueue.Enqueue(start);
            while(searchQueue.Count > 0){
                var current = searchQueue.Dequeue();
                map[current.X, current.Y] = current.Cost;
                foreach (var neighbor in this.GetNeighbors(map, current))
                    if (map[neighbor.X, neighbor.Y] == 0)
                        searchQueue.Enqueue(neighbor);
            }
            return map;
        }

        private IList<Node> GetNeighbors(int[,] map, Node node) {
            var ListOfNeighbors = new List<Node>();
            if (map[node.X, node.Y + 1] == 0) ListOfNeighbors.Add(new Node(node.X, node.Y + 1, node.Cost + 1));
            if (map[node.X, node.Y - 1] == 0) ListOfNeighbors.Add(new Node(node.X, node.Y - 1, node.Cost + 1));
            if (map[node.X + 1, node.Y] == 0) ListOfNeighbors.Add(new Node(node.X + 1, node.Y, node.Cost + 1));
            if (map[node.X - 1, node.Y] == 0) ListOfNeighbors.Add(new Node(node.X - 1, node.Y, node.Cost + 1));
            return ListOfNeighbors;
        }
    }
}
