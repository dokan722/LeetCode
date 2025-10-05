#include "problem_49.h"

#include <algorithm>
#include <unordered_map>

bool problem_49::test() {
    std::vector<std::string> strs { "eat", "tea", "tan", "ate", "nat", "bat" };

    std::vector<std::vector<std::string>> expected { { "bat" }, { "tan", "nat" }, { "eat", "tea", "ate" }};

    auto result = groupAnagrams(strs);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<std::string>> problem_49::groupAnagrams(std::vector<std::string> &strs) {
    std::unordered_map<std::string, std::vector<std::string>> result;
    for (auto s : strs)
    {
        auto key = s;
        std::sort(key.begin(), key.end());
        if (result.contains(key))
            result[key].push_back(s);
        else
            result[key] = std::vector { s };
    }

    std::vector<std::vector<std::string>> resultVec;
    for (auto p : result)
        resultVec.push_back(p.second);

    return resultVec;
}
