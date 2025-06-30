from .problem import Problem


class Problem1743(Problem):
    def test(self):
        adjacentPairs = [[2, 1], [3, 4], [3, 2]]

        expected = [1, 2, 3, 4]

        result = self.restoreArray(adjacentPairs)

        print(','.join(map(str, result)))

        return result == expected

    def restoreArray(self, adjacentPairs):
        graph = {}
        for pair in adjacentPairs:
            if pair[0] in graph:
                graph[pair[0]].append(pair[1])
            else:
                graph[pair[0]] = [pair[1]]
            if pair[1] in graph:
                graph[pair[1]].append(pair[0])
            else:
                graph[pair[1]] = [pair[0]]

        for k, v in graph.items():
            if len(v) == 1:
                root = k
                break
        result = [root]
        self.dfsListGraph(graph, root, None, result)

        return result

    def dfsListGraph(self, graph, curr, prev, result):
        for n in graph[curr]:
            if n != prev:
                result.append(n)
                self.dfsListGraph(graph, n, curr, result)
