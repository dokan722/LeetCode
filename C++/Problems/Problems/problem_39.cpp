#include "problem_39.h"

void problem_39::searchRec(std::vector<std::vector<int>>& result, std::vector<int>& cur, std::vector<int>& cands, int rem,
    int start) {
    if (rem < 0)
        return;
    if (rem == 0)
    {
        result.push_back(std::vector(cur));
        return;
    }
    for (int i = start; i < cands.size(); ++i)
    {
        cur.push_back(cands[i]);
        searchRec(result, cur, cands, rem - cands[i], i);
        cur.pop_back();
    }
}

bool problem_39::test() {
    std::vector candidates { 2, 3, 6, 7 };
    int target = 7;

    std::vector<std::vector<int>> expected { { 2, 2, 3 }, { 7 } };

    auto result = combinationSum(candidates, target);

    print2DVector(result);

    return expected == result;

}

std::vector<std::vector<int>> problem_39::combinationSum(std::vector<int> &candidates, int target) {
    std::vector<std::vector<int>> result;
    std::vector<int> cur;
    searchRec(result, cur, candidates, target, 0);
    return result;
}
