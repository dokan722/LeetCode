#include "problem_1306.h"

#include <stack>

bool problem_1306::test() {
    std::vector arr  { 4, 2, 3, 0, 3, 1, 2 };
    int start = 5;

    bool expected = true;

    auto result = canReach(arr, start);

    return result == expected;
}

bool problem_1306::canReach(std::vector<int> &arr, int start) {
    int n = arr.size();
    std::vector visited(n, false);
    std::stack<int> jumpStack;
    jumpStack.push(start);
    while (!jumpStack.empty())
    {
        auto id = jumpStack.top();
        jumpStack.pop();
        if (!visited[id])
        {
            if (arr[id] == 0)
                return true;
            visited[id] = true;
            if (id - arr[id] >= 0)
                jumpStack.push(id - arr[id]);
            if (id + arr[id] < n)
                jumpStack.push(id + arr[id]);
        }
    }

    return false;
}
