#ifndef PROBLEM_538_H
#define PROBLEM_538_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_583 : public problem {
public:
    bool test() override;

    int minDistance(std::string word1, std::string word2);
private:
    int minDistRec(std::vector<std::vector<int>>& dp, std::string word1, std::string word2, int i, int j);
};



#endif //PROBLEM_538_H
