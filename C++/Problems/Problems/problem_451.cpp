#include "problem_451.h"

#include <algorithm>
#include <unordered_map>

bool problem_451::test() {
    std::string s = "Aabb";

    std::string expected = "bbAa";

    auto result = frequencySort(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_451::frequencySort(std::string s) {
    std::unordered_map<char, int> counts;
    for (auto c : s)
    {
        if (counts.contains(c))
            counts[c]++;
        else
            counts[c] = 1;
    }

    int chars = counts.size();
    std::pair<int, char> pairs[chars];
    int i = 0;
    for (auto count : counts)
    {
        pairs[i] = std::pair(-count.second, count.first);
        i++;
    }
    std::sort(pairs, pairs + chars);
    std::string result = "";
    for (auto pair : pairs)
    {
        result +=  std::string(-pair.first, pair.second);
    }

    return result;
}
