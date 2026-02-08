#ifndef PROBLEM_110_H
#define PROBLEM_110_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_110 : public problem {
    struct TreeNode {
        int val;
        TreeNode *left;
        TreeNode *right;
        TreeNode() : val(0), left(nullptr), right(nullptr) {}
        TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
        TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
    };
public:
    bool test() override;

    bool isBalanced(TreeNode* root);
private:
    int isBalancedRec(TreeNode* root);
};

#endif //PROBLEM_110_H
