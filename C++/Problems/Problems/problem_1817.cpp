#include "problem_1817.h"

#include <unordered_map>
#include <unordered_set>

bool problem_1817::test() {
    std::vector<std::vector<int>> logs { { 0, 5 }, { 1, 2 }, { 0, 2 }, { 0, 5 }, { 1, 3 } };
    int k = 5;

    std::vector expected { 0, 2, 0, 0, 0 };

    auto result = findingUsersActiveMinutes(logs, k);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1817::findingUsersActiveMinutes(std::vector<std::vector<int>> &logs, int k) {
    std::vector result(k, 0);
    std::unordered_map<int, std::unordered_set<int>> acts;
    for (auto log : logs)
    {
        if (acts.contains(log[0]))
            acts[log[0]].insert(log[1]);
        else
            acts[log[0]] = std::unordered_set{ log[1] };
    }

    for (auto act : acts)
    {
        result[act.second.size() - 1]++;
    }

    return result;
}
