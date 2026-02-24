#ifndef PROBLEM_1022_H
#define PROBLEM_1022_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1022 : public problem {
    struct TreeNode {
        int val;
        TreeNode *left;
        TreeNode *right;

        TreeNode() : val(0), left(nullptr), right(nullptr) {
        }

        TreeNode(int x) : val(x), left(nullptr), right(nullptr) {
        }

        TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {
        }
    };
public:
    bool test() override;

    int sumRootToLeaf(TreeNode* root);
private:
    int _sum = 0;
    void sumRootToLeafRec(TreeNode* root, int val);
};

#endif //PROBLEM_1022_H
