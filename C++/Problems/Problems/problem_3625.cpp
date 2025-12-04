#include "problem_3625.h"

#include <float.h>
#include <unordered_map>

bool problem_3625::test() {
    std::vector<std::vector<int>> points { { -3, 2 }, { 3, 0 }, { 2, 3 }, { 3, 2 }, { 2, -3 } };

    int expected = 2;

    auto result = countTrapezoids(points);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3625::countTrapezoids(std::vector<std::vector<int>> &points) {
    int n = points.size();
    std::unordered_map<double, std::unordered_map<double, int>> trap;
    std::unordered_map<double, std::unordered_map<double, int>> par;
    for (int i = 0; i < n; ++i)
    {
        int x1 = points[i][0];
        int y1 = points[i][1];
        for (int j = i + 1; j < n; ++j)
        {
            int x2 = points[j][0];
            int y2 = points[j][1];
            int dx = x1 - x2;
            int dy = y1 - y2;
            double a, b;
            if (x1 == x2)
            {
                a = DBL_MAX;
                b = x1;
            }
            else
            {
                a = (double)(y2 - y1) / (x2 - x1);
                b = (double)(y1 * dx - x1 * dy) / dx;
            }

            double mid = (x1 + x2) * 10000.0 + (y1 + y2);
            if (!trap.contains(a))
                trap[a] = std::unordered_map<double, int>();
            if (!par.contains(mid))
                par[mid] = std::unordered_map<double, int>();
            if (!trap[a].contains(b))
                trap[a][b] = 1;
            else
                trap[a][b]++;
            if (!par[mid].contains(a))
                par[mid][a] = 1;
            else
                par[mid][a]++;
        }
    }

    int result = 0;
    for (auto t : trap)
    {
        int curr = 0;
        for (auto count : t.second)
        {
            result += curr * count.second;
            curr += count.second;
        }
    }

    for (auto p : par)
    {
        int curr = 0;
        for (auto count : p.second)
        {
            result -= curr * count.second;
            curr += count.second;
        }
    }

    return result;
}
