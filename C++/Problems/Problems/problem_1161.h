#ifndef PROBLEMS_PROBLEM_2161_H
#define PROBLEMS_PROBLEM_2161_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_1161 : public problem {
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

    int maxLevelSum(TreeNode* root);
};

#endif //PROBLEMS_PROBLEM_2161_H