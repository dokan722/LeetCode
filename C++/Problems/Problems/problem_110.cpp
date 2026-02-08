#include "problem_110.h"

bool problem_110::test() {
    auto branch1 = TreeNode(15);
    auto branch2 = TreeNode(7);
    auto branch4 = TreeNode(20, &branch1, &branch2);
    auto branch5 = TreeNode(9, nullptr, nullptr);
    auto root =  TreeNode(3, &branch5, &branch4 );

    int expected = true;

    auto result = isBalanced(&root);

    return result == expected;
}

bool problem_110::isBalanced(TreeNode *root) {
    return isBalancedRec(root) != -1;
}

int problem_110::isBalancedRec(TreeNode *root) {
    if (root == nullptr)
        return 0;
    int left = isBalancedRec(root->left);
    if (left == -1)
        return -1;
    int right = isBalancedRec(root->right);
    if (right == -1)
        return -1;
    if (std::abs(left - right) > 1)
        return -1;
    return std::max(left, right) + 1;
}
