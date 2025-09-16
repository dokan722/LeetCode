#include "problem_2197.h"

#include <stack>

bool problem_2197::test() {
    std::vector nums { 6, 4, 3, 2, 7, 6, 2 };

    std::vector expected { 12, 7, 6 };

    auto result = replaceNonCoprimes(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2197::replaceNonCoprimes(std::vector<int> &nums) {
    std::stack<int> elems;
    for (auto num : nums)
    {
        int next = num;
        while (!elems.empty())
        {
            int last = elems.top();
            int g = gcd(last, next);
            if (g == 1)
                break;
            next = (int)((long long)last * next / g);
            elems.pop();
        }
        elems.push(next);
    }
    int n = elems.size();
    std::vector<int> result(n);
    for (int i = 0; i < n; i++) {
        result[n - i - 1] = elems.top();
        elems.pop();
    }

    return result;
}

int problem_2197::gcd(int a, int b) {
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}
