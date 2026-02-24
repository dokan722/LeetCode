#include "problem_1022.h"

bool problem_1022::test() {
    TreeNode root1(0);
    TreeNode root2(1);
    TreeNode root3(0);
    TreeNode root4(1);
    TreeNode root5(0, &root1, &root2);
    TreeNode root6(1, &root3, &root4);
    TreeNode root7(1, &root5, &root6);

    int expected = 22;

    auto result = sumRootToLeaf(&root7);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1022::sumRootToLeaf(TreeNode *root) {
    sumRootToLeafRec(root, 0);
    return _sum;
}

void problem_1022::sumRootToLeafRec(TreeNode *root, int val) {
    if (root == nullptr)
        return;
    val = (val << 1) + root->val;
    if (root->left == nullptr && root->right == nullptr)
    {
        _sum += val;
        return;
    }
    sumRootToLeafRec(root->left, val);
    sumRootToLeafRec(root->right, val);
}
