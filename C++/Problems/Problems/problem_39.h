#ifndef PROBLEMS_PROBLEM_39_H
#define PROBLEMS_PROBLEM_39_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_39 : public problem {
    void searchRec(std::vector<std::vector<int>>& result, std::vector<int>& cur, std::vector<int>& cands, int rem, int start);
public:
    bool test() override;

    std::vector<std::vector<int>> combinationSum(std::vector<int>& candidates, int target);
};

#endif //PROBLEMS_PROBLEM_39_H