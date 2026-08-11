#include "problem_447.h"

bool problem_447::test() {
    std::vector<std::vector<int>> points { { 0, 0 }, { 1, 0 }, { 2, 0 } };

    int expected = 2;

    auto result = numberOfBoomerangs(points);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_447::numberOfBoomerangs(std::vector<std::vector<int>> &points) {
    int n = points.size();
    std::unordered_map<int, int> dists;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            int x = points[i][0] - points[j][0];
            int y = points[i][1] - points[j][1];
            int dist = x * x + y * y;
            if (dists.contains(dist))
            {
                result += 2 * dists[dist];
                dists[dist]++;
            }
            else
                dists[dist] = 1;
        }
        dists.clear();
    }

    return result;
}
