#include "problem_865.h"

bool problem_865::test() {
    auto branch1 = TreeNode(6);
    auto branch2 = TreeNode(7);
    auto branch3 = TreeNode(4);
    auto branch4 = TreeNode(0);
    auto branch5 = TreeNode(8);
    auto branch6 = TreeNode(2, &branch2, &branch3);
    auto branch7 = TreeNode(5, &branch1, &branch6);
    auto branch8 = TreeNode(1, &branch4, &branch5);
    auto branch9 = TreeNode(3, &branch7, &branch8);

    auto result = subtreeWithAllDeepest(&branch9);

    return result == &branch6;
}

problem_865::TreeNode * problem_865::subtreeWithAllDeepest(TreeNode *root) {
    dfsDepth(root, 0);
    return _deepest;
}

int problem_865::dfsDepth(TreeNode *root, int parentDepth) {
    if (root == nullptr)
        return parentDepth;
    int left = dfsDepth(root->left, parentDepth + 1);
    int right = dfsDepth(root->right, parentDepth + 1);
    if (left == right && right >= _maxDepth)
    {
        _deepest = root;
        _maxDepth = right;
    }

    return std::max(left, right);
}
