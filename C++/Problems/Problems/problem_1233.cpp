#include "problem_1233.h"

#include <algorithm>
#include <ranges>
#include <unordered_map>

bool problem_1233::test() {
    std::vector<std::string> folder { "/a", "/a/b", "/c/d", "/c/d/e", "/c/f" };

    std::vector<std::string> expected { "/a", "/c/d", "/c/f" };

    auto result = removeSubfolders(folder);

    print1DVector(result);

    return expected == result;
}

std::vector<std::string> splitBySlash(const std::string& input) {
    std::vector<std::string> result;
    size_t start = 0;
    size_t end;

    while ((end = input.find('/', start)) != std::string::npos) {
        result.push_back(input.substr(start, end - start));
        start = end + 1;
    }

    result.push_back(input.substr(start));
    return result;
}

class FolderTree
{
private:
    std::unordered_map<std::string, FolderTree> _nodes;

public:
    bool tryAddMainFolder(std::string folder)
{
    auto parts = splitBySlash(folder);
    auto node = this;
    auto prevPresent = false;
    for (int i = 1; i < parts.size(); i++)
    {
        if (node->_nodes.contains(parts[i]))
        {
            auto nodeNode = &node->_nodes[parts[i]];
            prevPresent = true;
            node = nodeNode;
        }
        else
        {
            if (node->_nodes.size() == 0 && prevPresent)
                return false;
            node->_nodes[parts[i]] =  FolderTree();
            node = &node->_nodes[parts[i]];
            prevPresent = false;
        }
    }


    return true;
}
};

std::vector<std::string> problem_1233::removeSubfolders(std::vector<std::string> &folder) {
    std::sort(folder.begin(), folder.end(),
        [](const std::string &a, const std::string &b) { return a.size() < b.size(); });
    FolderTree trie;
    std::vector<std::string> result;
    for (auto f : folder)
    {
        if (trie.tryAddMainFolder(f))
            result.push_back(f);
    }
    return result;
}
