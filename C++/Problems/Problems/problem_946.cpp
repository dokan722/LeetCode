#include "problem_946.h"

#include <stack>

bool problem_946::test() {
    std::vector pushed { 1, 2, 3, 4, 5 };
    std::vector popped { 4, 5, 3, 2, 1 };

    bool expected = true;

    auto result = validateStackSequences(pushed, popped);

    return expected == result;
}

bool problem_946::validateStackSequences(std::vector<int> &pushed, std::vector<int> &popped) {
    int n = pushed.size();
    int firstPopped = 0;
    std::stack<int> reverseStack;
    for (int i = 0; i < n; ++i)
    {
        reverseStack.push(pushed[i]);
        while (!reverseStack.empty() && reverseStack.top() == popped[firstPopped])
        {
            reverseStack.pop();
            firstPopped++;
        }
    }

    return reverseStack.empty();
}
