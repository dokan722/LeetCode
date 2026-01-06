#include "problem_1161.h"

#include <queue>

bool problem_1161::test() {
    auto branch1 = TreeNode(7);
    auto branch2 = TreeNode(-8);
    auto branch3 = TreeNode(0);
    auto branch4 = TreeNode(7, &branch1, &branch2);
    auto root =  TreeNode(1, &branch4, &branch3 );

    int expected = 2;

    auto result = maxLevelSum(&root);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1161::maxLevelSum(TreeNode *root) {
    int result = 1;
    int maxSum = root->val;
    int level = 0;
    std::queue<TreeNode*> nodes;
    nodes.push(root);
    while (!nodes.empty())
    {
        int currSum = 0;
        level++;
        int curr = nodes.size();
        for (int i = 0; i < curr; ++i)
        {
            auto next = nodes.front();
            nodes.pop();
            currSum += next->val;
            if (next->left != nullptr)
                nodes.push(next->left);
            if (next->right != nullptr)
                nodes.push(next->right);
        }

        if (currSum > maxSum)
        {
            result = level;
            maxSum = currSum;
        }
    }
    return result;
}
