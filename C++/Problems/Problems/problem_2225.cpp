#include "problem_2225.h"

#include <map>

bool problem_2225::test() {
    std::vector<std::vector<int>> matches =  {  { 2, 3 },  { 1, 3 },  { 5, 4 },  { 6, 4 } };

    std::vector<std::vector<int>> expected =  {  { 1, 2, 5, 6 }, { } };

    auto result = findWinners(matches);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_2225::findWinners(std::vector<std::vector<int>> &matches) {
    std::map<int, int> results;
    for (auto match : matches)
    {
        if (!results.contains(match[0]))
            results[match[0]] = 0;
        if (!results.contains(match[1]))
            results[match[1]] = 0;
        results[match[1]]++;
    }

    std::vector<int> no;
    std::vector<int> one;

    for (auto result : results)
    {
        if (result.second == 0)
            no.push_back(result.first);
        else if (result.second == 1)
            one.push_back(result.first);
    }

    return std::vector { no, one };
}
