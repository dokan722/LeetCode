#ifndef PROBLEMS_PROBLEM_1339_H
#define PROBLEMS_PROBLEM_1339_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_1339 : public problem {
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

    int maxProduct(TreeNode* root);
private:
    int sumRoots(TreeNode* root);
};

#endif //PROBLEMS_PROBLEM_1339_H