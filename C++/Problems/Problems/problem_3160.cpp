#include "problem_3160.h"

#include <unordered_map>

bool problem_3160::test() {
    int limit = 4;
    std::vector<std::vector<int>> queries { { 1, 4 }, { 2, 5 }, { 1, 3 }, { 3, 4 } };

    std::vector expected { 1, 2, 2, 3 };

    auto result = queryResults(limit, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3160::queryResults(int limit, std::vector<std::vector<int>> &queries) {
    int n = queries.size();
    std::unordered_map<int, int> color;
    std::unordered_map<int, int> colorCounts;
    colorCounts[0] = n + 1;
    int colors = 0;
    std::vector<int> result(n);
    for (int i = 0; i < n; ++i)
    {
        int oldColor = color.contains(queries[i][0]) ? color[queries[i][0]] : 0;
        int newColor = queries[i][1];
        color[queries[i][0]] = newColor;
        colorCounts[oldColor]--;
        if (colorCounts[oldColor] == 0)
            colorCounts.erase(oldColor);
        if (!colorCounts.contains(newColor))
            colorCounts[newColor] = 0;
        colorCounts[newColor]++;
        result[i] = colorCounts.size() - 1;
    }

    return result;
}
