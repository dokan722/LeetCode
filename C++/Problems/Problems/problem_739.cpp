#include "problem_739.h"

#include <stack>

bool problem_739::test() {
    std::vector temperatures { 73, 74, 75, 71, 69, 72, 76, 73 };

    std::vector expected { 1, 1, 4, 2, 1, 1, 0, 0 };

     auto result = dailyTemperatures(temperatures);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_739::dailyTemperatures(std::vector<int> &temperatures) {
    int n = temperatures.size();
    std::vector result(n, 0);
    std::stack<std::pair<int, int>> temps;

    for (int i = n - 1; i >= 0; --i)
    {
        int count = 1;
        while (!temps.empty() && temperatures[i] >= temps.top().first)
        {
            count += temps.top().second;
            temps.pop();
        }
        result[i] = temps.empty() ? 0 : count;
        temps.push(std::pair(temperatures[i], result[i]));
    }

    return result;
}
