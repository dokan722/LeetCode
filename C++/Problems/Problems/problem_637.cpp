#include "problem_637.h"

bool problem_637::test() {
    auto tree =  TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

    auto expected = std::vector<double> {3.0, 14.5, 11.0};

    auto result = averageOfLevels(&tree);

    return expected == result;
}

std::vector<double> problem_637::averageOfLevels(TreeNode *root) {
    std::unordered_map<int, DepthData> depthDict;

    travelTree(root, 0, &depthDict);

    std::vector<double> result;

    for (int i = 0; i < depthDict.size(); i++)
        result.push_back(depthDict[i].Sum / depthDict[i].Count);

    return result;
}

void problem_637::travelTree(TreeNode *root, int depth, std::unordered_map<int, DepthData> *depthDic) {
    if (depthDic->find(depth) != depthDic->end())
    {
        (*depthDic)[depth].Count += 1;
        (*depthDic)[depth].Sum += root->val;
    }
    else
    {
        (*depthDic)[depth] =  DepthData(1, root->val);
    }

    if (root->left != nullptr)
        travelTree(root->left, depth + 1, depthDic);
    if (root->right != nullptr)
        travelTree(root->right, depth +1, depthDic);
}
