#ifndef PROBLEM_637_H
#define PROBLEM_637_H


#include <unordered_map>
#include <vector>

#include "../problem.h"

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

    ~TreeNode() {
        delete left;
        delete right;
    }
};

struct DepthData
{
    double Count;
    double Sum;
};

class problem_637 : public problem {
public:
    bool test() override;

    std::vector<double> averageOfLevels(TreeNode *root);
private:
    void travelTree(TreeNode *root, int depth, std::unordered_map<int, DepthData> *depthDic);
};

#endif //PROBLEM_637_H
