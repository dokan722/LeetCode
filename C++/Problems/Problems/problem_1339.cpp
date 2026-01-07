#include "problem_1339.h"

#include <stack>

bool problem_1339::test() {
    auto branch1 = TreeNode(4);
    auto branch2 = TreeNode(5);
    auto branch3 = TreeNode(6);
    auto branch4 = TreeNode(2, &branch1, &branch2);
    auto branch5 = TreeNode(3, &branch3, nullptr);
    auto root =  TreeNode(1, &branch4, &branch5 );

    int expected = 110;

    auto result = maxProduct(&root);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1339::maxProduct(TreeNode *root) {
    sumRoots(root);
    int total = root->val;
    std::stack<TreeNode*> stack;
    if (root->left != nullptr)
        stack.push(root->left);
    if (root->right != nullptr)
        stack.push(root->right);

    long long result = 0;
    int mod = 1000000007;
    while (!stack.empty())
    {
        auto next = stack.top();
        stack.pop();
        if (next->left != nullptr)
            stack.push(next->left);
        if (next->right != nullptr)
            stack.push(next->right);
        result = std::max(result, (long long)next->val * (total - next->val));
    }

    return (int)(result % mod);
}

int problem_1339::sumRoots(TreeNode *root) {
    if (root == nullptr)
        return 0;
    root->val += sumRoots(root->left) + sumRoots(root->right);
    return root->val;
}
