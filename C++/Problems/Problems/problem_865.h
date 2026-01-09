#ifndef PROBLEM_865_H
#define PROBLEM_865_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_865 : public problem {
    struct TreeNode {
        int val;
        TreeNode *left;
        TreeNode *right;
        TreeNode() : val(0), left(nullptr), right(nullptr) {}
        TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
        TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
    };
    int _maxDepth = 0;
    TreeNode* _deepest = nullptr;
public:
    bool test() override;

    TreeNode* subtreeWithAllDeepest(TreeNode* root);
private:
    int dfsDepth(TreeNode* root, int parentDepth);
};

#endif //PROBLEM_865_H
