#ifndef PROBLEM_1733_H
#define PROBLEM_1733_H


#include "../problem.h"
#include <string>
#include <unordered_set>
#include <vector>

class problem_1733 : public problem {
public:
    bool test() override;

    int minimumTeachings(int n, std::vector<std::vector<int>>& languages, std::vector<std::vector<int>>& friendships);
private:
    bool isCommonLanguage(std::unordered_set<int> languagesFirst, std::unordered_set<int> languagesSecond);
};



#endif //PROBLEM_1733_H
