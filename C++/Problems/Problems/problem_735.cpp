#include "problem_735.h"

#include <stack>

bool problem_735::test() {
    std::vector asteroids { 3, 5, -6, 2, -1, 4 };

    std::vector expected { -6, 2, 4 };

    auto result = asteroidCollision(asteroids);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_735::asteroidCollision(std::vector<int> &asteroids) {
    int n = asteroids.size();
    std::stack<int> train;
    std::vector<int> leftAst;
    for (int i = 0; i < n; ++i)
    {
        if (asteroids[i] > 0)
            train.push(asteroids[i]);
        else
        {
            int mass = std::abs(asteroids[i]);
            while (!train.empty() && train.top() < mass)
                train.pop();
            if (train.empty())
                leftAst.push_back(asteroids[i]);
            else if (train.top() == mass)
                train.pop();
        }
    }
    int resultLen = train.size() + leftAst.size();
    std::vector<int> result(resultLen);
    for (int i = 0; i < leftAst.size(); ++i)
        result[i] = leftAst[i];
    int k = 1;
    while (!train.empty())
    {
        result[resultLen - k] = train.top();
        train.pop();
        k++;
    }

    return result;
}
