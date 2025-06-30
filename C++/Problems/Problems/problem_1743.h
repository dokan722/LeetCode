#ifndef PROBLEM_1743_H
#define PROBLEM_1743_H

#include <unordered_map>

#include "../problem.h"
#include <vector>

class problem_1743 : public problem {
public:
    bool test() override;

    std::vector<int> restoreArray(std::vector<std::vector<int>>& adjacentPairs);
private:
    void dfsListGraph(std::unordered_map<int, std::vector<int>>& graph, int curr, int prev, std::vector<int>& result);
};



#endif //PROBLEM_1743_H
